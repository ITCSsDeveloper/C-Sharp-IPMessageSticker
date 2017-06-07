using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

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

        public static void ImportStickers(string stickerName , string folder)
        {
            if (string.IsNullOrWhiteSpace(stickerName))
                throw new Exception("Sticker Name Invalid.");

            if (!Directory.Exists(folder))
                throw new Exception("Directory Invalid.");

            if (Directory.Exists(Root + stickerName))
                throw new Exception("Directory Exists.");

            Directory.CreateDirectory(Root+stickerName);



            File.Copy("file-a.txt", "file-b.txt", true); // overwrite = true
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