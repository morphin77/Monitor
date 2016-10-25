namespace KIP_Monitor
{
    partial class F_Error
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
            this.b_Save_Error_Data = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.rtb_Incedents_Description = new System.Windows.Forms.RichTextBox();
            this.l_Error_Description = new System.Windows.Forms.Label();
            this.l_Reason = new System.Windows.Forms.Label();
            this.rtb_reason = new System.Windows.Forms.RichTextBox();
            this.l_Action = new System.Windows.Forms.Label();
            this.rtb_Action = new System.Windows.Forms.RichTextBox();
            this.l_Responsible = new System.Windows.Forms.Label();
            this.tb_Responsible = new System.Windows.Forms.TextBox();
            this.l_Start_time = new System.Windows.Forms.Label();
            this.dtp_start_date_time = new System.Windows.Forms.DateTimePicker();
            this.l_status = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_Save_Error_Data
            // 
            this.b_Save_Error_Data.Location = new System.Drawing.Point(597, 467);
            this.b_Save_Error_Data.Name = "b_Save_Error_Data";
            this.b_Save_Error_Data.Size = new System.Drawing.Size(80, 23);
            this.b_Save_Error_Data.TabIndex = 0;
            this.b_Save_Error_Data.Text = "Сохранить";
            this.b_Save_Error_Data.UseVisualStyleBackColor = true;
            this.b_Save_Error_Data.Click += new System.EventHandler(this.b_Save_Error_Data_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(773, 467);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // rtb_Incedents_Description
            // 
            this.rtb_Incedents_Description.Location = new System.Drawing.Point(16, 32);
            this.rtb_Incedents_Description.Name = "rtb_Incedents_Description";
            this.rtb_Incedents_Description.Size = new System.Drawing.Size(460, 116);
            this.rtb_Incedents_Description.TabIndex = 2;
            this.rtb_Incedents_Description.Text = "";
            // 
            // l_Error_Description
            // 
            this.l_Error_Description.AutoSize = true;
            this.l_Error_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Error_Description.Location = new System.Drawing.Point(12, 9);
            this.l_Error_Description.Name = "l_Error_Description";
            this.l_Error_Description.Size = new System.Drawing.Size(148, 20);
            this.l_Error_Description.TabIndex = 3;
            this.l_Error_Description.Text = "Описание ошибки:";
            // 
            // l_Reason
            // 
            this.l_Reason.AutoSize = true;
            this.l_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Reason.Location = new System.Drawing.Point(12, 166);
            this.l_Reason.Name = "l_Reason";
            this.l_Reason.Size = new System.Drawing.Size(79, 20);
            this.l_Reason.TabIndex = 4;
            this.l_Reason.Text = "Причина:";
            // 
            // rtb_reason
            // 
            this.rtb_reason.Location = new System.Drawing.Point(12, 189);
            this.rtb_reason.Name = "rtb_reason";
            this.rtb_reason.Size = new System.Drawing.Size(464, 116);
            this.rtb_reason.TabIndex = 5;
            this.rtb_reason.Text = "";
            // 
            // l_Action
            // 
            this.l_Action.AutoSize = true;
            this.l_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Action.Location = new System.Drawing.Point(12, 317);
            this.l_Action.Name = "l_Action";
            this.l_Action.Size = new System.Drawing.Size(81, 20);
            this.l_Action.TabIndex = 6;
            this.l_Action.Text = "Сделано:";
            // 
            // rtb_Action
            // 
            this.rtb_Action.Location = new System.Drawing.Point(12, 340);
            this.rtb_Action.Name = "rtb_Action";
            this.rtb_Action.Size = new System.Drawing.Size(464, 116);
            this.rtb_Action.TabIndex = 7;
            this.rtb_Action.Text = "";
            // 
            // l_Responsible
            // 
            this.l_Responsible.AutoSize = true;
            this.l_Responsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Responsible.Location = new System.Drawing.Point(482, 32);
            this.l_Responsible.Name = "l_Responsible";
            this.l_Responsible.Size = new System.Drawing.Size(125, 20);
            this.l_Responsible.TabIndex = 8;
            this.l_Responsible.Text = "Ответственый:";
            // 
            // tb_Responsible
            // 
            this.tb_Responsible.Location = new System.Drawing.Point(613, 32);
            this.tb_Responsible.Name = "tb_Responsible";
            this.tb_Responsible.Size = new System.Drawing.Size(235, 20);
            this.tb_Responsible.TabIndex = 9;
            // 
            // l_Start_time
            // 
            this.l_Start_time.AutoSize = true;
            this.l_Start_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Start_time.Location = new System.Drawing.Point(482, 72);
            this.l_Start_time.Name = "l_Start_time";
            this.l_Start_time.Size = new System.Drawing.Size(71, 20);
            this.l_Start_time.TabIndex = 10;
            this.l_Start_time.Text = "Начало:";
            // 
            // dtp_start_date_time
            // 
            this.dtp_start_date_time.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dtp_start_date_time.Location = new System.Drawing.Point(613, 72);
            this.dtp_start_date_time.Name = "dtp_start_date_time";
            this.dtp_start_date_time.Size = new System.Drawing.Size(235, 20);
            this.dtp_start_date_time.TabIndex = 11;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_status.Location = new System.Drawing.Point(482, 110);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(66, 20);
            this.l_status.TabIndex = 12;
            this.l_status.Text = "Статус:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Исправено/Выпонено поостью",
            "Не исправео/Не закочено"});
            this.cb_status.Location = new System.Drawing.Point(613, 112);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(235, 21);
            this.cb_status.TabIndex = 13;
            // 
            // F_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 502);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.dtp_start_date_time);
            this.Controls.Add(this.l_Start_time);
            this.Controls.Add(this.tb_Responsible);
            this.Controls.Add(this.l_Responsible);
            this.Controls.Add(this.rtb_Action);
            this.Controls.Add(this.l_Action);
            this.Controls.Add(this.rtb_reason);
            this.Controls.Add(this.l_Reason);
            this.Controls.Add(this.l_Error_Description);
            this.Controls.Add(this.rtb_Incedents_Description);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_Save_Error_Data);
            this.Name = "F_Error";
            this.Text = "Новая задача";
            this.Load += new System.EventHandler(this.F_Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Save_Error_Data;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label l_Error_Description;
        private System.Windows.Forms.Label l_Reason;
        private System.Windows.Forms.RichTextBox rtb_reason;
        private System.Windows.Forms.Label l_Action;
        private System.Windows.Forms.RichTextBox rtb_Action;
        private System.Windows.Forms.Label l_Responsible;
        private System.Windows.Forms.TextBox tb_Responsible;
        private System.Windows.Forms.Label l_Start_time;
        private System.Windows.Forms.DateTimePicker dtp_start_date_time;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.ComboBox cb_status;
        public System.Windows.Forms.RichTextBox rtb_Incedents_Description;
    }
}