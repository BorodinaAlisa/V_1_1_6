using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    /// <summary>
    /// Класс используется для входа пользователя в приложении.
    /// </summary>
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            using (var applicationContex = new DB_993.Classes.ApplicationContextBD())
            {
                applicationContex.ApplicationContext();
            }
            InitializeComponent();
            MaximizeBox = false;
            Design();
            LoginTextAutho.PlaceholderText = "Электронная почта";
            PasswordTextAutho.PlaceholderText = "Пароль";
            LoginTextAutho.KeyPress += LoginTextAutho_KeyPress;
            PasswordTextAutho.Enter += PasswordTextAutho_Enter;
            PasswordTextAutho.KeyPress += PasswordTextAutho_KeyPress;
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void PasswordTextAutho_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var edit = new EditInput();
            edit.PasswordEnter(e);
        }

        private void PasswordTextAutho_Enter(object? sender, EventArgs e)
        {
            if (PasswordTextAutho.Text == OpenWindowLocal.PasswordText)
            {
                PasswordTextAutho.Text = String.Empty;
                PasswordTextAutho.PasswordChar = '*';
            }
        }

        private void LoginTextAutho_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var edit = new EditInput();
            edit.FalseText(e);

            LoginTextAutho.GotFocus += (sender, e) =>
            {
                if (LoginTextAutho.Text == "Электронная почта")
                {
                    LoginTextAutho.Text = String.Empty;
                    LoginTextAutho.ForeColor = Color.Black;
                }
            };
        }

        private void LoginText_Click(object sender, EventArgs e)
        {
            LoginTextAutho.Clear();
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            PasswordTextAutho.Clear();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var reg_win = new RegistrationWindow();
            reg_win.ShowDialog();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextAutho.Text) || string.IsNullOrWhiteSpace(PasswordTextAutho.Text))
            {
                MessageBox.Show(OpenWindowLocal.FieldsText);
                return;
            }
            HashPassword heshPassword = new HashPassword();
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var user = context.Users.FirstOrDefault(user => user.Email == LoginTextAutho.Text
                && user.Password == heshPassword.GetPassword(PasswordTextAutho.Text));
                if (user == null)
                {
                    MessageBox.Show(OpenWindowLocal.InvalidText);
                    return;
                }

                MessageBox.Show(OpenWindowLocal.AccountText);
                var mainWindow = new MainWindow(LoginTextAutho.Text);
                mainWindow.ShowDialog();
                this.Hide();
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");

            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            }

            Controls.Clear();
            InitializeComponent();
            Design();
        }
    }
}
