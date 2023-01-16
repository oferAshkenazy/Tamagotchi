using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi._4.UI.Base
{
    public class Screen
    {
        protected string title;

        public Screen(string title)
        {
            this.title = title;
        }

        public virtual void Show()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine($"{title,65}");

        }
    }
}
