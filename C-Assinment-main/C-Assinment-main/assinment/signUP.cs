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

namespace assinment
{
    public partial class signUP : Form
    {
        public signUP()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-F5UT3VQ\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();


            string Query = "Insert into SignUp values ('" + this.txtUserName.Text + "','" + this.txtEmailName.Text + "','" + this.txtPassword.Text + "');";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Successfully Inserted");
        }
    }
}
