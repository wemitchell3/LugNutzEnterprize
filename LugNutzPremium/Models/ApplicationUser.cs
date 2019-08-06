using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzPremium.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        
        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }
        
        [Display(Name = "Zip")]
        public int Zip { get; set; }
        
        [Display(Name = "Master Mechanic?")]
        public bool IsMasterMechanic { get; set; }

        [Display(Name = "Admin?")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}
