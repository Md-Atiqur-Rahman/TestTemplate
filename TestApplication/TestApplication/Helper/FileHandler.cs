using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Helper
{
    public static class FileHandler
    {
        private static readonly List<string> _allowedLogoFileTypes = new List<string> { ".png", ".jpg", ".jpeg", ".gif", ".bmp" };
        public static byte[] GenerateByte(IFormFile file, int filelength = 1048576)
        {

            if (file.Length > 0)
            {
                // 1048567 bytes = 1 MegaBytes
                if (file.FileName == string.Empty || file.Length > filelength) return null;

                var extension = Path.GetExtension(file.FileName);

                if (extension == null) return null;
                extension = extension.ToLower();
                if (_allowedLogoFileTypes.IndexOf(extension) == -1)
                {
                    return null;
                }
                using (MemoryStream target = new MemoryStream())
                {
                    file.CopyToAsync(target);
                    return target.ToArray();
                }
            }
            return null;
        }


        public static int GetFileSize(int contentLength)
        {
            var fileSizeInKiloBytes = contentLength / 1024;
            return Convert.ToInt32(fileSizeInKiloBytes);
        }

        public static string GetImage(byte[] arrayData)
        {
            if (arrayData != null)
            {
                var base64 = Convert.ToBase64String(arrayData);
                var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                return imgSrc;
            }
            else return null;
        }

    }


}
