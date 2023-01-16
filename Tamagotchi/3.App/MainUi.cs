using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._2.Models;
using Tamagotchi._4.UI;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._3.App
{
    public class MainUi
    {
        public static Player p;

        private Screen main;

        public MainUi(Screen p)
        {
            this.main = p;
        }

        public void ApplicationStart()
        {
            this.main.Show();
        }
    }
}
