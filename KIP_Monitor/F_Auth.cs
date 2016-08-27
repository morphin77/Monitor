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
            if (tb_Password.Text == TB_PasswordBase.Text)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mDS_Get_Auth_Data.Get_Auth_data". При необходимости она может быть перемещена или удалена.
            this.get_Auth_dataTableAdapter.Fill(this.mDS_Get_Auth_Data.Get_Auth_data);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitorDataSet1.Get_Auth_data". При необходимости она может быть перемещена или удалена.







        }


    }
}
