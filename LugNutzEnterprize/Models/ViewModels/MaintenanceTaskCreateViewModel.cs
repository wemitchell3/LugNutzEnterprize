using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzEnterprize.Models
{
    public class MaintenanceTaskCreateViewModel
    {
        [Required]
        [Display(Name = "Vehicle")]
        public string SelectedVehicle { get; set; }
        public IEnumerable<SelectListItem> Vehicles { get; set; }

       
    }
}
