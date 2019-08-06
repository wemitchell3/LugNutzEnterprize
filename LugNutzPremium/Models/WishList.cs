using System;
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
        public string WishListTitle { get; set; }

        [Required]
        public string WishListDescription { get; set; }

        [Required]
        public bool IsComplete { get; set; }

        [Timestamp]
        [Display(Name = "Date Created")]
        public byte[] CreatedDate { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Display(Name = "Date Created")]
        //public DateTime DateCreated { get; set; }
    }
}
