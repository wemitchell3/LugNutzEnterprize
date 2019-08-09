using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzPremium.Models
{
    public class MaintenanceTask : Attribute
    {

        [Key]
        public int MaintenanceTaskId { get; set; }

        [Required]
        [Display(Name = "Vehicle")]
        public int VehicleId { get; set; }

        [NotMapped]
        [Display(Name = "Vehicle Name")]
        public string VehicleFullName { get; set; }

        [Required]
        [Display(Name = "Maintenance Task")]
        public string MaintenanceTaskTitle { get; set; }

        [Required]
        [Display(Name = "Maintenance Description")]
        public string MaintenanceTaskDescription { get; set; }

        [Required]
        [Display(Name = "Mileage Due?")]
        public int TaskDueAtMileage { get; set; }

        [Required]
        [Display(Name = "Is Completed?")]
        public bool IsComplete { get; set; }
        
        [NotMapped]
        [Display(Name = "Vehicle")]
        public List<SelectListItem> VehicleSelectList { get; set; }

        [Required]
        [DataType(DataType.Date)]        
        [Display(Name = "Target Complete Date")]
        public DateTime TargetCompleteDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Created")]
        public DateTime CreatedDate { get; set; }

        [NotMapped]
        public List<MaintenanceTask> MaintainenanceTaskList { get; set; }

        [NotMapped]
        public List<MaintenanceTask> VehicleFullNameList { get; set; }

        //public DateTime CreatedDate { get; set; }
        //public DateTime ModifiedDate { get; set; }

        //public MaintenanceTask()
        //{
        //    this.CreatedDate = DateTime.UtcNow;
        //    //this.ModifiedDate = DateTime.UtcNow;
        //}
    }
}
