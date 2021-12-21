namespace kursovaya
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kod_zakaza { get; set; }

        [Required]
        [StringLength(50)]
        public string Pokupatel { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public decimal Cost { get; set; }

        public int Number { get; set; }
    }
}
