using System.ComponentModel.DataAnnotations.Schema;

namespace TZ_Parsing
{
    // сущность для таблицы ->
    public class Main
    {
        public int Id { get; set; }
        public string NameModel { get; set; }
        public string DateRange { get; set; }
        public string Equip { get; set; }

        [ForeignKey("Equipment")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? CodeModelId { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
