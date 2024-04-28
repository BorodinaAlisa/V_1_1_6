using System.ComponentModel.DataAnnotations.Schema;

namespace DB_993.Classes
{
    /// <summary>
    /// Класс, используемый для хранения информации об избранных объектах пользователя.
    /// </summary>
    public class Favourites
    {
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdFav")]
        public Realty? Realty_id { get; set; }
    }
}
