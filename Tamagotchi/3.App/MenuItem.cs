using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._4.UI.Base;

namespace Tamagotchi._3.App
{
    public class MenuItem
    {
        public string MenuTitle { get; set; }
        public Screen Screen { get; set; }
        public MenuItem() { }
        public MenuItem(string title, Screen screen)
        {
            MenuTitle = title;
            Screen = screen;
        }
    }
}
