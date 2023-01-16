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
    public class RegisterScreen : Screen
    {
        string userName;
        string passWord;

        public RegisterScreen() : base("Register Users")
        {

        }
        public override void Show()
        {
            //flow
            //
            base.Show();
            SetUserName();
            SetPassword();
            CreatePlayer();
        }
        private void SetUserName()
        {
            Console.WriteLine("Please Enter Desired User Name");
            userName = Console.ReadLine();
            while (!ValidateUserName())
            {
                Console.WriteLine("Please Enter Desired User Name");
                userName = Console.ReadLine();
            }
        }
        private void SetPassword()
        {
            Console.WriteLine("Please Enter Desired Password");
            this.passWord = Console.ReadLine();
            while (!ValidatePassWord())
            {
                Console.WriteLine("Please Enter Desired Password");
                passWord = Console.ReadLine();
            }
        }
        private bool ValidateUserName()
        {
            return true;
        }
        private bool ValidatePassWord()
        {
            return true;
        }

        private void CreatePlayer()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            try
            {
                MainUi.p = new Player(name, userName, passWord);
                Tamagotchi._1.Data.Users.Update(MainUi.p);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went Wrong...");
            }
        }

    }
}
