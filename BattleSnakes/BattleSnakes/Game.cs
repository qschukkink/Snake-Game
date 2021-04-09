using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            // krijg de hoogte van het speel veld
           int Player_H = PlayArea.ClientSize.Height;
           int Player_W = PlayArea.ClientSize.Width;
            // maak de start posities aan
            pos[0] = new Point(111, Player_H - snakegen.bodySise);
            pos[1] = new Point(222, Player_H - snakegen.bodySise);
            pos[2] = new Point(Player_W / 2, Player_H - snakegen.bodySise);                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start het ge selekteerde spel van het menu
            startGame(GameType);
        }

        private void startGame(int GameType)
        {
            // 0 = Clasic mode | 1 = Battle mode | 2 = Online Mode-TODO
            switch (GameType)
            {
                case 0:
                    snake = new snakegen[1];
                    snake[0] = new snakegen(WASD, Color.Green, pos[2], PlayArea);
                    break;
                case 1:
                    snake = new snakegen[2];
                    snake[0] = new snakegen(WASD, Color.Green, pos[0], PlayArea);
                    snake[1] = new snakegen(NUMP, Color.BlueViolet, pos[2], PlayArea);                    
                    break;                    
            }
            Timer.Start();
            food = new foodgen(PlayArea);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i].Move();
            }
        }
        /// <summary>
        /// move the snake using the indicated keys
        /// without being able to walk back immediately
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // restart the game
            if (e.KeyCode == Keys.Escape) {
                PlayArea.Controls.Clear();
                startGame(GameType);
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
    }
}
