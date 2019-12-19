namespace lolextract
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnBinSelect = new System.Windows.Forms.Button();
            this.btnBnkSelect = new System.Windows.Forms.Button();
            this.btnWpkSelect = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.btnVoiceExtract = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 64);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(93, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Wad \\ Wad.Client";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(543, 28);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(118, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "1- Wad Select";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(667, 28);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(118, 23);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "2- Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(745, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Wad.client files (*.wad.client)|*.wad.client|All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Tag = "";
            this.openFileDialog1.Title = "Select wad file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(763, 83);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(22, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "-";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.DisplayMember = "Bin";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 222);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(745, 30);
            this.listBox2.TabIndex = 5;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            // 
            // listBox3
            // 
            this.listBox3.AllowDrop = true;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 258);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(745, 30);
            this.listBox3.TabIndex = 6;
            this.listBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox3_DragDrop);
            this.listBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox3_DragEnter);
            // 
            // listBox4
            // 
            this.listBox4.AllowDrop = true;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(12, 294);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(745, 30);
            this.listBox4.TabIndex = 7;
            this.listBox4.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox4_DragDrop);
            this.listBox4.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox4_DragEnter);
            // 
            // btnBinSelect
            // 
            this.btnBinSelect.Location = new System.Drawing.Point(12, 193);
            this.btnBinSelect.Name = "btnBinSelect";
            this.btnBinSelect.Size = new System.Drawing.Size(118, 23);
            this.btnBinSelect.TabIndex = 8;
            this.btnBinSelect.Text = "3- Bin Select";
            this.btnBinSelect.UseVisualStyleBackColor = true;
            this.btnBinSelect.Click += new System.EventHandler(this.btnBinSelect_Click);
            // 
            // btnBnkSelect
            // 
            this.btnBnkSelect.Location = new System.Drawing.Point(136, 193);
            this.btnBnkSelect.Name = "btnBnkSelect";
            this.btnBnkSelect.Size = new System.Drawing.Size(118, 23);
            this.btnBnkSelect.TabIndex = 9;
            this.btnBnkSelect.Text = "4- BNK Select";
            this.btnBnkSelect.UseVisualStyleBackColor = true;
            this.btnBnkSelect.Click += new System.EventHandler(this.btnBnkSelect_Click);
            // 
            // btnWpkSelect
            // 
            this.btnWpkSelect.Location = new System.Drawing.Point(260, 193);
            this.btnWpkSelect.Name = "btnWpkSelect";
            this.btnWpkSelect.Size = new System.Drawing.Size(118, 23);
            this.btnWpkSelect.TabIndex = 10;
            this.btnWpkSelect.Text = "5- WPK Select";
            this.btnWpkSelect.UseVisualStyleBackColor = true;
            this.btnWpkSelect.Click += new System.EventHandler(this.btnWpkSelect_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Bin files (*.bin)|*.bin|All files (*.*)|*.*";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Filter = "BNK files (*.bnk)|*.bnk|All files (*.*)|*.*";
            this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.Filter = "WPK files (*.wpk)|*.wpk|All files (*.*)|*.*";
            this.openFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog4_FileOk);
            // 
            // btnVoiceExtract
            // 
            this.btnVoiceExtract.Location = new System.Drawing.Point(384, 193);
            this.btnVoiceExtract.Name = "btnVoiceExtract";
            this.btnVoiceExtract.Size = new System.Drawing.Size(118, 23);
            this.btnVoiceExtract.TabIndex = 11;
            this.btnVoiceExtract.Text = "6- Voice Extract";
            this.btnVoiceExtract.UseVisualStyleBackColor = true;
            this.btnVoiceExtract.Click += new System.EventHandler(this.btnVoiceExtract_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(763, 222);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(25, 102);
            this.btnRemove2.TabIndex = 12;
            this.btnRemove2.Text = "-";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lolextract.Properties.Resources.betr;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(153, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "youtube.com/PBETR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(349, 25);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 13);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "erdem.in";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnVoiceExtract);
            this.Controls.Add(this.btnWpkSelect);
            this.Controls.Add(this.btnBnkSelect);
            this.Controls.Add(this.btnBinSelect);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 377);
            this.MinimumSize = new System.Drawing.Size(816, 377);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBETR Extractor v7.0- By Erdem (IO) & Eren (Js)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnBinSelect;
        private System.Windows.Forms.Button btnBnkSelect;
        private System.Windows.Forms.Button btnWpkSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Button btnVoiceExtract;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

