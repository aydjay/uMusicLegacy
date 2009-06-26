namespace uMusic
{
    partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.txtbTuneLoc = new System.Windows.Forms.TextBox();
			this.picbPreview = new System.Windows.Forms.PictureBox();
			this.lblTune = new System.Windows.Forms.Label();
			this.lblPic = new System.Windows.Forms.Label();
			this.btnTuneBrowse = new System.Windows.Forms.Button();
			this.btnCreateVid = new System.Windows.Forms.Button();
			this.lblTuneLength = new System.Windows.Forms.Label();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnPicBrowse = new System.Windows.Forms.Button();
			this.txtbPicLoc = new System.Windows.Forms.TextBox();
			this.grpbPreview = new System.Windows.Forms.GroupBox();
			this.lblPersuasion = new System.Windows.Forms.Label();
			this.lnklDonate = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbUploadChoice = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.videoSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hostingSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rapidshareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
			this.grpbPreview.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.cmbUploadChoice.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtbTuneLoc
			// 
			this.txtbTuneLoc.AllowDrop = true;
			this.txtbTuneLoc.Location = new System.Drawing.Point(46, 14);
			this.txtbTuneLoc.Name = "txtbTuneLoc";
			this.txtbTuneLoc.Size = new System.Drawing.Size(232, 20);
			this.txtbTuneLoc.TabIndex = 0;
			this.txtbTuneLoc.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbTuneLoc_DragDrop);
			this.txtbTuneLoc.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbTuneLoc_DragEnter);
			// 
			// picbPreview
			// 
			this.picbPreview.Location = new System.Drawing.Point(6, 19);
			this.picbPreview.Name = "picbPreview";
			this.picbPreview.Size = new System.Drawing.Size(329, 234);
			this.picbPreview.TabIndex = 2;
			this.picbPreview.TabStop = false;
			// 
			// lblTune
			// 
			this.lblTune.AutoSize = true;
			this.lblTune.Location = new System.Drawing.Point(5, 17);
			this.lblTune.Name = "lblTune";
			this.lblTune.Size = new System.Drawing.Size(35, 13);
			this.lblTune.TabIndex = 3;
			this.lblTune.Text = "Song:";
			// 
			// lblPic
			// 
			this.lblPic.AutoSize = true;
			this.lblPic.Location = new System.Drawing.Point(5, 46);
			this.lblPic.Name = "lblPic";
			this.lblPic.Size = new System.Drawing.Size(43, 13);
			this.lblPic.TabIndex = 4;
			this.lblPic.Text = "Picture:";
			// 
			// btnTuneBrowse
			// 
			this.btnTuneBrowse.Location = new System.Drawing.Point(284, 12);
			this.btnTuneBrowse.Name = "btnTuneBrowse";
			this.btnTuneBrowse.Size = new System.Drawing.Size(51, 23);
			this.btnTuneBrowse.TabIndex = 1;
			this.btnTuneBrowse.Text = "Browse";
			this.btnTuneBrowse.UseVisualStyleBackColor = true;
			this.btnTuneBrowse.Click += new System.EventHandler(this.btnTuneBrowse_Click);
			// 
			// btnCreateVid
			// 
			this.btnCreateVid.Location = new System.Drawing.Point(3, 340);
			this.btnCreateVid.Name = "btnCreateVid";
			this.btnCreateVid.Size = new System.Drawing.Size(75, 34);
			this.btnCreateVid.TabIndex = 0;
			this.btnCreateVid.Text = "Create Video";
			this.btnCreateVid.UseVisualStyleBackColor = true;
			this.btnCreateVid.Click += new System.EventHandler(this.btnCreateVid_Click);
			// 
			// lblTuneLength
			// 
			this.lblTuneLength.AutoSize = true;
			this.lblTuneLength.Location = new System.Drawing.Point(232, 17);
			this.lblTuneLength.Name = "lblTuneLength";
			this.lblTuneLength.Size = new System.Drawing.Size(0, 13);
			this.lblTuneLength.TabIndex = 18;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(269, 340);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 34);
			this.btnUpload.TabIndex = 1;
			this.btnUpload.Text = "Upload Video";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnPicBrowse
			// 
			this.btnPicBrowse.Location = new System.Drawing.Point(284, 41);
			this.btnPicBrowse.Name = "btnPicBrowse";
			this.btnPicBrowse.Size = new System.Drawing.Size(51, 23);
			this.btnPicBrowse.TabIndex = 3;
			this.btnPicBrowse.Text = "Browse";
			this.btnPicBrowse.UseVisualStyleBackColor = true;
			this.btnPicBrowse.Click += new System.EventHandler(this.btnPicBrowse_Click);
			// 
			// txtbPicLoc
			// 
			this.txtbPicLoc.AllowDrop = true;
			this.txtbPicLoc.Location = new System.Drawing.Point(46, 43);
			this.txtbPicLoc.Name = "txtbPicLoc";
			this.txtbPicLoc.Size = new System.Drawing.Size(232, 20);
			this.txtbPicLoc.TabIndex = 2;
			this.txtbPicLoc.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbPicLoc_DragDrop);
			this.txtbPicLoc.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbPicLoc_DragEnter);
			// 
			// grpbPreview
			// 
			this.grpbPreview.Controls.Add(this.picbPreview);
			this.grpbPreview.Location = new System.Drawing.Point(3, 75);
			this.grpbPreview.Name = "grpbPreview";
			this.grpbPreview.Size = new System.Drawing.Size(341, 259);
			this.grpbPreview.TabIndex = 1;
			this.grpbPreview.TabStop = false;
			this.grpbPreview.Text = "Preview:";
			// 
			// lblPersuasion
			// 
			this.lblPersuasion.AutoSize = true;
			this.lblPersuasion.Location = new System.Drawing.Point(95, 338);
			this.lblPersuasion.Name = "lblPersuasion";
			this.lblPersuasion.Size = new System.Drawing.Size(156, 13);
			this.lblPersuasion.TabIndex = 26;
			this.lblPersuasion.Text = "Saved you time? Buy me a pint!";
			// 
			// lnklDonate
			// 
			this.lnklDonate.AutoSize = true;
			this.lnklDonate.Location = new System.Drawing.Point(153, 359);
			this.lnklDonate.Name = "lnklDonate";
			this.lnklDonate.Size = new System.Drawing.Size(42, 13);
			this.lnklDonate.TabIndex = 28;
			this.lnklDonate.TabStop = true;
			this.lnklDonate.Text = "Donate";
			this.lnklDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklDonate_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtbPicLoc);
			this.groupBox1.Controls.Add(this.txtbTuneLoc);
			this.groupBox1.Controls.Add(this.lblTune);
			this.groupBox1.Controls.Add(this.lblPic);
			this.groupBox1.Controls.Add(this.btnTuneBrowse);
			this.groupBox1.Controls.Add(this.btnPicBrowse);
			this.groupBox1.Controls.Add(this.lblTuneLength);
			this.groupBox1.Location = new System.Drawing.Point(3, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 69);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source Files:";
			// 
			// cmbUploadChoice
			// 
			this.cmbUploadChoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoSitesToolStripMenuItem,
            this.hostingSitesToolStripMenuItem});
			this.cmbUploadChoice.Name = "cmbUploadChoice";
			this.cmbUploadChoice.Size = new System.Drawing.Size(137, 48);
			// 
			// videoSitesToolStripMenuItem
			// 
			this.videoSitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeToolStripMenuItem});
			this.videoSitesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("videoSitesToolStripMenuItem.Image")));
			this.videoSitesToolStripMenuItem.Name = "videoSitesToolStripMenuItem";
			this.videoSitesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.videoSitesToolStripMenuItem.Text = "Video Sites";
			// 
			// youTubeToolStripMenuItem
			// 
			this.youTubeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youTubeToolStripMenuItem.Image")));
			this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
			this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.youTubeToolStripMenuItem.Text = "YouTube";
			this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.youTubeToolStripMenuItem_Click);
			// 
			// hostingSitesToolStripMenuItem
			// 
			this.hostingSitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapidshareToolStripMenuItem});
			this.hostingSitesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hostingSitesToolStripMenuItem.Image")));
			this.hostingSitesToolStripMenuItem.Name = "hostingSitesToolStripMenuItem";
			this.hostingSitesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.hostingSitesToolStripMenuItem.Text = "Hosting Sites";
			// 
			// rapidshareToolStripMenuItem
			// 
			this.rapidshareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rapidshareToolStripMenuItem.Image")));
			this.rapidshareToolStripMenuItem.Name = "rapidshareToolStripMenuItem";
			this.rapidshareToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.rapidshareToolStripMenuItem.Text = "Rapidshare";
			this.rapidshareToolStripMenuItem.Click += new System.EventHandler(this.rapidshareToolStripMenuItem_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 376);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lnklDonate);
			this.Controls.Add(this.lblPersuasion);
			this.Controls.Add(this.grpbPreview);
			this.Controls.Add(this.btnCreateVid);
			this.Controls.Add(this.btnUpload);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "uMusic";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
			this.grpbPreview.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.cmbUploadChoice.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TextBox txtbTuneLoc;
        private System.Windows.Forms.PictureBox picbPreview;
        private System.Windows.Forms.Label lblTune;
		private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Button btnTuneBrowse;
		private System.Windows.Forms.Button btnCreateVid;
		private System.Windows.Forms.Label lblTuneLength;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnPicBrowse;
		private System.Windows.Forms.TextBox txtbPicLoc;
		private System.Windows.Forms.GroupBox grpbPreview;
		private System.Windows.Forms.Label lblPersuasion;
		private System.Windows.Forms.LinkLabel lnklDonate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ContextMenuStrip cmbUploadChoice;
		private System.Windows.Forms.ToolStripMenuItem videoSitesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hostingSitesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rapidshareToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

