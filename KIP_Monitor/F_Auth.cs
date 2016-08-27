using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIP_Monitor
{
    public partial class F_Auth : Form
    {
        public static string CurrentUser;
        public static string Role;

        public F_Auth()
        {
            InitializeComponent();
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_Enter_Click(object sender, EventArgs e)
        {

            if (tb_Password.Text == TB_PasswordBase.Text && CB_UserName.Text!="")
            {
                Role = TB_role_Base.Text;
                CurrentUser = CB_UserName.Text;
                F_MainWindow f = new F_MainWindow();
                f.Show();
                this.Hide();
            }
            else
            {
                tb_Password.Clear();
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void F_Auth_Load(object sender, EventArgs e)
        {
            //заполняем список пользователей
            Sql.ConnectDb("SELECT UserName FROM Monitor.dbo.Users");
            for (int i = 0; i < Sql.DataSet.Tables[0].Rows.Count; i++)
            {
                CB_UserName.Items.Add(Sql.DataSet.Tables[0].Rows[i]["UserName"].ToString());
            }
         }
        
        private void CB_UserName_TextChanged(object sender, EventArgs e)
        {
           Sql.ConnectDb("SELECT Password, Role  FROM Users, Role WHERE Users.UserName like '%"+CB_UserName.Text+"%' AND Role.id_role = Users.id_role");
            TB_PasswordBase.Text = Sql.DataSet.Tables[0].Rows[0]["Password"].ToString();
            TB_role_Base.Text = Sql.DataSet.Tables[0].Rows[0]["Role"].ToString();
        }
    }
}
