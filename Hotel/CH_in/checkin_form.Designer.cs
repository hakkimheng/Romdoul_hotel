namespace Hotel.CH_in
{
    partial class checkin_form
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            bg = new Panel();
            label2 = new Label();
            line = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            completed_alert1 = new alert.completed_alert();
            label8 = new Label();
            error_alert1 = new alert.error_alert();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            next_in = new Guna.UI2.WinForms.Guna2Button();
            button1 = new Button();
            txt_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            txt_datein = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txt_phonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            txt_dateout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lastname_txt = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            room_choose1 = new room_choose();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            bg.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = bg;
            // 
            // bg
            // 
            bg.BackColor = Color.Orange;
            bg.Controls.Add(room_choose1);
            bg.Controls.Add(label2);
            bg.Controls.Add(line);
            bg.Controls.Add(label1);
            bg.Controls.Add(panel1);
            bg.Controls.Add(panel2);
            bg.Location = new Point(0, 2);
            bg.Name = "bg";
            bg.Size = new Size(1381, 874);
            bg.TabIndex = 1;
            bg.Paint += bg_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(738, 165);
            label2.Name = "label2";
            label2.Size = new Size(412, 84);
            label2.TabIndex = 18;
            label2.Text = "CHECK IN FORM";
            // 
            // line
            // 
            line.BackColor = Color.White;
            line.Location = new Point(1, 79);
            line.Name = "line";
            line.Size = new Size(1373, 5);
            line.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(160, 51);
            label1.TabIndex = 6;
            label1.Text = "CHECK IN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(completed_alert1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(error_alert1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(next_in);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_firstname);
            panel1.Controls.Add(txt_datein);
            panel1.Controls.Add(txt_phonenumber);
            panel1.Controls.Add(txt_dateout);
            panel1.Controls.Add(lastname_txt);
            panel1.Location = new Point(509, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 544);
            panel1.TabIndex = 16;
            // 
            // completed_alert1
            // 
            completed_alert1.BackColor = Color.SeaShell;
            completed_alert1.Location = new Point(3, 80);
            completed_alert1.Name = "completed_alert1";
            completed_alert1.Size = new Size(263, 250);
            completed_alert1.TabIndex = 15;
            completed_alert1.Visible = false;
            completed_alert1.Load += completed_alert1_Load;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(443, 277);
            label8.Name = "label8";
            label8.Size = new Size(130, 26);
            label8.TabIndex = 19;
            label8.Text = "Check Out Date";
            // 
            // error_alert1
            // 
            error_alert1.BackColor = Color.SeaShell;
            error_alert1.Location = new Point(3, 80);
            error_alert1.Name = "error_alert1";
            error_alert1.Size = new Size(263, 250);
            error_alert1.TabIndex = 14;
            error_alert1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(44, 277);
            label7.Name = "label7";
            label7.Size = new Size(117, 26);
            label7.TabIndex = 18;
            label7.Text = "Check In Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(443, 165);
            label6.Name = "label6";
            label6.Size = new Size(102, 26);
            label6.TabIndex = 17;
            label6.Text = "Select room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(44, 166);
            label5.Name = "label5";
            label5.Size = new Size(124, 26);
            label5.TabIndex = 16;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(443, 53);
            label4.Name = "label4";
            label4.Size = new Size(89, 26);
            label4.TabIndex = 15;
            label4.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(44, 53);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 14;
            label3.Text = "First name";
            // 
            // next_in
            // 
            next_in.BorderRadius = 20;
            next_in.CustomizableEdges = customizableEdges1;
            next_in.DisabledState.BorderColor = Color.DarkGray;
            next_in.DisabledState.CustomBorderColor = Color.DarkGray;
            next_in.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            next_in.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            next_in.FillColor = Color.MidnightBlue;
            next_in.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next_in.ForeColor = Color.White;
            next_in.Location = new Point(34, 415);
            next_in.Name = "next_in";
            next_in.ShadowDecoration.CustomizableEdges = customizableEdges2;
            next_in.Size = new Size(769, 63);
            next_in.TabIndex = 7;
            next_in.Text = "NEXT";
            next_in.Click += next_in_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(443, 194);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(360, 63);
            button1.TabIndex = 13;
            button1.Text = "Select Room";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_firstname
            // 
            txt_firstname.BorderRadius = 20;
            txt_firstname.CustomizableEdges = customizableEdges3;
            txt_firstname.DefaultText = "";
            txt_firstname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_firstname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_firstname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_firstname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_firstname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_firstname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_firstname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_firstname.Location = new Point(34, 80);
            txt_firstname.Margin = new Padding(4, 7, 4, 7);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.PasswordChar = '\0';
            txt_firstname.PlaceholderText = "Enter Firstname";
            txt_firstname.SelectedText = "";
            txt_firstname.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_firstname.Size = new Size(360, 63);
            txt_firstname.TabIndex = 0;
            txt_firstname.TextOffset = new Point(10, 0);
            txt_firstname.TextChanged += txt_firstname_TextChanged;
            txt_firstname.KeyPress += txt_firstname_KeyPress;
            // 
            // txt_datein
            // 
            txt_datein.BorderRadius = 20;
            txt_datein.Checked = true;
            txt_datein.CustomizableEdges = customizableEdges5;
            txt_datein.FillColor = Color.White;
            txt_datein.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_datein.ForeColor = Color.MidnightBlue;
            txt_datein.Format = DateTimePickerFormat.Long;
            txt_datein.Location = new Point(34, 306);
            txt_datein.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            txt_datein.MinDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            txt_datein.Name = "txt_datein";
            txt_datein.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_datein.Size = new Size(360, 63);
            txt_datein.TabIndex = 4;
            txt_datein.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.BorderRadius = 20;
            txt_phonenumber.CustomizableEdges = customizableEdges7;
            txt_phonenumber.DefaultText = "";
            txt_phonenumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_phonenumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_phonenumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_phonenumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_phonenumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_phonenumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phonenumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_phonenumber.Location = new Point(32, 194);
            txt_phonenumber.Margin = new Padding(4, 7, 4, 7);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.PasswordChar = '\0';
            txt_phonenumber.PlaceholderText = "Enter Phonenumber";
            txt_phonenumber.SelectedText = "";
            txt_phonenumber.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_phonenumber.Size = new Size(360, 63);
            txt_phonenumber.TabIndex = 9;
            txt_phonenumber.TextOffset = new Point(10, 0);
            txt_phonenumber.TextChanged += txt_phonenumber_TextChanged;
            txt_phonenumber.KeyPress += txt_phonenumber_KeyPress;
            // 
            // txt_dateout
            // 
            txt_dateout.BorderRadius = 20;
            txt_dateout.Checked = true;
            txt_dateout.CustomizableEdges = customizableEdges9;
            txt_dateout.FillColor = Color.White;
            txt_dateout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_dateout.ForeColor = Color.Brown;
            txt_dateout.Format = DateTimePickerFormat.Long;
            txt_dateout.Location = new Point(443, 306);
            txt_dateout.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            txt_dateout.MinDate = new DateTime(2024, 7, 18, 0, 0, 0, 0);
            txt_dateout.Name = "txt_dateout";
            txt_dateout.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_dateout.Size = new Size(360, 63);
            txt_dateout.TabIndex = 5;
            txt_dateout.Value = new DateTime(2024, 7, 18, 0, 0, 0, 0);
            // 
            // lastname_txt
            // 
            lastname_txt.BorderRadius = 20;
            lastname_txt.CustomizableEdges = customizableEdges11;
            lastname_txt.DefaultText = "";
            lastname_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            lastname_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            lastname_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            lastname_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            lastname_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            lastname_txt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastname_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            lastname_txt.Location = new Point(443, 80);
            lastname_txt.Margin = new Padding(4, 7, 4, 7);
            lastname_txt.Name = "lastname_txt";
            lastname_txt.PasswordChar = '\0';
            lastname_txt.PlaceholderText = "Enter Lastname";
            lastname_txt.SelectedText = "";
            lastname_txt.ShadowDecoration.CustomizableEdges = customizableEdges12;
            lastname_txt.Size = new Size(360, 63);
            lastname_txt.TabIndex = 8;
            lastname_txt.TextOffset = new Point(10, 0);
            lastname_txt.KeyPress += txt_firstname_KeyPress;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.image;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(6, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 779);
            panel2.TabIndex = 17;
            // 
            // room_choose1
            // 
            room_choose1.BackColor = Color.Orange;
            room_choose1.Location = new Point(9, 96);
            room_choose1.Name = "room_choose1";
            room_choose1.Size = new Size(1363, 778);
            room_choose1.TabIndex = 19;
            room_choose1.Visible = false;
            room_choose1.Load += room_choose1_Load_1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 40;
            guna2Elipse2.TargetControl = button1;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 50;
            guna2Elipse3.TargetControl = panel1;
            // 
            // checkin_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bg);
            Name = "checkin_form";
            Size = new Size(1381, 874);
            Load += checkin_form_Load;
            bg.ResumeLayout(false);
            bg.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel bg;
        private alert.completed_alert completed_alert1;
        private Button button1;
        private Panel line;
        private Guna.UI2.WinForms.Guna2TextBox txt_phonenumber;
        private Guna.UI2.WinForms.Guna2TextBox lastname_txt;
        private Guna.UI2.WinForms.Guna2Button next_in;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_dateout;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_datein;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstname;
        private alert.error_alert error_alert1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private room_choose room_choose1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
