using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudMainASP.Models
{
    public class Offers
    {
        public int Id { get; set; }
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
        public string LastUpdate { get; set; }
        [Required]
        public int FloorSpace { get; set; }
        [Required]
        public int Floor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; } = DateTime.Now;
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        [Required]
        public string Description { get; set; }
        public string GeolocationIdFk { get; set; }
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
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
