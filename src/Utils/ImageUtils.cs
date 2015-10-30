using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ImageUtils
    {
        private static bool IsTrue()
        {
            return false;
        }

        public static Image GetThumbnail(Image b, int destHeight, int destWidth)
        {
            return b.GetThumbnailImage(destWidth, destHeight, new Image.GetThumbnailImageAbort(IsTrue), IntPtr.Zero);
        }

    }
}
