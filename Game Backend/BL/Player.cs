using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Backend.BL
{
    public class Player :GameObject
    {
        int Health = 100;
        int stamina = 100;
        int damage = 10;
        Image CurrentSprite;
        public Player(PictureBox picture) :base(picture)
        {
            CurrentSprite = Image.FromFile("../../../Assets/Player/Idle_Down.gif");
            this.Sprite.Image = CurrentSprite;
            SetSpriteSize(256, 256);
            this.Sprite.Location = new Point(200, 200);

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
        public void ChangeSprite(Image sprite)
        {
            Sprite.Image = sprite;
        }
        public Point getCoord()
        {
            return Sprite.Location;
        }
        public void setCoord(Point Coord)
        {
            Sprite.Location = Coord;
        }
        public string getSpritePath(string dir,string state,int previousFrameNo)
        {
            string basicPath = "../../../Assets/Player/";
            int currentframe = previousFrameNo + 1;
            if (state == "idle" && previousFrameNo != 13)
            {
                return basicPath + state + "_"+dir+ "/"+currentframe+".png";
            }
            else
            {
                return basicPath + state + "/" + 0 + ".png";
            }
        }
    }
}
