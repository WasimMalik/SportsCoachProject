using Microsoft.AspNetCore.Mvc.Rendering;
using SportsCoachManagement.Entities.Models;
using System;
using System.Collections.Generic;
using static SportsCoachManagement.Entities.Enums.Enumeration;

namespace SportsCoachManagement.ViewModel
{
    public class SportsViewModel
    {
        public List<Test> tests { get; set; }
        public List<TestDetails> testDetails { get; set; }
        public List<User> users { get; set; }
        public List<sp_TestDetail> sp_TestDetail { get; set; }
        public List<spTotalParticipants> spTotalParticipants { get; set; }
      

      

    }
}
