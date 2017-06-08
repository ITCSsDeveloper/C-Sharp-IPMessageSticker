using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace C_Sharp_IPMessageSticker
{
    public class cMain
    {
        public static void Clipbroad_AddImage(Image img)
        {
            Clipboard.SetImage(img);
        }

        public static Image Clipbroad_GetImage(Image img)
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

        public static Process GetProcessIPMSG()
        {
            try
            {
                var processList = Process.GetProcesses();
                foreach (var process in processList)
                {
                    if (process.ProcessName == "ipmsg")
                    {
                        return process;
                    }
                }
            }
            catch
            {
                // ignored
            }

            return null;
        }

    }
}