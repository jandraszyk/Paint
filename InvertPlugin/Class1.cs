using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertPlugin
{
    public class Invert : ImageProcessingInterface.ImageProcessing
    {
        public string getName()
        {
            return "Odwróć kolory";
        }

        public void changeImage(Bitmap image)
        {
            Color c;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    image.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
        }
    }
}
