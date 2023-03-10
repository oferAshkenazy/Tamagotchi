using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._3.App;
using Tamagotchi._4.UI.Base;
using Tamagotchi._4.UI.Interfaces;

namespace Tamagotchi._4.UI
{
    public class GameScreen : Screen
    {
        IGamePlay game;
        public GameScreen(IGamePlay game) : base($"Play {game.Name}")
        {
            this.game = game;
        }

        public override void Show()
        {
            base.Show();
            game.Play();
           //MainUi.p.AddScore(game.Name, game.Score);
        }
    }
}
