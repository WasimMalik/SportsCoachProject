using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsCoachManagement.Contracts;
using SportsCoachManagement.ViewModel;

namespace SportsCoachManagement.Controllers
{
    public class CoachController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public CoachController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public IActionResult Index()
        {           
            var getTotalParticipants = _repoWrapper.spTotalParticipants.GetTotalParticipants();
            var SportsViewModel = new SportsViewModel()
            {
                spTotalParticipants = getTotalParticipants.ToList()
            };
            return View(SportsViewModel);
        }
        [HttpGet]
        public IActionResult CreateTest()
        {
            TestTypeViewModel testTypeViewModel = new TestTypeViewModel();
            return View(testTypeViewModel);
           
        }
        [HttpPost]
        public IActionResult CreateTest(TestTypeViewModel _sportsviewmodel )
        {

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddAthelete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAthelete(SportsViewModel sportsviewmodel)
        {
            return View();
        }
       
        public IActionResult TestDetail(string TestName, string Testdate)
        {
            
            DateTime oDate = DateTime.ParseExact(Testdate, "ddMMyyyy", null);
            var getTestdetails = _repoWrapper.sp_TestDetail.GetAllTestDetails(TestName, oDate);
            var SportsViewModel = new SportsViewModel()
            {
                sp_TestDetail = getTestdetails.ToList()
            };
            return PartialView("TestDetails", SportsViewModel);
          
        }
       

    }
}
