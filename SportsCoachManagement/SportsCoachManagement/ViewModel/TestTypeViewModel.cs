using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SportsCoachManagement.Entities.Enums.Enumeration;

namespace SportsCoachManagement.ViewModel
{
    public class TestTypeViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime TestDate { get; set; }

        public TestType Type { get; set; }
        public List<SelectListItem> TestTypes { get; set; }
        public TestTypeViewModel()
        {
            TestTypes = new List<SelectListItem>();
            TestTypes.Add(new SelectListItem {
                Value=((int)TestType.Coopertest).ToString(),
                Text= TestType.Coopertest.ToString()
            });
            TestTypes.Add(new SelectListItem
            {
                Value = ((int)TestType.Sprinttest).ToString(),
                Text = TestType.Sprinttest.ToString()
            });
        }

    }
}
