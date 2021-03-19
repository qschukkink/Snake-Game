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
        snakegen[] snake;

        //set key combos
        Keys[] WASD = new Keys[] { Keys.W, Keys.D, Keys.S, Keys.A };
        Keys[] NUMP = new Keys[] { Keys.NumPad8, Keys.NumPad6, Keys.NumPad2, Keys.NumPad4 };
        Point[] pos = new Point[3];

        int Player_H;
        public Game()
        {
            InitializeComponent();
            // krijg de hoogte van het speel veld
            Player_H = PlayArea.ClientSize.Height;
            // maak de start posities aan
            pos[0] = new Point(111, Player_H - snakegen.bodySise);
            pos[1] = new Point(222, Player_H - snakegen.bodySise);
            pos[2] = new Point(333, Player_H - snakegen.bodySise);                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start het ge selekteerde spel van het menu
            startGame(1);
        }

        private void startGame(int GameType)
        {
            // 0 = Clasic mode | 1 = Battle mode 

            // kiets tussen 1 speeler of 2 speelers
            switch (GameType)
            {
                default:
                    snake = new snakegen[1];
                    snake[0] = new snakegen(WASD, Color.Green, pos[2], PlayArea);
                    Timer.Start();
                    break;
                case 1:
                    snake = new snakegen[2];
                    snake[0] = new snakegen(WASD, Color.Green, pos[0], PlayArea);
                    snake[1] = new snakegen(NUMP, Color.BlueViolet, pos[2], PlayArea);
                    Timer.Start();
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i].SnakeMove();
            }
        }
        /// <summary>
        /// beweeg de snake door middel van de aangegeven toetsen
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.Write(e.KeyCode);
            for (int s = 0; s < snake.Length; s++)
            {
                for (int i = 0; i < snake[s].k.Length; i++)
                {
                    if (snake[s].k[i] == e.KeyCode) { snake[s].dir = i; }
                }
            }
        }
    }
}
