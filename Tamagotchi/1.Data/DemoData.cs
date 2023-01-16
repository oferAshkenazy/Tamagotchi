using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._2.Models;

namespace Tamagotchi._1.Data
{
    public static class DemoData
    {
        public static void Init()
        {
            Users.players = new List<Player>() { new Player("ofek", "ofek", "1234",
            "ofek@gmail.com","Lofek","hodas","F",new DateTime(2006, 1, 2),
            new List<Animal>()) };
            Animal a = new Animal();
            a.AnimalID = 1;
            a.AnimalName = "bili";
            a.Birthday = new DateTime(2000, 5, 6);
            a.Age = 23;
            a.Email = "ofek@gmail.com";
            a.Weight = 12;
            a.Cleanlinesslevel = 1;
            a.Happinesslevel = 2;
            a.HealthstatusID = 5;
            a.Hungerlevel = 3;
            a.LifeCycleID = 2;

            Animal b = new Animal();
            b.AnimalID = 2;
            b.AnimalName = "bili";
            b.Birthday = new DateTime(2020, 5, 6);
            b.Age = 3;
            b.Email = "ofek@gmail.com";
            b.Weight = 5;
            b.Cleanlinesslevel = 1;
            b.Happinesslevel = 4;
            b.HealthstatusID = 5;
            b.Hungerlevel = 2;
            b.LifeCycleID = 2;

            Animals.Add(a);
            Animals.Add(b);


        }
    }
}
