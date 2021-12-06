namespace InspectAvtoDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Cars { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string VIN { get; set; }

        [StringLength(50)]
        public string Manu { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public int? Year { get; set; }

        public int? Wei { get; set; }

        public int? Color { get; set; }

        public int? Engine_Type { get; set; }

        [StringLength(50)]
        public string Type_od { get; set; }
    }
}
