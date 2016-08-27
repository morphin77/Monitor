namespace KIP_Monitor
{
    partial class F_Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l_UserName = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.b_Enter = new System.Windows.Forms.Button();
            this.b_Exit = new System.Windows.Forms.Button();
            this.CB_UserName = new System.Windows.Forms.ComboBox();
            this.TB_PasswordBase = new System.Windows.Forms.TextBox();
            this.TB_role_Base = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_UserName
            // 
            this.l_UserName.AutoSize = true;
            this.l_UserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_UserName.Location = new System.Drawing.Point(3, 9);
            this.l_UserName.Name = "l_UserName";
            this.l_UserName.Size = new System.Drawing.Size(175, 22);
            this.l_UserName.TabIndex = 0;
            this.l_UserName.Text = "Имя Пользователя";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Password.Location = new System.Drawing.Point(3, 53);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(76, 22);
            this.l_Password.TabIndex = 1;
            this.l_Password.Text = "Пароль";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(200, 50);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(189, 29);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // b_Enter
            // 
            this.b_Enter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Enter.Location = new System.Drawing.Point(7, 99);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(91, 34);
            this.b_Enter.TabIndex = 4;
            this.b_Enter.Text = "Вход";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.b_Enter_Click);
            // 
            // b_Exit
            // 
            this.b_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Exit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Exit.Location = new System.Drawing.Point(298, 99);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(91, 34);
            this.b_Exit.TabIndex = 5;
            this.b_Exit.Text = "Выход";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // CB_UserName
            // 
            this.CB_UserName.DisplayMember = "UserName";
            this.CB_UserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_UserName.FormattingEnabled = true;
            this.CB_UserName.Location = new System.Drawing.Point(200, 9);
            this.CB_UserName.Name = "CB_UserName";
            this.CB_UserName.Size = new System.Drawing.Size(189, 30);
            this.CB_UserName.TabIndex = 6;
            this.CB_UserName.ValueMember = "UserName";
            this.CB_UserName.TextChanged += new System.EventHandler(this.CB_UserName_TextChanged);
            // 
            // TB_PasswordBase
            // 
            this.TB_PasswordBase.Location = new System.Drawing.Point(200, 53);
            this.TB_PasswordBase.Name = "TB_PasswordBase";
            this.TB_PasswordBase.ReadOnly = true;
            this.TB_PasswordBase.Size = new System.Drawing.Size(100, 20);
            this.TB_PasswordBase.TabIndex = 7;
            // 
            // TB_role_Base
            // 
            this.TB_role_Base.Location = new System.Drawing.Point(289, 57);
            this.TB_role_Base.Name = "TB_role_Base";
            this.TB_role_Base.ReadOnly = true;
            this.TB_role_Base.Size = new System.Drawing.Size(100, 20);
            this.TB_role_Base.TabIndex = 8;
            // 
            // bindingSource1
            // 
            this.bindingSource1.Position = 0;
            // 
            // F_Auth
            // 
            this.AcceptButton = this.b_Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_Exit;
            this.ClientSize = new System.Drawing.Size(399, 139);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.TB_PasswordBase);
            this.Controls.Add(this.CB_UserName);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.b_Enter);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_UserName);
            this.Controls.Add(this.TB_role_Base);
            this.Name = "F_Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.F_Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_UserName;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.ComboBox CB_UserName;
        private System.Windows.Forms.TextBox TB_PasswordBase;
        private System.Windows.Forms.TextBox TB_role_Base;
        private System.Windows.Forms.BindingSource bindingSource1;
        
    }
}

