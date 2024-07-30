namespace Hotel.checkout
{
    partial class check_out
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            line = new Panel();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            checkpn = new Guna.UI2.WinForms.Guna2TextBox();
            checkout_btn = new Guna.UI2.WinForms.Guna2Button();
            check_room = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            panel1 = new Panel();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label3 = new Label();
            panel2 = new Panel();
            error_alert1 = new alert.error_alert();
            verify1 = new verify();
            payment1 = new payment();
            checkout_success1 = new alert.checkout_success();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // line
            // 
            line.BackColor = Color.White;
            line.Location = new Point(3, 80);
            line.Name = "line";
            line.Size = new Size(1388, 5);
            line.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins ExtraBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(193, 51);
            label1.TabIndex = 13;
            label1.Text = "CHECK OUT";
            label1.Click += label1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // checkpn
            // 
            checkpn.BackColor = Color.NavajoWhite;
            checkpn.BorderRadius = 20;
            checkpn.CustomizableEdges = customizableEdges1;
            checkpn.DefaultText = "";
            checkpn.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            checkpn.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            checkpn.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            checkpn.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            checkpn.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            checkpn.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkpn.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            checkpn.Location = new Point(57, 149);
            checkpn.Margin = new Padding(5, 6, 5, 6);
            checkpn.Name = "checkpn";
            checkpn.PasswordChar = '\0';
            checkpn.PlaceholderText = "Phone Number";
            checkpn.SelectedText = "";
            checkpn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            checkpn.Size = new Size(555, 69);
            checkpn.TabIndex = 16;
            checkpn.TextOffset = new Point(10, 0);
            checkpn.TextChanged += checkpn_TextChanged;
            // 
            // checkout_btn
            // 
            checkout_btn.BackColor = Color.NavajoWhite;
            checkout_btn.BorderRadius = 20;
            checkout_btn.CustomizableEdges = customizableEdges3;
            checkout_btn.DisabledState.BorderColor = Color.DarkGray;
            checkout_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            checkout_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            checkout_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            checkout_btn.FillColor = Color.ForestGreen;
            checkout_btn.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkout_btn.ForeColor = Color.White;
            checkout_btn.Location = new Point(57, 394);
            checkout_btn.Name = "checkout_btn";
            checkout_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            checkout_btn.Size = new Size(555, 62);
            checkout_btn.TabIndex = 17;
            checkout_btn.Text = "NEXT";
            checkout_btn.Click += checkout_btn_Click;
            // 
            // check_room
            // 
            check_room.BackColor = Color.NavajoWhite;
            check_room.BorderRadius = 20;
            check_room.CustomizableEdges = customizableEdges5;
            check_room.DefaultText = "";
            check_room.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            check_room.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            check_room.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            check_room.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            check_room.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            check_room.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_room.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            check_room.Location = new Point(57, 276);
            check_room.Margin = new Padding(5, 6, 5, 6);
            check_room.Name = "check_room";
            check_room.PasswordChar = '\0';
            check_room.PlaceholderText = "Room";
            check_room.SelectedText = "";
            check_room.ShadowDecoration.CustomizableEdges = customizableEdges6;
            check_room.Size = new Size(555, 69);
            check_room.TabIndex = 18;
            check_room.TextOffset = new Point(10, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.NavajoWhite;
            label2.Font = new Font("Poppins ExtraBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 52);
            label2.Name = "label2";
            label2.Size = new Size(310, 51);
            label2.TabIndex = 19;
            label2.Text = "ENTER INFOMATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(check_room);
            panel1.Controls.Add(checkout_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkpn);
            panel1.Location = new Point(616, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 501);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 50;
            guna2Elipse2.TargetControl = panel1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(334, 39);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 20;
            label3.Text = "Thank you";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Artboard_3;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(38, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 660);
            panel2.TabIndex = 21;
            // 
            // error_alert1
            // 
            error_alert1.BackColor = Color.SeaShell;
            error_alert1.Location = new Point(546, 369);
            error_alert1.Name = "error_alert1";
            error_alert1.Size = new Size(263, 250);
            error_alert1.TabIndex = 23;
            error_alert1.Visible = false;
            // 
            // verify1
            // 
            verify1.BackColor = Color.White;
            verify1.Location = new Point(235, 273);
            verify1.Name = "verify1";
            verify1.room = null;
            verify1.Size = new Size(884, 475);
            verify1.TabIndex = 22;
            verify1.Visible = false;
            // 
            // payment1
            // 
            payment1.BackColor = Color.White;
            payment1.Location = new Point(234, 272);
            payment1.Name = "payment1";
            payment1.phone = null;
            payment1.room = null;
            payment1.Size = new Size(885, 475);
            payment1.TabIndex = 24;
            payment1.Visible = false;
            payment1.Load += payment1_Load;
            // 
            // checkout_success1
            // 
            checkout_success1.BackColor = Color.SeaShell;
            checkout_success1.Location = new Point(547, 370);
            checkout_success1.Name = "checkout_success1";
            checkout_success1.Size = new Size(263, 250);
            checkout_success1.TabIndex = 25;
            checkout_success1.Visible = false;
            // 
            // check_out
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(verify1);
            Controls.Add(payment1);
            Controls.Add(checkout_success1);
            Controls.Add(error_alert1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(line);
            Controls.Add(label1);
            Name = "check_out";
            Size = new Size(1381, 874);
            Load += check_out_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel line;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox checkpn;
        private Guna.UI2.WinForms.Guna2Button checkout_btn;
        private Guna.UI2.WinForms.Guna2TextBox check_room;
        private Label label2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label3;
        private Panel panel2;
        private alert.error_alert error_alert1;
        private verify verify1;
        private payment payment1;
        private alert.checkout_success checkout_success1;
    }
}
