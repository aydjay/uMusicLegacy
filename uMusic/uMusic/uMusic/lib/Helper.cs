using System;
using System.Drawing;
using System.Windows.Forms;
using Splicer.Timeline;
using Splicer.WindowsMedia;
using Splicer.Renderer;
using Trails;

namespace uMusic.lib
{
	class Helper
	{
		public void OpenFile(TextBox boxToFill,string fileTypes,string cancelMessage, string errorMessage)
		{
			using (OpenFileDialog fd = new OpenFileDialog())
			{
				fd.Filter = fileTypes;
				fd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
				if (fd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						boxToFill.Text = fd.FileName;
					}
					catch (Exception ex)
					{
						MessageBox.Show(errorMessage + Environment.NewLine + "Exception thrown:" + ex.Message.ToString());
					}
				}
				else
				{
					MessageBox.Show(cancelMessage);
				}
			}
		}

		public string GetSaveName(string fileTypes, string cancelMessage, string errorMessage)
		{
			using (SaveFileDialog sfd = new SaveFileDialog())
			{
				sfd.Filter = "WMV Files|*.WMV";
				sfd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
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

		
		public void RenderImage(string imagePath, PictureBox boxToFill)
		{
			using (Image img = Image.FromFile(imagePath))
			{
				PreviewImage pre = new PreviewImage(boxToFill, img);
				pre.ProcessImage();
			}
		}

		public void CreateVideo(string videoToCreate, string imageLoc, string tuneLoc)
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

					IClip clip1 = videoTrack.AddImage(imageLoc, 0, DetermineSongLength(tuneLoc));

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

		public string YoutubeUploadVideo(string userName, string pwd, string videoToUpload, string title, string description, string tags)
		{
			string error = "";
			YouTube tube = new YouTube();
			MessageBox.Show("Authenticating!", "Upload", MessageBoxButtons.OK);
			if (tube.Authorize(userName, pwd))
			{
				MessageBox.Show("Attempting Upload!", "Upload", MessageBoxButtons.OK);
				tube.Upload(title, "Made using uMusic!" + Environment.NewLine + description, YouTube.Catagory.Music, tags, videoToUpload, out error);
				if (MessageBox.Show("Upload Successfully completed." + Environment.NewLine + Environment.NewLine + "Do you want to open \"My Videos\" on YouTube?", "Prompt", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start("www.youtube.com/my_videos");
				}
			}
			return error;
		}

		private double DetermineSongLength(string songToCheck)
		{
			MP3Header mp3 = new MP3Header();
			mp3.ReadMP3Information(songToCheck);
			return double.Parse(mp3.intLength.ToString());
		}

		public void TestForFileDropped(DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}
		}

		public void GetFilenameFromDroppedFile(DragEventArgs e, TextBox boxToFill)
		{
			string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			foreach (string File in FileList)
			{
				boxToFill.Text = File;
			}
		}
	}
}
