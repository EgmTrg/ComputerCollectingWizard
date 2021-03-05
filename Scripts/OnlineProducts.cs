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
            string CATEGORY_URL = GetCategoryUrl(category);
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

                    new CreateProductBox().NewItemBox(currentFLPanel, p_URL, p_NAME, p_PRICE, category);
                }
            }
            else
            {
                foreach (var product in productListItems)
                {
                    string p_NAME = product.GetAttributeValue("data-name", "");
                    string p_URL = _INCEHESAPADRESS + product.GetAttributeValue("href", "");
                    string p_PRICE = product.GetAttributeValue("data-price", "");

                    new CreateProductBox().NewItemBox(currentFLPanel, p_URL, p_NAME, p_PRICE, category);
                }
            }
        }

        private string GetCategoryUrl(PC_Category category)
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

        internal void OpenURL(string url)
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
}
