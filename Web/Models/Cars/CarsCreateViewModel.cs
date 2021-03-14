using System.ComponentModel.DataAnnotations;
using Data.Enumeration;
using Web.Attributes;

namespace Web.Models.Cars
{
    public class CarsCreateViewModel
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public EngineEnum Engine { get; set; }
    }
}
