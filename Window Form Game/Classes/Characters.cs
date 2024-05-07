using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Form_Game.Classes
{
    public class Characters
    {
        protected Point Coord;
        protected int Health;
        protected int stamina;
        protected int damage;
        protected string dir;

        public Characters()
        {

        }
        public Characters(Point Coord)
        {
            this.Coord = Coord;
        }

        public Point getCoord()
        {
            return Coord;
        }
        public int getHealth()
        {
            return Health;
        }
        public int getStamina()
        {
            return stamina;
        }
        public int getDamage()
        {
            return damage;
        }
        public string getDir()
        {
            return dir;
        }
        public void setCoord(Point Coord)
        {
            this.Coord = Coord;
        }
        public void setHealth(int Health)
        {
            this.Health = Health;
        }
        public void setStamina(int Stamina)
        {
            this.stamina = Stamina;
        }
        public void setDamage(int Damage)
        {
            this.damage = Damage;
        }
        public void setDir(string Dir) 
        {
            this.dir = Dir;
        }
    }
}
