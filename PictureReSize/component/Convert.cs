using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureReSize.component
{
    class Convert
    {
        private readonly List<string> MoveErrorList = new List<string>();
        private int ActiveFilesLength;
        public void PictureFileCheck()
        {
            var vs = System.IO.Directory.GetFiles(Data.InputFolderPath, "*." + Data.InputFileType);
            if (vs.Length == 0)
            {
                MessageBox.Show("フォルダの中に変換できるものがありませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ActiveFilesLength = vs.Length;

                Resizer(); // 変換実行
            }
        }

        private async void Resizer()
        {
            int cnt = 0;
            Data.converting = true;

            var vs = System.IO.Directory.GetFiles(Data.InputFolderPath, "*." + Data.InputFileType);

            foreach (string stFilePath in vs)
            {
                await Task.Run(() =>
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

                });

                cnt++;
                Function.Taskbar(cnt, ActiveFilesLength);

                PictureMove();
                Function.TempDelete();
            }
            MessageBox.Show("合計:" + cnt + "個変換しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
