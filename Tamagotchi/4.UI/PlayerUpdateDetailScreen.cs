using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._4.UI
{
    public class PlayerUpdateDetailScreen : Screen
    {
        public PlayerUpdateDetailScreen() : base($"{MainUi.p.Firstname} details")
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"PlayerUpdateDetailScreen");
            Console.WriteLine($"Firstname  " + MainUi.p.Firstname);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter Updated Firstname"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string Firstname = Console.ReadLine();
            if ( Firstname != "" ) { MainUi.p.Firstname = Firstname; }

            Console.WriteLine($"Lastname  " + MainUi.p.Lastname);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter Updated Lastname"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string Lastname = Console.ReadLine();
            if (Lastname!="") { MainUi.p.Lastname = Lastname; } 

            Console.WriteLine($"Address  " + MainUi.p.Address);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter Updated Address"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string Address = Console.ReadLine();
            if (Address != "") { MainUi.p.Address = Address; } 


            Console.WriteLine($"Email  " + MainUi.p.Email);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"\tEnter Updated Email"}");
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop + 1);
            Console.ResetColor();
            string Email = Console.ReadLine();
            if (Email != "") { MainUi.p.Email = Email; } 

            Console.WriteLine($"Username  " + MainUi.p.Username);
            Console.WriteLine($"Password  " + MainUi.p.Password);
           

            Console.ReadKey();



        }
    }
}
