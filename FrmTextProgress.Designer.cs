namespace DZ2_Lists
{
    partial class FrmTextProgress
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbReadProgress = new ProgressBar();
            tbDirectory = new TextBox();
            btnRead = new Button();
            btnDir = new Button();
            SuspendLayout();
            // 
            // pbReadProgress
            // 
            pbReadProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbReadProgress.Location = new Point(12, 53);
            pbReadProgress.Name = "pbReadProgress";
            pbReadProgress.Size = new Size(620, 29);
            pbReadProgress.TabIndex = 0;
            // 
            // tbDirectory
            // 
            tbDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDirectory.Location = new Point(12, 12);
            tbDirectory.Name = "tbDirectory";
            tbDirectory.Size = new Size(416, 27);
            tbDirectory.TabIndex = 1;
            tbDirectory.Text = "Выберите файл, нажав кнопку Обзор";
            // 
            // btnRead
            // 
            btnRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRead.Location = new Point(538, 10);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 2;
            btnRead.Text = "Прочитать";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDir
            // 
            btnDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDir.Location = new Point(438, 11);
            btnDir.Name = "btnDir";
            btnDir.Size = new Size(94, 29);
            btnDir.TabIndex = 3;
            btnDir.Text = "Обзор";
            btnDir.UseVisualStyleBackColor = true;
            btnDir.Click += btnDir_Click;
            // 
            // FrmTextProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 97);
            Controls.Add(btnDir);
            Controls.Add(btnRead);
            Controls.Add(tbDirectory);
            Controls.Add(pbReadProgress);
            Name = "FrmTextProgress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Прогресс чтения файла";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbReadProgress;
        private TextBox tbDirectory;
        private Button btnRead;
        private Button btnDir;
    }
}
