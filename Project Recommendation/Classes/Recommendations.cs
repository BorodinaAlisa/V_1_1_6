using System.ComponentModel.DataAnnotations.Schema;

namespace DB_993.Classes
{
    /// <summary>
    /// Класс представляет модель данных для хранения рекомендаций или оценок недвижимости.
    /// </summary>
    public class Recommendations
    {
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdRec")]
        public Realty? Realty_id { get; set; }

        public int Mark_Realty { get; set; }
        [ForeignKey("ReltyInMarkRec")]
        public Realty? Realty_mark { get; set; }
        public string? UserEmail { get; set; }
    }
}
