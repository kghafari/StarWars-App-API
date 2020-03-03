using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23_SWAPI.Models
{
    public class People
    {
        //map properties to JSON output
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_Color { get; set; }
        public string Skin_Color { get; set; }
        public string Eye_Color { get; set; }
        public string Birth_Year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }

        public string[] Films { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Starships { get; set; }
    }
}
