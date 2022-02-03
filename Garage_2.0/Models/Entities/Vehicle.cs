using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Parkerad")]
        public bool Parked { get; set; }

        [Required]
        [StringLength(6)]
        [Display(Name = "Reg-nr")]
        public string? RegNo { get; set; }

        [Display(Name = "Ankomsttid")]
        public DateTime ArrivalTime { get; set; }

        [Display(Name = "Utcheckningstid")]
        private DateTime CheckOutTime { get; set; }

        [StringLength(25)]
        [Display(Name = "Märke")]
        public string? Brand { get; set; }

        [StringLength(20)]
        [Display(Name = "Modell")]
        public string? Model { get; set; }

        [Range(2, 16)]
        [Display(Name = "Antal hjul")]
        public int NoOfWheels { get; set; }

        [StringLength(20)]
        [Display(Name = "Färg")]
        public string? Color { get; set; }

        [Display(Name = "Fordonstyp")]
        public VehicleType vehicleType { get; set; }
    }
}