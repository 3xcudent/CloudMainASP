using CloudMainASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudMainASP.Controllers
{
    public class AcountController : Controller
    {
        public ActionResult Login(ApplicationUser user)
        {
            return View("~/Index");
        }
    }
}
