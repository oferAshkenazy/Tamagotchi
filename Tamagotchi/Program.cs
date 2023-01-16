

using Tamagotchi._3.App;
using Tamagotchi._4.UI;

namespace Tamagotchi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create main app
            MainUi app = new MainUi(new WelcomeScreen());
            app.ApplicationStart();

        }
    }
}
