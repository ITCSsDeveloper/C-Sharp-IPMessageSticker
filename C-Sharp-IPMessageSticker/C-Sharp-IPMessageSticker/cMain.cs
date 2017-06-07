using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public class cMain
    {
        public static void AddImage(Image img)
        {
            Clipboard.SetImage(img);
        }

        public static Image GetImage(Image img)
        {
            Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
            }
            return returnImage;
        }

        public static Image LoadImageFormPath(string path)
        {
            Image temp;
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Path.GetFullPath(path))))
            {
                temp = Image.FromStream(ms);
                ms.Dispose();
            }
            return temp;
        }



        public static bool CheckProcess()
        {
            try
            {
                var processList = Process.GetProcesses();
                if (processList.Any(process => process.ProcessName == "ipmsg"))
                    return true;
            }
            catch
            {
                // ignored
            }

            return false;
        }

    }
}