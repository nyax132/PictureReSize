using System.Collections.Generic;
using System.Windows.Forms;

namespace PictureReSize
{
    static class Data
    {
        public static string GetAppPath() => Application.StartupPath;
        public static string Appname;

        public static bool converting;

        public static string InputFolderPath;
        public static string OutputFolderPath;
        public static string InputFileType;
        public static string OutputFileType;
        public static List<string> inputFolderListPath = new List<string>();

        public static int X;
        public static int Y;

        public static bool aspect_lock;
        public static bool fukusu = false;
    }
}
