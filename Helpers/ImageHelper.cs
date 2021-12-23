using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public class ImageHelper
    {
        public static Image GetThumbnail(string fullFilePath, double maxSize = 120)
        {
            // create an image object, using the filename we just retrieved
            var orgImage = System.Drawing.Image.FromFile(fullFilePath);
            // create the actual thumbnail image
            return MakeThumbnail(orgImage, maxSize);
        }    

        private static Image MakeThumbnail(Image orgImage, double maxSize)
        {
            double ratio = 0;
            if (orgImage.Width > orgImage.Height)
            {
                ratio = maxSize / orgImage.Width;
            }
            else
            {
                ratio = maxSize / orgImage.Height;
            }
            return orgImage.GetThumbnailImage(Convert.ToInt32(ratio * orgImage.Width), Convert.ToInt32(ratio * orgImage.Height), new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
        }

        private static bool ThumbnailCallback()
        {
            return true;
        }


        public static Image Resize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = (Convert.ToSingle(Width / Convert.ToDecimal(sourceWidth)));
            nPercentH = (Convert.ToSingle(Height / Convert.ToDecimal(sourceHeight)));
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = Convert.ToInt32((sourceWidth * nPercent));
            int destHeight = Convert.ToInt32((sourceHeight * nPercent));

            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            using (Graphics grPhoto = Graphics.FromImage(bmPhoto))
            {
                grPhoto.Clear(Color.White);
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.SmoothingMode = SmoothingMode.HighQuality;
                grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
                grPhoto.CompositingQuality = CompositingQuality.HighQuality;

                grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHeight));

            }

            return bmPhoto;
        }
        public static void ResizeJpegImageAndSave(string originalImagePath, string destinationImagePath, int resizeToWidth, int resizeToHeight)
        {
            Image resizedImage = default(Image);
            using (Bitmap originalImage = new System.Drawing.Bitmap(originalImagePath))
            {
                resizedImage = Resize(originalImage, resizeToWidth, resizeToHeight);
                ImageCodecInfo[] info = ImageCodecInfo.GetImageEncoders();
                EncoderParameters @params = new EncoderParameters();
                @params.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
                FileInfo fi = new FileInfo(destinationImagePath);
                if (fi.Directory.Exists == false)
                    fi.Directory.Create();

                resizedImage.Save(destinationImagePath, info[1], @params);
            }
            resizedImage.Dispose();
        }
        public static byte[] ResizeAndConvertToBytes(Image originalImage, int width, int height)
        {
            var image = Resize(originalImage, width, height);
            using (image)
            {
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    ms.Position = 0;
                    return ms.ToArray();
                }
            }
        }
    }
}
