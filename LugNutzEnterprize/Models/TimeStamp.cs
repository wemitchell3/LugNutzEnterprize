using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzEnterprize.Models
{
    public class TimeStamp
    {
        public DateTime? CreatedDated { get; set; }
        public string UserCreated { get; set; }
        public DateTime? ModeifiedDate { get; set; }
        public string UserModified { get; set; }
    }
}
