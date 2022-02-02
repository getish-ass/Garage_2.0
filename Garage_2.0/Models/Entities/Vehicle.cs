using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public bool Parked { get; set; }

        [Required]
        [StringLength(6)]
        public string RegNo { get; set; }
        
        public DateTime ArrivalTime { get; set; }
        [StringLength(20)]
        public string Brand { get; set; }
        [StringLength(15)]
        public string Model { get; set; }
        [Range(2, 16)]
        public int NoOfWheels { get; set; }
        [StringLength(15)]
        public string Color { get; set; }
        public Vehicle vehicleType { get; set; }
    }
}
