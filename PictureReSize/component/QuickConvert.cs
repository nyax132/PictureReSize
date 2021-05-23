using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureReSize.component
{
    class QuickConvert
    {
        private readonly List<string> MoveErrorList = new List<string>();
        private int ActiveFilesLength;
        string[] DragFileList;
        public void Run(String[] Data)
        {
            DragFileList = Data;
            ActiveFilesLength = DragFileList.Length;

            Resizer();
        }

        private async void Resizer()
        {
            int cnt = 0;
            Data.converting = true;

            foreach (string stFilePath in DragFileList)
            {
                await Task.Run(() =>
                {
                    try
                    {
                        var filename = System.IO.Path.GetFileNameWithoutExtension(stFilePath);

                        using Bitmap bmp = new Bitmap(stFilePath);

                        var resizeWidth = Data.X;
                        var resizeHeight = (int)((float)bmp.Height / bmp.Width * Data.X);

                        if (!Data.aspect_lock) //アスペクト比解除時
                        {
                            resizeWidth = Data.X;
                            resizeHeight = Data.Y;
                        }

                        using Bitmap resizeBmp = new Bitmap(resizeWidth, resizeHeight);

                        using Graphics g = Graphics.FromImage(resizeBmp);

                        g.DrawImage(bmp, 0, 0, resizeWidth, resizeHeight);

                        resizeBmp.Save(System.IO.Path.Combine(Data.GetAppPath() + @"/Temp/", filename + "." + Data.OutputFileType));

                    }
                    catch (System.ArgumentException)
                    {
                        Console.WriteLine("ファイルの変換に失敗　スルー");
                    }
                });

                cnt++;
                Function.Taskbar(cnt, ActiveFilesLength);

                PictureMove();
                Function.TempDelete();
            }
            //MessageBox.Show("合計:" + cnt + "個変換しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Media.SystemSounds.Asterisk.Play();

            if (MoveErrorList.Count != 0)　//エラーが有る場合
            {
                string erroritemlist = "";

                foreach (var item in MoveErrorList)
                {
                    erroritemlist += Environment.NewLine + item;
                }

                MessageBox.Show(erroritemlist + Environment.NewLine + "以下の画像の移動に失敗しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Function.TempDelete();
            Data.converting = false;
        }

        private void PictureMove()
        {
            DirectoryInfo target = new DirectoryInfo(Data.GetAppPath() + @"/Temp/");
            foreach (FileInfo file in target.GetFiles())
            {
                //file.CopyTo(Data.OutputFolderPath + file.Name);
                try
                {
                    System.IO.File.Copy(file.FullName, Data.OutputFolderPath + file.Name, true);
                }
                catch
                {
                    MoveErrorList.Add(file.Name);
                    Console.WriteLine("MoveErrorCnt Add :" + file.Name);
                }
            }
        }
    }
}
