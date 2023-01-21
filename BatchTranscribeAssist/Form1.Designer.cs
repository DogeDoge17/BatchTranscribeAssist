namespace BatchTranscribeAssist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.folderLbl = new System.Windows.Forms.Label();
            this.fileBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.fileLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(12, 65);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(162, 47);
            this.folderBtn.TabIndex = 0;
            this.folderBtn.Text = "Folder";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(196, 12);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(147, 58);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.Text = "previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(637, 12);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(151, 58);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(196, 376);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(592, 62);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(196, 76);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(592, 294);
            this.inputBox.TabIndex = 5;
            this.inputBox.Text = "";
            // 
            // folderLbl
            // 
            this.folderLbl.Location = new System.Drawing.Point(12, 262);
            this.folderLbl.Name = "folderLbl";
            this.folderLbl.Size = new System.Drawing.Size(162, 176);
            this.folderLbl.TabIndex = 6;
            this.folderLbl.Text = "No folder open";
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(12, 12);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(162, 47);
            this.fileBtn.TabIndex = 7;
            this.fileBtn.Text = "File";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.Location = new System.Drawing.Point(349, 12);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(282, 58);
            this.statusLbl.TabIndex = 8;
            this.statusLbl.Text = "no audio name\r\n0/0";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileLbl
            // 
            this.fileLbl.Location = new System.Drawing.Point(12, 115);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(162, 147);
            this.fileLbl.TabIndex = 9;
            this.fileLbl.Text = "No file open";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(180, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 484);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.folderLbl);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.folderBtn);
            this.Name = "Form1";
            this.Text = "Batch Transcribe Assist";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button folderBtn;
        private Button previousBtn;
        private Button nextBtn;
        private Button playBtn;
        private RichTextBox inputBox;
        private Label folderLbl;
        private Button fileBtn;
        private Label statusLbl;
        private Label fileLbl;
        private PictureBox pictureBox1;
    }
}