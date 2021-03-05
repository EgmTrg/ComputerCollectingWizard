using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCollectingWizard.Scripts
{
    class CreateProductBox : OnlineProducts
    {
        internal void NewItemBox(FlowLayoutPanel FlowPanel, string URL, string P_name, string P_price, PC_Category category)
        {
            //ProductImages pi = new ProductImages();
            Panel pnl = new Panel();
            PictureBox pbox = new PictureBox();
            Label lbl1 = new Label();
            Label lbl2 = new Label();
            IconButton ibutton1 = new IconButton();
            IconButton ibutton2 = new IconButton();
            FlowPanel.Controls.Add(pnl);

            pnl.Size = new Size(285, 300);
            pnl.Controls.Add(pbox);

            pbox.Size = new Size(230, 205);
            pbox.Location = new Point(31, 9);
            pbox.Image = new ProductImage().CategoryControl(category, double.Parse(P_price) / 100);
            pbox.SizeMode = PictureBoxSizeMode.Zoom;
            pbox.Click += (eventSender, eventArg) => base.OpenURL(URL);

            pnl.Controls.Add(lbl1);
            lbl1.Location = new Point(28, 220);
            lbl1.AutoSize = false;
            lbl1.Size = new Size(223, 25);
            lbl1.Text = P_name;
            lbl1.Click += (eventSender, eventArg) => OpenURL(URL);
            #region info for above sentence
            // Yukaridaki eventSender ve eventArg degisken isimleri Sender ve eventArgs turunden birer degiskendir.
            // Bu kod lbl1 olustuktan sonra calisacagi icin hata vermiyor.
            // => (Lambda) operatoru ise şu anlama geliyor;
            // (eventSender, eventArgs) Değişkenlerini al OpenURL' fonksiyonuna git.
            #endregion

            pnl.Controls.Add(lbl2);
            lbl2.Location = new Point(28, 249);
            lbl2.AutoSize = false;
            lbl2.Size = new Size(151, 21);
            lbl2.Text = P_price.ToString() + " TL";


            pnl.Controls.Add(ibutton1);
            ibutton1.Location = new Point(195, 249);
            ibutton1.Size = new Size(30, 30);
            ibutton1.FlatStyle = FlatStyle.Flat;
            ibutton1.IconChar = IconChar.Star;
            ibutton1.IconSize = 32;
            ibutton1.Text = "";

            pnl.Controls.Add(ibutton2);
            ibutton2.Location = new Point(231, 249);
            ibutton2.Size = new Size(30, 30);
            ibutton2.FlatStyle = FlatStyle.Flat;
            ibutton2.IconChar = IconChar.ShoppingBasket;
            ibutton2.IconSize = 32;
            ibutton2.Text = "";

            foreach (Control control in pnl.Controls)
            {
                control.Cursor = Cursors.Hand;
            }

            new CustomFont().Itembox_Font(pnl, 13);
        }
    }
}
