using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._2.Models;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._4.UI
{
    public class PlayerAnimalsDetailScreen : Screen
    {
        public PlayerAnimalsDetailScreen() : base($"{MainUi.p.Firstname} Animals details")
        {
        }

        public override void Show()
        {
            base.Show();
            if (MainUi.p.Animals.Count == 0)
            {
                Console.WriteLine($"No Animal for player "+ MainUi.p.Firstname);
            }

            foreach(Animal animal in MainUi.p.Animals)
            {
                Console.WriteLine();
                Console.WriteLine($"Animal details");
                Console.WriteLine($"AnimalName  " + animal.AnimalName);
                Console.WriteLine($"AnimalID  " + animal.AnimalID);
                Console.WriteLine($"LifeCycleID  " + animal.LifeCycleID);
                Console.WriteLine($"Birthday  " + animal.Birthday);
                Console.WriteLine($"Cleanlinesslevel  " + animal.Cleanlinesslevel);
                Console.WriteLine($"Age  " + animal.Age);
                Console.WriteLine($"Happinesslevel  " + animal.Happinesslevel);
                Console.WriteLine($"Weight  " + animal.Weight);
                Console.WriteLine("****************************************************");
            }
            
            Console.ReadKey();

        }
    }
}
