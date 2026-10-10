namespace CS3230_Group5
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Form signInPage = new View.LogInPage();
            signInPage.Show();
            this.Hide();
        }
    }
}
