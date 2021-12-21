namespace kursovaya
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sotrudniki")]
    public partial class Sotrudniki
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string Positions { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal? Zarplata { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone_number { get; set; }

        [StringLength(20)]
        public string Passport { get; set; }

        [StringLength(50)]
        public string Pol { get; set; }
    }
}
