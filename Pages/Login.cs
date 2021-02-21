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

namespace ComputerCollectingWizard
{
    public partial class Login : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=EGEMEN-PC\SQLEXPRESS;Initial Catalog=ComputerCollectingWizard;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        #region Header
        private void exit_ıconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimaze_ıconButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Buttons
        private void login_iconbutton_Click(object sender, EventArgs e)
        {

            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("Select * from Accounts", sql);
                SqlDataReader dr = cmd.ExecuteReader();
                bool login = false;
                while (dr.Read())
                {
                    string p1 = textBox1.Text, p2 = textBox2.Text;
                    if (p1.Equals(dr["Username"]) && p2.Equals(dr["Password"]))
                    {
                        login = true;
                        new Main().Show();
                    }
                }
                if (!login) MessageBox.Show("Üyeliğiniz Bulunmamaktadır.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            
        }

        private void register_iconbutton_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
        #endregion
    }
}
