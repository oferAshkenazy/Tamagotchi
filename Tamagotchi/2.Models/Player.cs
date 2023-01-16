using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamagotchi._2.Models
{
    public class Player
    {
        public Player(string Firstname, string Username, string Password)
        {
            this.Firstname = Firstname;
            this.Username = Username;
            this.Password = Password;

        }

        public Player(string Firstname, string Username, string Password,string Email,string Lastname
            ,string Address,string Gender,DateTime Birthdate,List<Animal>? Animals)
        {
            this.Firstname = Firstname;
            this.Username = Username;
            this.Password = Password;
            this.Email= Email;
            this.Lastname= Lastname;
            this.Address = Address; 
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Animals = Animals;
        }

        public string Email { get; set; }   
        public string Username { get; set; }    
        public string Password  { get; set; }
        public string Firstname { get; set; } 
        public string Lastname { get; set; }        
        public string Address { get; set; } 
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Animal>? Animals { get; set; }

    }
}
