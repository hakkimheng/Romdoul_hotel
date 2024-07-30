namespace Hotel.alert
{
    partial class checkout_success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout_success));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            tryagain_btn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImage = Properties.Resources._7518748;
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(85, 19);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(87, 83);
            guna2CirclePictureBox1.TabIndex = 13;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // tryagain_btn
            // 
            tryagain_btn.BackColor = Color.SeaShell;
            tryagain_btn.BorderRadius = 20;
            tryagain_btn.CustomizableEdges = customizableEdges2;
            tryagain_btn.DisabledState.BorderColor = Color.DarkGray;
            tryagain_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            tryagain_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tryagain_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tryagain_btn.FillColor = Color.DarkGreen;
            tryagain_btn.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tryagain_btn.ForeColor = Color.White;
            tryagain_btn.Location = new Point(23, 182);
            tryagain_btn.Name = "tryagain_btn";
            tryagain_btn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            tryagain_btn.Size = new Size(217, 50);
            tryagain_btn.TabIndex = 12;
            tryagain_btn.Text = "Okey";
            tryagain_btn.Click += tryagain_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(59, 138);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 11;
            label2.Text = "Check Out Completed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(49, 105);
            label1.Name = "label1";
            label1.Size = new Size(170, 42);
            label1.TabIndex = 10;
            label1.Text = "SUCCESSFUL";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // checkout_success
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(tryagain_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "checkout_success";
            Size = new Size(263, 250);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button tryagain_btn;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
