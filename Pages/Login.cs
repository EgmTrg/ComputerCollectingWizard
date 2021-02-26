using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
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

        OleDbConnection oleDB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ComputerCollectingWizard.mdb");

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
            #region SQL DATABASE COMMANDS
            /*try
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
            }*/
            #endregion
            // VALID DATABASE IS ACCESS. BECAUSE I DONT KNOW HOW TO ATTACH SQL .MDF FILE.
            #region ACCDB COMMANDS 'ACCESS'
            try
            {
                oleDB.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from Accounts Where Username = @p1", oleDB);
                cmd.Parameters.AddWithValue("@p1", username_Textbox.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (password_Textbox.Text.Equals(dr["Password"]))
                        Logged(true);
                    else
                        MessageBox.Show("Sifreniz Yanlis!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Logged(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oleDB.Close();
            }
            #endregion
        }

        private void register_iconbutton_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }

        #endregion
        private static void Logged(bool logged)
        {
            if (logged)
                new Main().Show();
            else
            {
                DialogResult result =
                    MessageBox.Show("Kayitli kullanici bulunamamaktadir. Kayit olmak istermisiniz?", "Want to Register?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    new Register().ShowDialog();
            }
        }
    }
}
