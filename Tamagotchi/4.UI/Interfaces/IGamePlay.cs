using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi._4.UI.Interfaces
{
    public interface IGamePlay
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public void Play();

    }
}
