using ComputerCollectingWizard.Pages;
using ComputerCollectingWizard.Pages.MenuPages;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Xml;

namespace ComputerCollectingWizard
{
    public partial class Main : Form
    {
        //GLOBAL VARIABLES:
        private Form validPage;
        //END OF GLOBAL VARIABLES
        #region Moveable App Panel and Header Buttons Code.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_ıconButton_Click(object sender, EventArgs e)
        {
            validPage.Close();
            Application.Exit();
        }

        private void maximize_ıconButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            //It fill up in the gaps when app is fullscreen.
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        #endregion
        #region MenuButtons Methods
        private void menu_iconButton_Click(object sender, EventArgs e)
        {
            if (Menu_Panel.Width.Equals(246))
                Menu_Panel.Width = 55;
            else
                Menu_Panel.Width = 246;
        }
        private void OpenPage(Form CurrentPage)
        {
            if (validPage != null)
                validPage.Close();

            validPage = CurrentPage;
            CurrentPage.TopLevel = false;
            CurrentPage.FormBorderStyle = FormBorderStyle.None;
            CurrentPage.Dock = DockStyle.Fill;

            PageController_Panel.Controls.Add(CurrentPage);
            CurrentPage.BringToFront();
            CurrentPage.Show();
        }
        private void OpenPage(object sender, EventArgs e)
        {
            switch ((sender as IconButton).AccessibleName)
            {
                case "DesktopPageButton":
                    OpenPage(new DesktopPage());
                    break;
                case "LaptopPageButton":
                    OpenPage(new LaptopPage());
                    break;
                case "AllinOnePageButton":
                    OpenPage(new AllinOnePage());
                    break;
                case "GeForcePageButton":
                    OpenPage(new GeForcePage());
                    break;
            }
        }
        #endregion
        private void Currency()
        {
            const string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(url);
            DateTime date = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string eur = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            time_label.Text = string.Format("Tarih: " + date.ToShortDateString());
            usd_label.Text = string.Format("USD: {0} TL", usd);
            euro_label.Text = " Euro: " + eur + " TL";
        }

        public Main()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenPage(new HomePage());
            Currency();
        }
    }
}
