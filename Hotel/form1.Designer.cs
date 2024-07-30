namespace Hotel
{
    partial class Romdoul
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Romdoul));
            username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username_txt.BorderRadius = 20;
            username_txt.CustomizableEdges = customizableEdges8;
            username_txt.DefaultText = "";
            username_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txt.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txt.Location = new Point(453, 270);
            username_txt.Margin = new Padding(4, 7, 4, 7);
            username_txt.Name = "username_txt";
            username_txt.PasswordChar = '\0';
            username_txt.PlaceholderText = "Enter Unsername";
            username_txt.SelectedText = "";
            username_txt.ShadowDecoration.CustomizableEdges = customizableEdges9;
            username_txt.Size = new Size(373, 57);
            username_txt.TabIndex = 0;
            username_txt.TextOffset = new Point(20, 0);
            username_txt.TextChanged += guna2TextBox1_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_login.BorderRadius = 20;
            btn_login.CustomizableEdges = customizableEdges10;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.FillColor = Color.Orange;
            btn_login.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(453, 449);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btn_login.Size = new Size(373, 54);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOG IN";
            btn_login.Click += btn_login_Click;
            // 
            // password_txt
            // 
            password_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password_txt.BorderRadius = 20;
            password_txt.CustomizableEdges = customizableEdges12;
            password_txt.DefaultText = "";
            password_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password_txt.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password_txt.Location = new Point(453, 356);
            password_txt.Margin = new Padding(4, 7, 4, 7);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.PlaceholderText = "Enter Password";
            password_txt.SelectedText = "";
            password_txt.ShadowDecoration.CustomizableEdges = customizableEdges13;
            password_txt.Size = new Size(373, 57);
            password_txt.TabIndex = 3;
            password_txt.TextOffset = new Point(20, 0);
            password_txt.TextChanged += guna2TextBox2_TextChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logo_hotel;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(399, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 150);
            panel1.TabIndex = 4;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImage = Properties.Resources.unchecked_169779;
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2CirclePictureBox1.Image = Properties.Resources.unchecked_169779;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(1171, 17);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(40, 40);
            guna2CirclePictureBox1.TabIndex = 12;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // Romdoul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 688);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(panel1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(btn_login);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Romdoul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2TextBox password_txt;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
