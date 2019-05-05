using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static SportsCoachManagement.Entities.Enums.Enumeration;

namespace SportsCoachManagement.Entities.Models
{
    [Table("Test")]
    public class Test
    {
        public long Id { get; set; }
        public string TestName { get; set; }
        public string TestType { get; set; }
        public string Description { get; set; }
        //public TestType Type { get; set; }
    }
}
