namespace DZ2_Lists
{
    partial class FrmResume
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMain = new ListBox();
            tbFirstName = new TextBox();
            tbSureName = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnMod = new Button();
            btnDel = new Button();
            btnLoadFromFile = new Button();
            btnSaveToFile = new Button();
            SuspendLayout();
            // 
            // lbMain
            // 
            lbMain.FormattingEnabled = true;
            lbMain.Location = new Point(12, 12);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(188, 164);
            lbMain.TabIndex = 0;
            lbMain.SelectedIndexChanged += lbMain_SelectedIndexChanged;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(288, 12);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(125, 27);
            tbFirstName.TabIndex = 1;
            // 
            // tbSureName
            // 
            tbSureName.Location = new Point(288, 45);
            tbSureName.Name = "tbSureName";
            tbSureName.Size = new Size(125, 27);
            tbSureName.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(288, 78);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(288, 111);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(125, 27);
            tbPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 48);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Фамилия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 81);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 114);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Телефон:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(12, 217);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(188, 29);
            btnMod.TabIndex = 10;
            btnMod.Text = "Изменить";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(12, 252);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(188, 29);
            btnDel.TabIndex = 11;
            btnDel.Text = "Удалить";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(263, 252);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(157, 29);
            btnLoadFromFile.TabIndex = 12;
            btnLoadFromFile.Text = "Загрузить из файла";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(263, 217);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(157, 29);
            btnSaveToFile.TabIndex = 13;
            btnSaveToFile.Text = "Сохранить в файл";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // FrmResume
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 297);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnLoadFromFile);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbSureName);
            Controls.Add(tbFirstName);
            Controls.Add(lbMain);
            Name = "FrmResume";
            Text = "FrmResume";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbMain;
        private TextBox tbFirstName;
        private TextBox tbSureName;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnMod;
        private Button btnDel;
        private Button btnLoadFromFile;
        private Button btnSaveToFile;
    }
}