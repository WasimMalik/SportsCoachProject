using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsCoachManagement.Entities.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
    }
}
