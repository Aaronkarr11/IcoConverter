using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcoConverter
{
    public class ConverterLogic : IConverterLogic
    {

        //public byte[] ConvertImageToIcon(byte[] bytes)
        //{
        //    try
        //    {
        //        using (var ms = new MemoryStream(bytes))
        //        {
        //            using (var bmp = new Bitmap(ms))
        //            {
        //                ImageCodecInfo icoEncoder = GetEncoder(ImageFormat.Icon);
        //                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
        //                EncoderParameters myEncoderParameters = new EncoderParameters(1);

        //                using (var outStream = new MemoryStream())
        //                {

        //                    var myEncoderParameter = new EncoderParameter(myEncoder, 32);
        //                    myEncoderParameters.Param[0] = myEncoderParameter;

        //                    Bitmap bitmap = new Bitmap(image, new Size(32, 32));
        //                    bitmap.Save(fs, ImageFormat.Icon);

        //                    bmp.Save(outStream, icoEncoder, myEncoderParameters);
        //                    return outStream.ToArray();
        //                }
        //            }
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return new byte[0];
        //    }
        //}


        public byte[] ConvertImageToIcon(string inputImagePath, int size)
        {
            try
            {
                using (Image image = Image.FromFile(inputImagePath))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
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
                            // Use a 32x32 image as an icon
                            Bitmap bitmap = new Bitmap(image, new Size(32, 32));
                            bitmap.Save(fs, ImageFormat.Icon);
                        }
                    }
                }

                Console.WriteLine("Icon file created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


    }
}
