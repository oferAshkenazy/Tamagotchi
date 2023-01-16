using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._3.App;

namespace Tamagotchi._4.UI
{
    public class MainMenuScreen : MenuScreen
    {
        public MainMenuScreen() : base($"Hello {MainUi.p.Firstname} ")
        {
            AddItem("Player Details", new PlayerDetailScreen());
            AddItem("Player Upadte Details", new PlayerUpdateDetailScreen());
            AddItem("Players Animals", new PlayerAnimalsDetailScreen());
            AddItem("Players Animals Add", new PlayerAnimalsAddScreen());
            AddItem("Play Games", new GameMenuScreen());
        }


    }
}
