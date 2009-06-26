using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace uMusic
{
    public class PreviewImage
    {
        private PictureBox m_boxToFill;
        private Image m_ImageToOpen;

        public PreviewImage(PictureBox boxToFill, Image imageToOpen)
        {
            m_boxToFill = boxToFill;
            m_ImageToOpen = imageToOpen;
        }

        public void ProcessImage()
        {
            Rectangle newRect = GetScaledRectangle(m_ImageToOpen, m_boxToFill.ClientRectangle);
            m_boxToFill.Image = GetResizedImage(m_ImageToOpen, newRect);
        }

        private static Rectangle GetScaledRectangle(Image imageToOpen, Rectangle thumbRect)
        {
            if (imageToOpen.Width < thumbRect.Width && imageToOpen.Height < thumbRect.Height)
                return new Rectangle(thumbRect.X + ((thumbRect.Width - imageToOpen.Width) / 2), thumbRect.Y + ((thumbRect.Height - imageToOpen.Height) / 2), imageToOpen.Width, imageToOpen.Height);

            int sourceWidth = imageToOpen.Width;
            int sourceHeight = imageToOpen.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)thumbRect.Width / (float)sourceWidth);
            nPercentH = ((float)thumbRect.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            if (destWidth.Equals(0))
                destWidth = 1;
            if (destHeight.Equals(0))
                destHeight = 1;

            Rectangle retRect = new Rectangle(thumbRect.X, thumbRect.Y, destWidth, destHeight);

            if (retRect.Height < thumbRect.Height)
                retRect.Y = retRect.Y + Convert.ToInt32(((float)thumbRect.Height - (float)retRect.Height) / (float)2);

            if (retRect.Width < thumbRect.Width)
                retRect.X = retRect.X + Convert.ToInt32(((float)thumbRect.Width - (float)retRect.Width) / (float)2);

            return retRect;
        }

        private static Image GetResizedImage(Image imageToOpen, Rectangle rect)
        {
            Bitmap b = new Bitmap(rect.Width, rect.Height);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imageToOpen, 0, 0, rect.Width, rect.Height);
            g.Dispose();

            try
            {
                return (Image)b.Clone();
            }
            finally
            {
                b.Dispose();
                b = null;
                g = null;
            }
        }
    }
}
