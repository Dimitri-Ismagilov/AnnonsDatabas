using AnnonsDatabas.Repository;

namespace AnnonsDatabas.Views
{
    public partial class Login : Form
    {
        public DataContext user = new();
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = buttonLogin;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var userList = user.GetAppUser();
            string login = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Användarnamn och Lösenord måste vara ifyllda för att logga in!");
            }

            var matchedUser = userList
                .FirstOrDefault(u => u.Login.Equals(login, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            if (matchedUser != null)
            {
                int userID = matchedUser.UserID;
                //StoreUserSession(userID);
                var appUserView = new AppUserView(userID);
                appUserView.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Felaktiga inloggningsuppgifter");
            }
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
