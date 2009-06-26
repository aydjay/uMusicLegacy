using System;
using System.ComponentModel;
using System.Windows.Forms;
using uMusic.lib;
using System.Collections.Generic;
using System.IO;

namespace uMusic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
		}
		#region Member Variables
		
		private string m_EncodeSaveName = string.Empty;
		private string m_Tune = string.Empty;
		private List<string> m_Pics = new List<string>();		
		/// <summary>
		/// m_Helper is the global instance of the helper class.
		/// </summary>
		private Helper m_Helper = new Helper();
		#endregion
		#region Events
		private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
		}
		#endregion
		#region Buttons
		private void btnTuneBrowse_Click(object sender, EventArgs e)
		{
			m_Tune = m_Helper.OpenFile("MP3 Files|*.mp3",
												"Must select a song!", 
												"There has been a problem opening the song!");
			txtbTuneLoc.Text = m_Tune;
		}

		private void btnPicBrowse_Click(object sender, EventArgs e)
		{
			
			m_Helper.ClearPicFilesPaths(lstbPicLoc,m_Pics);

			m_Pics = m_Helper.OpenFiles("JPG Files|*.jpg",
				"Must select a picture(s)!",
				"There has been a problem opening the picture!");
			
			//Read all of the JPG Files into the Picture List Box
			foreach (string pic in m_Pics)
			{
				lstbPicLoc.Items.Add(pic);
			}
			
			m_Helper.RenderImage(picbPreview, lstbPicLoc.Items[0].ToString());
		}

		/// <summary>
		/// Handler for the Clear Click, will clear out the listbox and the member variable
		/// </summary>
		/// <param name="sender">Object Sender</param>
		/// <param name="e">Event Arguments</param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			if (bgwRenderer.IsBusy)
			{
				bgwRenderer.CancelAsync();
			}
			m_Helper.ClearPicFilesPaths(lstbPicLoc, m_Pics);
		}

		/// <summary>
		/// Handler for the Preview click
		/// </summary>
		/// <param name="sender">Object Sender</param>
		/// <param name="e">Envent Arguments</param>
		public void btnPreview_Click(object sender, EventArgs e)
		{
			btnPreview.Enabled = false;
			btnPreview.Text = "Wait...";
			if (bgwRenderer.IsBusy)
			{
				bgwRenderer.CancelAsync();
				if (bgwRenderer.CancellationPending)
				{
					System.Threading.Thread.Sleep(1000);
					bgwRenderer.RunWorkerAsync();
				}
				else
				{
					bgwRenderer.RunWorkerAsync();
				}
			}
			else
			{
				bgwRenderer.RunWorkerAsync();
			}
		}

        private void btnCreateVid_Click(object sender, EventArgs e)
        {
			if (lstbPicLoc.Items.Count==0| txtbTuneLoc.Equals(String.Empty))
			{
				MessageBox.Show("You must choose and Picture and a Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if (lstbPicLoc.Items.Count == 1)
				{
					m_Helper.PrepareGUI4Encoding(btnCreateVid,ref m_EncodeSaveName);
					bgwEncoder.RunWorkerAsync();
				}
				else
				{
					m_Helper.PrepareGUI4Encoding(btnCreateVid,ref m_EncodeSaveName);
					bgwSlideShowEncoder.RunWorkerAsync();
				}
			}
		}

		

		private void btnUpload_Click(object sender, EventArgs e)
		{
			cmbUploadChoice.Show(Cursor.Position);
		}

		private void lnklDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=deathman102%40gmail%2ecom&lc=GB&item_name=uMusic&currency_code=GBP&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted");
		}
		#endregion
		#region Context Menu Entries
		private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Upload up = new Upload();
			if (up.ShowDialog() == DialogResult.OK) { }
		}

		private void rapidshareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RapidShare_Upload rapidForm = new RapidShare_Upload();
			if (rapidForm.ShowDialog() == DialogResult.OK) { }
		}
		#endregion
		#region Threading

		private void bgwEncoder_DoWork(object sender, DoWorkEventArgs e)
		{
			m_Helper.CreateVideo(m_EncodeSaveName, m_Pics[0].ToString(), m_Tune);
		}

		private void bgwEncoder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnCreateVid.Text = "Create Video";
			btnCreateVid.Enabled = true;
			MessageBox.Show("Finished encoding!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void bgwSlideShowEncoder_DoWork(object sender, DoWorkEventArgs e)
		{
			m_Helper.CreateSlideShow(m_EncodeSaveName, m_Pics, txtbTuneLoc.Text);
		}

		private void bgwSlideShowEncoder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnCreateVid.Text = "Create Video";
			btnCreateVid.Enabled = true;
			MessageBox.Show("Finished encoding!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void bgwRenderer_DoWork(object sender, DoWorkEventArgs e)
		{
			m_Helper.RenderListOfImages(picbPreview,m_Pics);
		}

		private void bgwRenderer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnPreview.Text = "Preview";
			btnPreview.Enabled = true;
			m_Helper.RenderImage(picbPreview, lstbPicLoc.Items[0].ToString());
		}

		#endregion
		#region DragDrops
		private void txtbTuneLoc_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}

		private void txtbTuneLoc_DragDrop(object sender, DragEventArgs e)
		{
			m_Tune = "";
			m_Tune = m_Helper.GetFilenameFromDroppedFile(e);
			txtbTuneLoc.Text = m_Tune;
		}

		private void lstbPicLoc_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}
		/// <summary>
		/// Handler for the Drop Event for the List Box of pictures
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lstbPicLoc_DragDrop(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				m_Helper.ClearPicFilesPaths(lstbPicLoc, m_Pics);

				string[] tmpArr = (string[])e.Data.GetData(DataFormats.FileDrop, false);
				foreach (string pic in tmpArr)
				{
					m_Pics.Add(pic);
					lstbPicLoc.Items.Add(pic);
				}

				m_Helper.RenderImage(picbPreview, lstbPicLoc.Items[0].ToString());
			}			
		}

		/// <summary>
		/// Handler fot the DragOver Event for the ListBox for the pictures
		/// </summary>
		/// <param name="sender">Object Sender</param>
		/// <param name="e">DragEvent Arguments</param>
		private void lstbPicLoc_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}
		#endregion
		
		
	}
}
