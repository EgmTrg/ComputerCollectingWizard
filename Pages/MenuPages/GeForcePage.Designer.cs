
namespace ComputerCollectingWizard.Pages.MenuPages
{
    partial class GeForcePage
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
            this.GeForcePage_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filter_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GeForcePage_flowLayoutPanel
            // 
            this.GeForcePage_flowLayoutPanel.AutoScroll = true;
            this.GeForcePage_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeForcePage_flowLayoutPanel.Location = new System.Drawing.Point(194, 0);
            this.GeForcePage_flowLayoutPanel.Name = "GeForcePage_flowLayoutPanel";
            this.GeForcePage_flowLayoutPanel.Size = new System.Drawing.Size(606, 450);
            this.GeForcePage_flowLayoutPanel.TabIndex = 3;
            // 
            // filter_panel
            // 
            this.filter_panel.AutoScroll = true;
            this.filter_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filter_panel.Location = new System.Drawing.Point(0, 0);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(194, 450);
            this.filter_panel.TabIndex = 2;
            // 
            // GeForcePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeForcePage_flowLayoutPanel);
            this.Controls.Add(this.filter_panel);
            this.Name = "GeForcePage";
            this.Text = "GeForcePage";
            this.Load += new System.EventHandler(this.GeForcePage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.FlowLayoutPanel GeForcePage_flowLayoutPanel;
    }
}