using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auto.App.CRUD.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Marke { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Km { get; set; }
    }
}
