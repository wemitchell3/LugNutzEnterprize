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
        public string MessageContent { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Time Stamp")]
        public DateTime CreatedDate { get; set; }


        [Required]
        public string TopicId { get; set; }

        [Required]
        public string TopicName { get; set; }        
    }
}
