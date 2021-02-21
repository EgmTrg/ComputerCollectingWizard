using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ComputerCollectingWizard.Scripts
{
    internal class CustomFont
    {
        System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();

        public CustomFont()
        {
            string fontpath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            File.WriteAllBytes(fontpath, Properties.Resources.Roboto_Light);
            pfc.AddFontFile(fontpath);
        }

        public void CustomFontLoader(Panel panel, int FontSize)
        {
            foreach (Control control in panel.Controls)
                control.Font = new Font(pfc.Families[0], FontSize, FontStyle.Regular);
        }

        public void Itembox_Font(Panel panel, int fontsize)
        {
            foreach (Control control in panel.Controls)
                control.Font = new Font("Comic Sans MS", fontsize, FontStyle.Regular);
        }
    }
}