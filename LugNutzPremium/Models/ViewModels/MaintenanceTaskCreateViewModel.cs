using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LugNutzPremium.Models
{
    public class MaintenanceTaskCreateViewModel
    {
        [Required]
        [Display(Name = "Vehicle")]
        public string SelectedVehicle { get; set; }
        public IEnumerable<SelectListItem> Vehicles { get; set; }
    }
}
