using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSnakes
{
    public partial class Game : Form
    {        
        public int GameType = 1;
        snakegen[] snake;
        foodgen food;

        //set key combos
        Keys[] WASD = new Keys[] { Keys.W,       Keys.D,       Keys.S,       Keys.A };
        Keys[] NUMP = new Keys[] { Keys.NumPad8, Keys.NumPad6, Keys.NumPad2, Keys.NumPad4 };
        Point[] pos = new Point[3];
        public Game()
        {
            InitializeComponent();
            // get the height of the playing field
            int Player_H = PlayArea.ClientSize.Height;
           int Player_W = PlayArea.ClientSize.Width;
            // create the starting positions
            pos[0] = new Point(48, Player_H - snakegen.bodySise);
            pos[1] = new Point(96, Player_H - snakegen.bodySise);
            pos[2] = new Point(Player_W / 2, Player_H - snakegen.bodySise);                         
        }

        private void startGame(int GameType)
        {
            var startsound = new SoundPlayer(@"Resources\menu.wav");
            startsound.Play();
            // 0 = Clasic mode | 1 = VS mode | 2 = VS Online Mode-TODO
            switch (GameType)
            {
                case 0:
                    snake = new snakegen[1];
                    SnakeDis1.Visible = true;
                    snake[0] = new snakegen(WASD, Color.Green, pos[2], PlayArea);
                    break;
                case 1:
                    snake = new snakegen[2];
                    SnakeDis1.Visible = true;
                    SnakeDis2.Visible = true;
                    snake[0] = new snakegen(WASD, Color.Green, pos[0], PlayArea);
                    snake[1] = new snakegen(NUMP, Color.BlueViolet, pos[2], PlayArea);                    
                    break;
                case 2:
                    snake = new snakegen[2];
                    SnakeDis1.Visible = true;
                    SnakeDis2.Visible = true;
                    snake[0] = new snakegen(WASD, Color.Green, pos[0], PlayArea);
                    //snake[1] = new snakegen(NUMP, Color.BlueViolet, pos[2], PlayArea); gets data from the other client
                    break;
            }
            Timer.Start();
            GameMenu.Visible = false;
            food = new foodgen(PlayArea);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snake.Length; i++)
            {
                if (i == 0) { SnakeScore1.Text = "" + snake[i].score; }
                else { SnakeScore2.Text = "" + snake[i].score; }
                snake[i].Move();
                snake[i].checkScore(food , PlayArea);
            }
        }
        /// <summary>
        /// move the snake using the indicated keys
        /// reset game on ESC
        /// </summary>
        /// <algo>
        /// look at the keys on the keyboard and do something on the correct keys
        /// </algo>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // restart the game
            if (e.KeyCode == Keys.Escape) {
                PlayArea.Controls.Clear();
                Timer.Stop();
                GameMenu.Visible = true;
            }
            for (int s = 0; s < snake.Length; s++)
            {                
                for (int i = 0; i < snake[s].k.Length; i++)
                {
                    if (snake[s].k[i] == e.KeyCode) {
                        if ((i + 2) %4 != snake[s].dir)
                        {
                            snake[s].dir = i;
                        }                        
                    }
                }
                
            }
        }
        private void BTN_Singleplayer_Click(object sender, EventArgs e)
        {
            GameType = 0;
            //start the selected game from the menu
            startGame(GameType);
        }

        private void BTN_Multiplayer_Click(object sender, EventArgs e)
        {
            GameType = 1;
            //start the selected game from the menu
            startGame(GameType);
        }

        private void BTN_Online_Click(object sender, EventArgs e)
        {
            GameType = 2;
            //start the selected game from the menu
            //startGame(GameType);
        }
    }
}
