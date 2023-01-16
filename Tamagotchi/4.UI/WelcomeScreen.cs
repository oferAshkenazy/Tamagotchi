using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._1.Data;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._4.UI
{
    public class WelcomeScreen : Screen
    {


        public WelcomeScreen() : base("Welcome Tamagotchi")
        {
            DemoData.Init();
        }

        public override void Show()
        {
            base.Show();
            Console.Write(@"   
  ,d                                                                      
  88                                                                      
MM88MMM ,adPPYYba, 88,dPYba,,adPYba,  ,adPPYYba,  ,adPPYb,d8  ,adPPYba,   
  88    """"     `Y8 88P'   ""88""    ""8a """"     `Y8 a8""    `Y88 a8""     ""8a  
  88    ,adPPPPP88 88      88      88 ,adPPPPP88 8b       88 8b       d8  
  88,   88,    ,88 88      88      88 88,    ,88 ""8a,   ,d88 ""8a,   ,a8""  
  ""Y888 `""8bbdP""Y8 88      88      88 `""8bbdP""Y8  `""YbbdP""Y8  `""YbbdP""'   
                                                  aa,    ,88              
                                                   ""Y8bbdP""           
                                                               ", 65);


            Console.ReadKey();
            Screen next = new MenuScreen("Tamagotchi GAME");
            ((MenuScreen)next).AddItem("Login", new LoginScreen());
            ((MenuScreen)next).AddItem("Register", new RegisterScreen());
            next.Show();
            Console.Clear();
            Console.WriteLine(@" 
  ████████████████████████████████████████████████████████████  
██                                                            ██
██              ██████    ██      ██    ██████                ██
██              ██        ████    ██    ██    ██              ██
██              ██████    ██  ██  ██    ██    ██              ██
██              ██        ██    ████    ██    ██              ██
██              ██████    ██      ██    ██████                ██
██                                                            ██
  ████████████████████████████████████████████████████████████  

                                                                        ");
            //Users.Save(MainUi.p);
            Console.ReadKey();

        }
    }
}
