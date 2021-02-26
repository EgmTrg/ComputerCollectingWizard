
namespace ComputerCollectingWizard
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_iconbutton = new FontAwesome.Sharp.IconButton();
            this.register_iconbutton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minimaze_ıconButton = new FontAwesome.Sharp.IconButton();
            this.exit_ıconButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_Textbox
            // 
            this.username_Textbox.BackColor = System.Drawing.Color.Snow;
            this.username_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_Textbox.Location = new System.Drawing.Point(151, 54);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(247, 31);
            this.username_Textbox.TabIndex = 1;
            // 
            // password_Textbox
            // 
            this.password_Textbox.BackColor = System.Drawing.Color.Snow;
            this.password_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_Textbox.Location = new System.Drawing.Point(151, 96);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(247, 31);
            this.password_Textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanici Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre:";
            // 
            // login_iconbutton
            // 
            this.login_iconbutton.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_iconbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.login_iconbutton.IconColor = System.Drawing.Color.Black;
            this.login_iconbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.login_iconbutton.Location = new System.Drawing.Point(281, 133);
            this.login_iconbutton.Name = "login_iconbutton";
            this.login_iconbutton.Size = new System.Drawing.Size(116, 37);
            this.login_iconbutton.TabIndex = 3;
            this.login_iconbutton.Text = "Login";
            this.login_iconbutton.UseVisualStyleBackColor = true;
            this.login_iconbutton.Click += new System.EventHandler(this.login_iconbutton_Click);
            // 
            // register_iconbutton
            // 
            this.register_iconbutton.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_iconbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.register_iconbutton.IconColor = System.Drawing.Color.Black;
            this.register_iconbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.register_iconbutton.Location = new System.Drawing.Point(151, 133);
            this.register_iconbutton.Name = "register_iconbutton";
            this.register_iconbutton.Size = new System.Drawing.Size(116, 37);
            this.register_iconbutton.TabIndex = 4;
            this.register_iconbutton.Text = "Register";
            this.register_iconbutton.UseVisualStyleBackColor = true;
            this.register_iconbutton.Click += new System.EventHandler(this.register_iconbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.minimaze_ıconButton);
            this.panel1.Controls.Add(this.exit_ıconButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 35);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerCollectingWizard.Properties.Resources.Ava1219_Littlear_Computer;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Computer Collecting Wizard Software";
            // 
            // minimaze_ıconButton
            // 
            this.minimaze_ıconButton.FlatAppearance.BorderSize = 0;
            this.minimaze_ıconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimaze_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimaze_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimaze_ıconButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimaze_ıconButton.IconColor = System.Drawing.Color.Black;
            this.minimaze_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimaze_ıconButton.IconSize = 32;
            this.minimaze_ıconButton.Location = new System.Drawing.Point(340, 3);
            this.minimaze_ıconButton.Name = "minimaze_ıconButton";
            this.minimaze_ıconButton.Size = new System.Drawing.Size(26, 29);
            this.minimaze_ıconButton.TabIndex = 98;
            this.minimaze_ıconButton.UseVisualStyleBackColor = true;
            this.minimaze_ıconButton.Click += new System.EventHandler(this.minimaze_ıconButton_Click);
            // 
            // exit_ıconButton
            // 
            this.exit_ıconButton.FlatAppearance.BorderSize = 0;
            this.exit_ıconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_ıconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exit_ıconButton.IconColor = System.Drawing.Color.Black;
            this.exit_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_ıconButton.IconSize = 32;
            this.exit_ıconButton.Location = new System.Drawing.Point(377, 3);
            this.exit_ıconButton.Name = "exit_ıconButton";
            this.exit_ıconButton.Size = new System.Drawing.Size(26, 29);
            this.exit_ıconButton.TabIndex = 99;
            this.exit_ıconButton.UseVisualStyleBackColor = true;
            this.exit_ıconButton.Click += new System.EventHandler(this.exit_ıconButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(407, 178);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_iconbutton);
            this.Controls.Add(this.login_iconbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_Textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton login_iconbutton;
        private FontAwesome.Sharp.IconButton register_iconbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton minimaze_ıconButton;
        private FontAwesome.Sharp.IconButton exit_ıconButton;
    }
}

