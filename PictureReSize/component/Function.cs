using Microsoft.WindowsAPICodePack.Taskbar;
using System.IO;

namespace PictureReSize.component
{
    class Function
    {
        public static void TempDelete()
        {
            DirectoryInfo target = new DirectoryInfo(Data.GetAppPath() + @"/Temp/");
            foreach (FileInfo file in target.GetFiles())
            {
                file.Delete();
            }
        }

        public static void Taskbar(int cnt, int max)
        {
            if (max <= cnt)
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
                return;
            }
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            TaskbarManager.Instance.SetProgressValue(cnt, max);
        }
    }
}
