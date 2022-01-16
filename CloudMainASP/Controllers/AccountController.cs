using CloudMainASP.Data;
using CloudMainASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CloudMainASP.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(ApplicationUser user)
        {
            return View("~/Index");
        }
        public string GetProfilePicture(ApplicationUser user)
        {
            string picture = user.ProfilePicture;
            return picture;
         }
    }
}
