using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte AjustBrightness(int iIn, int iChange)
        {
            int iOut = iIn + iChange;
            if (iOut < 0) iOut = 0;
            if (iOut > 255) iOut = 255;
            return (byte)iOut;
        }

        private byte AjustContrast(int iIn, double fContrast)
        {
            double pixel = iIn / 255.0;
            pixel -= 0.5;
            pixel *= fContrast;
            pixel += 0.5;
            pixel *= 255;
            if (pixel < 0) pixel = 0;
            if (pixel > 255) pixel = 255;
            return (byte)pixel;
        }

        private void Brightness(Bitmap pBitmap, int iBrightness)
        {
            BitmapData pBitmapData = pBitmap.LockBits(
                new Rectangle(0, 0, pBitmap.Width, pBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            byte[] pData = new byte[pBitmapData.Stride * pBitmapData.Height];
            Marshal.Copy(pBitmapData.Scan0, pData, 0, pData.Length);

            int iOffset = pBitmapData.Stride - pBitmapData.Width * 3;
            int iIndex = 0;
            for (int i = 0; i < pBitmapData.Height; i++)
            {
                for (int j = 0; j < pBitmapData.Width; j++)
                {
                    for (int k = iIndex; k < iIndex + 3; k++)
                    {
                        pData[k] = AjustBrightness(pData[k], iBrightness);
                    }
                    iIndex += 3;
                }
                iIndex += iOffset;
            }

            Marshal.Copy(pData, 0, pBitmapData.Scan0, pData.Length);
            pBitmap.UnlockBits(pBitmapData);
        }

        public void Contrast(Bitmap pBitmap, int iContrast)
        {
            double contrast = Math.Pow((100.0 + iContrast) / 100.0, 2);

            BitmapData pBitmapData = pBitmap.LockBits(
                new Rectangle(0, 0, pBitmap.Width, pBitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            byte[] pData = new byte[pBitmapData.Stride * pBitmapData.Height];
            Marshal.Copy(pBitmapData.Scan0, pData, 0, pData.Length);

            int iOffset = pBitmapData.Stride - pBitmapData.Width * 3;
            int iIndex = 0;
            for (int i = 0; i < pBitmapData.Height; i++)
            {
                for (int j = 0; j < pBitmapData.Width; j++)
                {
                    for (int k = iIndex; k < iIndex + 3; k++)
                    {
                        pData[k] = AjustContrast(pData[k], contrast);
                    }
                    iIndex += 3;
                }
                iIndex += iOffset;
            }

            Marshal.Copy(pData, 0, pBitmapData.Scan0, pData.Length);
            pBitmap.UnlockBits(pBitmapData);
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            TrackBarBrightness1.Value = 0;
            TrackBarContrast1.Value = 1250;

            TrackBarBrightness2.Value = 0;
            TrackBarContrast2.Value = 0;

            TrackBarBrightness3.Value = 0;
            TrackBarContrast3.Value = 20;
            TrackBarSaturation3.Value = 20;
            TrackBarHue3.Value = 0;
            TrackBarGamma3.Value = 20;

            TrackBarBrightness4.Value = 0;
            TrackBarContrast4.Value = 0;

            pictureBox1.Image = global::WindowsFormsApplication14.Properties.Resources.untitled;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            DateTime pDateTimeStart = DateTime.Now;

            Bitmap pSource = global::WindowsFormsApplication14.Properties.Resources.untitled; 

            AForgeFilter pFilterBrightness = new AForgeFilter();
            pFilterBrightness.AdjustValue = (double)TrackBarBrightness1.Value / 1000;
            Bitmap pBitmapBrightness = checkBoxSafe.Checked ? pFilterBrightness.ApplySafe(pSource) : pFilterBrightness.Apply(pSource);
            AForgeFilter pFilterContrast = new AForgeFilter();
            pFilterContrast.Factor = (double)TrackBarContrast1.Value / 1000;
            Bitmap pBitmapContrast = checkBoxSafe.Checked ? pFilterContrast.ApplySafe(pBitmapBrightness) : pFilterContrast.Apply(pBitmapBrightness);

            pictureBox1.Image = pBitmapContrast;

            TimeSpan pSpan = DateTime.Now - pDateTimeStart;
            textBoxTime1.Text = ((int)pSpan.TotalMilliseconds).ToString();
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            DateTime pDateTimeStart = DateTime.Now;

            Bitmap pSource = global::WindowsFormsApplication14.Properties.Resources.untitled;
            Bitmap pBitmap = pSource.Clone(new Rectangle(0, 0, pSource.Width, pSource.Height), pSource.PixelFormat);

            new BrightnessContrast().Adjust(pBitmap, TrackBarBrightness2.Value, TrackBarContrast2.Value);
            //new Brightness().Adjust(pBitmap, TrackBarBrightness2.Value);
            //new Contrast().Adjust(pBitmap, TrackBarContrast2.Value);

            pictureBox1.Image = pBitmap;

            TimeSpan pSpan = DateTime.Now - pDateTimeStart;
            textBoxTime2.Text = ((int)pSpan.TotalMilliseconds).ToString();
        }

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            DateTime pDateTimeStart = DateTime.Now;

            QColorMatrix pQColorMatrix = new QColorMatrix();
            pQColorMatrix.ScaleColors(TrackBarContrast3.Value * 0.05f, QColorMatrix.MatrixOrder.MatrixOrderPrepend);
            pQColorMatrix.TranslateColors(TrackBarBrightness3.Value * 0.05f, QColorMatrix.MatrixOrder.MatrixOrderAppend);
            pQColorMatrix.SetSaturation(TrackBarSaturation3.Value * 0.05f, QColorMatrix.MatrixOrder.MatrixOrderAppend);
            pQColorMatrix.RotateHue(TrackBarHue3.Value * 4.0f);

            Bitmap pSource = global::WindowsFormsApplication14.Properties.Resources.untitled;
            pictureBox1.Image = pQColorMatrix.Adjust(pSource, TrackBarGamma3.Value * 0.05f);

            TimeSpan pSpan = DateTime.Now - pDateTimeStart;
            textBoxTime3.Text = ((int)pSpan.TotalMilliseconds).ToString();
        }

        private void TrackBar4_ValueChanged(object sender, EventArgs e)
        {
            DateTime pDateTimeStart = DateTime.Now;

            Bitmap pSource = global::WindowsFormsApplication14.Properties.Resources.untitled;
            Bitmap pBitmap = pSource.Clone(new Rectangle(0, 0, pSource.Width, pSource.Height), pSource.PixelFormat);

            //new BrightnessSlow().Adjust(pBitmap, TrackBarBrightness4.Value);
            //new ContrastSlow().Adjust(pBitmap, (sbyte)TrackBarContrast4.Value);
            new BrightnessContrastSlow().Adjust(pBitmap, TrackBarBrightness4.Value, TrackBarContrast4.Value);

            pictureBox1.Image = pBitmap;

            TimeSpan pSpan = DateTime.Now - pDateTimeStart;
            textBoxTime4.Text = ((int)pSpan.TotalMilliseconds).ToString();
        }
    }
}
