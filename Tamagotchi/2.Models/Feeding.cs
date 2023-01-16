using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi._2.Models
{
    public class Feeding
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int HungerLevelAffect { get; set; }
        public int Calories { get; set; }
    }
}
