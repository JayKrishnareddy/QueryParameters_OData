using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Security.Cryptography.Xml;

namespace Odata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(nameof(GetData))]
        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        public List<Stores> GetData() => GetDummyData();
        
        private List<Stores> GetDummyData()
        {
            List<Stores> people = new List<Stores>
        {
            new Stores
            {
                Id = 1,
                Name = "Soap",
                Category = "Personal Care",
                Imported = true,
                Quantity = 4,
                Cost = 3.50
            },
            new Stores
            {
                Id = 2,
                Name = "Shampoo",
                Category = "Personal Care",
                Imported = false,
                Quantity = 15,
                Cost = 6.50
            },
            new Stores
            {
                Id = 3,
               Name = "Beer",
                Category = "Adult Beverage",
                Imported = false,
                Quantity = 6,
                Cost = 5.68
            },
            new Stores
            {
                Id = 4,
               Name = "Wine",
                Category = "Adult Beverage",
                Imported = true,
                Quantity = 4,
                Cost = 3.50
            },
            new Stores
            {
                Id = 5,
                Name = "Razor",
                Category = "Personal Care",
                Imported = true,
                Quantity = 46,
                Cost = 1
            }
            // Add more dummy data as needed
             };
            return people;
        }
    }
    public class Stores
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public long Quantity { get; set; }
        public bool Imported { get; set; }
        public double Cost { get; set; }
    }
}