using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    /// <summary>
    /// Класс используется для регистрации пользователя в приложении.
    /// </summary>
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            Design();
            MaximizeBox = false;
            PasswordRegText.PasswordChar = '*';
            LoginRegText.KeyPress += LoginRegText_KeyPress;
            PasswordRegText.KeyPress += PasswordRegText_KeyPress;
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            NameLabel.Parent = pictureBox2;
            NameLabel.BackColor = Color.Transparent;
            EmailLabel.Parent = pictureBox2;
            EmailLabel.BackColor = Color.Transparent;
            PasswordLabel.Parent = pictureBox2;
            PasswordLabel.BackColor = Color.Transparent;
        }

        private void PasswordRegText_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var edit = new EditInput();
            edit.PasswordEnter(e);
        }

        private void LoginRegText_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var edit = new EditInput();
            edit.FalseText(e);
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameRegText.Text) || string.IsNullOrWhiteSpace(LoginRegText.Text) || string.IsNullOrWhiteSpace(PasswordRegText.Text))
            {
                MessageBox.Show(RegistrationWindowLocal.FieldsTextReg);
                return;
            }

            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var existingUser = context.Users.FirstOrDefault(user => user.Email == LoginRegText.Text);
                if (existingUser != null)
                {
                    MessageBox.Show(RegistrationWindowLocal.EmailTextReg);
                    return;
                }
                HashPassword heshPassword = new HashPassword();
                var newUser = new User
                {
                    Name = NameRegText.Text,
                    Email = LoginRegText.Text,
                    Password = heshPassword.GetPassword(PasswordRegText.Text)
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show(RegistrationWindowLocal.RegText);
                MainWindow mainWindow = new MainWindow(LoginRegText.Text);
                mainWindow.ShowDialog();

            }
        }
    }
}
