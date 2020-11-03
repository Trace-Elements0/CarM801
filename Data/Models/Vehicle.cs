using System.ComponentModel.DataAnnotations;

namespace CarM8_01.Data.Models
{
    public class Vehicle
    {
        public string VehicleId { get; set; }

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
        public string Mileage { get; set; }

        [Required]
        public string FuelCapacity { get; set; }
    }
}