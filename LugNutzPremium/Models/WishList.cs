using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzPremium.Models
{
    public class WishList
    {
        [Key]
        public int WishListId { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [NotMapped]
        [Display(Name = "Vehicle Name")]
        public string VehicleFullName { get; set; }

        [Required]
        [Display(Name = "Wish List Item")]
        public string WishListTitle { get; set; }

        [Required]
        [Display(Name = "Notes")]
        public string WishListDescription { get; set; }

        [Required]
        [Display(Name = "Completed?")]
        public bool IsComplete { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [NotMapped]
        [Display(Name = "Vehicle")]
        public List<SelectListItem> VehicleSelectList { get; set; }
    }
}
