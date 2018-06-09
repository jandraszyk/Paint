using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayscalePlugin
{
    public class GrayScale : ImageProcessingInterface.ImageProcessing
    {

        public string getName()
        {
            return "Skala szarości";
        }

        public void changeImage(Bitmap image)
        {
            Color c;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    image.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
        }
    }
}
