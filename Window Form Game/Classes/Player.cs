using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Form_Game.Classes
{
    public class Player : Characters, ICharacters
    {
        public Player(Point Coord) : base(Coord) 
        {
            Health = 100;
            stamina = 100;
            damage = 10;
            dir = "_Down";
        }
        public void ChangeSprite(string animation)
        {
            string Path = "../../Assets/Player/" +""+animation+".gif";
        }
    }
}
