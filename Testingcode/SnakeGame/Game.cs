using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {
        public int score = 0;
        public int tail = 3;
        public int size = 16;
        public string direction = "Up";
        public Random rand = new Random();
        public Label[] snake = new Label[10];
        public Game()
        {
            InitializeComponent();
        }
        private void BTN_Play_Click(object sender, EventArgs e)
        {
            GameStart();
            //verberg het home screen
            Snake_Home.Visible = false;
        }
        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// set alles voor de game goed 
        /// </summary>
        private void GameStart()
        { 
            Timer.Start();
            SnakeFood();
            // genereer snake 1
            makesnake(Color.Red, Game_Canvas.Width / 2, Game_Canvas.Height - size);
        }

        /// <summary>
        /// Maak een lijst van Labels aan
        /// </summary>
        private void makesnake(Color HeadColor, int X, int Y)
        {
            // maak een snake aan
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Label();
                if (i == 0) { snake[i].BackColor = HeadColor; } else { snake[i].BackColor = Color.Black; }
                snake[i].Size = new Size(size, size);
                snake[i].Location = new System.Drawing.Point(X, Y + (16 * i));
                Game_Canvas.Controls.Add(snake[i]);
            }
        }
        /// <summary>
        /// Set de food op een random locasie in het speel veld
        /// </summary>
        private void SnakeFood()
        {
            Snake_Food.Location = new Point(rand.Next(0, 580), rand.Next(0, 580));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            label_score.Text = "" + score;
            for (int i = 0; i < snake.Length; i++)
            {
                if (i > tail) { snake[i].Visible = false; } else { snake[i].Visible = true; }
                switch (direction)
                {
                    case "Up": snake[i].Location = new System.Drawing.Point(snake[i].Location.X, snake[i].Location.Y - size); break;
                    case "Down": snake[i].Location = new System.Drawing.Point(snake[i].Location.X, snake[i].Location.Y + size); break;
                    case "left": snake[i].Location = new System.Drawing.Point(snake[i].Location.X - size, snake[i].Location.Y); break;
                    case "right": snake[i].Location = new System.Drawing.Point(snake[i].Location.X + size, snake[i].Location.Y); break;
                }


            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 38: direction = "Up"; break;
                case 40: direction = "Down"; break;
                case 37: direction = "left"; break;
                case 39: direction = "right"; break;
            }
        }
    }
}
