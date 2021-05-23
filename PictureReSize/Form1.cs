using PictureReSize.component;
using System;
using System.Windows.Forms;

namespace PictureReSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xtextbox.Text = "1920";
            Ytextbox.Text = "1080";
            InputTypetextbox.Text = "jpg";
            OutputTypetextbox.Text = "jpg";
            InputtextBox.Text = "選択してください";
            OutputtextBox.Text = "選択してください";
            InputFileListBox.Visible = false;
            InputFileListRemoveButton.Visible = false;
            InputButton.Select();

            Data.Appname = this.Text;

            //var con = new component.Convert();
            Function.TempDelete();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            var selectpath = new FolderSelecter().FolderSelect();

            Data.InputFolderPath = selectpath + @"\";

            if (Data.fukusu)//複数
            {
                Data.inputFolderListPath.Add(selectpath);
                InputFileListBox.Items.Add(selectpath);
            }

            InputtextBox.Text = selectpath + @"\";
            Console.WriteLine("InputPath: " + selectpath);
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            var selectpath = new FolderSelecter().FolderSelect();
            Data.OutputFolderPath = selectpath + @"\";
            OutputtextBox.Text = selectpath + @"\";
            Console.WriteLine("OutputPath: " + selectpath);
        }

        private void HenkanButton_Click(object sender, EventArgs e)
        {
            Function.TempDelete();
            if (Data.converting)
            {
                MessageBox.Show("変換中ですよ！！！　そんなに急がないで(´；ω；｀)", "(´；ω；｀)(´；ω；｀)(´；ω；｀)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Data.InputFileType = InputTypetextbox.Text;
            Data.OutputFileType = OutputTypetextbox.Text;
            Data.X = int.Parse(Xtextbox.Text);
            Data.Y = int.Parse(Ytextbox.Text);
            Data.aspect_lock = aspect_ratioCheckBox.Checked;

            var inputcheck = 0;
            if (Data.InputFileType.Length == 0) inputcheck++;
            if (Data.OutputFileType.Length == 0) inputcheck++;
            if (Data.InputFolderPath == null) inputcheck++;
            if (Data.OutputFolderPath == null) inputcheck++;

            if (inputcheck != 0)
            {
                MessageBox.Show("入力内容を確認してください", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Data.fukusu)
            {
                var multicon = new MultiConvert();
                multicon.PictureFileCheck();
                return;
            }

            var con = new component.Convert();
            con.PictureFileCheck();
        }

        private void FukusuCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (FukusuCheckbox.Checked)
            {
                InputFileListBox.Visible = true;
                InputFileListRemoveButton.Visible = true;
                Data.fukusu = true;
                InputButton.Text = "追加";
            }
            else
            {
                InputFileListBox.Visible = false;
                InputFileListRemoveButton.Visible = false;
                Data.fukusu = false;
                Data.inputFolderListPath.Clear();
                InputFileListBox.Items.Clear();
                InputButton.Text = "入力";
            }
        }

        private void InputFileListRemoveButton_Click(object sender, EventArgs e)
        {
            if (Data.fukusu)
            {
                if (InputFileListBox.SelectedIndex == -1) return;
                Console.WriteLine(InputFileListBox.Text);
                Data.inputFolderListPath.Remove(InputFileListBox.Text);


                InputFileListBox.Items.RemoveAt(InputFileListBox.SelectedIndex);
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Data.InputFileType = InputTypetextbox.Text;
            Data.OutputFileType = OutputTypetextbox.Text;
            Data.X = int.Parse(Xtextbox.Text);
            Data.Y = int.Parse(Ytextbox.Text);
            Data.aspect_lock = aspect_ratioCheckBox.Checked;

            if (Data.OutputFolderPath == null)
            {
                var selectpath = new FolderSelecter().FolderSelect();
                Data.OutputFolderPath = selectpath + @"\";
                OutputtextBox.Text = selectpath + @"\";
                Console.WriteLine("OutputPath: " + selectpath);
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var quickcon = new QuickConvert();

            quickcon.Run(files);
        }
    }
}
