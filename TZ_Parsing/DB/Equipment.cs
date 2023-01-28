using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TZ_Parsing.DB;

namespace TZ_Parsing
{
    public class Equipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Engine1 { get; set; }
        public string Body { get; set; }
        public string Grade { get; set; }
        public int? AtmMtmId { get; set; } //
        public int? DriverPositionId { get; set; } //
        public string SideWindow { get; set; }
        public string SeatingCopacity { get; set; }
        public string FuelInduction { get; set; }
        public string Destination { get; set; }
        public string Destination1 { get; set; }
        public string Destination2 { get; set; }
        public string GearShiftType { get; set; }
        public string Product { get; set; }
        public string Cab { get; set; }
        public string Deck { get; set; }
        public string BuildingCondition { get; set; }
        public string TransmissionModel { get; set; }
        public string LoadingCapacity { get; set; }
        public string RearTire { get; set; }
        public string NoOfDoors { get; set; }
        public string DeckMaterial { get; set; }
        public string DeckCab { get; set; }
        public string ModelMark { get; set; }

        public virtual AtmMtm AtmMtm { get; set; }
        public virtual DriverPosition DriverPosition { get; set; }
        public virtual ICollection<Main> Mains { get; set; }
    }
}
