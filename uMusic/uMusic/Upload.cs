using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Trails;



namespace uMusic
{
	public partial class Upload : Form
	{
		public Upload()
		{
			InitializeComponent();
		}

		private void Upload_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		private void btnUploadStart_Click(object sender, EventArgs e)
		{
			try
			{				
					UploadVideo();	
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message.ToString());
			}
			
		}
		private void UploadVideo()
		{
			string error = "";
			YouTube tube = new YouTube();
			MessageBox.Show("Authenticating!", "Upload", MessageBoxButtons.OK);
			if (tube.Authorize(txtbUsername.Text, txtbPwd.Text))
			{
				MessageBox.Show("Attempting Upload!", "Upload", MessageBoxButtons.OK);
				tube.Upload(txtbTitle.Text, "Made using uMusic!" +Environment.NewLine + txtbDescription.Text , YouTube.Catagory.Music, txtbTags.Text, txtbVideo.Text, out error);
				if (MessageBox.Show("Upload Successfully completed." + Environment.NewLine + Environment.NewLine + "Do you want to open \"My Videos\" on YouTube?", "Prompt", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start("www.youtube.com/my_videos");
				}
			}
		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			Main main = new Main();
			txtbVideo.Text = main.GetOpenName();
		}

		private void lblTags_Click(object sender, EventArgs e)
		{

		}
	}
}
