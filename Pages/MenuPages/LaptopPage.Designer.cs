
namespace ComputerCollectingWizard.Pages.MenuPages
{
    partial class LaptopPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filter_panel = new System.Windows.Forms.Panel();
            this.LaptopPage_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // filter_panel
            // 
            this.filter_panel.AutoScroll = true;
            this.filter_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filter_panel.Location = new System.Drawing.Point(0, 0);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(194, 450);
            this.filter_panel.TabIndex = 0;
            // 
            // LaptopPage_flowLayoutPanel
            // 
            this.LaptopPage_flowLayoutPanel.AutoScroll = true;
            this.LaptopPage_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaptopPage_flowLayoutPanel.Location = new System.Drawing.Point(194, 0);
            this.LaptopPage_flowLayoutPanel.Name = "LaptopPage_flowLayoutPanel";
            this.LaptopPage_flowLayoutPanel.Size = new System.Drawing.Size(606, 450);
            this.LaptopPage_flowLayoutPanel.TabIndex = 1;
            // 
            // LaptopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaptopPage_flowLayoutPanel);
            this.Controls.Add(this.filter_panel);
            this.Name = "LaptopPage";
            this.Text = "LaptopPage";
            this.Load += new System.EventHandler(this.LaptopPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.FlowLayoutPanel LaptopPage_flowLayoutPanel;
    }
}