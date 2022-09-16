using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;

namespace Clippy
{
    public sealed class ClipboardNotification
    {

        /// <summary>
        /// Occurs when the contents of the clipboard is updated.
        /// </summary>
        public static event EventHandler ClipboardUpdate;

        private static NotificationForm _form = new NotificationForm();

        /// <summary>
        /// Raises the <see cref="ClipboardUpdate"/> event.
        /// </summary>
        /// <param name="e">Event arguments for the event.</param>
        private static void OnClipboardUpdate(Message m, IntPtr owner, EventArgs e)
        {
            var handler = ClipboardUpdate;
            if (handler != null)
            {

                //handler(null,e);
                handler(new ClipboardSender(owner,m), e);
            }
        }


        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetOpenClipboardWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetClipboardOwner();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetClipboardSequenceNumber();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(int hwnd, StringBuilder text, int count);

        public static string GetOpenClipboardWindowText()
        {
            IntPtr hwnd = GetOpenClipboardWindow();
            StringBuilder sb = new StringBuilder(501);
            GetWindowText(hwnd.ToInt32(), sb, 500);
            return sb.ToString();
        }

        public static string GetOpenClipboardWindowText(IntPtr Hwnd)
        {
            StringBuilder sb = new StringBuilder(501);
            GetWindowText(Hwnd.ToInt32(), sb, 500);
            return sb.ToString();
        }

        public static Process GetProcessLockingClipboard()
        {
            int processId;
            GetWindowThreadProcessId(GetOpenClipboardWindow(), out processId);

            return Process.GetProcessById(processId);
        }
        public static Process GetProcessLockingClipboard(IntPtr Hwnd)
        {
            int processId;
            GetWindowThreadProcessId(Hwnd, out processId);

            return Process.GetProcessById(processId);
        }
        /// <summary>
        /// Hidden form to recieve the WM_CLIPBOARDUPDATE message.
        /// </summary>
        private class NotificationForm : Form
        {
            public NotificationForm()
            {
                NativeMethods.SetParent(Handle, NativeMethods.HWND_MESSAGE);
                NativeMethods.AddClipboardFormatListener(Handle);

                SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
                this.Disposed += NotificationForm_Disposed;

            }

            private void NotificationForm_Disposed(object sender, EventArgs e)
            {
                SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
            }

            private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
            {
                if(e.Reason == SessionSwitchReason.SessionLock)
                    NativeMethods.RemoveClipboardFormatListener(Handle);
                else if (e.Reason == SessionSwitchReason.SessionUnlock)
                    NativeMethods.AddClipboardFormatListener(Handle);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == NativeMethods.WM_CLIPBOARDUPDATE)
                {
                    try
                    {
                        IntPtr owner = GetClipboardOwner();
                        if(owner != IntPtr.Zero)
                            OnClipboardUpdate(m, owner, null);
                    }
                    catch (Exception ex)
                    {
                        ;
                    }
                }
                base.WndProc(ref m);
            }
            
        }

        public class ClipboardSender{

            public IntPtr Owner { get; set; }
            public Message Message { get; set; }

            public ClipboardSender()
            {

            }
            public ClipboardSender(IntPtr Owner, Message Message)
            {
                this.Owner = Owner;
                this.Message = Message;
            }

        }
    }

    internal static class NativeMethods
    {
        // See http://msdn.microsoft.com/en-us/library/ms649021%28v=vs.85%29.aspx
        public const int WM_CLIPBOARDUPDATE = 0x031D;
        public static IntPtr HWND_MESSAGE = new IntPtr(-3);

        // See http://msdn.microsoft.com/en-us/library/ms632599%28VS.85%29.aspx#message_only
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener(IntPtr hwnd);

        // See https://msdn.microsoft.com/en-us/library/windows/desktop/ms649050(v=vs.85).aspx
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        // See http://msdn.microsoft.com/en-us/library/ms633541%28v=vs.85%29.aspx
        // See http://msdn.microsoft.com/en-us/library/ms649033%28VS.85%29.aspx
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


    }
    
}
