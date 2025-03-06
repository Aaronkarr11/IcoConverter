using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace IcoConverter
{
    public class ConverterLogic : IConverterLogic
    {
        public string ConvertImageToIcon(string inputImagePath, int size, string outputImagePath)
        {
            Dictionary<string, byte[]> result = new Dictionary<string, byte[]>();
            try
            {
                MemoryStream imageStream = new MemoryStream();
                Image image = Image.FromFile(inputImagePath);
                using (FileStream fs = new FileStream(outputImagePath, FileMode.Create))
                {
                    SaveAsIcon(image, fs, size);
                }
                return $"All Done! Your icon file is saved to {outputImagePath}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        private static void SaveAsIcon(Image img, Stream outputStream, int size)
        {
            int width = size;
            int height = size;

            using (Bitmap bmp = new Bitmap(img, new Size(width, height)))
            {
                Icon icon = Icon.FromHandle(bmp.GetHicon());
                icon.Save(outputStream);
            }
        }


    }
}
