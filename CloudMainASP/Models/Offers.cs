using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace CloudMainASP.Models
{
    public class Offers
    {
        public int Id { get; set; }
        public int NumerOfRooms { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public string TypeOfBuilding { get; set; }
        public string Availability { get; set; }
        public string LastUpdate { get; set; }
        public int FloorSpace { get; set; }
        public int Floor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
        public string GeolocationIdFk { get; set; }
        public int Price { get; set; }
        public bool Negotiable { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public int NumberOfFloors { get; set; }
        public string DateBuilt { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
