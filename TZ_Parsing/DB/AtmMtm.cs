using System.Collections.Generic;


namespace TZ_Parsing.DB
{
    // сущность для таблицы ->
    public class AtmMtm
    {
        public int Id { get; set; }
        public string Transmission { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
