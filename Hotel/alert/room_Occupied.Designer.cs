namespace Hotel.alert
{
    partial class room_Occupied
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tryagain_btn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            label1 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
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
            tryagain_btn.Location = new Point(23, 185);
            tryagain_btn.Name = "tryagain_btn";
            tryagain_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tryagain_btn.Size = new Size(212, 47);
            tryagain_btn.TabIndex = 9;
            tryagain_btn.Text = "Try Other";
            tryagain_btn.Click += tryagain_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(73, 138);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 7;
            label2.Text = "Room is OCCUPIED";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(89, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 42);
            label1.TabIndex = 6;
            label1.Text = "Erorr !";
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.SeaShell;
            guna2Panel2.BackgroundImage = Properties.Resources.round_error_icon_16_removebg_preview;
            guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(65, 18);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(128, 88);
            guna2Panel2.TabIndex = 8;
            // 
            // room_Occupied
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(tryagain_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2Panel2);
            Name = "room_Occupied";
            Size = new Size(263, 250);
            Load += room_Occupied_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button tryagain_btn;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
