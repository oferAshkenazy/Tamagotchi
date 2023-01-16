using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._2.Models;

namespace Tamagotchi._1.Data
{
    public class Animals
    {
        public static List<Animal>? animals;

        public static void Add(Animal animal)
        {
            Player p = Users.Get(animal.Email);

            p.Animals.Add(animal);
        }

    }
}
