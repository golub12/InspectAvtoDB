namespace InspectAvtoDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        public int? Post { get; set; }

        [StringLength(50)]
        public string Addres { get; set; }

        [StringLength(50)]
        public string AdressLife { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string JobName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string Descrip { get; set; }
    }
}
