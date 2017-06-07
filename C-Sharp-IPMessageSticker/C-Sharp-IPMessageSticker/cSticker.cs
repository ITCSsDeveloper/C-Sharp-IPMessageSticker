using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_IPMessageSticker
{
   public class cSticker
    {
       public static IEnumerable<StickerSet> GetStickers()
       {
           List<StickerSet> sss = new List<StickerSet>();




           return sss;
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
        public string  Name {get; set; }
        public string Path { get; set; }
    }
}
