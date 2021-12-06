namespace InspectAvtoDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cards
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Cards { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? licence_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expire_date { get; set; }

        [StringLength(50)]
        public string categories { get; set; }

        [StringLength(50)]
        public string licence_series { get; set; }

        [Column("licence number")]
        [StringLength(10)]
        public string licence_number { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
