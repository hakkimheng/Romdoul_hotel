namespace Hotel.alert
{
    partial class error_alert
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            tryagain_btn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(89, 104);
            label1.Name = "label1";
            label1.Size = new Size(90, 42);
            label1.TabIndex = 2;
            label1.Text = "Erorr !";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(73, 136);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 3;
            label2.Text = "Please try again!";
            label2.Click += label2_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.SeaShell;
            guna2Panel2.BackgroundImage = Properties.Resources.round_error_icon_16_removebg_preview;
            guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(65, 16);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(128, 88);
            guna2Panel2.TabIndex = 4;
            // 
            // tryagain_btn
            // 
            tryagain_btn.BackColor = Color.SeaShell;
            tryagain_btn.BorderRadius = 20;
            tryagain_btn.CustomizableEdges = customizableEdges1;
            tryagain_btn.DisabledState.BorderColor = Color.DarkGray;
            tryagain_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            tryagain_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tryagain_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tryagain_btn.FillColor = Color.FromArgb(192, 64, 0);
            tryagain_btn.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tryagain_btn.ForeColor = Color.White;
            tryagain_btn.Location = new Point(23, 180);
            tryagain_btn.Name = "tryagain_btn";
            tryagain_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tryagain_btn.Size = new Size(217, 50);
            tryagain_btn.TabIndex = 5;
            tryagain_btn.Text = "Try Again";
            tryagain_btn.Click += tryagain_btn_Click;
            // 
            // error_alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tryagain_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Panel2);
            Name = "error_alert";
            Size = new Size(263, 250);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button tryagain_btn;
    }
}
