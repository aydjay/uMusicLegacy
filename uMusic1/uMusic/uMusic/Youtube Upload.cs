using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using uMusic.lib;



namespace uMusic
{
	public partial class Upload : Form
	{
		public Upload()
		{
			InitializeComponent();
		}

		private string m_ErrorStore = string.Empty;

		private void Upload_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
		}

		#region Member Variables
		private Helper m_Helper = new Helper();
		#endregion


		#region Buttons
		private void btnUploadStart_Click(object sender, EventArgs e)
		{
			try
			{
				btnUploadStart.Text = "Uploading...";
				btnUploadStart.Enabled = false;
				backgroundWorker1.RunWorkerAsync();	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			Helper help = new Helper();
			help.OpenFile(txtbVideo, "WMV Files|*.wmv|AVI Files|*.avi|MPG Files|*.mpg", "Must select a video file to upload!", "Error occured while opening the video file!");
		}
		#endregion
		

		#region Threading
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			m_ErrorStore = m_Helper.YoutubeUploadVideo(txtbUsername.Text, txtbPwd.Text, txtbVideo.Text, txtbTitle.Text, txtbDescription.Text,txtbTags.Text);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			txtbOutput.Text = m_ErrorStore;
			btnUploadStart.Text = "Upload";
			btnUploadStart.Enabled = true;
		}
		#endregion
		#region Drag and Drop
		private void txtbVideo_DragDrop(object sender, DragEventArgs e)
		{
			m_Helper.GetFilenameFromDroppedFile(e, txtbVideo);
		}

		private void txtbVideo_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}
		#endregion
	}
}
