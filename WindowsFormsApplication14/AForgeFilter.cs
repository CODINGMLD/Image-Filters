using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication14
{
    public class YCbCr
    {
        // Fields
        public double Cb;
        public const short CbIndex = 1;
        public double Cr;
        public const short CrIndex = 2;
        public double Y;
        public const short YIndex = 0;

        // Methods
        public YCbCr()
        {
        }

        public YCbCr(double y, double cb, double cr)
        {
            this.Y = Math.Max(0.0, Math.Min(1.0, y));
            this.Cb = Math.Max(-0.5, Math.Min(0.5, cb));
            this.Cr = Math.Max(-0.5, Math.Min(0.5, cr));
        }
    }

    public class ColorConverter
    {
        // Methods
        private ColorConverter()
        {
        }

        public static void HSL2RGB(HSL hsl, RGB rgb)
        {
            if (hsl.Saturation == 0.0)
            {
                rgb.Red = rgb.Green = rgb.Blue = (byte)(hsl.Luminance * 255.0);
            }
            else
            {
                double vH = ((double)hsl.Hue) / 360.0;
                double num2 = (hsl.Luminance < 0.5) ? (hsl.Luminance * (1.0 + hsl.Saturation)) : ((hsl.Luminance + hsl.Saturation) - (hsl.Luminance * hsl.Saturation));
                double num = (2.0 * hsl.Luminance) - num2;
                rgb.Red = (byte)(255.0 * Hue_2_RGB(num, num2, vH + 0.33333333333333331));
                rgb.Green = (byte)(255.0 * Hue_2_RGB(num, num2, vH));
                rgb.Blue = (byte)(255.0 * Hue_2_RGB(num, num2, vH - 0.33333333333333331));
            }
        }

        private static double Hue_2_RGB(double v1, double v2, double vH)
        {
            if (vH < 0.0)
            {
                vH++;
            }
            if (vH > 1.0)
            {
                vH--;
            }
            if ((6.0 * vH) < 1.0)
            {
                return (v1 + (((v2 - v1) * 6.0) * vH));
            }
            if ((2.0 * vH) < 1.0)
            {
                return v2;
            }
            if ((3.0 * vH) < 2.0)
            {
                return (v1 + (((v2 - v1) * (0.66666666666666663 - vH)) * 6.0));
            }
            return v1;
        }

        public static void RGB2HSL(RGB rgb, HSL hsl)
        {
            double num = ((double)rgb.Red) / 255.0;
            double num2 = ((double)rgb.Green) / 255.0;
            double num3 = ((double)rgb.Blue) / 255.0;
            double num4 = Math.Min(Math.Min(num, num2), num3);
            double num5 = Math.Max(Math.Max(num, num2), num3);
            double num6 = num5 - num4;
            hsl.Luminance = (num5 + num4) / 2.0;
            if (num6 == 0.0)
            {
                hsl.Hue = 0;
                hsl.Saturation = 0.0;
            }
            else
            {
                double num10;
                hsl.Saturation = (hsl.Luminance < 0.5) ? (num6 / (num5 + num4)) : (num6 / ((2.0 - num5) - num4));
                double num7 = (((num5 - num) / 6.0) + (num6 / 2.0)) / num6;
                double num8 = (((num5 - num2) / 6.0) + (num6 / 2.0)) / num6;
                double num9 = (((num5 - num3) / 6.0) + (num6 / 2.0)) / num6;
                if (num == num5)
                {
                    num10 = num9 - num8;
                }
                else if (num2 == num5)
                {
                    num10 = (0.33333333333333331 + num7) - num9;
                }
                else
                {
                    num10 = (0.66666666666666663 + num8) - num7;
                }
                if (num10 < 0.0)
                {
                    num10++;
                }
                if (num10 > 1.0)
                {
                    num10--;
                }
                hsl.Hue = (int)(num10 * 360.0);
            }
        }

        public static void RGB2YCbCr(RGB rgb, YCbCr ycbcr)
        {
            double num = ((double)rgb.Red) / 255.0;
            double num2 = ((double)rgb.Green) / 255.0;
            double num3 = ((double)rgb.Blue) / 255.0;
            ycbcr.Y = ((0.2989 * num) + (0.5866 * num2)) + (0.1145 * num3);
            ycbcr.Cb = ((-0.1687 * num) - (0.3313 * num2)) + (0.5 * num3);
            ycbcr.Cr = ((0.5 * num) - (0.4184 * num2)) - (0.0816 * num3);
        }

        public static void YCbCr2RGB(YCbCr ycbcr, RGB rgb)
        {
            double num = Math.Max(0.0, Math.Min((double)1.0, (double)((ycbcr.Y + (0.0 * ycbcr.Cb)) + (1.4022 * ycbcr.Cr))));
            double num2 = Math.Max(0.0, Math.Min((double)1.0, (double)((ycbcr.Y - (0.3456 * ycbcr.Cb)) - (0.7145 * ycbcr.Cr))));
            double num3 = Math.Max(0.0, Math.Min((double)1.0, (double)((ycbcr.Y + (1.771 * ycbcr.Cb)) + (0.0 * ycbcr.Cr))));
            rgb.Red = (byte)(num * 255.0);
            rgb.Green = (byte)(num2 * 255.0);
            rgb.Blue = (byte)(num3 * 255.0);
        }
    }

    public class DoubleRange
    {
        private double max;
        private double min;

        public DoubleRange(double min, double max)
        {
            this.min = min;
            this.max = max;
        }

        public bool IsInside(DoubleRange range)
        {
            return (this.IsInside(range.min) && this.IsInside(range.max));
        }

        public bool IsInside(double x)
        {
            return ((x >= this.min) && (x <= this.max));
        }

        public bool IsOverlapping(DoubleRange range)
        {
            if (!this.IsInside(range.min))
            {
                return this.IsInside(range.max);
            }
            return true;
        }

        public double Length
        {
            get
            {
                return (this.max - this.min);
            }
        }

        public double Max
        {
            get
            {
                return this.max;
            }
            set
            {
                this.max = value;
            }
        }

        public double Min
        {
            get
            {
                return this.min;
            }
            set
            {
                this.min = value;
            }
        }
    }

    public class RGB
    {
        public byte Blue;
        public byte Green;
        public byte Red;

        public RGB()
        {
        }

        public RGB(Color color)
        {
            this.Red = color.R;
            this.Green = color.G;
            this.Blue = color.B;
        }

        public RGB(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(this.Red, this.Green, this.Blue);
            }
            set
            {
                this.Red = value.R;
                this.Green = value.G;
                this.Blue = value.B;
            }
        }
    }

    public class HSL
    {
        // Fields
        public int Hue;
        public double Luminance;
        public double Saturation;

        // Methods
        public HSL()
        {
        }

        public HSL(int hue, double saturation, double luminance)
        {
            this.Hue = hue;
            this.Saturation = saturation;
            this.Luminance = luminance;
        }
    }

    public class AForgeFilter
    {
        [DllImport("ntdll.dll")]
        public static extern IntPtr memcpy(IntPtr dst, IntPtr src, int count);

        // Fields
        private DoubleRange inLuminance = new DoubleRange(0.0, 1.0);
        private DoubleRange inSaturation = new DoubleRange(0.0, 1.0);
        private DoubleRange outLuminance = new DoubleRange(0.0, 1.0);
        private DoubleRange outSaturation = new DoubleRange(0.0, 1.0);

        // Methods
        protected unsafe void ProcessFilter(BitmapData imageData)
        {
            int width = imageData.Width;
            int height = imageData.Height;
            int num3 = imageData.Stride - (width * 3);
            RGB rgb = new RGB();
            HSL hsl = new HSL();
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            if (this.inLuminance.Max != this.inLuminance.Min)
            {
                num4 = (this.outLuminance.Max - this.outLuminance.Min) / (this.inLuminance.Max - this.inLuminance.Min);
                num5 = this.outLuminance.Min - (num4 * this.inLuminance.Min);
            }
            if (this.inSaturation.Max != this.inSaturation.Min)
            {
                num6 = (this.outSaturation.Max - this.outSaturation.Min) / (this.inSaturation.Max - this.inSaturation.Min);
                num7 = this.outSaturation.Min - (num6 * this.inSaturation.Min);
            }
            byte* numPtr = (byte*)imageData.Scan0.ToPointer();
            for (int i = 0; i < height; i++)
            {
                int num9 = 0;
                while (num9 < width)
                {
                    rgb.Red = numPtr[2];
                    rgb.Green = numPtr[1];
                    rgb.Blue = numPtr[0];
                    ColorConverter.RGB2HSL(rgb, hsl);
                    if (hsl.Luminance >= this.inLuminance.Max)
                    {
                        hsl.Luminance = this.outLuminance.Max;
                    }
                    else if (hsl.Luminance <= this.inLuminance.Min)
                    {
                        hsl.Luminance = this.outLuminance.Min;
                    }
                    else
                    {
                        hsl.Luminance = (num4 * hsl.Luminance) + num5;
                    }
                    if (hsl.Saturation >= this.inSaturation.Max)
                    {
                        hsl.Saturation = this.outSaturation.Max;
                    }
                    else if (hsl.Saturation <= this.inSaturation.Min)
                    {
                        hsl.Saturation = this.outSaturation.Min;
                    }
                    else
                    {
                        hsl.Saturation = (num6 * hsl.Saturation) + num7;
                    }
                    ColorConverter.HSL2RGB(hsl, rgb);
                    numPtr[2] = rgb.Red;
                    numPtr[1] = rgb.Green;
                    numPtr[0] = rgb.Blue;
                    num9++;
                    numPtr += 3;
                }
                numPtr += num3;
            }
        }

        // Methods
        protected void ProcessFilterSafe(BitmapData imageData)
        {
            int width = imageData.Width;
            int height = imageData.Height;
            int num3 = imageData.Stride - (width * 3);
            RGB rgb = new RGB();
            HSL hsl = new HSL();
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            double num7 = 0.0;
            if (this.inLuminance.Max != this.inLuminance.Min)
            {
                num4 = (this.outLuminance.Max - this.outLuminance.Min) / (this.inLuminance.Max - this.inLuminance.Min);
                num5 = this.outLuminance.Min - (num4 * this.inLuminance.Min);
            }
            if (this.inSaturation.Max != this.inSaturation.Min)
            {
                num6 = (this.outSaturation.Max - this.outSaturation.Min) / (this.inSaturation.Max - this.inSaturation.Min);
                num7 = this.outSaturation.Min - (num6 * this.inSaturation.Min);
            }

            byte[] pData = new byte[imageData.Stride * imageData.Height];
            Marshal.Copy(imageData.Scan0, pData, 0, pData.Length);

            int iOffset = imageData.Stride - imageData.Width * 3;
            int iIndex = 0;
            for (int i = 0; i < imageData.Height; i++)
            {
                for (int j = 0; j < imageData.Width; j++)
                {
                    rgb.Red = pData[iIndex + 2];
                    rgb.Green = pData[iIndex + 1];
                    rgb.Blue = pData[iIndex + 0];
                    ColorConverter.RGB2HSL(rgb, hsl);
                    if (hsl.Luminance >= this.inLuminance.Max)
                    {
                        hsl.Luminance = this.outLuminance.Max;
                    }
                    else if (hsl.Luminance <= this.inLuminance.Min)
                    {
                        hsl.Luminance = this.outLuminance.Min;
                    }
                    else
                    {
                        hsl.Luminance = (num4 * hsl.Luminance) + num5;
                    }
                    if (hsl.Saturation >= this.inSaturation.Max)
                    {
                        hsl.Saturation = this.outSaturation.Max;
                    }
                    else if (hsl.Saturation <= this.inSaturation.Min)
                    {
                        hsl.Saturation = this.outSaturation.Min;
                    }
                    else
                    {
                        hsl.Saturation = (num6 * hsl.Saturation) + num7;
                    }
                    ColorConverter.HSL2RGB(hsl, rgb);
                    pData[iIndex + 2] = rgb.Red;
                    pData[iIndex + 1] = rgb.Green;
                    pData[iIndex + 0] = rgb.Blue;
                    iIndex += 3;
                }
                iIndex += iOffset;
            }

            Marshal.Copy(pData, 0, imageData.Scan0, pData.Length);
        }

        // Properties
        public DoubleRange InLuminance
        {
            get
            {
                return this.inLuminance;
            }
            set
            {
                this.inLuminance = value;
            }
        }

        public DoubleRange InSaturation
        {
            get
            {
                return this.inSaturation;
            }
            set
            {
                this.inSaturation = value;
            }
        }

        public DoubleRange OutLuminance
        {
            get
            {
                return this.outLuminance;
            }
            set
            {
                this.outLuminance = value;
            }
        }

        public DoubleRange OutSaturation
        {
            get
            {
                return this.outSaturation;
            }
            set
            {
                this.outSaturation = value;
            }
        }

        private double adjustValue = 0.1;
        public double AdjustValue
        {
            get
            {
                return this.adjustValue;
            }
            set
            {
                this.adjustValue = Math.Max(-1.0, Math.Min(1.0, value));
                if (this.adjustValue > 0.0)
                {
                    InLuminance = new DoubleRange(0.0, 1.0 - this.adjustValue);
                    OutLuminance = new DoubleRange(this.adjustValue, 1.0);
                }
                else
                {
                    InLuminance = new DoubleRange(-this.adjustValue, 1.0);
                    OutLuminance = new DoubleRange(0.0, 1.0 + this.adjustValue);
                }
            }
        }

        private double factor = 1.25;
        public double Factor
        {
            get
            {
                return this.factor;
            }
            set
            {
                this.factor = Math.Max(1E-06, value);
                InLuminance = new DoubleRange(0.0, 1.0);
                OutLuminance = new DoubleRange(0.0, 1.0);
                if (this.factor > 1.0)
                {
                    InLuminance = new DoubleRange(0.5 - (0.5 / this.factor), 0.5 + (0.5 / this.factor));
                }
                else
                {
                    OutLuminance = new DoubleRange(0.5 - (0.5 * this.factor), 0.5 + (0.5 * this.factor));
                }
            }
        }

        public Bitmap Apply(Bitmap image)
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Bitmap bitmap = this.Apply(imageData);
            image.UnlockBits(imageData);
            return bitmap;
        }

        public Bitmap ApplySafe(Bitmap image)
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            Bitmap bitmap = this.ApplySafe(imageData);
            image.UnlockBits(imageData);
            return bitmap;
        }

        public Bitmap Apply(BitmapData imageData)
        {
            if (imageData.PixelFormat != PixelFormat.Format24bppRgb)
            {
                throw new ArgumentException();
            }
            int width = imageData.Width;
            int height = imageData.Height;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            memcpy(data.Scan0, imageData.Scan0, imageData.Stride * height);
            ProcessFilter(data);
            bitmap.UnlockBits(data);
            return bitmap;
        }

        public Bitmap ApplySafe(BitmapData imageData)
        {
            if (imageData.PixelFormat != PixelFormat.Format24bppRgb)
            {
                throw new ArgumentException();
            }
            int width = imageData.Width;
            int height = imageData.Height;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            memcpy(data.Scan0, imageData.Scan0, imageData.Stride * height);
            ProcessFilterSafe(data);
            bitmap.UnlockBits(data);
            return bitmap;
        }
    }
}


