using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzPremium.Models
{
    public class Forum
    {
        [Key]
        public int MessageId { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Msg { get; set; }

        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Date { get; set; }

        [Required]
        public int TopicId { get; set; }

        //[Required]
        //public Topic topic { get; set; }

        [Required]
        public string SenderId { get; set; }

        [Required]
        public ApplicationUser Sender { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        [Required]
        public ApplicationUser Receiver { get; set; }
    }
}
