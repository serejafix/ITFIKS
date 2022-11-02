namespace Lan_DBStreetsFromIndex
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Street
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Street")]
        [Required]
        [StringLength(50)]
        public string Street1 { get; set; }

        public int IndexId { get; set; }

        public virtual Index Index { get; set; }
    }
}
