namespace PDFSplitterAndMerge
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSplit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loaderPictureBox = new System.Windows.Forms.PictureBox();
            this.txtmilitary = new System.Windows.Forms.TextBox();
            this.btnMilitary = new System.Windows.Forms.Button();
            this.txtscrpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSplitAndMerge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpclpath = new System.Windows.Forms.TextBox();
            this.btnSelectPcl = new System.Windows.Forms.Button();
            this.btnsplitpclfiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loaderPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(514, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select folder for split files";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(290, 437);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(225, 24);
            this.txtFolderName.TabIndex = 1;
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.selectFolder.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.ForeColor = System.Drawing.Color.White;
            this.selectFolder.Location = new System.Drawing.Point(521, 435);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(125, 26);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "Browse";
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.ForeColor = System.Drawing.Color.White;
            this.btnSplit.Location = new System.Drawing.Point(290, 480);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(156, 26);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "Split Complaint Files";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // loaderPictureBox
            // 
            this.loaderPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.loaderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loaderPictureBox.Image")));
            this.loaderPictureBox.Location = new System.Drawing.Point(260, 268);
            this.loaderPictureBox.Name = "loaderPictureBox";
            this.loaderPictureBox.Size = new System.Drawing.Size(808, 268);
            this.loaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loaderPictureBox.TabIndex = 4;
            this.loaderPictureBox.TabStop = false;
            this.loaderPictureBox.Visible = false;
            // 
            // txtmilitary
            // 
            this.txtmilitary.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmilitary.Location = new System.Drawing.Point(290, 317);
            this.txtmilitary.Name = "txtmilitary";
            this.txtmilitary.Size = new System.Drawing.Size(225, 24);
            this.txtmilitary.TabIndex = 5;
            // 
            // btnMilitary
            // 
            this.btnMilitary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.btnMilitary.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilitary.ForeColor = System.Drawing.Color.White;
            this.btnMilitary.Location = new System.Drawing.Point(521, 315);
            this.btnMilitary.Name = "btnMilitary";
            this.btnMilitary.Size = new System.Drawing.Size(125, 26);
            this.btnMilitary.TabIndex = 6;
            this.btnMilitary.Text = "Browse";
            this.btnMilitary.UseVisualStyleBackColor = false;
            this.btnMilitary.Click += new System.EventHandler(this.btnMilitary_Click);
            // 
            // txtscrpath
            // 
            this.txtscrpath.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscrpath.Location = new System.Drawing.Point(682, 315);
            this.txtscrpath.Name = "txtscrpath";
            this.txtscrpath.Size = new System.Drawing.Size(225, 24);
            this.txtscrpath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(913, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSplitAndMerge
            // 
            this.btnSplitAndMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.btnSplitAndMerge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitAndMerge.ForeColor = System.Drawing.Color.White;
            this.btnSplitAndMerge.Location = new System.Drawing.Point(290, 362);
            this.btnSplitAndMerge.Name = "btnSplitAndMerge";
            this.btnSplitAndMerge.Size = new System.Drawing.Size(225, 26);
            this.btnSplitAndMerge.TabIndex = 9;
            this.btnSplitAndMerge.Text = "Split Military and Merge SCRA files";
            this.btnSplitAndMerge.UseVisualStyleBackColor = false;
            this.btnSplitAndMerge.Click += new System.EventHandler(this.btnSplitAndMerge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Complaint folder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Military folder :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select SCRA folder :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select PCL folder :";
            // 
            // txtpclpath
            // 
            this.txtpclpath.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpclpath.Location = new System.Drawing.Point(682, 437);
            this.txtpclpath.Name = "txtpclpath";
            this.txtpclpath.Size = new System.Drawing.Size(225, 24);
            this.txtpclpath.TabIndex = 14;
            // 
            // btnSelectPcl
            // 
            this.btnSelectPcl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.btnSelectPcl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPcl.ForeColor = System.Drawing.Color.White;
            this.btnSelectPcl.Location = new System.Drawing.Point(913, 435);
            this.btnSelectPcl.Name = "btnSelectPcl";
            this.btnSelectPcl.Size = new System.Drawing.Size(125, 26);
            this.btnSelectPcl.TabIndex = 15;
            this.btnSelectPcl.Text = "Browse";
            this.btnSelectPcl.UseVisualStyleBackColor = false;
            this.btnSelectPcl.Click += new System.EventHandler(this.btnSelectPcl_Click);
            // 
            // btnsplitpclfiles
            // 
            this.btnsplitpclfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.btnsplitpclfiles.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsplitpclfiles.ForeColor = System.Drawing.Color.White;
            this.btnsplitpclfiles.Location = new System.Drawing.Point(682, 479);
            this.btnsplitpclfiles.Name = "btnsplitpclfiles";
            this.btnsplitpclfiles.Size = new System.Drawing.Size(156, 26);
            this.btnsplitpclfiles.TabIndex = 16;
            this.btnsplitpclfiles.Text = "Split PCL files";
            this.btnsplitpclfiles.UseVisualStyleBackColor = false;
            this.btnsplitpclfiles.Click += new System.EventHandler(this.btnsplitpclfiles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.loaderPictureBox);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnsplitpclfiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelectPcl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpclpath);
            this.panel1.Controls.Add(this.txtFolderName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.selectFolder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSplit);
            this.panel1.Controls.Add(this.txtmilitary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMilitary);
            this.panel1.Controls.Add(this.btnSplitAndMerge);
            this.panel1.Controls.Add(this.txtscrpath);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 705);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 37);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(260, 268);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(808, 268);
            this.panel2.TabIndex = 18;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(260, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(808, 64);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF splitter And Merger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.loaderPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSplit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox loaderPictureBox;
        private System.Windows.Forms.TextBox txtmilitary;
        private System.Windows.Forms.Button btnMilitary;
        private System.Windows.Forms.TextBox txtscrpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSplitAndMerge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpclpath;
        private System.Windows.Forms.Button btnSelectPcl;
        private System.Windows.Forms.Button btnsplitpclfiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

