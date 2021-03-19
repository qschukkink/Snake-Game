using System;
using System.Windows.Forms;

namespace SnakeGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game_Canvas = new System.Windows.Forms.Panel();
            this.Snake_Food = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Snake_Home = new System.Windows.Forms.Panel();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Game_Canvas.SuspendLayout();
            this.Snake_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // Game_Canvas
            // 
            this.Game_Canvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Game_Canvas.Controls.Add(this.Snake_Food);
            this.Game_Canvas.Location = new System.Drawing.Point(0, 0);
            this.Game_Canvas.Name = "Game_Canvas";
            this.Game_Canvas.Size = new System.Drawing.Size(560, 560);
            this.Game_Canvas.TabIndex = 0;
            // 
            // Snake_Food
            // 
            this.Snake_Food.BackColor = System.Drawing.Color.Yellow;
            this.Snake_Food.Location = new System.Drawing.Point(581, 0);
            this.Snake_Food.Name = "Snake_Food";
            this.Snake_Food.Size = new System.Drawing.Size(16, 16);
            this.Snake_Food.TabIndex = 0;
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_s.ForeColor = System.Drawing.Color.White;
            this.label_s.Location = new System.Drawing.Point(560, 0);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(80, 25);
            this.label_s.TabIndex = 1;
            this.label_s.Text = "Score:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.White;
            this.label_score.Location = new System.Drawing.Point(646, 0);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(24, 25);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "0";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Snake_Home
            // 
            this.Snake_Home.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Snake_Home.Controls.Add(this.BTN_exit);
            this.Snake_Home.Controls.Add(this.BTN_Play);
            this.Snake_Home.Controls.Add(this.label1);
            this.Snake_Home.Location = new System.Drawing.Point(0, 0);
            this.Snake_Home.Name = "Snake_Home";
            this.Snake_Home.Size = new System.Drawing.Size(756, 560);
            this.Snake_Home.TabIndex = 1;
            // 
            // BTN_exit
            // 
            this.BTN_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exit.Location = new System.Drawing.Point(233, 340);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(273, 65);
            this.BTN_exit.TabIndex = 1;
            this.BTN_exit.Text = "Exit";
            this.BTN_exit.UseVisualStyleBackColor = false;
            this.BTN_exit.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // BTN_Play
            // 
            this.BTN_Play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Play.Location = new System.Drawing.Point(233, 260);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(273, 65);
            this.BTN_Play.TabIndex = 1;
            this.BTN_Play.Text = "Play";
            this.BTN_Play.UseVisualStyleBackColor = false;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snake";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(755, 560);
            this.Controls.Add(this.Snake_Home);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.Game_Canvas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(771, 640);
            this.Name = "Game";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Game_Canvas.ResumeLayout(false);
            this.Snake_Home.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Game_Canvas;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Snake_Food;
        private System.Windows.Forms.Panel Snake_Home;
        private System.Windows.Forms.Button BTN_exit;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Label label1;
    }
}

