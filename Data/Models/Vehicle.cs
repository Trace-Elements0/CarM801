using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarM8_01.Data.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string VehicleType { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public string FuelCapacity { get; set; }
    }
}
