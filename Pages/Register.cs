using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.OleDb;

namespace ComputerCollectingWizard
{
    public partial class Register : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=EGEMEN-PC\SQLEXPRESS;Initial Catalog=ComputerCollectingWizard;Integrated Security=True");

        OleDbConnection oleDB = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ComputerCollectingWizard.mdb");

        public Register()
        {
            InitializeComponent();
        }

        private void exit_ıconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimaze_ıconButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void register_iconbutton_Click(object sender, EventArgs e)
        {
            if (TextBoxController())
            {
                MessageBox.Show("Lutfen Alanlari Doldurunuz.");
                return;
            }
            #region SQL DB Commands
            /*try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(
                    "insert into Accounts(NameSurname,Username,Password,Email) values (@p1,@p2,@p3,@p4)", sql);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", textBox4.Text);
                cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added!");
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
            #region ACCDB Kodlari
            try
            {
                oleDB.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Accounts([Name/Surname],[Username],[Password],[Email]) values(@p1,@p2,@p3,@p4)", oleDB);
                cmd.Parameters.AddWithValue("@p1",nameSurname_textBox.Text);
                cmd.Parameters.AddWithValue("@p2",username_textBox.Text);
                cmd.Parameters.AddWithValue("@p3",password_maskedTextBox.Text);
                cmd.Parameters.AddWithValue("@p4",email_textBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Basariyla kayit olundu.");
                this.Close();
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

        private bool TextBoxController()
        {
            bool isFull = false;
            List<TextBox> tboxList = new List<TextBox>();
            tboxList.Add(nameSurname_textBox);
            tboxList.Add(username_textBox);
            tboxList.Add(email_textBox);
            tboxList.Add(email2_textBox);
            foreach (TextBox item in tboxList)
            {
                if (isFull)
                    return isFull;
                if (item.Text == "" || item.Text == null)
                    isFull = true;
            }

            if (
                (!password_maskedTextBox.Text.Equals(null) || !password2_maskedTextBox.Text.Equals(null))
                    && 
                (!password_maskedTextBox.Text.Equals(password2_maskedTextBox.Text) || !tboxList[2].Text.Equals(tboxList[3].Text))
               )
                return true;
            return isFull;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
