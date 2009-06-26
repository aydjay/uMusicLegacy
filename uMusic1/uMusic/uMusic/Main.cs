using System;
using System.ComponentModel;
using System.Windows.Forms;
using uMusic.lib;

namespace uMusic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
		}
		#region Member Variables
		private string m_TuneLength = string.Empty;
		private string m_EncodeSaveName = string.Empty;
		/// <summary>
		/// m_Helper is the instance of the helper class.
		/// <para>
		/// </para>
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
			m_Helper.OpenFile(txtbPicLoc, "MP3 Files|*.mp3", "Must select a song!", "There has been a problem opening the song!");
		}

		private void btnPicBrowse_Click(object sender, EventArgs e)
		{
			m_Helper.OpenFile(txtbPicLoc, "JPG Files|*.jpg", "Must select a song!", "There has been a problem opening the song!");
			m_Helper.RenderImage(txtbPicLoc.Text, picbPreview);
		}

        private void btnCreateVid_Click(object sender, EventArgs e)
        {
			if (txtbPicLoc.Text.Equals(string.Empty) | txtbTuneLoc.Equals(String.Empty))
			{
				MessageBox.Show("You must choose and Picture and a Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				btnCreateVid.Text = "Encoding...";
				btnCreateVid.Enabled = false;
				m_EncodeSaveName = m_Helper.GetSaveName("WMV Files|*.wmv", "Must select a file name to save too!", "There has been a problem saving the file");
				backgroundWorker1.RunWorkerAsync();
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
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			m_Helper.CreateVideo(m_EncodeSaveName, txtbPicLoc.Text, txtbTuneLoc.Text);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnCreateVid.Text = "Create Video";
			btnCreateVid.Enabled = true;
			MessageBox.Show("Finished encoding!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
		#region DragDrops
		private void txtbTuneLoc_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}

		private void txtbTuneLoc_DragDrop(object sender, DragEventArgs e)
		{
			m_Helper.GetFilenameFromDroppedFile(e, txtbTuneLoc);
		}

		private void txtbPicLoc_DragEnter(object sender, DragEventArgs e)
		{
			m_Helper.TestForFileDropped(e);
		}

		private void txtbPicLoc_DragDrop(object sender, DragEventArgs e)
		{
			m_Helper.GetFilenameFromDroppedFile(e, txtbPicLoc);
			m_Helper.RenderImage(txtbPicLoc.Text, picbPreview);
		}
		#endregion
		
	}
}
