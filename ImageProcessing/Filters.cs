using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.ComponentModel;

namespace ImageProcessing
{
    abstract class Filters
    {

        protected abstract Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y);

        protected Random rand = new Random();

        public int Clamp(int value, int min, int max)
       {
           if (value < min)
               return min;
           if (value > max)
               return max;
           return value;
       }

     virtual  public Bitmap processImage(Bitmap sourceImage,BackgroundWorker worker){
           Bitmap resultImage=new Bitmap(sourceImage.Width, sourceImage.Height);

           for(int i=0; i < sourceImage.Width;i++)
           {
               worker.ReportProgress((int)((float)i / resultImage.Width * 100));
               if (worker.CancellationPending)
                   return null;


               for(int j=0; j<sourceImage.Height;j++)
               {
                   resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage,i,j));
          
               }

           }

           return resultImage;
       }  
    }

    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;

        protected MatrixFilter()
        {

        }

        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }

            }

            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }

    }


    

    class GaussianFilter: MatrixFilter
    {
        public GaussianFilter()
        {
            CreateGaussianKernel(2, 3);
        }

        public void CreateGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;

            for(int i = -radius;i<=radius;i++)
            {
                for(int j=-radius;j<=radius;j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }

            for(int i = 0; i< size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    kernel[i, j] /= norm;
                }
            }
        }

    }

    class SobelFilter : MatrixFilter
    {
        public float[,] kernelX = new float[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        public float[,] kernelY = new float[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

        public SobelFilter()
        {

        }
        
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = 3 / 2;
            int radiusY = 3 / 2;

            float resultXR = 0, resultXG = 0, resultXB = 0,
                resultYR = 0, resultYG = 0, resultYB = 0;

            for (int i = -radiusX; i <= radiusX; i++)
                for (int j = -radiusY; j <= radiusY; j++)
                {

                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultXR += neighborColor.R * kernelX[i + radiusX, j + radiusY];
                    resultXG += neighborColor.G * kernelX[i + radiusX, j + radiusY];
                    resultXB += neighborColor.B * kernelX[i + radiusX, j + radiusY];

                    resultYR += neighborColor.R * kernelY[i + radiusX, j + radiusY];
                    resultYG += neighborColor.G * kernelY[i + radiusX, j + radiusY];
                    resultYB += neighborColor.B * kernelY[i + radiusX, j + radiusY];
                }

            int R = (int)(Math.Sqrt(resultXR * resultXR + resultYR * resultYR));
            int G = (int)(Math.Sqrt(resultXG * resultXG + resultYG * resultYG));
            int B = (int)(Math.Sqrt(resultXB * resultXB + resultYB * resultYB));

            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }
    }

    class LinearSmoothing : MatrixFilter
    {
        public float[,] kernel1 = new float[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        public LinearSmoothing() {

        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y) {

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {

                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += neighborColor.R * kernel1[i + 1, j + 1];
                    resultG += neighborColor.G * kernel1[i + 1, j + 1];
                    resultB += neighborColor.B * kernel1[i + 1, j + 1];
              
                }

            resultR /= 9;
            resultG /= 9;
            resultB /= 9;

            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }

    }

    class LinearSmoothing2 : MatrixFilter
    {
        public float[,] kernel1 = new float[3, 3] { { 1, 2, 1 }, { 2, 4, 2 }, { 1, 2, 1 } };
        public LinearSmoothing2()
        {

        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {

                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += neighborColor.R * kernel1[i + 1, j + 1];
                    resultG += neighborColor.G * kernel1[i + 1, j + 1];
                    resultB += neighborColor.B * kernel1[i + 1, j + 1];

                }

            resultR /= 16;
            resultG /= 16;
            resultB /= 16;

            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }

    }
    class Mediana : MatrixFilter
    {
          private int size;
        public Mediana(int _size)
        {
            size = _size;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = size/2;
            int radiusY = size/2;

            int[] R = new int[size * size];
            int[] G = new int[size * size];
            int[] B = new int[size * size];

            int flag = 0;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);

                    Color neighborColor = sourceImage.GetPixel(idX, idY);

                    R[flag] = neighborColor.R;
                    G[flag] = neighborColor.G;
                    B[flag] = neighborColor.B;

                    flag++;
                }

            }

            Array.Sort(R);
            Array.Sort(G);
            Array.Sort(B);

            int num = (size * size + 1) / 2;

            Color resultColor = Color.FromArgb(R[num], G[num], B[num]);

            return resultColor;
        }
    }

    class Laplass1: MatrixFilter
    {
        private double c;
       public Laplass1(double _c = -1)
        {
            c = _c;
            kernel = new float[3, 3] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = 3 / 2;
            int radiusY = 3 / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            Color neighborColor;
            for (int i = -radiusX; i <= radiusX; i++)
            {
                for (int j = -radiusY; j <= radiusY; j++)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);

                    neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += kernel[i + 1, j + 1] * neighborColor.R;
                    resultG += kernel[i + 1, j + 1] * neighborColor.G;
                    resultB += kernel[i + 1, j + 1] * neighborColor.B;

                }

            }

             neighborColor = sourceImage.GetPixel(x, y);

            int R = neighborColor.R + (int)(c * resultR);
            int G = neighborColor.G + (int)(c * resultG);
            int B = neighborColor.B + (int)(c * resultB);

            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }

    }

    class Laplass2 : MatrixFilter
    {
        private double c;
        public Laplass2(double _c = -1)
        {
            c = _c;
            kernel = new float[3, 3] { { 1, 1, 1 }, { 1, -8, 1 }, { 1, 1, 1 } };
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = 3 / 2;
            int radiusY = 3 / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            Color neighborColor;
            for (int i = -radiusX; i <= radiusX; i++)
            {
                for (int j = -radiusY; j <= radiusY; j++)
                {
                    int idX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourceImage.Height - 1);

                    neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += kernel[i + 1, j + 1] * neighborColor.R;
                    resultG += kernel[i + 1, j + 1] * neighborColor.G;
                    resultB += kernel[i + 1, j + 1] * neighborColor.B;

                }

            }

            neighborColor = sourceImage.GetPixel(x, y);

            int R = neighborColor.R + (int)(c * resultR);
            int G = neighborColor.G + (int)(c * resultG);
            int B = neighborColor.B + (int)(c * resultB);

            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }

    }

    class FrequencyIncrease : MatrixFilter
    {
        protected double k;
        public FrequencyIncrease(double _k)
        {
            k = _k;
            CreateGaussianKernel(2, 10);
        }
        public void CreateGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;

            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= norm;
                }
            }
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            Color neighborColor;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    neighborColor = sourceImage.GetPixel(idX, idY);

                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }

            }
            neighborColor = sourceImage.GetPixel(x, y);

            resultR = neighborColor.R + (int)(k * (neighborColor.R - resultR));
            resultG = neighborColor.G + (int)(k * (neighborColor.G - resultG));
            resultB = neighborColor.B + (int)(k * (neighborColor.B - resultB));

            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }


    }

}
