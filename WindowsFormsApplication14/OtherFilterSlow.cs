using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication14
{
    abstract class MyFilterSlowBase
    {
        abstract protected void Prepare(int[] pValues);
        abstract protected byte Adjust(byte iValue);

        public void Adjust(Bitmap pBitmap, params int[] pValues)
        {
            Prepare(pValues);

            for (int i = 0; i < pBitmap.Width; i++)
            {
                for (int j = 0; j < pBitmap.Height; j++)
                {
                    Color pColor = pBitmap.GetPixel(i, j);
                    int iR = Adjust(pColor.R);
                    int iG = Adjust(pColor.G);
                    int iB = Adjust(pColor.B);
                    pBitmap.SetPixel(i, j, Color.FromArgb(iR, iG, iB));
                }
            }
        }

        protected byte Fix(int iValue)
        {
            if (iValue < 0) iValue = 0;
            if (iValue > 255) iValue = 255;
            return (byte)iValue;
        }
    }

    class BrightnessSlow : MyFilterSlowBase
    {
        private int m_iBrightness;
        protected override void Prepare(int[] pValues)
        {
            m_iBrightness = pValues[0];
        }
        protected override byte Adjust(byte iValue)
        {
            return Fix(iValue + m_iBrightness);
        }
    }

    class ContrastSlow : MyFilterSlowBase
    {
        private double m_fContrast;
        protected override void Prepare(int[] pValues)
        {
            m_fContrast = Math.Pow((100.0 + pValues[0]) / 100.0, 2);
        }
        protected override byte Adjust(byte iValue)
        {
            return Fix((int)(((iValue / 255.0 - 0.5) * m_fContrast + 0.5) * 255.0));
        }
    }

    class BrightnessContrastSlow : MyFilterSlowBase
    {
        private int m_iBrightness;
        private double m_fContrast;
        protected override void Prepare(int[] pValues)
        {
            m_iBrightness = pValues[0];
            m_fContrast = Math.Pow((100.0 + pValues[1]) / 100.0, 2);
        }
        protected override byte Adjust(byte iValue)
        {
            return Fix((int)(((Fix(iValue + m_iBrightness) / 255.0 - 0.5) * m_fContrast + 0.5) * 255.0));
        }
    }
}
