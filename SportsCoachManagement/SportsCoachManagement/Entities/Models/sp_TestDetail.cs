using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Entities.Models
{

    public class sp_TestDetail
    {
        [Key]
        public long SerialNumber { get; set; }
        public long Testid { get; set; }
        public DateTime Testdate { get; set; }
       
        public string Ranking { get; set; }
        public decimal Distance { get; set; }
        public string FitnessRating { get; set; }
        public string TestName { get; set; }
       
        

    }
}
