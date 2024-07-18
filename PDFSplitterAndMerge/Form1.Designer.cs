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
            ((System.ComponentModel.ISupportInitialize)(this.loaderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder for split files";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(312, 84);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(218, 24);
            this.txtFolderName.TabIndex = 1;
            // 
            // selectFolder
            // 
            this.selectFolder.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.Location = new System.Drawing.Point(529, 84);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(118, 24);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "Browse";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(673, 85);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(156, 23);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "Split Complaint Files";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // loaderPictureBox
            // 
            this.loaderPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loaderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loaderPictureBox.Image")));
            this.loaderPictureBox.Location = new System.Drawing.Point(247, 285);
            this.loaderPictureBox.Name = "loaderPictureBox";
            this.loaderPictureBox.Size = new System.Drawing.Size(428, 132);
            this.loaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loaderPictureBox.TabIndex = 4;
            this.loaderPictureBox.TabStop = false;
            this.loaderPictureBox.Visible = false;
            // 
            // txtmilitary
            // 
            this.txtmilitary.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmilitary.Location = new System.Drawing.Point(312, 139);
            this.txtmilitary.Name = "txtmilitary";
            this.txtmilitary.Size = new System.Drawing.Size(218, 24);
            this.txtmilitary.TabIndex = 5;
            // 
            // btnMilitary
            // 
            this.btnMilitary.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilitary.Location = new System.Drawing.Point(529, 139);
            this.btnMilitary.Name = "btnMilitary";
            this.btnMilitary.Size = new System.Drawing.Size(118, 25);
            this.btnMilitary.TabIndex = 6;
            this.btnMilitary.Text = "Browse";
            this.btnMilitary.UseVisualStyleBackColor = true;
            this.btnMilitary.Click += new System.EventHandler(this.btnMilitary_Click);
            // 
            // txtscrpath
            // 
            this.txtscrpath.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscrpath.Location = new System.Drawing.Point(312, 186);
            this.txtscrpath.Name = "txtscrpath";
            this.txtscrpath.Size = new System.Drawing.Size(218, 24);
            this.txtscrpath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSplitAndMerge
            // 
            this.btnSplitAndMerge.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitAndMerge.Location = new System.Drawing.Point(673, 141);
            this.btnSplitAndMerge.Name = "btnSplitAndMerge";
            this.btnSplitAndMerge.Size = new System.Drawing.Size(156, 23);
            this.btnSplitAndMerge.TabIndex = 9;
            this.btnSplitAndMerge.Text = "Split And Merge";
            this.btnSplitAndMerge.UseVisualStyleBackColor = true;
            this.btnSplitAndMerge.Click += new System.EventHandler(this.btnSplitAndMerge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Complaint folder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Military folder :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Scra folder :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Pcl folder :";
            // 
            // txtpclpath
            // 
            this.txtpclpath.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpclpath.Location = new System.Drawing.Point(312, 230);
            this.txtpclpath.Name = "txtpclpath";
            this.txtpclpath.Size = new System.Drawing.Size(218, 24);
            this.txtpclpath.TabIndex = 14;
            // 
            // btnSelectPcl
            // 
            this.btnSelectPcl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPcl.Location = new System.Drawing.Point(529, 230);
            this.btnSelectPcl.Name = "btnSelectPcl";
            this.btnSelectPcl.Size = new System.Drawing.Size(118, 24);
            this.btnSelectPcl.TabIndex = 15;
            this.btnSelectPcl.Text = "Browse";
            this.btnSelectPcl.UseVisualStyleBackColor = true;
            this.btnSelectPcl.Click += new System.EventHandler(this.btnSelectPcl_Click);
            // 
            // btnsplitpclfiles
            // 
            this.btnsplitpclfiles.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsplitpclfiles.Location = new System.Drawing.Point(673, 230);
            this.btnsplitpclfiles.Name = "btnsplitpclfiles";
            this.btnsplitpclfiles.Size = new System.Drawing.Size(156, 23);
            this.btnsplitpclfiles.TabIndex = 16;
            this.btnsplitpclfiles.Text = "Split PCL files";
            this.btnsplitpclfiles.UseVisualStyleBackColor = true;
            this.btnsplitpclfiles.Click += new System.EventHandler(this.btnsplitpclfiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 479);
            this.Controls.Add(this.btnsplitpclfiles);
            this.Controls.Add(this.btnSelectPcl);
            this.Controls.Add(this.txtpclpath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSplitAndMerge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtscrpath);
            this.Controls.Add(this.btnMilitary);
            this.Controls.Add(this.txtmilitary);
            this.Controls.Add(this.loaderPictureBox);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF splitter And Merger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.loaderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

