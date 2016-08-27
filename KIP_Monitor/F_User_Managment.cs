using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIP_Monitor
{
    public partial class F_User_Managment : Form
    {
        public F_User_Managment()
        {
            InitializeComponent();
        }

        public void F_User_Managment_Load(object sender, EventArgs e)
        {
            Sql.ConnectDb("SELECT UserName, Password, Role  FROM Users, Role WHERE Role.id_role = Users.id_role");
            bindingSource1.DataSource = Sql.DataSet.Tables[0];
            bindingNavigator1.BindingSource = this.bindingSource1;
            dataGridView1.DataSource = this.bindingSource1;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            F_User_Create f = new F_User_Create();
            f.Show();
        }        
    }
}
