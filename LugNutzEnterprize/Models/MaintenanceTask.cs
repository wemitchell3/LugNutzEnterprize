using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzEnterprize.Models
{
    public class MaintenanceTask
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

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Created")]
        public DateTime TargetCompleteDate { get; set; }        
    }
}
