    using Game_Backend.BL;
using Game_Backend.BL.Movement;

namespace Window_Form_Game
{
    public partial class Main : Form
    {
        public Game game;
        System.Windows.Forms.Timer timer1;
        Game_Backend.BL.Player player;
        PictureBox playerbox;



        public Main()
        {
            InitializeComponent();
            InitializeTimer();
            playerbox = new PictureBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this);
            Point boundary = new Point(this.Width, this.Height);
            player = new Game_Backend.BL.Player(playerbox);
            /*player.move = new HorizontalMovement(40, boundary, "Left", 256);*/
            game.Add(player);
            game.AddobjectToForm(player);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Update();
        }
        private void InitializeTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2; // Adjust rotation speed as needed
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (EZInput.Keyboard.IsKeyPressed(EZInput.Key.LeftArrow))
            {
                player.ChangeSprite(Image.FromFile("../../../Assets/Player/Walk_Left.gif"));
                Point point = player.getCoord();

                point.X += 1;

                player.setCoord(point);
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
