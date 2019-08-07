using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LugNutzPremium.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [Display(Name="Message")]
        public string MessageContent { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string TopicId { get; set; }

        public string TopicName { get; set; }  
        
        [Required]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Time Stamp")]
        [DisplayFormat(DataFormatString = "{0:dddd, MMMM dd yyyy h:mm:ss tt}")]
        public DateTime CreatedDate { get; set; }
    }
}
