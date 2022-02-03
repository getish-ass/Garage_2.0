using Garage_2._0.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage_2._0.Models.ViewModel
{
    public class DataModel
    {
     public IEnumerable<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
     public IEnumerable<SelectListItem>  VehicleTypes { get; set; } = new List<SelectListItem>();
     public String? RegNo { get; set; }
     public VehicleType? VehicleType { get; set; }
    }
}
