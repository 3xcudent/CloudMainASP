using CloudMainASP.Data;
using CloudMainASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudMainASP.Controllers
{
    public class OfferController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Offers offer) {
                db.Offers.Add(offer);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
