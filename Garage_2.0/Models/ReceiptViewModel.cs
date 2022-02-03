using System.ComponentModel.DataAnnotations;

namespace Garage_2._0.Models
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Reg-nr")]
        public string? RegNo { get; set; }

        [Display(Name = "Ankomsttid")]
        public DateTime ArrivalTime { get; set; }

        //[Display(Name = "Tid parkering avslutades")]
        //public DateTime CheckOutTime { get; set; }

        [Display(Name = "Parkerad tid")]
        public TimeSpan ParkedTime { get; set; }



        //[Display(Name = "Kostnad")]
        //public int Cost { get; set; }
    }
}
