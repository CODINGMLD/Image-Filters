using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace WindowsFormsApplication14
{
    class QColorMatrix
    {
        const float rad = (float)(Math.PI / 180.0f);

        const float lumR = 0.3086f;
        const float lumG = 0.6094f;
        const float lumB = 0.0820f;

        public enum MatrixOrder
        {
            MatrixOrderPrepend = 0,
            MatrixOrderAppend = 1
        };

        private float[][] m_pColorMatrix = new float[5][];

        public QColorMatrix()
        {
            Reset();
        }

        public QColorMatrix(float[][] pColorMatrix)
        {
            m_pColorMatrix = pColorMatrix;
        }

        public void Reset()
        {
            m_pColorMatrix[0] = new float[] { 1, 0, 0, 0, 0 };
            m_pColorMatrix[1] = new float[] { 0, 1, 0, 0, 0 };
            m_pColorMatrix[2] = new float[] { 0, 0, 1, 0, 0 };
            m_pColorMatrix[3] = new float[] { 0, 0, 0, 1, 0 };
            m_pColorMatrix[4] = new float[] { 0, 0, 0, 0, 1 };
        }

        private void Multiply(QColorMatrix pColorMatrix, MatrixOrder order)
        {
            float[][] a;
            float[][] b;

	        if (order == MatrixOrder.MatrixOrderAppend)
	        {
		        a = pColorMatrix.m_pColorMatrix;
		        b = m_pColorMatrix;
	        }
	        else
	        {
		        a = m_pColorMatrix;
		        b = pColorMatrix.m_pColorMatrix;
	        }

            float[][] temp = new float[5][];

            for (int y = 0; y < 5 ; y++)
            {
                temp[y] = new float[4];
                for (int x = 0; x < 4; x++)
		        {
			        float t = 0;
			        for (int i = 0; i < 5; i++) t += b[y][i] * a[i][x];
                    temp[y][x] = t;
                }
            }

            string csTemp = "";
	        for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    m_pColorMatrix[y][x] = temp[y][x];
                    csTemp += m_pColorMatrix[y][x] + ", ";
                }
                csTemp += m_pColorMatrix[y][4] + "\n";
            }
        }

        private void Scale(float scaleRed, float scaleGreen,
            float scaleBlue, float scaleOpacity, MatrixOrder order)
        {
            QColorMatrix m = new QColorMatrix();

            m.m_pColorMatrix[0][0] = scaleRed;
            m.m_pColorMatrix[1][1] = scaleGreen;
            m.m_pColorMatrix[2][2] = scaleBlue;
            m.m_pColorMatrix[3][3] = scaleOpacity;

            Multiply(m, order);
        }

        private void Translate(float offsetRed, float offsetGreen,
                   float offsetBlue, float offsetOpacity, MatrixOrder order)
        {
            QColorMatrix m = new QColorMatrix();

            m.m_pColorMatrix[4][0] = offsetRed;
            m.m_pColorMatrix[4][1] = offsetGreen;
            m.m_pColorMatrix[4][2] = offsetBlue;
            m.m_pColorMatrix[4][3] = offsetOpacity;

	        Multiply(m, order);
        }

        public void ScaleColors(float scale, MatrixOrder order)
        {
            Scale(scale, scale, scale, 1.0f, order);
        }

        public void TranslateColors(float offset, MatrixOrder order)
        {
            Translate(offset, offset, offset, 1.0f, order);
        }

        public void SetSaturation(float saturation, MatrixOrder order)
        {
            float satCompl = 1.0f - saturation;
            float satComplR = lumR * satCompl;
            float satComplG = lumG * satCompl;
            float satComplB = lumB * satCompl;

            QColorMatrix m = new QColorMatrix(
                new float[5][]
	        {
		        new float[] {satComplR + saturation,	satComplR,	satComplR,	0.0f, 0.0f},
		        new float[] {satComplG,	satComplG + saturation,	satComplG,	0.0f, 0.0f},
		        new float[] {satComplB,	satComplB,	satComplB + saturation,	0.0f, 0.0f},
		        new float[] {0.0f,	0.0f,	0.0f,	1.0f,	0.0f},
		        new float[] {0.0f,	0.0f,	0.0f,	0.0f,	1.0f}
	        });
            Multiply(m, order);
        }

        public void RotateHue(float phi)
        {
            InitHue();
            Multiply(m_pPreHue, MatrixOrder.MatrixOrderAppend);

	        // Rotate around the blue axis
            RotateBlue(phi, MatrixOrder.MatrixOrderAppend);

            Multiply(m_pPostHue, MatrixOrder.MatrixOrderAppend);
        }

    	private void RotateRed(float phi, MatrixOrder order)
		{ 
            RotateColor(phi, 2, 1, order); 
        }
    	private void RotateGreen(float phi, MatrixOrder order)
		{ 
            RotateColor(phi, 0, 2, order); 
        }
    	private void RotateBlue(float phi, MatrixOrder order)
		{ 
            RotateColor(phi, 1, 0, order); 
        }

        private void RotateColor(float phi, int x, int y, MatrixOrder order)
        {
	        phi *= rad;
	        QColorMatrix m = new QColorMatrix();

            m.m_pColorMatrix[x][x] = m.m_pColorMatrix[y][y] = (float)Math.Cos(phi);

            float s = (float)Math.Sin(phi);
            m.m_pColorMatrix[y][x] = s;
            m.m_pColorMatrix[x][y] = -s;

	        Multiply(m, order);
        }

        private void ShearRed(float green, float blue, MatrixOrder order)
        { 
            ShearColor(0, 1, green, 2, blue, order); 
        }
        private void ShearGreen(float red, float blue, MatrixOrder order)
        { 
            ShearColor(1, 0, red, 2, blue, order); 
        }
        private void ShearBlue(float red, float green, MatrixOrder order)
        { 
            ShearColor(2, 0, red, 1, green, order); 
        }

        private void ShearColor(int x, int y1, float d1, int y2, float d2, MatrixOrder order)
        {
	        QColorMatrix m = new QColorMatrix();
            m.m_pColorMatrix[y1][x] = d1;
            m.m_pColorMatrix[y2][x] = d2;

	        Multiply(m, order);
        }

        private void TransformVector(float[] v)
        {
	        float[] temp = new float[4];

	        for (int x = 0; x < 4; x++)
	        {
                temp[x] = m_pColorMatrix[4][x];
                for (int y = 0; y < 4; y++)
                {
                    temp[x] += v[y] * m_pColorMatrix[y][x];
                }
	        }
            for (int x = 0; x < 4; x++)
            {
                v[x] = temp[x];
            }
        }

        QColorMatrix m_pPreHue = null;
        QColorMatrix m_pPostHue = null;
        private void InitHue()
        {
            if (m_pPreHue != null) return;

            m_pPreHue = new QColorMatrix();
            m_pPostHue = new QColorMatrix();

	        const float greenRotation = 35.0f;
            //	const REAL greenRotation = 39.182655f;

	        // NOTE: theoretically, greenRotation should have the value of 39.182655 degrees,
	        // being the angle for which the sine is 1/(sqrt(3)), and the cosine is sqrt(2/3).
	        // However, I found that using a slightly smaller angle works better.
	        // In particular, the greys in the image are not visibly affected with the smaller
	        // angle, while they deviate a little bit with the theoretical value.
	        // An explanation escapes me for now.
	        // If you rather stick with the theory, change the comments in the previous lines.


		    // Rotating the hue of an image is a rather convoluted task, involving several matrix
		    // multiplications. For efficiency, we prepare two static matrices.
		    // This is by far the most complicated part of this class. For the background
		    // theory, refer to the sgi-sites mentioned at the top of this file.

		    // Prepare the preHue matrix.
		    // Rotate the grey vector in the green plane.
            m_pPreHue.RotateRed(45.0f, MatrixOrder.MatrixOrderPrepend);

		    // Next, rotate it again in the green plane, so it coincides with the blue axis.
		    m_pPreHue.RotateGreen(- greenRotation, MatrixOrder.MatrixOrderAppend);

		    // Hue rotations keep the color luminations constant, so that only the hues change
		    // visible. To accomplish that, we shear the blue plane.
		    float[] lum = new float[]{ lumR, lumG, lumB, 1.0f };

		    // Transform the luminance vector.
		    m_pPreHue.TransformVector(lum);

		    // Calculate the shear factors for red and green.
            float red = lum[0] / lum[2];
            float green = lum[1] / lum[2];

		    // Shear the blue plane.
            m_pPreHue.ShearBlue(red, green, MatrixOrder.MatrixOrderAppend);

		    // Prepare the postHue matrix. This holds the opposite transformations of the
		    // preHue matrix. In fact, postHue is the inversion of preHue.
            m_pPostHue.ShearBlue(-red, -green, MatrixOrder.MatrixOrderPrepend);
            m_pPostHue.RotateGreen(greenRotation, MatrixOrder.MatrixOrderAppend);
            m_pPostHue.RotateRed(-45.0f, MatrixOrder.MatrixOrderAppend);
	    }

        public Bitmap Adjust(Bitmap pBitmap, float fGamma)
        {
            //Reset();
            ColorMatrix matrix = new ColorMatrix(m_pColorMatrix);
            
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetColorMatrix(matrix);
            imageAttr.SetGamma(fGamma);
            Rectangle destRect = new Rectangle(0, 0, pBitmap.Width, pBitmap.Height);
            Bitmap pAdjustedBitmap = new Bitmap(pBitmap.Width, pBitmap.Height);
            Graphics pGraphics = Graphics.FromImage(pAdjustedBitmap);
            pGraphics.DrawImage(pBitmap, destRect, 0, 0, pBitmap.Width, pBitmap.Height, GraphicsUnit.Pixel, imageAttr);
            pGraphics.Dispose();
            return pAdjustedBitmap;
        }
    }
}
