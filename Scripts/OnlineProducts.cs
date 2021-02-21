using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ComputerCollectingWizard.Scripts
{
    class OnlineProducts
    {
        CustomFont customFont = new CustomFont();
        const string _INCEHESAPADRESS = "https://www.incehesap.com";

        public enum PC_Category
        {
            AllinOne,
            Dekstop,
            geForce,
            Laptop,
        }

        public async void GETDATA(FlowLayoutPanel currentFLPanel, PC_Category category)
        {
            string CATEGORY_URL = TakeCategoryUrl(category);
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(CATEGORY_URL);

            var htmlDOC = new HtmlAgilityPack.HtmlDocument();
            htmlDOC.LoadHtml(html.ToString());

            var productHTML = htmlDOC.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("product-list")).ToList();

            var productListItems = productHTML[0].Descendants("a")
            .Where(node => node.GetAttributeValue("itemprop", "")
            .Equals("url")).ToList();

            if (category == PC_Category.geForce)
            {
                var productListItemsGEFORCE = productHTML[0].Descendants("a")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("product-link ihlog")).ToList();

                foreach (var product in productListItemsGEFORCE)
                {
                    string p_NAME = product.GetAttributeValue("data-name", "");
                    string p_URL = _INCEHESAPADRESS + product.GetAttributeValue("href", "");
                    string p_PRICE = product.GetAttributeValue("data-price", "");

                    NewItemBox(currentFLPanel, p_URL, p_NAME, p_PRICE, category);
                }
            }
            else
            {
                foreach (var product in productListItems)
                {
                    string p_NAME = product.GetAttributeValue("data-name", "");
                    string p_URL = _INCEHESAPADRESS + product.GetAttributeValue("href", "");
                    string p_PRICE = product.GetAttributeValue("data-price", "");

                    NewItemBox(currentFLPanel, p_URL, p_NAME, p_PRICE, category);
                }
            }
        }

        private string TakeCategoryUrl(PC_Category category)
        {
            switch (category)
            {
                case PC_Category.AllinOne: return "https://www.incehesap.com/all-in-one-pc-fiyatlari";
                case PC_Category.Dekstop: return "https://www.incehesap.com/hazir-sistemler-fiyatlari";
                case PC_Category.geForce: return "https://www.incehesap.com/q/geForce/geforce-hazir-sistemler/";
                case PC_Category.Laptop: return "https://www.incehesap.com/gaming-notebook-fiyatlari/";
                default: return null;
            }
        }

        private void NewItemBox(FlowLayoutPanel FlowPanel, string URL, string P_name, string P_price, PC_Category category)
        {
            ProductImages pi = new ProductImages();
            Panel pnl = new Panel();
            PictureBox pbox = new PictureBox();
            Label lbl1 = new Label();
            Label lbl2 = new Label();
            IconButton ibutton1 = new IconButton();
            IconButton ibutton2 = new IconButton();
            FlowPanel.Controls.Add(pnl);

            pnl.Size = new Size(290, 303);
            pnl.Controls.Add(pbox);

            pbox.Size = new Size(230, 205);
            pbox.Location = new Point(31, 9);
            pbox.Image = pi.CategoryControl(category, double.Parse(P_price) / 100);
            pbox.SizeMode = PictureBoxSizeMode.Zoom;
            pbox.Click += (eventSender, eventArg) => OpenURL(URL);

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
            ibutton1.Padding = new Padding(0, 0, 7, 0);
            ibutton1.FlatStyle = FlatStyle.Flat;
            ibutton1.IconChar = IconChar.Star;
            ibutton1.IconSize = 32;
            ibutton1.Text = "";

            pnl.Controls.Add(ibutton2);
            ibutton2.Location = new Point(231, 249);
            ibutton2.Size = new Size(30, 30);
            ibutton2.Padding = new Padding(0, 0, 7, 0);
            ibutton2.FlatStyle = FlatStyle.Flat;
            ibutton2.IconChar = IconChar.ShoppingBasket;
            ibutton2.IconSize = 32;
            ibutton2.Text = "";

            foreach (Control control in pnl.Controls)
            {
                control.Cursor = Cursors.Hand;
            }

            customFont.Itembox_Font(pnl, 13);
        }

        private void OpenURL(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (System.Exception e)
            {
                if (e.Message == "Dosya adı verilmediğinden işlem başlatılamıyor.")
                {
                    MessageBox.Show("URL Boş", "URL Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

    class ProductImages
    {
        public Image CategoryControl(OnlineProducts.PC_Category category, double price)
        {
            switch (category)
            {
                case OnlineProducts.PC_Category.AllinOne:
                    return AllinOne(price);
                case OnlineProducts.PC_Category.Dekstop:
                    return Desktop(price);
                case OnlineProducts.PC_Category.geForce:
                    return Desktop(price);
                case OnlineProducts.PC_Category.Laptop:
                    return Laptop(price);
                default: return null;
            }
        }

        public Image AllinOne(double Price)
        {
            string grade = null;

            if (Price < 4500.00)
                grade = "low";
            else if (Price < 7000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowAIO;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumAIO;
                    }
                case "high":
                    {
                        return Properties.Resources.highAIO;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
        public Image Desktop(double Price)
        {
            string grade = null;

            if (Price < 3000.00)
                grade = "low";
            else if (Price < 6000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowDP;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumDP;
                    }
                case "high":
                    {
                        return Properties.Resources.highDP;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
        public Image Laptop(double Price)
        {
            string grade = null;

            if (Price < 7000.00)
                grade = "low";
            else if (Price < 15000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowLAPTOP;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumLAPTOP;
                    }
                case "high":
                    {
                        return Properties.Resources.highLAPTOP;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
    }
}
