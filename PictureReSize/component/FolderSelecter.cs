using System.IO;
using System.Windows.Forms;

namespace PictureReSize.component
{
    public class FolderSelecter
    {
        public string FolderSelect()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.FileName = "フォルダ選択";
                openFileDialog1.Filter = "フォルダー|.";
                openFileDialog1.ValidateNames = false;
                openFileDialog1.CheckFileExists = false;
                openFileDialog1.CheckPathExists = true;

                using (OpenFileDialog openFileDialog2 = openFileDialog1)
                {
                    if (openFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        return Path.GetDirectoryName(openFileDialog2.FileName);
                    }
                }
                return "";
            }
        }
    }
}
