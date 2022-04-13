
namespace Pong
{
    partial class FormPong
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
            this.Lbl_PlayerName = new System.Windows.Forms.Label();
            this.Lbl_PlayerScore = new System.Windows.Forms.Label();
            this.Lbl_BotName = new System.Windows.Forms.Label();
            this.Lbl_BotScore = new System.Windows.Forms.Label();
            this.Lbl_Countdown = new System.Windows.Forms.Label();
            this.Lbl_Bottom = new System.Windows.Forms.Label();
            this.PicBox_Ball = new System.Windows.Forms.PictureBox();
            this.Lbl_Top = new System.Windows.Forms.Label();
            this.Timer_Countdown = new System.Windows.Forms.Timer(this.components);
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Picbox_Player = new System.Windows.Forms.PictureBox();
            this.Timer_Game = new System.Windows.Forms.Timer(this.components);
            this.PicBox_Bot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bot)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_PlayerName
            // 
            this.Lbl_PlayerName.AutoSize = true;
            this.Lbl_PlayerName.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_PlayerName.ForeColor = System.Drawing.Color.White;
            this.Lbl_PlayerName.Location = new System.Drawing.Point(12, 9);
            this.Lbl_PlayerName.Name = "Lbl_PlayerName";
            this.Lbl_PlayerName.Size = new System.Drawing.Size(45, 16);
            this.Lbl_PlayerName.TabIndex = 1;
            this.Lbl_PlayerName.Text = "label1";
            // 
            // Lbl_PlayerScore
            // 
            this.Lbl_PlayerScore.AutoSize = true;
            this.Lbl_PlayerScore.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_PlayerScore.ForeColor = System.Drawing.Color.White;
            this.Lbl_PlayerScore.Location = new System.Drawing.Point(123, 9);
            this.Lbl_PlayerScore.Name = "Lbl_PlayerScore";
            this.Lbl_PlayerScore.Size = new System.Drawing.Size(15, 16);
            this.Lbl_PlayerScore.TabIndex = 1;
            this.Lbl_PlayerScore.Text = "0";
            // 
            // Lbl_BotName
            // 
            this.Lbl_BotName.AutoSize = true;
            this.Lbl_BotName.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_BotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_BotName.ForeColor = System.Drawing.Color.White;
            this.Lbl_BotName.Location = new System.Drawing.Point(593, 9);
            this.Lbl_BotName.Name = "Lbl_BotName";
            this.Lbl_BotName.Size = new System.Drawing.Size(45, 16);
            this.Lbl_BotName.TabIndex = 1;
            this.Lbl_BotName.Text = "label1";
            // 
            // Lbl_BotScore
            // 
            this.Lbl_BotScore.AutoSize = true;
            this.Lbl_BotScore.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_BotScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_BotScore.ForeColor = System.Drawing.Color.White;
            this.Lbl_BotScore.Location = new System.Drawing.Point(729, 9);
            this.Lbl_BotScore.Name = "Lbl_BotScore";
            this.Lbl_BotScore.Size = new System.Drawing.Size(15, 16);
            this.Lbl_BotScore.TabIndex = 1;
            this.Lbl_BotScore.Text = "0";
            // 
            // Lbl_Countdown
            // 
            this.Lbl_Countdown.AutoSize = true;
            this.Lbl_Countdown.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Countdown.ForeColor = System.Drawing.Color.White;
            this.Lbl_Countdown.Location = new System.Drawing.Point(360, 9);
            this.Lbl_Countdown.Name = "Lbl_Countdown";
            this.Lbl_Countdown.Size = new System.Drawing.Size(45, 16);
            this.Lbl_Countdown.TabIndex = 1;
            this.Lbl_Countdown.Text = "label1";
            // 
            // Lbl_Bottom
            // 
            this.Lbl_Bottom.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_Bottom.Location = new System.Drawing.Point(0, 430);
            this.Lbl_Bottom.Name = "Lbl_Bottom";
            this.Lbl_Bottom.Size = new System.Drawing.Size(805, 30);
            this.Lbl_Bottom.TabIndex = 2;
            this.Lbl_Bottom.Tag = "Duvar";
            // 
            // PicBox_Ball
            // 
            this.PicBox_Ball.Image = global::Pong.Properties.Resources._342de4636c487db7d84f9535320fc7ee;
            this.PicBox_Ball.Location = new System.Drawing.Point(375, 214);
            this.PicBox_Ball.Name = "PicBox_Ball";
            this.PicBox_Ball.Size = new System.Drawing.Size(30, 30);
            this.PicBox_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Ball.TabIndex = 4;
            this.PicBox_Ball.TabStop = false;
            // 
            // Lbl_Top
            // 
            this.Lbl_Top.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_Top.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Top.Name = "Lbl_Top";
            this.Lbl_Top.Size = new System.Drawing.Size(808, 30);
            this.Lbl_Top.TabIndex = 0;
            this.Lbl_Top.Tag = "Duvar";
            // 
            // Timer_Countdown
            // 
            this.Timer_Countdown.Enabled = true;
            this.Timer_Countdown.Interval = 1000;
            this.Timer_Countdown.Tick += new System.EventHandler(this.Timer_Countdown_Tick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Image = global::Pong.Properties.Resources._60_608870_line_lines_neon_purple_freetoedit_neon_lines_png;
            this.Btn_Exit.Location = new System.Drawing.Point(717, 430);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Picbox_Player
            // 
            this.Picbox_Player.Image = global::Pong.Properties.Resources._60_608870_line_lines_neon_purple_freetoedit_neon_lines_png;
            this.Picbox_Player.Location = new System.Drawing.Point(5, 179);
            this.Picbox_Player.Name = "Picbox_Player";
            this.Picbox_Player.Size = new System.Drawing.Size(10, 60);
            this.Picbox_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_Player.TabIndex = 9;
            this.Picbox_Player.TabStop = false;
            // 
            // Timer_Game
            // 
            this.Timer_Game.Enabled = true;
            this.Timer_Game.Interval = 20;
            this.Timer_Game.Tick += new System.EventHandler(this.Timer_Game_Tick);
            // 
            // PicBox_Bot
            // 
            this.PicBox_Bot.Image = global::Pong.Properties.Resources._60_608870_line_lines_neon_purple_freetoedit_neon_lines_png;
            this.PicBox_Bot.Location = new System.Drawing.Point(790, 214);
            this.PicBox_Bot.Name = "PicBox_Bot";
            this.PicBox_Bot.Size = new System.Drawing.Size(10, 60);
            this.PicBox_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Bot.TabIndex = 10;
            this.PicBox_Bot.TabStop = false;
            // 
            // FormPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.PicBox_Bot);
            this.Controls.Add(this.Picbox_Player);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.PicBox_Ball);
            this.Controls.Add(this.Lbl_Bottom);
            this.Controls.Add(this.Lbl_BotScore);
            this.Controls.Add(this.Lbl_BotName);
            this.Controls.Add(this.Lbl_PlayerScore);
            this.Controls.Add(this.Lbl_Countdown);
            this.Controls.Add(this.Lbl_PlayerName);
            this.Controls.Add(this.Lbl_Top);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormPong";
            this.Text = "FormPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Bot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_PlayerName;
        private System.Windows.Forms.Label Lbl_PlayerScore;
        private System.Windows.Forms.Label Lbl_BotName;
        private System.Windows.Forms.Label Lbl_BotScore;
        private System.Windows.Forms.Label Lbl_Countdown;
        private System.Windows.Forms.Label Lbl_Bottom;
        private System.Windows.Forms.PictureBox PicBox_Ball;
        private System.Windows.Forms.Label Lbl_Top;
        private System.Windows.Forms.Timer Timer_Countdown;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.PictureBox Picbox_Player;
        private System.Windows.Forms.Timer Timer_Game;
        private System.Windows.Forms.PictureBox PicBox_Bot;
    }
}