using AnnonsDatabas.Repository;

namespace AnnonsDatabas.Views
{
    public partial class CreateNewUser : Form
    {
        public DataContext appUser = new();
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string login = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            var userList = appUser.GetAppUser();
            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Alla fält måste vara ifyllda");
                return;
            }

            if (userList.Any(u => u.Login == login))
            {
                MessageBox.Show("Namnet är upptaget, välj ett annat!");
                return;
            }
            else
            {
                appUser.CreateNewUser(login, password);
                MessageBox.Show("Användaren har skapats");
                this.Close();                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
