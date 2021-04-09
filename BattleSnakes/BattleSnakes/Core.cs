using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        Label[] body;
        public int dir;
        public static int bodylength = 4;
        public static int bodySise = 16;
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
            //beweeg de staart
            for (int i = body.Length -1; i>0;i--)
            {
                body[i].Location = body[i - 1].Location;
            }
            // beweeg de kop
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
    class foodgen 
    {
        Label food;
        public static int foodSise = snakegen.bodySise;
        static Random Rand = new Random();
        public foodgen(Control Target) 
        {
            food = new Label();
            food.BackColor = Color.Yellow;
            food.Size = new Size(foodSise, foodSise);
            food.Location = foodpos(Target);
            food.Tag = "Food";
            Target.Controls.Add(food);
        }
        /// <summary>
        /// create a point with a random value within the playing field
        /// </summary>
        public Point foodpos(Control Target)
        {
            int Width = Target.Width;
            int Height = Target.Height;
            Point pos = new Point(Rand.Next(0, Width - foodSise), Rand.Next(0, Height - foodSise));
            return pos;
        }
    }
}
