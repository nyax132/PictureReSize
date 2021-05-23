
namespace PictureReSize
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FukusuCheckbox = new System.Windows.Forms.CheckBox();
            this.aspect_ratioCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputTypetextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputTypetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ytextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Xtextbox = new System.Windows.Forms.TextBox();
            this.HenkanButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.OutputtextBox = new System.Windows.Forms.TextBox();
            this.InputFileListBox = new System.Windows.Forms.ListBox();
            this.InputFileListRemoveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FukusuCheckbox);
            this.groupBox1.Controls.Add(this.aspect_ratioCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OutputTypetextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InputTypetextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Ytextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Xtextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(192, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本設定";
            // 
            // FukusuCheckbox
            // 
            this.FukusuCheckbox.AutoSize = true;
            this.FukusuCheckbox.Location = new System.Drawing.Point(9, 191);
            this.FukusuCheckbox.Name = "FukusuCheckbox";
            this.FukusuCheckbox.Size = new System.Drawing.Size(75, 22);
            this.FukusuCheckbox.TabIndex = 9;
            this.FukusuCheckbox.Text = "複数選択";
            this.FukusuCheckbox.UseVisualStyleBackColor = true;
            this.FukusuCheckbox.CheckedChanged += new System.EventHandler(this.FukusuCheckbox_CheckedChanged);
            // 
            // aspect_ratioCheckBox
            // 
            this.aspect_ratioCheckBox.AutoSize = true;
            this.aspect_ratioCheckBox.Checked = true;
            this.aspect_ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aspect_ratioCheckBox.Location = new System.Drawing.Point(9, 155);
            this.aspect_ratioCheckBox.Name = "aspect_ratioCheckBox";
            this.aspect_ratioCheckBox.Size = new System.Drawing.Size(159, 22);
            this.aspect_ratioCheckBox.TabIndex = 8;
            this.aspect_ratioCheckBox.Text = "アスペクト比を維持する";
            this.aspect_ratioCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "➖➖➖➖➖➖➖➖➖➖➖";
            // 
            // OutputTypetextbox
            // 
            this.OutputTypetextbox.Location = new System.Drawing.Point(108, 101);
            this.OutputTypetextbox.Name = "OutputTypetextbox";
            this.OutputTypetextbox.Size = new System.Drawing.Size(75, 25);
            this.OutputTypetextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "出力拡張子";
            // 
            // InputTypetextbox
            // 
            this.InputTypetextbox.Location = new System.Drawing.Point(108, 66);
            this.InputTypetextbox.Name = "InputTypetextbox";
            this.InputTypetextbox.Size = new System.Drawing.Size(75, 25);
            this.InputTypetextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "読み取る拡張子";
            // 
            // Ytextbox
            // 
            this.Ytextbox.Location = new System.Drawing.Point(108, 25);
            this.Ytextbox.Name = "Ytextbox";
            this.Ytextbox.Size = new System.Drawing.Size(75, 25);
            this.Ytextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // Xtextbox
            // 
            this.Xtextbox.Location = new System.Drawing.Point(6, 25);
            this.Xtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Xtextbox.Name = "Xtextbox";
            this.Xtextbox.Size = new System.Drawing.Size(75, 25);
            this.Xtextbox.TabIndex = 0;
            // 
            // HenkanButton
            // 
            this.HenkanButton.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HenkanButton.Location = new System.Drawing.Point(12, 334);
            this.HenkanButton.Name = "HenkanButton";
            this.HenkanButton.Size = new System.Drawing.Size(578, 65);
            this.HenkanButton.TabIndex = 1;
            this.HenkanButton.Text = "変換";
            this.HenkanButton.UseVisualStyleBackColor = true;
            this.HenkanButton.Click += new System.EventHandler(this.HenkanButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputButton.Location = new System.Drawing.Point(12, 240);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(286, 65);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "入力";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutputButton.Location = new System.Drawing.Point(304, 240);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(286, 65);
            this.OutputButton.TabIndex = 3;
            this.OutputButton.Text = "出力";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(12, 303);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.ReadOnly = true;
            this.InputtextBox.Size = new System.Drawing.Size(286, 25);
            this.InputtextBox.TabIndex = 4;
            // 
            // OutputtextBox
            // 
            this.OutputtextBox.Location = new System.Drawing.Point(304, 303);
            this.OutputtextBox.Name = "OutputtextBox";
            this.OutputtextBox.ReadOnly = true;
            this.OutputtextBox.Size = new System.Drawing.Size(286, 25);
            this.OutputtextBox.TabIndex = 5;
            // 
            // InputFileListBox
            // 
            this.InputFileListBox.FormattingEnabled = true;
            this.InputFileListBox.ItemHeight = 18;
            this.InputFileListBox.Location = new System.Drawing.Point(210, 13);
            this.InputFileListBox.Name = "InputFileListBox";
            this.InputFileListBox.Size = new System.Drawing.Size(374, 184);
            this.InputFileListBox.TabIndex = 6;
            // 
            // InputFileListRemoveButton
            // 
            this.InputFileListRemoveButton.Location = new System.Drawing.Point(507, 203);
            this.InputFileListRemoveButton.Name = "InputFileListRemoveButton";
            this.InputFileListRemoveButton.Size = new System.Drawing.Size(77, 23);
            this.InputFileListRemoveButton.TabIndex = 7;
            this.InputFileListRemoveButton.Text = "削除";
            this.InputFileListRemoveButton.UseVisualStyleBackColor = true;
            this.InputFileListRemoveButton.Click += new System.EventHandler(this.InputFileListRemoveButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.InputFileListRemoveButton);
            this.Controls.Add(this.InputFileListBox);
            this.Controls.Add(this.OutputtextBox);
            this.Controls.Add(this.InputtextBox);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.HenkanButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Picture Resize 2";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Ytextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Xtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputTypetextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTypetextbox;
        private System.Windows.Forms.Button HenkanButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.TextBox OutputtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox aspect_ratioCheckBox;
        private System.Windows.Forms.CheckBox FukusuCheckbox;
        private System.Windows.Forms.ListBox InputFileListBox;
        private System.Windows.Forms.Button InputFileListRemoveButton;
    }
}

