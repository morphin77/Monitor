﻿namespace KIP_Monitor
{
    partial class F_MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MainWindow));
            this.SS = new System.Windows.Forms.StatusStrip();
            this.SSL_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSL_Role = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSL_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSL_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSL_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeForDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.резервToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияСортировкиБревенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияРаспиловкиБревенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияСортировкиДосокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияВыведениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_ForConnect = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SS.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSL_User,
            this.SSL_Role,
            this.SSL_Message,
            this.SSL_Time,
            this.SSL_Date});
            this.SS.Location = new System.Drawing.Point(0, 420);
            this.SS.Name = "SS";
            this.SS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SS.Size = new System.Drawing.Size(907, 22);
            this.SS.TabIndex = 0;
            this.SS.Text = "statusStrip1";
            // 
            // SSL_User
            // 
            this.SSL_User.Name = "SSL_User";
            this.SSL_User.Size = new System.Drawing.Size(30, 17);
            this.SSL_User.Text = "User";
            // 
            // SSL_Role
            // 
            this.SSL_Role.Name = "SSL_Role";
            this.SSL_Role.Size = new System.Drawing.Size(0, 17);
            // 
            // SSL_Message
            // 
            this.SSL_Message.AutoSize = false;
            this.SSL_Message.Name = "SSL_Message";
            this.SSL_Message.Size = new System.Drawing.Size(1100, 17);
            // 
            // SSL_Time
            // 
            this.SSL_Time.Name = "SSL_Time";
            this.SSL_Time.Size = new System.Drawing.Size(0, 0);
            // 
            // SSL_Date
            // 
            this.SSL_Date.Name = "SSL_Date";
            this.SSL_Date.Size = new System.Drawing.Size(0, 0);
            // 
            // timeForDateTime
            // 
            this.timeForDateTime.Enabled = true;
            this.timeForDateTime.Tick += new System.EventHandler(this.timeForDateTime_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.резервToolStripMenuItem,
            this.линияСортировкиБревенToolStripMenuItem,
            this.линияРаспиловкиБревенToolStripMenuItem,
            this.линияСортировкиДосокToolStripMenuItem,
            this.линияВыведениеToolStripMenuItem,
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // резервToolStripMenuItem
            // 
            this.резервToolStripMenuItem.Name = "резервToolStripMenuItem";
            this.резервToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.резервToolStripMenuItem.Text = "Резерв";
            // 
            // линияСортировкиБревенToolStripMenuItem
            // 
            this.линияСортировкиБревенToolStripMenuItem.Name = "линияСортировкиБревенToolStripMenuItem";
            this.линияСортировкиБревенToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.линияСортировкиБревенToolStripMenuItem.Text = "Сортировка бревен";
            // 
            // линияРаспиловкиБревенToolStripMenuItem
            // 
            this.линияРаспиловкиБревенToolStripMenuItem.Name = "линияРаспиловкиБревенToolStripMenuItem";
            this.линияРаспиловкиБревенToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.линияРаспиловкиБревенToolStripMenuItem.Text = "Распиловка бревен";
            // 
            // линияСортировкиДосокToolStripMenuItem
            // 
            this.линияСортировкиДосокToolStripMenuItem.Name = "линияСортировкиДосокToolStripMenuItem";
            this.линияСортировкиДосокToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.линияСортировкиДосокToolStripMenuItem.Text = "Первичная сортировки досок";
            // 
            // линияВыведениеToolStripMenuItem
            // 
            this.линияВыведениеToolStripMenuItem.Name = "линияВыведениеToolStripMenuItem";
            this.линияВыведениеToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.линияВыведениеToolStripMenuItem.Text = "Выведение отходов";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            this.администрированиеToolStripMenuItem.Visible = false;
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // Timer_ForConnect
            // 
            this.Timer_ForConnect.Enabled = true;
            this.Timer_ForConnect.Tick += new System.EventHandler(this.Timer_ForConnect_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // F_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "F_MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.F_MainWindow_Load);
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStripStatusLabel SSL_User;
        private System.Windows.Forms.ToolStripStatusLabel SSL_Message;
        private System.Windows.Forms.ToolStripStatusLabel SSL_Time;
        private System.Windows.Forms.ToolStripStatusLabel SSL_Date;
        private System.Windows.Forms.Timer timeForDateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem резервToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияСортировкиБревенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияРаспиловкиБревенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияСортировкиДосокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияВыведениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel SSL_Role;
        private System.Windows.Forms.Timer Timer_ForConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}