namespace Hotel.checkout
{
    partial class verify
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            checkout_btn = new Guna.UI2.WinForms.Guna2Button();
            checkout_txt = new Label();
            checkin_txt = new Label();
            room_txt = new Label();
            last_txt = new Label();
            phone_txt = new Label();
            fiest_txt = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel8 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(checkout_btn);
            panel1.Controls.Add(checkout_txt);
            panel1.Controls.Add(checkin_txt);
            panel1.Controls.Add(room_txt);
            panel1.Controls.Add(last_txt);
            panel1.Controls.Add(phone_txt);
            panel1.Controls.Add(fiest_txt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(366, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 363);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // checkout_btn
            // 
            checkout_btn.BackColor = Color.Orange;
            checkout_btn.BorderRadius = 20;
            checkout_btn.CustomizableEdges = customizableEdges7;
            checkout_btn.DisabledState.BorderColor = Color.DarkGray;
            checkout_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            checkout_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            checkout_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            checkout_btn.FillColor = Color.ForestGreen;
            checkout_btn.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkout_btn.ForeColor = Color.White;
            checkout_btn.Location = new Point(354, 310);
            checkout_btn.Name = "checkout_btn";
            checkout_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            checkout_btn.Size = new Size(125, 45);
            checkout_btn.TabIndex = 20;
            checkout_btn.Text = "NEXT";
            checkout_btn.Click += checkout_btn_Click;
            // 
            // checkout_txt
            // 
            checkout_txt.AutoSize = true;
            checkout_txt.Font = new Font("Poppins", 14.25F);
            checkout_txt.ForeColor = Color.White;
            checkout_txt.Location = new Point(230, 262);
            checkout_txt.Name = "checkout_txt";
            checkout_txt.Size = new Size(20, 34);
            checkout_txt.TabIndex = 29;
            checkout_txt.Text = " ";
            // 
            // checkin_txt
            // 
            checkin_txt.AutoSize = true;
            checkin_txt.Font = new Font("Poppins", 14.25F);
            checkin_txt.ForeColor = Color.White;
            checkin_txt.Location = new Point(230, 219);
            checkin_txt.Name = "checkin_txt";
            checkin_txt.RightToLeft = RightToLeft.Yes;
            checkin_txt.Size = new Size(20, 34);
            checkin_txt.TabIndex = 28;
            checkin_txt.Text = " ";
            checkin_txt.Click += checkin_txt_Click;
            // 
            // room_txt
            // 
            room_txt.AutoSize = true;
            room_txt.Font = new Font("Poppins", 14.25F);
            room_txt.ForeColor = Color.White;
            room_txt.Location = new Point(230, 170);
            room_txt.Name = "room_txt";
            room_txt.Size = new Size(20, 34);
            room_txt.TabIndex = 27;
            room_txt.Text = " ";
            // 
            // last_txt
            // 
            last_txt.AutoSize = true;
            last_txt.Font = new Font("Poppins", 14.25F);
            last_txt.ForeColor = Color.White;
            last_txt.Location = new Point(230, 77);
            last_txt.Name = "last_txt";
            last_txt.Size = new Size(20, 34);
            last_txt.TabIndex = 26;
            last_txt.Text = " ";
            // 
            // phone_txt
            // 
            phone_txt.AutoSize = true;
            phone_txt.Font = new Font("Poppins", 14.25F);
            phone_txt.ForeColor = Color.White;
            phone_txt.Location = new Point(230, 126);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(20, 34);
            phone_txt.TabIndex = 25;
            phone_txt.Text = " ";
            // 
            // fiest_txt
            // 
            fiest_txt.AutoSize = true;
            fiest_txt.Font = new Font("Poppins", 14.25F);
            fiest_txt.ForeColor = Color.White;
            fiest_txt.Location = new Point(230, 34);
            fiest_txt.Name = "fiest_txt";
            fiest_txt.Size = new Size(20, 34);
            fiest_txt.TabIndex = 24;
            fiest_txt.Text = " ";
            fiest_txt.Click += fiest_txt_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 263);
            label7.Name = "label7";
            label7.Size = new Size(187, 34);
            label7.TabIndex = 5;
            label7.Text = "CHECK OUT DATE  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 14.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 220);
            label6.Name = "label6";
            label6.Size = new Size(167, 34);
            label6.TabIndex = 4;
            label6.Text = "CHECK IN DATE  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 14.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 171);
            label5.Name = "label5";
            label5.Size = new Size(87, 34);
            label5.TabIndex = 3;
            label5.Text = "ROOM  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 78);
            label4.Name = "label4";
            label4.Size = new Size(123, 34);
            label4.TabIndex = 2;
            label4.Text = "LAST NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 127);
            label3.Name = "label3";
            label3.Size = new Size(167, 34);
            label3.TabIndex = 1;
            label3.Text = "PHONE NUMBER :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 35);
            label2.Name = "label2";
            label2.Size = new Size(129, 34);
            label2.TabIndex = 0;
            label2.Text = "FIRST NAME :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(516, 19);
            label1.Name = "label1";
            label1.Size = new Size(198, 51);
            label1.TabIndex = 18;
            label1.Text = "VERIFY INFO";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Orange;
            panel8.Location = new Point(335, -1);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 496);
            panel8.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.verify;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(45, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 236);
            panel2.TabIndex = 58;
            // 
            // verify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "verify";
            Size = new Size(885, 475);
            Load += verify_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label checkout_txt;
        private Label checkin_txt;
        private Label room_txt;
        private Label last_txt;
        private Label phone_txt;
        private Label fiest_txt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button checkout_btn;
        private Panel panel8;
        private Panel panel2;
    }
}
