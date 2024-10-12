using System.ComponentModel.DataAnnotations;

namespace MVCPrac.Models
{
    public class Vehicles
    {
        [Key]
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string Category {  get; set; }
        public string Description { get; set; }
    }
}
