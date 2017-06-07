using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace C_Sharp_IPMessageSticker
{
    public class cSticker
    {
        private static string Root = @"Stickers/";

        public static IEnumerable<StickerSet> GetStickers()
        {
            var stickerSets = new List<StickerSet>();

            if (!Directory.Exists(Root))
                Directory.CreateDirectory(Root);

            // Get Folder list
            var folders = Directory.GetDirectories(Root);
            foreach (var folder in folders)
            {
                var temp = new StickerSet();
                var files = Directory.GetFiles(folder + @"/", "*.png");

                temp.NameHeader = folder.Replace(Root, "").Trim();
                temp.IconHeader = files.FirstOrDefault();

                var tempStickers = new List<Sticker>();
                foreach (var file in files)
                {
                    var sTemp = new Sticker();
                    sTemp.Name = file.Replace(Root, "").Replace(temp.NameHeader + @"/", "").Replace(@".png", "").Trim();
                    sTemp.Path = file.Trim();
                    tempStickers.Add(sTemp);
                }

                temp.Stickers = tempStickers;
                stickerSets.Add(temp);
            }

            return stickerSets;
        }

        public static void ImportStickers(string stickerName, string folder)
        {
            if (string.IsNullOrWhiteSpace(stickerName))
                throw new Exception("Sticker Name Invalid.");

            if (!Directory.Exists(folder))
                throw new Exception("Directory Invalid.");

            if (Directory.Exists(Root + stickerName))
                throw new Exception("Directory Exists.");

            Directory.CreateDirectory(Root + stickerName);

            var Files = new DirectoryInfo(folder).GetFiles();
            foreach (FileInfo file in Files)
            {
                CopySticker(file.FullName, Root + stickerName + @"/" + file.Name.Replace(file.Extension, "") + ".png");
            }
        }

        public static void DeleteSticker(string stickerName)
        {
            if (string.IsNullOrWhiteSpace(stickerName))
                throw new Exception("Sticker Name Invalid.");

            if (!Directory.Exists(Root + stickerName))
                throw new Exception("No Sticker Name");

            Directory.Delete(Root + stickerName.Trim(),true);
        }

        private static void CopySticker(string source, string destination)
        {
            var bmp1 = cMain.LoadImageFormPath(source);
            var jpgEncoder = GetEncoder(ImageFormat.Png);
            var myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100);

            bmp1 = (Image)(new Bitmap(bmp1, new Size(64, 64)));
            bmp1.Save(destination, jpgEncoder, myEncoderParameters);
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }
    }

    public class StickerSet
    {
        public string NameHeader { get; set; }
        public string IconHeader { get; set; }

        public IEnumerable<Sticker> Stickers { get; set; }
    }

    public class Sticker
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}