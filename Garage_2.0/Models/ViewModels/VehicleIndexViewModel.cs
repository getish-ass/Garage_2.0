using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Garage_2._0.Models.ViewModels
{
    public class VehicleIndexViewModel
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
  
        [Display(Name = "Fordonstyp")]
        public VehicleType VehicleType { get; set; }
    }
}
