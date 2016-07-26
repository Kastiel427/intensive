using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taks1;


namespace Task3_2.Controllers
{
    public class HomeController : Controller
    {  
        [HeaderIDMVC]
        public ActionResult Index()
        {
            IEnumerable<Tasks> tasks = Program.tasks;

            ViewBag.Tasks = tasks;

            return View();
        }
    }

    public class HeaderIDMVC : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
        {
            Random random = new Random();
            int id = random.Next(0, Program.tasks.Count);

            actionExecutedContext.HttpContext.Response.Headers.Add("X-TEST-ID", id.ToString());
        }
    }
}
