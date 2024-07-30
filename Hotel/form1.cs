namespace Hotel
{
    public partial class Romdoul : Form
    {
        public Romdoul()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(username_txt.Text != "" & password_txt.Text!= "")
            {
                function func = new function();
                string username = username_txt.Text;
                string password = password_txt.Text;
                bool check =func.Login(username, password);
                if (check) {
                    checkin checkin = new checkin();
                    checkin.Show();
                    this.Hide();
                }
                else
                {
                    username_txt.Clear();
                    password_txt.Clear();
                }
            }
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void number()
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
