using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._1.Data;
using Tamagotchi._2.Models;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._4.UI
{
    public class PlayerAnimalsAddScreen : Screen
    {
        public PlayerAnimalsAddScreen() : base($"Add animal for {MainUi.p.Firstname}")
        {
        }

        public override void Show()
        {
            base.Show();
            if (MainUi.p.Animals.Count == 0)
            {
                Console.WriteLine($"No Animal for player "+ MainUi.p.Firstname);
            }
            else
            {
                Animal a = new Animal();
                a.AnimalID = MainUi.p.Animals.Count + 1;
                a.Email = MainUi.p.Email;
                Console.WriteLine();
                Console.WriteLine($"Player Name " + MainUi.p.Firstname);
                
                Console.WriteLine($"Animal details");
                Console.WriteLine("Please Enter Animal Name");
                a.AnimalName = Console.ReadLine();
                Console.WriteLine("Please Enter Animal Birthday");
                a.Birthday = System.Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Please Enter Animal Weight ");
                a.Weight = float.Parse(Console.ReadLine());
               
                Animals.Add(a);
               
                Console.WriteLine("****************************************************");
            }
            
            Console.ReadKey();

        }
    }
}
