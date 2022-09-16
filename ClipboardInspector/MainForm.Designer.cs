namespace ClipboardViewerTest
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomFormat = new System.Windows.Forms.TextBox();
            this.btnCustomFormat = new System.Windows.Forms.Button();
            this.comboDefaultFormats = new System.Windows.Forms.ComboBox();
            this.btnSetDefaultFormat = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioBigEndianUnicode = new System.Windows.Forms.RadioButton();
            this.radioUTF32 = new System.Windows.Forms.RadioButton();
            this.radioUTF7 = new System.Windows.Forms.RadioButton();
            this.radioUTF8 = new System.Windows.Forms.RadioButton();
            this.radioUnicode = new System.Windows.Forms.RadioButton();
            this.radioPrintable = new System.Windows.Forms.RadioButton();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.radioAscii = new System.Windows.Forms.RadioButton();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 604);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(221, 111);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(593, 522);
            this.txtContent.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtCustomFormat);
            this.panel1.Controls.Add(this.btnCustomFormat);
            this.panel1.Controls.Add(this.comboDefaultFormats);
            this.panel1.Controls.Add(this.btnSetDefaultFormat);
            this.panel1.Controls.Add(this.btnEmpty);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.radioBigEndianUnicode);
            this.panel1.Controls.Add(this.radioUTF32);
            this.panel1.Controls.Add(this.radioUTF7);
            this.panel1.Controls.Add(this.radioUTF8);
            this.panel1.Controls.Add(this.radioUnicode);
            this.panel1.Controls.Add(this.radioPrintable);
            this.panel1.Controls.Add(this.radioHex);
            this.panel1.Controls.Add(this.radioAscii);
            this.panel1.Location = new System.Drawing.Point(221, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 97);
            this.panel1.TabIndex = 3;
            // 
            // txtCustomFormat
            // 
            this.txtCustomFormat.Location = new System.Drawing.Point(369, 63);
            this.txtCustomFormat.Name = "txtCustomFormat";
            this.txtCustomFormat.Size = new System.Drawing.Size(221, 20);
            this.txtCustomFormat.TabIndex = 21;
            this.txtCustomFormat.DoubleClick += new System.EventHandler(this.txtCustomFormat_DoubleClick);
            // 
            // btnCustomFormat
            // 
            this.btnCustomFormat.Location = new System.Drawing.Point(245, 62);
            this.btnCustomFormat.Name = "btnCustomFormat";
            this.btnCustomFormat.Size = new System.Drawing.Size(118, 23);
            this.btnCustomFormat.TabIndex = 20;
            this.btnCustomFormat.Text = "custom format:";
            this.btnCustomFormat.UseVisualStyleBackColor = true;
            this.btnCustomFormat.Click += new System.EventHandler(this.btnCustomFormat_Click);
            // 
            // comboDefaultFormats
            // 
            this.comboDefaultFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDefaultFormats.FormattingEnabled = true;
            this.comboDefaultFormats.Location = new System.Drawing.Point(130, 63);
            this.comboDefaultFormats.Name = "comboDefaultFormats";
            this.comboDefaultFormats.Size = new System.Drawing.Size(109, 23);
            this.comboDefaultFormats.TabIndex = 19;
            // 
            // btnSetDefaultFormat
            // 
            this.btnSetDefaultFormat.Location = new System.Drawing.Point(6, 62);
            this.btnSetDefaultFormat.Name = "btnSetDefaultFormat";
            this.btnSetDefaultFormat.Size = new System.Drawing.Size(118, 24);
            this.btnSetDefaultFormat.TabIndex = 18;
            this.btnSetDefaultFormat.Text = "set as format:";
            this.btnSetDefaultFormat.UseVisualStyleBackColor = true;
            this.btnSetDefaultFormat.Click += new System.EventHandler(this.btnSetDefaultFormat_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpty.Location = new System.Drawing.Point(465, 33);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(118, 23);
            this.btnEmpty.TabIndex = 16;
            this.btnEmpty.Text = "empty clipboard";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Location = new System.Drawing.Point(46, 43);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(98, 13);
            this.txtSize.TabIndex = 14;
            this.txtSize.Text = "0";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(3, 43);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 15);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Size:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(46, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(98, 13);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "CF_TEXT";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(46, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(98, 13);
            this.txtID.TabIndex = 9;
            this.txtID.Text = "0x0";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(502, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "save data";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioBigEndianUnicode
            // 
            this.radioBigEndianUnicode.AutoSize = true;
            this.radioBigEndianUnicode.Location = new System.Drawing.Point(272, 22);
            this.radioBigEndianUnicode.Name = "radioBigEndianUnicode";
            this.radioBigEndianUnicode.Size = new System.Drawing.Size(133, 19);
            this.radioBigEndianUnicode.TabIndex = 7;
            this.radioBigEndianUnicode.Text = "Big Endian Unicode";
            this.radioBigEndianUnicode.UseVisualStyleBackColor = true;
            this.radioBigEndianUnicode.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioUTF32
            // 
            this.radioUTF32.AutoSize = true;
            this.radioUTF32.Location = new System.Drawing.Point(211, 22);
            this.radioUTF32.Name = "radioUTF32";
            this.radioUTF32.Size = new System.Drawing.Size(61, 19);
            this.radioUTF32.TabIndex = 6;
            this.radioUTF32.Text = "UTF-32";
            this.radioUTF32.UseVisualStyleBackColor = true;
            this.radioUTF32.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioUTF7
            // 
            this.radioUTF7.AutoSize = true;
            this.radioUTF7.Location = new System.Drawing.Point(150, 22);
            this.radioUTF7.Name = "radioUTF7";
            this.radioUTF7.Size = new System.Drawing.Size(55, 19);
            this.radioUTF7.TabIndex = 5;
            this.radioUTF7.Text = "UTF-7";
            this.radioUTF7.UseVisualStyleBackColor = true;
            this.radioUTF7.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioUTF8
            // 
            this.radioUTF8.AutoSize = true;
            this.radioUTF8.Checked = true;
            this.radioUTF8.Location = new System.Drawing.Point(150, 5);
            this.radioUTF8.Name = "radioUTF8";
            this.radioUTF8.Size = new System.Drawing.Size(55, 19);
            this.radioUTF8.TabIndex = 4;
            this.radioUTF8.TabStop = true;
            this.radioUTF8.Text = "UTF-8";
            this.radioUTF8.UseVisualStyleBackColor = true;
            this.radioUTF8.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioUnicode
            // 
            this.radioUnicode.AutoSize = true;
            this.radioUnicode.Location = new System.Drawing.Point(272, 4);
            this.radioUnicode.Name = "radioUnicode";
            this.radioUnicode.Size = new System.Drawing.Size(67, 19);
            this.radioUnicode.TabIndex = 3;
            this.radioUnicode.Text = "Unicode";
            this.radioUnicode.UseVisualStyleBackColor = true;
            this.radioUnicode.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioPrintable
            // 
            this.radioPrintable.AutoSize = true;
            this.radioPrintable.Location = new System.Drawing.Point(345, 4);
            this.radioPrintable.Name = "radioPrintable";
            this.radioPrintable.Size = new System.Drawing.Size(109, 19);
            this.radioPrintable.TabIndex = 2;
            this.radioPrintable.Text = "Printable Text";
            this.radioPrintable.UseVisualStyleBackColor = true;
            this.radioPrintable.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioHex
            // 
            this.radioHex.AutoSize = true;
            this.radioHex.Location = new System.Drawing.Point(460, 4);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(43, 19);
            this.radioHex.TabIndex = 1;
            this.radioHex.Text = "Hex";
            this.radioHex.UseVisualStyleBackColor = true;
            this.radioHex.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioAscii
            // 
            this.radioAscii.AutoSize = true;
            this.radioAscii.Location = new System.Drawing.Point(211, 5);
            this.radioAscii.Name = "radioAscii";
            this.radioAscii.Size = new System.Drawing.Size(55, 19);
            this.radioAscii.TabIndex = 0;
            this.radioAscii.Text = "ASCII";
            this.radioAscii.UseVisualStyleBackColor = true;
            this.radioAscii.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Checked = true;
            this.chkAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdate.Location = new System.Drawing.Point(12, 8);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(92, 19);
            this.chkAutoUpdate.TabIndex = 5;
            this.chkAutoUpdate.Text = "auto update";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(151, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 647);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkAutoUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(842, 474);
            this.Name = "MainForm";
            this.Text = "Clipboard Inspector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioPrintable;
        private System.Windows.Forms.RadioButton radioHex;
        private System.Windows.Forms.RadioButton radioAscii;
        private System.Windows.Forms.RadioButton radioUTF8;
        private System.Windows.Forms.RadioButton radioUnicode;
        private System.Windows.Forms.RadioButton radioBigEndianUnicode;
        private System.Windows.Forms.RadioButton radioUTF32;
        private System.Windows.Forms.RadioButton radioUTF7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.TextBox txtCustomFormat;
        private System.Windows.Forms.Button btnCustomFormat;
        private System.Windows.Forms.ComboBox comboDefaultFormats;
        private System.Windows.Forms.Button btnSetDefaultFormat;
    }
}

