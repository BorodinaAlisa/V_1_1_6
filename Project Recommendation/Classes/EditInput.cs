namespace DB_993.Classes
{
    /// <summary>
    /// Класс содержит методы для обработки ввода текста в текстовых полях, 
    /// предназначенных для ввода пароля и текста, с ограничениями на допустимые символы.
    /// </summary>
    public class EditInput
    {
        public EditInput() { }

        /// <summary>
        /// Метод обрабатывает событие нажатия клавиши в текстовом поле пароля.
        /// Запрещает ввод пробелов.
        /// </summary>
        public void PasswordEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Метод  обрабатывает событие нажатия клавиши в текстовом поле электронной почты.
        /// Запрещает ввод кириллицы.
        /// </summary>
        public void FalseText(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.LowercaseLetter) && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.UppercaseLetter))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                {
                    e.Handled = true;
                }
            }
        }

    }
}
