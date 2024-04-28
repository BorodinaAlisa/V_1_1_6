namespace DB_993.Classes
{
    /// <summary>
    /// Класс представляет модель пользователя с идентификатором, именем, электронной почтой и паролем.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
