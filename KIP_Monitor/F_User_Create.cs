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
    public partial class F_User_Create : Form
    {
        int role_id;
        public F_User_Create()
        {
            InitializeComponent();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void b_Insert_New_User_Click(object sender, EventArgs e)
        {
            Sql.ConnectDb("INSERT INTO Users (UserName, Password, id_role) VALUES ('" + tb_User_name.Text + "', '" + tb_Password.Text + "', '" + role_id + "')");
            //todo:сделать перезагрузку dataBinding на F_User_mangment
            this.Close();
        }

        private void cb_Role_TextChanged(object sender, EventArgs e)
        {
            Sql.ConnectDb("SELECT id_role FROM Role WHERE Role.Role like '%" + cb_Role.Text + "%'");
            role_id = Convert.ToInt32(Sql.DataSet.Tables[0].Rows[0]["id_role"]);
        }

        private void F_User_Create_Load(object sender, EventArgs e)
        {
            Sql.ConnectDb("SELECT Role FROM Role");
            for (int i = 0; i < Sql.DataSet.Tables[0].Rows.Count; i++)
            {
                cb_Role.Items.Add(Sql.DataSet.Tables[0].Rows[i]["Role"].ToString());
            }
        }
    }
}
