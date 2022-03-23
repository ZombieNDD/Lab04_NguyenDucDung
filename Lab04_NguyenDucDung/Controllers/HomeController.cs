using Lab04_NguyenDucDung.Models;
using Lab04_NguyenDucDung.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04_NguyenDucDung.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourse = _dbContext.Courses
                .Where(x => x.DateTime > DateTime.Now)
                .OrderBy(x => x.DateTime)
                .Select(x => new UpCommingCourse()
                {
                    DateTime = x.DateTime,
                    LecturerName = x.Lecturer.Name
                });
                
            return View(upcommingCourse);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}