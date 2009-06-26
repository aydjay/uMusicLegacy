namespace uMusic
{
	partial class Upload
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtbVideo = new System.Windows.Forms.TextBox();
			this.lblVideo = new System.Windows.Forms.Label();
			this.btnUploadStart = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtbTitle = new System.Windows.Forms.TextBox();
			this.lblTags = new System.Windows.Forms.Label();
			this.txtbTags = new System.Windows.Forms.TextBox();
			this.lblPwd = new System.Windows.Forms.Label();
			this.txtbPwd = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtbUsername = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtbDescription = new System.Windows.Forms.TextBox();
			this.btnDone = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtbOutput = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(235, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtbVideo
			// 
			this.txtbVideo.AllowDrop = true;
			this.txtbVideo.Location = new System.Drawing.Point(70, 15);
			this.txtbVideo.Name = "txtbVideo";
			this.txtbVideo.Size = new System.Drawing.Size(159, 20);
			this.txtbVideo.TabIndex = 0;
			this.txtbVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbVideo_DragDrop);
			this.txtbVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbVideo_DragEnter);
			// 
			// lblVideo
			// 
			this.lblVideo.AutoSize = true;
			this.lblVideo.Location = new System.Drawing.Point(27, 18);
			this.lblVideo.Name = "lblVideo";
			this.lblVideo.Size = new System.Drawing.Size(37, 13);
			this.lblVideo.TabIndex = 2;
			this.lblVideo.Text = "Video:";
			// 
			// btnUploadStart
			// 
			this.btnUploadStart.Location = new System.Drawing.Point(136, 368);
			this.btnUploadStart.Name = "btnUploadStart";
			this.btnUploadStart.Size = new System.Drawing.Size(100, 23);
			this.btnUploadStart.TabIndex = 0;
			this.btnUploadStart.Text = "Upload";
			this.btnUploadStart.UseVisualStyleBackColor = true;
			this.btnUploadStart.Click += new System.EventHandler(this.btnUploadStart_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(40, 18);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(30, 13);
			this.lblTitle.TabIndex = 6;
			this.lblTitle.Text = "Title:";
			// 
			// txtbTitle
			// 
			this.txtbTitle.Location = new System.Drawing.Point(73, 15);
			this.txtbTitle.MaxLength = 60;
			this.txtbTitle.Name = "txtbTitle";
			this.txtbTitle.Size = new System.Drawing.Size(237, 20);
			this.txtbTitle.TabIndex = 0;
			// 
			// lblTags
			// 
			this.lblTags.AutoSize = true;
			this.lblTags.Location = new System.Drawing.Point(36, 202);
			this.lblTags.Name = "lblTags";
			this.lblTags.Size = new System.Drawing.Size(34, 13);
			this.lblTags.TabIndex = 9;
			this.lblTags.Text = "Tags:";
			// 
			// txtbTags
			// 
			this.txtbTags.Location = new System.Drawing.Point(73, 202);
			this.txtbTags.MaxLength = 60;
			this.txtbTags.Name = "txtbTags";
			this.txtbTags.Size = new System.Drawing.Size(238, 20);
			this.txtbTags.TabIndex = 2;
			// 
			// lblPwd
			// 
			this.lblPwd.AutoSize = true;
			this.lblPwd.Location = new System.Drawing.Point(176, 18);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.Size = new System.Drawing.Size(31, 13);
			this.lblPwd.TabIndex = 17;
			this.lblPwd.Text = "Pwd:";
			// 
			// txtbPwd
			// 
			this.txtbPwd.Location = new System.Drawing.Point(207, 14);
			this.txtbPwd.Name = "txtbPwd";
			this.txtbPwd.PasswordChar = '*';
			this.txtbPwd.Size = new System.Drawing.Size(100, 20);
			this.txtbPwd.TabIndex = 1;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(9, 18);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 15;
			this.lblUsername.Text = "Username:";
			// 
			// txtbUsername
			// 
			this.txtbUsername.Location = new System.Drawing.Point(70, 14);
			this.txtbUsername.Name = "txtbUsername";
			this.txtbUsername.Size = new System.Drawing.Size(100, 20);
			this.txtbUsername.TabIndex = 0;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(7, 41);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 19;
			this.lblDescription.Text = "Description:";
			// 
			// txtbDescription
			// 
			this.txtbDescription.Location = new System.Drawing.Point(73, 41);
			this.txtbDescription.MaxLength = 1000;
			this.txtbDescription.Multiline = true;
			this.txtbDescription.Name = "txtbDescription";
			this.txtbDescription.Size = new System.Drawing.Size(237, 155);
			this.txtbDescription.TabIndex = 1;
			// 
			// btnDone
			// 
			this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDone.Location = new System.Drawing.Point(242, 368);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(75, 23);
			this.btnDone.TabIndex = 1;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtbOutput);
			this.groupBox1.Controls.Add(this.lblOutput);
			this.groupBox1.Controls.Add(this.txtbTitle);
			this.groupBox1.Controls.Add(this.lblDescription);
			this.groupBox1.Controls.Add(this.lblTitle);
			this.groupBox1.Controls.Add(this.txtbDescription);
			this.groupBox1.Controls.Add(this.txtbTags);
			this.groupBox1.Controls.Add(this.lblTags);
			this.groupBox1.Location = new System.Drawing.Point(1, 109);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 253);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Video Details:";
			// 
			// txtbOutput
			// 
			this.txtbOutput.Enabled = false;
			this.txtbOutput.Location = new System.Drawing.Point(73, 227);
			this.txtbOutput.MaxLength = 60;
			this.txtbOutput.Name = "txtbOutput";
			this.txtbOutput.Size = new System.Drawing.Size(238, 20);
			this.txtbOutput.TabIndex = 3;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(28, 227);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(42, 13);
			this.lblOutput.TabIndex = 21;
			this.lblOutput.Text = "Output:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtbVideo);
			this.groupBox2.Controls.Add(this.btnBrowse);
			this.groupBox2.Controls.Add(this.lblVideo);
			this.groupBox2.Location = new System.Drawing.Point(1, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(316, 48);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Video File:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblUsername);
			this.groupBox3.Controls.Add(this.txtbUsername);
			this.groupBox3.Controls.Add(this.txtbPwd);
			this.groupBox3.Controls.Add(this.lblPwd);
			this.groupBox3.Location = new System.Drawing.Point(1, 55);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(316, 48);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Credentials:";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// Upload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 397);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnUploadStart);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Upload";
			this.Text = "Upload";
			this.Load += new System.EventHandler(this.Upload_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtbVideo;
		private System.Windows.Forms.Label lblVideo;
		private System.Windows.Forms.Button btnUploadStart;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtbTitle;
		private System.Windows.Forms.Label lblTags;
		private System.Windows.Forms.TextBox txtbTags;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.TextBox txtbPwd;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtbUsername;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtbDescription;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox txtbOutput;
		private System.Windows.Forms.Label lblOutput;
	}
}