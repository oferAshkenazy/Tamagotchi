using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._4.UI
{
    public class PlayerDetailScreen : Screen
    {
        public PlayerDetailScreen() : base($"{MainUi.p.Firstname} details")
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"PlayerDetailScreen");
            Console.WriteLine($"Firstname  " +MainUi.p.Firstname);
            Console.WriteLine($"Lastname  " + MainUi.p.Lastname);
            Console.WriteLine($"Birthdate  " + MainUi.p.Birthdate);
            Console.WriteLine($"Address  " + MainUi.p.Address);
            Console.WriteLine($"Email  " + MainUi.p.Email);
            Console.WriteLine($"Gender  " + MainUi.p.Gender);
            Console.WriteLine($"Username  " + MainUi.p.Username);
            Console.WriteLine($"Password  " + MainUi.p.Password);
           

            Console.ReadKey();



        }
    }
}
