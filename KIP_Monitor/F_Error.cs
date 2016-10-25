using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KIP_Monitor
{
    public partial class F_Error : Form
    {
        public static SqlConnection Connection;
        public static SqlCommand Request;
        public static SqlDataAdapter SqlDataAdapter;


        public F_Error()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Error_Load(object sender, EventArgs e)
        {
            tb_Responsible.Text = F_Auth.CurrentUser;
            dtp_start_date_time.Value = DateTime.Now;

        }

        private void b_Save_Error_Data_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=WIN-69V9K3A7J6U\\SQLEXPRESS;Initial Catalog=Monitor;Integrated Security=True"))

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Incedents VALUES(" + rtb_Incedents_Description.Text + "," + rtb_reason.Text + "," + rtb_Action.Text + "," + tb_Responsible.Text + ",@value," + DateTime.Now + "," + cb_status.Text + ")";
                cmd.Parameters.AddWithValue("@start_date_time", dtp_start_date_time.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
