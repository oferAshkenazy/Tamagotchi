using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi._2.Models;
using Tamagotchi._4.UI;

namespace Tamagotchi._1.Data
{
    public class Users
    {
        public static List<Player>? players;
        public static Player Login(string Username, string Password)
        {
            return players.FirstOrDefault(x => x.Username == Username && x.Password == Password);
        }

        public static Player Get(string Email)
        {
            return players.FirstOrDefault(x => x.Email == Email);
        }

        internal static void Save(Player p)
        {
            players[players.FindIndex(x => x.Username == p.Username)] = p;

        }
        public static void Update(Player p)
        {
            if (players.Find(x => x.Username == p.Username) != null)
            {
                Save(p);
                return;
            }
            players.Add(p);
        }
    }
}
