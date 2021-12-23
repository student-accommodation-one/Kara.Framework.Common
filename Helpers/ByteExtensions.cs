using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class ByteExtensions
    {
        public static string ToBase64ImageSource(this byte[] photo, string unvailableImagePath)
        {
            var imgSrc = string.Empty;
            if (photo != null)
            {
                var base64 = Convert.ToBase64String(photo);
                imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
            }
            else
            {
                imgSrc = unvailableImagePath;
            }

            return imgSrc;
        }
    }
}
