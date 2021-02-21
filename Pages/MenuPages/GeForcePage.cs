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
    public partial class GeForcePage : Form
    {
        public GeForcePage()
        {
            InitializeComponent();
        }
        OnlineProducts onlineProducts = new OnlineProducts();
        private void GeForcePage_Load(object sender, EventArgs e)
        {
            onlineProducts.GETDATA(GeForcePage_flowLayoutPanel,OnlineProducts.PC_Category.geForce);
        }
    }
}
