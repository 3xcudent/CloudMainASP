using CloudMainASP.Data;
using CloudMainASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Security.Claims;

namespace CloudMainASP.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(ApplicationUser user)
        {
            return View("~/Index");
        }
        public string GetUserId(ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException(nameof(principal));
            }
            var claim = principal.FindFirst(ClaimTypes.NameIdentifier);
            return claim != null ? claim.Value : null;
        }
        [HttpGet]
        [Route("AddOffer")]
        public IActionResult AddOffer()
        {
            return View("/Areas/Identity/Pages/Account/AddOffer.cshtml");
        }
    }
}
