using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSnakes
{
    class snakegen
    {
        public Keys[] k;
        Label[] body;
        public int dir;
        public static int bodylength = 4;
        public static int bodySise = 16;
        /// <summary>
        /// genereer een snake met de megeleverde properties
        /// </summary>
        public snakegen(Keys[] K,Color C,Point P, Control Target) {
            this.k = K;
            body = new Label[bodylength];
            for (int i = 0; i < body.Length; i++)
            {
                body[i] = new Label();
                body[i].BackColor = C;
                body[i].Size = new Size(bodySise, bodySise);
                body[i].Location = new Point(P.X, P.Y + bodySise*i);
                body[i].Tag = i;
                if (i == 0)
                {
                    body[i].BorderStyle = BorderStyle.FixedSingle;
                    body[i].BackColor = Color.Black;
                }
                Target.Controls.Add(body[i]);


            }
            
        }
        /// <summary>
        /// verplaats de Snake kom naar de gekozen rigting
        /// en laat de staar de kop 1 voor 1 volgen
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
        public static int foodSise = 16;

        public foodgen(Point P, Control Target) 
        {
            food = new Label();
            food = new Label();
            food.BackColor = Color.Yellow;
            food.Size = new Size(foodSise, foodSise);
            food.Location = new Point(P.X, P.Y);
            food.Tag = "Food";
            Target.Controls.Add(food);
        }
    }
}
