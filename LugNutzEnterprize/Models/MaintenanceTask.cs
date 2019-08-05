using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzEnterprize.Models
{
    public class MaintenanceTask : Attribute   
    {
        [Key]
        public int MaintenanceTaskId { get; set; }

        [Required]
        public int VehicleId { get; set; }        

        [Required]
        public string MaintenanceTaskTitle { get; set; }

        [Required]
        public string MaintenanceTaskDescription { get; set; }

        [Required]
        public int TaskDueAtMileage { get; set; }

        [Required]
        public bool IsComplete { get; set; }
        
        [NotMapped]
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

        //public DateTime CreatedDate { get; set; }
        //public DateTime ModifiedDate { get; set; }

        //public MaintenanceTask()
        //{
        //    this.CreatedDate = DateTime.UtcNow;
        //    //this.ModifiedDate = DateTime.UtcNow;
        //}
    }
}
