using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzetwarzanieObrazow
{
    class Filters
    {
        public static void Negative(object param)
        {
           Bitmap image = (Bitmap)param;

           int maxValue = 255;
           for (int y = 0; y < image.Height; y++)
           {
               for (int x = 0; x < image.Width; x++)
               {
                   Color pixel = image.GetPixel(x, y);
                   image.SetPixel(x, y, Color.FromArgb(pixel.A, maxValue - pixel.R, maxValue - pixel.G, maxValue - pixel.B));
               }
           }

        }

      
        public static void Greyscale(object param)
        {
           Bitmap image = (Bitmap)param;

           double kr = 0.299;
           double kg = 0.587;
           double kb = 0.114;

           for (int y = 0; y < image.Height; y++)
           {
               for (int x = 0; x < image.Width; x++)
               {
                   Color pixel = image.GetPixel(x, y);
                   int grey = (int)(kr * pixel.R + kg * pixel.G + kb * pixel.B);
                   image.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
               }
           }
        }

        public static void mirror(object param)
        {
           Bitmap image = (Bitmap)param;

           for (int y = 0; y < image.Height; y++)
           {
               for (int x = 0; x < image.Width / 2; x++)
               {
                   Color leftPixel = image.GetPixel(x, y);
                   Color rightPixel = image.GetPixel(image.Width - x - 1, y);

                   image.SetPixel(x, y, rightPixel);
                   image.SetPixel(image.Width - x - 1, y, leftPixel);
               }
           }
        }

        public static void Threshhold(object param)
        {
           Bitmap image = (Bitmap)param;
           int threshhold = 140;

           for (int y = 0; y < image.Height; y++)
           {
               for (int x = 0; x < image.Width; x++)
               {
                   Color pixel = image.GetPixel(x, y);
                   int grey = (int)((pixel.R + pixel.G + pixel.B) / 3);
                   if (grey < threshhold)
                       image.SetPixel(x, y, Color.Black);
                   else
                       image.SetPixel(x, y, Color.White);
               }
           }
        }

    }
}
