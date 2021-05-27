using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSnakes
{
    class core
    {
        /// <summary>
        /// return a lighter version of the same color
        /// </summary>
        public static Color LighterColor(Color color, float correctionfactory = 50f)
        {
            correctionfactory = correctionfactory / 100f;
            const float rgb255 = 255f;
            return Color.FromArgb
                (
                (int)((float)color.R + ((rgb255 - (float)color.R) * correctionfactory)), 
                (int)((float)color.G + ((rgb255 - (float)color.G) * correctionfactory)), 
                (int)((float)color.B + ((rgb255 - (float)color.B) * correctionfactory))
                );
        }
    }
    class snakegen
    {
        public Keys[] k;
        public Label[] body;
        public int dir;
        public static int bodylength = 4;
        public static int bodySise = 16;
        public bool living = true;
        public int score = 0;
        
        /// <summary>
        /// create a snake with the given properties
        /// </summary>
        public snakegen(Keys[] K,Color C,Point P, Control Target) {
            this.k = K;
            body = new Label[bodylength];
            for (int i = 0; i < body.Length; i++)
            {
                body[i] = new Label();
                body[i].BackColor = core.LighterColor(C);
                body[i].Size = new Size(bodySise, bodySise);
                body[i].Location = new Point(P.X, P.Y + bodySise*i);
                body[i].Tag = i;
                if (i == 0)
                {
                    body[i].BorderStyle = BorderStyle.FixedSingle;
                    body[i].BackColor = C;
                }
                Target.Controls.Add(body[i]);


            }
            
        }
        /// <summary>
        /// move the Snake head to the chosen direction
        /// and move the tail to the location of the block in front of it
        /// </summary>
        public void Move()
        {
            if (living)
            {
                // moves the tail
                for (int i = body.Length -1; i>0;i--)
            {
                body[i].Location = body[i - 1].Location;
            }
            
                // move the head
                Point SnakeHead = body[0].Location;
            switch (dir)
            {
                case 0: body[0].Location = new Point(SnakeHead.X, SnakeHead.Y - snakegen.bodySise); break;
                case 1: body[0].Location = new Point(SnakeHead.X + snakegen.bodySise, SnakeHead.Y); break;
                case 2: body[0].Location = new Point(SnakeHead.X, SnakeHead.Y + snakegen.bodySise); break;
                case 3: body[0].Location = new Point(SnakeHead.X - snakegen.bodySise, SnakeHead.Y); break;
            }
        }
        }
        internal void collision(snakegen Snake, Panel PlayArea, Panel Endscreen)
        {
               
            if (body[0].Location.X == -16)             {endgame(PlayArea, Endscreen); }
            if (body[0].Location.Y == -16)             {endgame(PlayArea, Endscreen); }
            if (body[0].Location.X == PlayArea.Width)  {endgame(PlayArea, Endscreen); }
            if (body[0].Location.Y == PlayArea.Height) {endgame(PlayArea, Endscreen); }
            for (int i = 1; i < body.Length; i++){if (body[0].Location == body[i].Location) { endgame(PlayArea, Endscreen); }}

        }
        /// <summary>
        /// ends the game and clears the field
        /// </summary>
        /// <algo>
        /// display the game over screen
        /// clear the Panel
        /// play the collision sound
        /// </algo>
        internal void endgame(Panel playArea, Panel Endscreen) 
        {
            Game.players--;
            living = false;
            Console.WriteLine(Game.players);
            var collisionsound = new SoundPlayer(@"Resources\collision.wav");
            if (!living) collisionsound.Play();
            for (int i = 0; i < body.Length; i++) {body[i].Location = new Point(10000 + (16*i), 10000);}
            if (Game.players == 0) {playArea.Controls.Clear();Endscreen.Visible = true;}        
        }

        /// <summary>
        /// see if the player should get a point and get longer
        /// </summary>
        /// <algo>
        /// look at the location of the player and that of the food they are the same then give that player a point and add a piece to the tail
        /// </algo>
        /// <param name="food"></param>
        /// <param name="Target"></param>
        internal void checkScore(foodgen food, Control Target)
        {            
            if (body[0].Location == food.foodloc)
            {
                var foodsound = new SoundPlayer(@"Resources\food.wav");
                foodsound.Play(); 
                food.Move(Target);
                score++;
                Array.Resize(ref body, body.Length + 1);
                body[body.Length - 1] = new Label();
                body[body.Length - 1].BackColor = body[body.Length - 2].BackColor;
                body[body.Length - 1].Size = new Size(bodySise, bodySise);
                body[body.Length - 1].Location = new Point(-32,0);
                body[body.Length - 1].Tag = body.Length - 1;
                Target.Controls.Add(body[body.Length - 1]);
            }

        }
    }
    /// <summary>
    /// put a piece of food on the playing field
    /// <algo>
    /// generate a random number and place the food on that spot
    /// </algo>
    /// </summary>
    class foodgen 
    {
        Label food;
        public static int foodSise = snakegen.bodySise;
        public Point foodloc;
        static Random Rand = new Random();
        public foodgen(Control Target) 
        {
            food = new Label();
            food.BackColor = Color.Yellow;
            food.Size = new Size(foodSise, foodSise);
            food.Location = foodpos(Target);
            foodloc = food.Location;
            food.Name = "Food";
            Target.Controls.Add(food);
        }
        public void Move(Control Target)
        {
            food.Location = foodpos(Target);
            foodloc = food.Location;
            // send pos to server 
        }
        /// <summary>
        /// create a point with a random value within the playing field
        /// </summary>
        public static Point foodpos(Control Target)
        {
            //125
            int Width = Target.Width;
            int Height = Target.Height;
            int randpos = (16 * Rand.Next(1, 29));
            Point pos = new Point(randpos, randpos);
            return pos;
        }
    }
}
