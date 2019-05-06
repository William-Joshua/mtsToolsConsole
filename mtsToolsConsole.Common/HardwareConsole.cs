using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtsToolsConsole.Common
{
    public class HardwareConsole
    {
        public static Image GetPrintScreenImage()
        {
            Bitmap snapshotImage= new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            Graphics graphics = Graphics.FromImage(snapshotImage);
            graphics.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));
            return snapshotImage;
        }
        public static void StoreImageToCache(Image image,string cacheLocalAddr)
        {
            try
            {
                image.Save(cacheLocalAddr, ImageFormat.Jpeg);
            }
            catch (Exception exception)
            {
                throw exception;
            }
           
        }
    }
}
