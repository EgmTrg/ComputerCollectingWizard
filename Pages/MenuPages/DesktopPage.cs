using ComputerCollectingWizard.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCollectingWizard.Pages
{
    public partial class DesktopPage : Form
    {
        public DesktopPage()
        {
            InitializeComponent();
        }
        OnlineProducts onlineProducts = new OnlineProducts();
        private void DesktopPage_Load(object sender, EventArgs e)
        {
            onlineProducts.GETDATA(DesktopPage_flowLayoutPanel, OnlineProducts.PC_Category.Dekstop);
        }
    }
}
