using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi._2.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Email { get; set; }
        public string AnimalName { get; set; }
        public DateTime Birthday { get; set; }
        public float Weight { get; set; }
        public int Age { get; set; }
        public int LifeCycleID { get; set; }
        public int HealthstatusID { get; set; }
        public int Hungerlevel { get; set; }
        public int Cleanlinesslevel { get; set; }
        public int Happinesslevel { get; set; } 
    }
}
