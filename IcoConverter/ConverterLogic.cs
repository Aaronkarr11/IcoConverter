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
        public byte[] ConvertImageToIcon(string inputImagePath, int size, string fileType)
        {
            try
            {
                using (Image image = Image.FromFile(inputImagePath))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        if (fileType == "PNG")
                        {
                            image.Save(memoryStream, ImageFormat.Png);
                        }
                        else
                        {
                            image.Save(memoryStream, ImageFormat.Png);
                        }
                        // Use a 32x32 image as an icon
                        Bitmap bitmap = new Bitmap(image, new Size(size, size));
                        //bitmap.Save(memoryStream, ImageFormat.Icon);
                        return memoryStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                return new byte[0];

            }
        }

        public void ConvertImageToIcon(string inputImagePath, string outputIconPath)
        {
            try
            {
                using (Image image = Image.FromFile(inputImagePath))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Png);
       
                        using (FileStream fs = new FileStream(outputIconPath, FileMode.Create))
                        {
                            Bitmap bitmap = new Bitmap(image, new Size(32, 32));
                            bitmap.Save(fs, ImageFormat.Icon);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
