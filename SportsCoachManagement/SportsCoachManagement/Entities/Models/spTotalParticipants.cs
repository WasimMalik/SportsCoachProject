using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Entities.Models
{
    public class spTotalParticipants
    {
        [Key]
        public long SerialNumber { get; set; }
        public DateTime TestDate { get; set; }
        public int Testcount { get; set; }       
        public string TestType { get; set; }
    }
}
