using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardViewerTest
{
    public partial class MainForm : Form
    {
        uint currentFormat = 0;
        byte[] data;
        bool autoUpdateDisabled = false;

        BindingList<ClipboardData> clipboardDatas = new BindingList<ClipboardData>();

        private class ClipboardData
        {
            public uint Id { get; set; }
            public string Name { get; set; }
            public string Description { get { return "[0x" + Id.ToString("X4").ToLower() + "] " + Name;  } }

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var item in Enum.GetValues(typeof(klemmbrett.ClipboardHelper.ClipboardFormats)))
            {
                
                comboDefaultFormats.Items.Add(item);
            }
            comboDefaultFormats.Text = "CF_TEXT";
            
 
            Clippy.ClipboardNotification.ClipboardUpdate += ClipboardNotification_ClipboardUpdate;
            listBox1.DataSource = clipboardDatas;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Description";
            UpdateClipboardData();
        }

        private void ListBox1_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void ClipboardNotification_ClipboardUpdate(object sender, EventArgs e)
        {
            if(chkAutoUpdate.Checked || autoUpdateDisabled)
                UpdateClipboardData(true);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ClipboardData)listBox1.SelectedItem);
            if(item != null)
                switch (item.Name)
                {
                    case "CF_TEXT":
                    case "CF_OEMTEXT":
                    case "Csv":
                        //radioUTF8.Checked = true;
                        break;
                    case "CF_UNICODETEXT":
                        //radioUnicode.Checked = true;
                        break;
                    case "Rich Text Format":
                    case "HTML Format":
                        //radioUTF8.Checked = true;
                        break;
                    default:
                        //radioHex.Checked = true;
                        break;
                }
            ShowData();
        }

        void UpdateClipboardData(bool sleep = false)
        {
            clipboardDatas.Clear();
            Dictionary<uint, string> formats = klemmbrett.ClipboardHelper.GetClipboardFormats(this.Handle);

            foreach (KeyValuePair<uint, string> format in formats)
                clipboardDatas.Add(new ClipboardData() { Id = format.Key, Name = format.Value });

            if (sleep)
                System.Threading.Thread.Sleep(50); // stop race conditions
            ShowData();
        }

        void ShowData()
        {
           
            var item = ((ClipboardData)listBox1.SelectedItem);
            
            if (item == null)
                return;

            uint id = item.Id;
            

            txtID.Text = "0x" + id.ToString("X4").ToLower();
            txtName.Text = item.Name;
            this.data = klemmbrett.ClipboardHelper.GetClipboardDataBytes(IntPtr.Zero,id);

            

            if (data == null) {
                txtContent.Text = "<null>";
                return;
            }
            else if (radioHex.Checked)
                txtContent.Text = HexDumpHelper.SimpleHexDump(data);
            else if (radioPrintable.Checked)
                txtContent.Text = HexDumpHelper.BinDump(data);
            else if (radioAscii.Checked)
                txtContent.Text = Encoding.ASCII.GetString(data);
            else if (radioUnicode.Checked)
                txtContent.Text = Encoding.Unicode.GetString(data);
            else if (radioUTF8.Checked)
                txtContent.Text = Encoding.UTF8.GetString(data);
            else if (radioUTF7.Checked)
                txtContent.Text = Encoding.UTF7.GetString(data);
            else if (radioUTF32.Checked)
                txtContent.Text = Encoding.UTF32.GetString(data);
            else if (radioBigEndianUnicode.Checked)
                txtContent.Text = Encoding.BigEndianUnicode.GetString(data);


            txtSize.Text = data.Length.ToString() + " bytes";
            /*
            if (data != null && item.Name == "Rich Text Format")
                richTextBox1.Rtf = Encoding.UTF8.GetString(data);
            */

        }

        private void radioText_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog.FileName, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClipboardData();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            klemmbrett.ClipboardHelper.ClearClipboard(this.Handle);
            ShowData();
        }

        private void btnSetDefaultFormat_Click(object sender, EventArgs e)
        {
            klemmbrett.ClipboardHelper.ClipboardFormats format = (klemmbrett.ClipboardHelper.ClipboardFormats)comboDefaultFormats.SelectedItem;
            klemmbrett.ClipboardHelper.SetClipboardDataBytes(this.Handle, format, data);
            ShowData();
        }

        private void btnCustomFormat_Click(object sender, EventArgs e)
        {
            klemmbrett.ClipboardHelper.SetClipboardDataBytesCustomFormat(this.Handle, txtCustomFormat.Text, this.data);
            ShowData();
        }

        private void txtCustomFormat_DoubleClick(object sender, EventArgs e)
        {
            var item = ((ClipboardData)listBox1.SelectedItem);
            txtCustomFormat.Text = item.Name;
        }
    }
}
