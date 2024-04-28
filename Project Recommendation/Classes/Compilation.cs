using System.ComponentModel.DataAnnotations.Schema;

namespace DB_993.Classes
{
    public class Compilation
    {
        /// <summary>
        /// Класс, используемый для хранения информации о подборках пользователя.
        /// </summary>
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdCom")]
        public Realty? Realty_id { get; set; }
    }
}
