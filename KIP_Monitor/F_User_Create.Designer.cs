namespace KIP_Monitor
{
    partial class F_User_Create
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
            this.tb_User_name = new System.Windows.Forms.TextBox();
            this.l_User_Name = new System.Windows.Forms.Label();
            this.l_User_Role = new System.Windows.Forms.Label();
            this.l_User_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.b_Insert_New_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_User_name
            // 
            this.tb_User_name.Location = new System.Drawing.Point(185, 26);
            this.tb_User_name.Name = "tb_User_name";
            this.tb_User_name.Size = new System.Drawing.Size(170, 20);
            this.tb_User_name.TabIndex = 0;
            // 
            // l_User_Name
            // 
            this.l_User_Name.AutoSize = true;
            this.l_User_Name.Location = new System.Drawing.Point(12, 29);
            this.l_User_Name.Name = "l_User_Name";
            this.l_User_Name.Size = new System.Drawing.Size(173, 13);
            this.l_User_Name.TabIndex = 1;
            this.l_User_Name.Text = "Фамилия и инициалы сотрудика";
            // 
            // l_User_Role
            // 
            this.l_User_Role.AutoSize = true;
            this.l_User_Role.Location = new System.Drawing.Point(12, 83);
            this.l_User_Role.Name = "l_User_Role";
            this.l_User_Role.Size = new System.Drawing.Size(32, 13);
            this.l_User_Role.TabIndex = 2;
            this.l_User_Role.Text = "Роль";
            // 
            // l_User_Password
            // 
            this.l_User_Password.AutoSize = true;
            this.l_User_Password.Location = new System.Drawing.Point(12, 56);
            this.l_User_Password.Name = "l_User_Password";
            this.l_User_Password.Size = new System.Drawing.Size(45, 13);
            this.l_User_Password.TabIndex = 3;
            this.l_User_Password.Text = "Пароль";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(185, 53);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(170, 20);
            this.tb_Password.TabIndex = 4;
            // 
            // cb_Role
            // 
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(185, 83);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(170, 21);
            this.cb_Role.TabIndex = 5;
            this.cb_Role.TextChanged += new System.EventHandler(this.cb_Role_TextChanged);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(280, 119);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 6;
            this.b_Cancel.Text = "Отмена";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // b_Insert_New_User
            // 
            this.b_Insert_New_User.Location = new System.Drawing.Point(185, 119);
            this.b_Insert_New_User.Name = "b_Insert_New_User";
            this.b_Insert_New_User.Size = new System.Drawing.Size(75, 23);
            this.b_Insert_New_User.TabIndex = 7;
            this.b_Insert_New_User.Text = "Сохранить";
            this.b_Insert_New_User.UseVisualStyleBackColor = true;
            this.b_Insert_New_User.Click += new System.EventHandler(this.b_Insert_New_User_Click);
            // 
            // F_User_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 154);
            this.Controls.Add(this.b_Insert_New_User);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.l_User_Password);
            this.Controls.Add(this.l_User_Role);
            this.Controls.Add(this.l_User_Name);
            this.Controls.Add(this.tb_User_name);
            this.Name = "F_User_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать пользоватля";
            this.Load += new System.EventHandler(this.F_User_Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_User_name;
        private System.Windows.Forms.Label l_User_Name;
        private System.Windows.Forms.Label l_User_Role;
        private System.Windows.Forms.Label l_User_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Button b_Insert_New_User;
    }
}