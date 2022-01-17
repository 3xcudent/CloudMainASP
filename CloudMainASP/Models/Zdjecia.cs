using Microsoft.AspNetCore.Mvc;

namespace CloudMainASP.Models
{
    public class Zdjecia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdOfferFk { get; set; }
    }
}
