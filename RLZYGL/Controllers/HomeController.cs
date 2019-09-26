using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Model;
using IocContainer;
namespace RLZYGL.Controllers
{
    public class HomeController : Controller
    {
        IStudentBLL stuBLL = IocCreate.CreateBLL<IStudentBLL>("containerTwo", "StudentBLL");
        public ActionResult Index()
        {
           
            return View(stuBLL.SelectAll());
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