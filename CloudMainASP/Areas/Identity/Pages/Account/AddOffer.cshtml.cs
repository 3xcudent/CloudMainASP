using CloudMainASP.Controllers;
using CloudMainASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CloudMainASP.Areas.Identity.Pages.Account.Manage
{
    public class AddOffer : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;


        public AddOffer(UserManager<ApplicationUser> userManager,
                SignInManager<ApplicationUser> signInManager,
                ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public class InputModel
        {
            public int NumerOfRooms { get; set; }
            public string Title { get; set; }
            public string State { get; set; }
            public string TypeOfBuilding { get; set; }
            public string Availability { get; set; }
            public int FloorSpace { get; set; }
            public int Floor { get; set; }
            public string ContactNumber { get; set; }
            public string ContactEmail { get; set; }
            public string Description { get; set; }
            public int Price { get; set; }
            public bool Negotiable { get; set; }
            public string HouseNumber { get; set; }
            public string Street { get; set; }
            public string PostCode { get; set; }
            public string City { get; set; }
            public int NumberOfFloors { get; set; }
            public string DateBuilt { get; set; }
            public int UserId { get; set; }
        }
        public IActionResult OnPost(string returnUrl = null)
        {
            ReturnUrl = Url.Content("~/");
            var user = _userManager.GetUserAsync(User);
            OfferController controller = new OfferController();
            var offer = new Offers
            {
                NumerOfRooms = Input.NumerOfRooms,
                Title = Input.Title,
                State = Input.State,
                TypeOfBuilding = Input.TypeOfBuilding,
                Availability = Input.Availability,
                FloorSpace = Input.FloorSpace,
                Floor = Input.Floor,
                ContactNumber = Input.ContactNumber,
                ContactEmail = Input.ContactEmail,
                Description = Input.Description,
                Price = Input.Price,
                Negotiable = Input.Negotiable,
                HouseNumber = Input.HouseNumber,
                Street = Input.Street,
                PostCode = Input.PostCode,
                City = Input.City,
                NumberOfFloors = Input.NumberOfFloors,
                DateBuilt = Input.DateBuilt,
                UserId = user.Id
            };
            controller.Create(offer);
            return Page();
        }
    }
}
