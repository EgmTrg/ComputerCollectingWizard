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

namespace ComputerCollectingWizard.Pages.MenuPages
{
    public partial class LaptopPage : Form
    {
        public LaptopPage()
        {
            InitializeComponent();
        }
        OnlineProducts onlineProducts = new OnlineProducts();
        private void LaptopPage_Load(object sender, EventArgs e)
        {
            onlineProducts.GETDATA(LaptopPage_flowLayoutPanel, OnlineProducts.PC_Category.Laptop);
        }
    }
}
