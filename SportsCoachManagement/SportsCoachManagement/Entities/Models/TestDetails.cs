using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Entities.Models
{
    [Table("TestDetails")]
    public class TestDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public string FitnessRating { get; set; }
        public decimal Distance { get; set; }
        public DateTime Date { get; set; }
        
    }
}
