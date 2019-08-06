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

        [Required]
        [Display(Name = "Wish List Item")]
        public string WishListTitle { get; set; }

        [Required]
        [Display(Name = "Wish List Item Description")]
        public string WishListDescription { get; set; }

        [Required]
        [Display(Name = "Is Completed?")]
        public bool IsComplete { get; set; }

        [Timestamp]
        [Display(Name = "Date Created")]
        public byte[] CreatedDate { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Display(Name = "Date Created")]
        //public DateTime DateCreated { get; set; }

        [NotMapped]
        [Display(Name = "Vehicle")]
        public List<SelectListItem> VehicleSelectList { get; set; }
    }
}
