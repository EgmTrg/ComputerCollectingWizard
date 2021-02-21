using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ComputerCollectingWizard
{
    public partial class Register : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source=EGEMEN-PC\SQLEXPRESS;Initial Catalog=ComputerCollectingWizard;Integrated Security=True");

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

            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(
                    "insert into Accounts(NameSurname,Username,Password,Email) values (@p1,@p2,@p3,@p4)", sql);
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", textBox4.Text);
                //cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Added!");
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

        private bool TextBoxController()
        {
            bool isFull = false;
            List<TextBox> tboxList = new List<TextBox>();
            tboxList.Add(textBox1);
            tboxList.Add(textBox2);
            tboxList.Add(textBox3);
            tboxList.Add(textBox4);
            foreach (TextBox item in tboxList)
            {
                if (isFull)
                    return isFull;
                if (item.Text == "" || item.Text == null)
                    isFull = true;
            }

            if (
                (!maskedTextBox1.Text.Equals(null) || !maskedTextBox2.Text.Equals(null))
                    && 
                (!maskedTextBox1.Text.Equals(maskedTextBox2.Text) || !tboxList[2].Text.Equals(tboxList[3].Text))
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
