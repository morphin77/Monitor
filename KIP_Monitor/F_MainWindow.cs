using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KIP_Monitor
{
    public partial class F_MainWindow : Form
    {
        public F_MainWindow()
        {
            InitializeComponent();
        }

        private void F_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timeForDateTime_Tick(object sender, EventArgs e)
        {
            SSL_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            SSL_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void F_MainWindow_Load(object sender, EventArgs e)
        {
            SSL_Role.Text = F_Auth.Role;
            SSL_User.Text = F_Auth.CurrentUser;
            if (SSL_Role.Text == "Администратор")
            {
                администрированиеToolStripMenuItem.Visible = true;         
            }
        }

        private void Timer_ForConnect_Tick(object sender, EventArgs e)
        {
            SiemensPLC_319F_3.connectTo();
            for (int i = 0; i < SiemensPLC_319F_3.ThreeLinePB11Errors1.Rank; i++)
            {
                label1.Text = SiemensPLC_319F_3.memoryRes1.ToString();
            }

            for (int i = 0; i < SiemensPLC_319F_3.ThreeLinePB11Errors2.Rank; i++)
            {
                    label2.Text = SiemensPLC_319F_3.ThreeLinePB11Errors2[i].ToString();
            }

            for (int i = 0; i < SiemensPLC_319F_3.ThreeLinePB11Errors3.Rank; i++)
            {
                    label3.Text = SiemensPLC_319F_3.ThreeLinePB11Errors3[i].ToString();
            }
        }
    }
}
