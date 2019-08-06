using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzPremium.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [Required]
        [Display(Name="TimeStamp")]
        public int TopicName { get; set; }

        [Required]
        [Display(Name = "TimeStamp")]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Message> Messages { get; set; }        
    }
}
