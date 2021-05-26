
namespace BattleSnakes
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
            this.PlayArea = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SnakeDis1 = new System.Windows.Forms.GroupBox();
            this.SnakeScore1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SnakeDis2 = new System.Windows.Forms.GroupBox();
            this.SnakeScore2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameMenu = new System.Windows.Forms.Panel();
            this.BTN_Online = new System.Windows.Forms.Button();
            this.BTN_Multiplayer = new System.Windows.Forms.Button();
            this.BTN_Singleplayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pen_GameOver = new System.Windows.Forms.Panel();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.BTN_menu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SnakeDis1.SuspendLayout();
            this.SnakeDis2.SuspendLayout();
            this.GameMenu.SuspendLayout();
            this.Pen_GameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlayArea.Location = new System.Drawing.Point(0, 0);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(480, 480);
            this.PlayArea.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SnakeDis1
            // 
            this.SnakeDis1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SnakeDis1.Controls.Add(this.SnakeScore1);
            this.SnakeDis1.Controls.Add(this.label1);
            this.SnakeDis1.Location = new System.Drawing.Point(486, 12);
            this.SnakeDis1.Name = "SnakeDis1";
            this.SnakeDis1.Size = new System.Drawing.Size(218, 36);
            this.SnakeDis1.TabIndex = 2;
            this.SnakeDis1.TabStop = false;
            this.SnakeDis1.Text = "Snake 1";
            this.SnakeDis1.Visible = false;
            // 
            // SnakeScore1
            // 
            this.SnakeScore1.AutoSize = true;
            this.SnakeScore1.Location = new System.Drawing.Point(53, 16);
            this.SnakeScore1.Name = "SnakeScore1";
            this.SnakeScore1.Size = new System.Drawing.Size(10, 13);
            this.SnakeScore1.TabIndex = 0;
            this.SnakeScore1.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score :";
            // 
            // SnakeDis2
            // 
            this.SnakeDis2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SnakeDis2.Controls.Add(this.SnakeScore2);
            this.SnakeDis2.Controls.Add(this.label2);
            this.SnakeDis2.Location = new System.Drawing.Point(486, 54);
            this.SnakeDis2.Name = "SnakeDis2";
            this.SnakeDis2.Size = new System.Drawing.Size(218, 36);
            this.SnakeDis2.TabIndex = 2;
            this.SnakeDis2.TabStop = false;
            this.SnakeDis2.Text = "Snake 2";
            this.SnakeDis2.Visible = false;
            // 
            // SnakeScore2
            // 
            this.SnakeScore2.AutoSize = true;
            this.SnakeScore2.Location = new System.Drawing.Point(55, 16);
            this.SnakeScore2.Name = "SnakeScore2";
            this.SnakeScore2.Size = new System.Drawing.Size(10, 13);
            this.SnakeScore2.TabIndex = 0;
            this.SnakeScore2.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score :";
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameMenu.Controls.Add(this.BTN_Online);
            this.GameMenu.Controls.Add(this.BTN_Multiplayer);
            this.GameMenu.Controls.Add(this.BTN_Singleplayer);
            this.GameMenu.Controls.Add(this.label3);
            this.GameMenu.Location = new System.Drawing.Point(-1, -4);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(718, 489);
            this.GameMenu.TabIndex = 0;
            // 
            // BTN_Online
            // 
            this.BTN_Online.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Online.Cursor = System.Windows.Forms.Cursors.No;
            this.BTN_Online.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Online.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Online.ForeColor = System.Drawing.Color.DimGray;
            this.BTN_Online.Location = new System.Drawing.Point(216, 294);
            this.BTN_Online.Name = "BTN_Online";
            this.BTN_Online.Size = new System.Drawing.Size(282, 54);
            this.BTN_Online.TabIndex = 1;
            this.BTN_Online.Text = "Online";
            this.BTN_Online.UseVisualStyleBackColor = false;
            this.BTN_Online.Click += new System.EventHandler(this.BTN_Online_Click);
            // 
            // BTN_Multiplayer
            // 
            this.BTN_Multiplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Multiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Multiplayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Multiplayer.ForeColor = System.Drawing.Color.White;
            this.BTN_Multiplayer.Location = new System.Drawing.Point(216, 234);
            this.BTN_Multiplayer.Name = "BTN_Multiplayer";
            this.BTN_Multiplayer.Size = new System.Drawing.Size(282, 54);
            this.BTN_Multiplayer.TabIndex = 1;
            this.BTN_Multiplayer.Text = "Local Multiplayer";
            this.BTN_Multiplayer.UseVisualStyleBackColor = false;
            this.BTN_Multiplayer.Click += new System.EventHandler(this.BTN_Multiplayer_Click);
            // 
            // BTN_Singleplayer
            // 
            this.BTN_Singleplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Singleplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Singleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Singleplayer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Singleplayer.ForeColor = System.Drawing.Color.White;
            this.BTN_Singleplayer.Location = new System.Drawing.Point(216, 174);
            this.BTN_Singleplayer.Name = "BTN_Singleplayer";
            this.BTN_Singleplayer.Size = new System.Drawing.Size(282, 54);
            this.BTN_Singleplayer.TabIndex = 1;
            this.BTN_Singleplayer.Text = "Singleplayer";
            this.BTN_Singleplayer.UseVisualStyleBackColor = false;
            this.BTN_Singleplayer.Click += new System.EventHandler(this.BTN_Singleplayer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 148);
            this.label3.TabIndex = 0;
            this.label3.Text = "Snake";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pen_GameOver
            // 
            this.Pen_GameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pen_GameOver.Controls.Add(this.BTN_exit);
            this.Pen_GameOver.Controls.Add(this.BTN_menu);
            this.Pen_GameOver.Controls.Add(this.label4);
            this.Pen_GameOver.Location = new System.Drawing.Point(-1, -4);
            this.Pen_GameOver.Name = "Pen_GameOver";
            this.Pen_GameOver.Size = new System.Drawing.Size(718, 489);
            this.Pen_GameOver.TabIndex = 3;
            this.Pen_GameOver.Visible = false;
            // 
            // BTN_exit
            // 
            this.BTN_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_exit.ForeColor = System.Drawing.Color.White;
            this.BTN_exit.Location = new System.Drawing.Point(216, 234);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(282, 54);
            this.BTN_exit.TabIndex = 1;
            this.BTN_exit.Text = "Exit";
            this.BTN_exit.UseVisualStyleBackColor = false;
            this.BTN_exit.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // BTN_menu
            // 
            this.BTN_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_menu.ForeColor = System.Drawing.Color.White;
            this.BTN_menu.Location = new System.Drawing.Point(216, 174);
            this.BTN_menu.Name = "BTN_menu";
            this.BTN_menu.Size = new System.Drawing.Size(282, 54);
            this.BTN_menu.TabIndex = 1;
            this.BTN_menu.Text = "Menu";
            this.BTN_menu.UseVisualStyleBackColor = false;
            this.BTN_menu.Click += new System.EventHandler(this.BTN_menu_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 148);
            this.label4.TabIndex = 0;
            this.label4.Text = "Game Over";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 481);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.Pen_GameOver);
            this.Controls.Add(this.PlayArea);
            this.Controls.Add(this.SnakeDis2);
            this.Controls.Add(this.SnakeDis1);
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.SnakeDis1.ResumeLayout(false);
            this.SnakeDis1.PerformLayout();
            this.SnakeDis2.ResumeLayout(false);
            this.SnakeDis2.PerformLayout();
            this.GameMenu.ResumeLayout(false);
            this.Pen_GameOver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayArea;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox SnakeDis1;
        private System.Windows.Forms.Label SnakeScore1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SnakeDis2;
        private System.Windows.Forms.Label SnakeScore2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GameMenu;
        private System.Windows.Forms.Button BTN_Online;
        private System.Windows.Forms.Button BTN_Multiplayer;
        private System.Windows.Forms.Button BTN_Singleplayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pen_GameOver;
        private System.Windows.Forms.Button BTN_exit;
        private System.Windows.Forms.Button BTN_menu;
        private System.Windows.Forms.Label label4;
    }
}

