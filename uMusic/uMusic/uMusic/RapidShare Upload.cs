using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uMusic.lib;

namespace uMusic
{
	public partial class RapidShare_Upload : Form
	{
		public RapidShare_Upload()
		{
			InitializeComponent();
		}
		#region Member Variables
		private Helper m_Helper = new Helper();
		#endregion
		#region Events

		private void RapidShare_Upload_Load(object sender, EventArgs e)
		{
			rdoBFree.Checked = true;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
		}

		private void txtbOutput_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		#endregion
		#region Buttons

		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (txtbVideo.Text == "") 
			{
				m_Helper.OpenFile(txtbVideo, "All Files|*.*",
					"Need to select a file to upload!", 
					"An error occured with the file that you selected!");
			}
			btnUpload.Enabled = false;
			btnUpload.Text = "Uploading...";
			backgroundWorker1.RunWorkerAsync();
		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			m_Helper.OpenFile(txtbVideo, "All Files|*.*", "Need to select a file to upload!", "An error occured with the file that you selected!");
		}
		#endregion
		#region Threading
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Rapidshare Rapid = new Rapidshare();
			int type = 0;//Free User
			if (rdoBPremium.Checked)
			{
				type = 1;//Premium User
			}
			else if (rdoBCollector.Checked)
			{
				type = 2;//Collector User
			}

			string result = Rapid.UploadToRapidshare(txtbVideo.Text, txtbUsername.Text, txtbPwd.Text, type);
			if (result.StartsWith("<!")) result = "Login failed!";
			e.Result = result;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			txtbOutput.Text = e.Result.ToString();
			btnUpload.Enabled = true;
			btnUpload.Text = "Upload";
		}

		#endregion
		#region Drag Drops
		private void txtbVideo_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}

		private void txtbVideo_DragDrop(object sender, DragEventArgs e)
		{
			m_Helper.GetFilenameFromDroppedFile(e, txtbVideo);
		}
		#endregion
	}
}
