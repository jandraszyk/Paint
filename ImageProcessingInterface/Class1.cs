using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingInterface
{
    public interface ImageProcessing
    {
        void changeImage(Bitmap image);
        string getName();
    }
}
