namespace jf_edp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                // Simple validation (replace with your real logic)
                if (username == "admin" && password == "1234")
                {
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();           // Show dashboard
                    this.Hide();                // Hide login form (optional: use this.Close() to exit)
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
