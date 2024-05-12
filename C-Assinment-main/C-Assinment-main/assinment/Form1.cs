using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace assinment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-F5UT3VQ\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();


            string Query = "SELECT * FROM login WHERE UserName='" + this.txtUserId.Text + "' AND Password='" + this.txtPassword.Text + "' ";
            SqlCommand sqlcom = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

           
           
            
            try
            {
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Log in Successfully");
                    loginPage l1 = new loginPage();
                    l1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                    signUP s1 = new signUP();
                    s1.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();

            }



        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUP s1 = new signUP();
            s1.ShowDialog();

        }
    }
}
