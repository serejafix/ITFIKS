using System.Collections.Generic;

namespace TZ_Parsing.DB
{
    // сущность для таблицы ->
    public class DriverPosition
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
