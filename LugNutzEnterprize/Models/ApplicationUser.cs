using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzEnterprize.Models
{
    public class ApplicationUser : IdentityUser
    {
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

        [NotMapped]
        [Display(Name = "Seller")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
