namespace uMusic
{
	partial class RapidShare_Upload
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapidShare_Upload));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtbUsername = new System.Windows.Forms.TextBox();
			this.txtbPwd = new System.Windows.Forms.TextBox();
			this.lblPwd = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtbVideo = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lblVideo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtbOutput = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rdoBPremium = new System.Windows.Forms.RadioButton();
			this.rdoBCollector = new System.Windows.Forms.RadioButton();
			this.rdoBFree = new System.Windows.Forms.RadioButton();
			this.btnUpload = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnDone = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblUsername);
			this.groupBox3.Controls.Add(this.txtbUsername);
			this.groupBox3.Controls.Add(this.txtbPwd);
			this.groupBox3.Controls.Add(this.lblPwd);
			this.groupBox3.Location = new System.Drawing.Point(2, 114);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(316, 45);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Credentials:";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(3, 23);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 15;
			this.lblUsername.Text = "Username:";
			// 
			// txtbUsername
			// 
			this.txtbUsername.Location = new System.Drawing.Point(61, 19);
			this.txtbUsername.Name = "txtbUsername";
			this.txtbUsername.Size = new System.Drawing.Size(114, 20);
			this.txtbUsername.TabIndex = 0;
			// 
			// txtbPwd
			// 
			this.txtbPwd.Location = new System.Drawing.Point(212, 19);
			this.txtbPwd.Name = "txtbPwd";
			this.txtbPwd.PasswordChar = '*';
			this.txtbPwd.Size = new System.Drawing.Size(100, 20);
			this.txtbPwd.TabIndex = 1;
			// 
			// lblPwd
			// 
			this.lblPwd.AutoSize = true;
			this.lblPwd.Location = new System.Drawing.Point(181, 23);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.Size = new System.Drawing.Size(31, 13);
			this.lblPwd.TabIndex = 17;
			this.lblPwd.Text = "Pwd:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtbVideo);
			this.groupBox2.Controls.Add(this.btnBrowse);
			this.groupBox2.Controls.Add(this.lblVideo);
			this.groupBox2.Location = new System.Drawing.Point(2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(316, 48);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Video File:";
			// 
			// txtbVideo
			// 
			this.txtbVideo.AllowDrop = true;
			this.txtbVideo.Location = new System.Drawing.Point(60, 16);
			this.txtbVideo.Name = "txtbVideo";
			this.txtbVideo.Size = new System.Drawing.Size(159, 20);
			this.txtbVideo.TabIndex = 1;
			this.txtbVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtbVideo_DragDrop);
			this.txtbVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtbVideo_DragEnter);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(236, 13);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// lblVideo
			// 
			this.lblVideo.AutoSize = true;
			this.lblVideo.Location = new System.Drawing.Point(17, 19);
			this.lblVideo.Name = "lblVideo";
			this.lblVideo.Size = new System.Drawing.Size(37, 13);
			this.lblVideo.TabIndex = 2;
			this.lblVideo.Text = "Video:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtbOutput);
			this.groupBox1.Location = new System.Drawing.Point(2, 165);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 238);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Output:";
			// 
			// txtbOutput
			// 
			this.txtbOutput.Location = new System.Drawing.Point(6, 13);
			this.txtbOutput.Name = "txtbOutput";
			this.txtbOutput.Size = new System.Drawing.Size(305, 219);
			this.txtbOutput.TabIndex = 0;
			this.txtbOutput.Text = "";
			this.txtbOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtbOutput_LinkClicked);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.rdoBPremium);
			this.groupBox4.Controls.Add(this.rdoBCollector);
			this.groupBox4.Controls.Add(this.rdoBFree);
			this.groupBox4.Location = new System.Drawing.Point(2, 53);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(317, 58);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Account Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "* Username and Password Required!";
			// 
			// rdoBPremium
			// 
			this.rdoBPremium.AutoSize = true;
			this.rdoBPremium.Location = new System.Drawing.Point(216, 19);
			this.rdoBPremium.Name = "rdoBPremium";
			this.rdoBPremium.Size = new System.Drawing.Size(97, 17);
			this.rdoBPremium.TabIndex = 2;
			this.rdoBPremium.TabStop = true;
			this.rdoBPremium.Text = "Premium User *";
			this.rdoBPremium.UseVisualStyleBackColor = true;
			// 
			// rdoBCollector
			// 
			this.rdoBCollector.AutoSize = true;
			this.rdoBCollector.Location = new System.Drawing.Point(99, 19);
			this.rdoBCollector.Name = "rdoBCollector";
			this.rdoBCollector.Size = new System.Drawing.Size(98, 17);
			this.rdoBCollector.TabIndex = 1;
			this.rdoBCollector.TabStop = true;
			this.rdoBCollector.Text = "Collector User *";
			this.rdoBCollector.UseVisualStyleBackColor = true;
			// 
			// rdoBFree
			// 
			this.rdoBFree.AutoSize = true;
			this.rdoBFree.Location = new System.Drawing.Point(8, 19);
			this.rdoBFree.Name = "rdoBFree";
			this.rdoBFree.Size = new System.Drawing.Size(71, 17);
			this.rdoBFree.TabIndex = 0;
			this.rdoBFree.TabStop = true;
			this.rdoBFree.Text = "Free User";
			this.rdoBFree.UseVisualStyleBackColor = true;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(219, 406);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(100, 23);
			this.btnUpload.TabIndex = 5;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnDone
			// 
			this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDone.Location = new System.Drawing.Point(138, 406);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(75, 23);
			this.btnDone.TabIndex = 4;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = true;
			// 
			// RapidShare_Upload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 432);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RapidShare_Upload";
			this.Text = "Upload";
			this.Load += new System.EventHandler(this.RapidShare_Upload_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtbUsername;
		private System.Windows.Forms.TextBox txtbPwd;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtbVideo;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label lblVideo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rdoBPremium;
		private System.Windows.Forms.RadioButton rdoBCollector;
		private System.Windows.Forms.RadioButton rdoBFree;
		private System.Windows.Forms.Button btnUpload;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.RichTextBox txtbOutput;
		private System.Windows.Forms.Label label1;

	}
}