using System.Collections.Generic;

namespace CarM8_01.Data.Models
{
    public class VehicleType
    {
        public string ID { get; set; }
        public string Type { get; set; }

        public static List<VehicleType> Types = new List<VehicleType>()
        {
            new VehicleType() { ID= "Convertible", Type = "Convertible"},
            new VehicleType() { ID= "Coupe", Type = "Coupe"},
            new VehicleType() { ID= "Hatchback", Type = "Hatchback"},
            new VehicleType() { ID= "Minivan/Van", Type = "Minivan/Van"},
            new VehicleType() { ID= "Sedan", Type = "Sedan"},
            new VehicleType() { ID= "Station Wagon", Type = "Station Wagon"},
            new VehicleType() { ID= "SUV", Type = "SUV"},
            new VehicleType() { ID= "Truck", Type = "Truck"},
        };
    }
}