    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Backend.BL
{
    public class GameObject
    {
        protected PictureBox Sprite;
        public IMove move;

        public GameObject(Point Coord)
        {
            Sprite = new PictureBox();
            Image sprite = Image.FromFile("../../../Assets/404.png");
            Sprite.Image = sprite;
            Sprite.BackColor = Color.Transparent;
            Sprite.Location = Coord;
        }
        public GameObject(PictureBox picture)
        {
            Sprite = picture;
            Image sprite = Image.FromFile("../../../Assets/404.png");
            Sprite.Image = sprite;
            Sprite.BackColor = Color.Transparent;
        }
        public void update()
        {
            /*this.Sprite.Location = move.move(this.Sprite.Location);*/
        }
        public void SetSpriteSize(int x,int y)
        {
            this.Sprite.Size = new Size(x,y);
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public PictureBox GetSprite()
        {
            return this.Sprite;
        }
    }
}
