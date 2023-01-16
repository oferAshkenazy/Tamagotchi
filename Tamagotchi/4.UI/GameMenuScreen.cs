using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._3.App;

namespace Tamagotchi._4.UI
{
    public class GameMenuScreen : MenuScreen
    {

        public GameMenuScreen() : base("Choose Game")
        {
            this.AddItem("Pong", new GameScreen(new Pong()));
            this.AddItem("Fluffy Bird", new GameScreen(new FluffyBirdGame()));
        }


    }
}
