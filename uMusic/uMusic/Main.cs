using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using Splicer.Timeline;
using Splicer.Renderer;
using Splicer.WindowsMedia;


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
		#endregion
		#region Events

		private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		#endregion
		#region Buttons
		private void btnTuneBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "MP3 Files|*.mp3";
			fd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
			if (fd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					txtbTuneLoc.Text = fd.FileName;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error processing song File" + Environment.NewLine + "Please check that file is song image" + Environment.NewLine + "Exception thrown:" + ex.Message.ToString());
				}
			}
			else
			{
				MessageBox.Show("Must pick a song!");
			}
		}
		private void btnPicBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files|*.jpg";
            fd.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
					txtbPicLoc.Text = fd.FileName;
					RenderImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing Image File" + Environment.NewLine + "Please check that file is valid image" + Environment.NewLine + "Exception thrown:" + ex.Message.ToString());
                }
            }
		}


        private void btnCreateVid_Click(object sender, EventArgs e)
        {
			if (txtbPicLoc.Text.Equals(string.Empty) | txtbTuneLoc.Equals(String.Empty))
			{
				MessageBox.Show("You must choose and Picture and a Song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				CreateVideo(GetSaveName(), txtbPicLoc.Text, txtbTuneLoc.Text);
			}
		}

		#endregion
		#region Functions

		private void RenderImage()
		{
			using (Image img = Image.FromFile(txtbPicLoc.Text))
			{
				PreviewImage pre = new PreviewImage(picbPreview, img);
				pre.ProcessImage();
			}
		}

		private void CreateVideo(string videoToCreate, string imageLoc, string tuneLoc)
		{
			if (videoToCreate.Equals(""))
			{
				MessageBox.Show("Video file name not selected, unable to continue");
			}
			else
			{
				using (ITimeline timeline = new DefaultTimeline())
				{
					IGroup group = timeline.AddVideoGroup(32, 640, 480);
					ITrack videoTrack = group.AddTrack();

					IClip clip1 = videoTrack.AddImage(imageLoc, 0, DetermineSongLength());

					// add some audio
					ITrack audioTrack = timeline.AddAudioGroup().AddTrack();
					IClip audio = audioTrack.AddAudio(tuneLoc, 0, videoTrack.Duration);

					// create an audio envelope effect, this will:
					// fade the audio from 0% to 100% in 1 second.
					// play at full volume until 1 second before the end of the track
					// fade back out to 0% volume
					audioTrack.AddEffect(0, audio.Duration, StandardEffects.CreateAudioEnvelope(1.0, 1.0, 1.0, audio.Duration));

					// render our slideshow out to a windows media file
					using (WindowsMediaRenderer renderer = new WindowsMediaRenderer(timeline, videoToCreate, WindowsMediaProfiles.HighQualityVideo))
					//using (AviFileRenderer renderer= new AviFileRenderer(timeline,videoToCreate))
					{
						renderer.Render();
					}
				}
			}
		}

		private double DetermineSongLength()
		{
			MP3Header mp3 = new MP3Header();
			mp3.ReadMP3Information(txtbTuneLoc.Text);
			return double.Parse(mp3.intLength.ToString());
		}

		public string GetSaveName()
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "WMV Files|*.WMV";
				sfd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					return sfd.FileName;
				}
				else
				{
					return "";
				}
			}
		}

		#endregion

		private void btnUpload_Click(object sender, EventArgs e)
		{
			Upload up = new Upload();
			if (up.ShowDialog() == DialogResult.OK)
			{

			}
		}

		public string GetOpenName()
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "WMV Files|*.WMV|AVI Files|*.avi|All Files|*.*";
				ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					return ofd.FileName;
				}
				else
				{
					return "";
				}
			}
		}

		private void lnklDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=deathman102%40gmail%2ecom&lc=GB&item_name=uMusic&currency_code=GBP&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted");
		}





		
		

		
    }
}
