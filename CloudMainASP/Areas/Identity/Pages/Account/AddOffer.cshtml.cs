using CloudMainASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudMainASP.Areas.Identity.Pages.Account.Manage
{
    public class AddOffer : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        
    }
    public class InputModel
    {
        [Required]
        public int NumerOfRooms { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string TypeOfBuilding { get; set; }
        [Required]
        public string Availability { get; set; }
        [Required]
        public int FloorSpace { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public bool Negotiable { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int NumberOfFloors { get; set; }
        [Required]
        public string DateBuilt { get; set; }
        public int UserId { get; set; }
    }
}
