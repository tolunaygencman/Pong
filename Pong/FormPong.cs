using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class FormPong : Form
    {
        public FormPong()
        {
            InitializeComponent();
        }
        
        bool moveUp, moveDown;
        int speed = 5;
        int ball = 3;
        int EndScore;
        
        bool vertical = true;
        bool horizon = true;
        int score1;
        int score2;
        

        public void Verial(int timeLimit,int scoreLimit,string playerName,string botName)
        {
            
            Lbl_Countdown.Text = timeLimit.ToString();
            EndScore = scoreLimit;
            Lbl_BotName.Text = botName +" :";
            Lbl_PlayerName.Text = playerName+" :";
            if (playerName == "")
            {
                Lbl_PlayerName.Text = "Mr.Fuckface :";
            }
            if (botName == "")
            {
                Lbl_BotName.Text = "Mr.WorldWide :";
            } 
            
        }
     
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Timer_Countdown.Stop();
            Timer_Game.Stop();
            this.Close();
            form.Show();

        }

        private void Timer_Countdown_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int count = Convert.ToInt32(Lbl_Countdown.Text);
            count--;
            Lbl_Countdown.Text = count.ToString();
            if (rnd.Next(1,20) < 3)
            {
                ball++;
                
            }
            
        }


        private void FormPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
        }

        private void FormPong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            
        }

        private void Timer_Game_Tick(object sender, EventArgs e)
        {
            BallMove();
            BotMove();
            Movement();
            if (PicBox_Ball.Left<0)
            {
                
                score2 = Convert.ToInt32(Lbl_BotScore.Text);
                score2++;
                Lbl_BotScore.Text = score2.ToString();
                Timer_Countdown.Stop();
                Reset();
                Timer_Countdown.Start();

            }
            if (PicBox_Ball.Right>800)
            {
                score1 = Convert.ToInt32(Lbl_PlayerScore.Text);
                score1++;
                Lbl_PlayerScore.Text = score1.ToString();
                Timer_Countdown.Stop();
                Reset();
                Timer_Countdown.Start();

            }
            if (score1==EndScore)
            {
                Form1 form = new Form1();
                MessageBox.Show($"{Lbl_PlayerName.Text} kazandı");
                this.Hide();
                form.Show();

            }
            if (score2 == EndScore)
            {
                Form1 form = new Form1();
                MessageBox.Show($"{Lbl_BotName.Text} kazandı");
                this.Hide();
                form.Show();
            }
            if (Convert.ToInt32(Lbl_Countdown.Text)==0)
            {
                Timer_Countdown.Stop();
                if (score1<score2)
                {
                    Form1 form = new Form1();
                    Timer_Game.Stop();
                    MessageBox.Show($"{Lbl_BotName.Text} kazandı");
                    this.Hide();
                    form.Show();
                }
                else if (score1>score2)
                {
                    Form1 form = new Form1();
                    Timer_Game.Stop();
                    MessageBox.Show($"{Lbl_PlayerName.Text} kazandı");
                    this.Hide();
                    form.Show();
                }
                else
                {
                    Form1 form = new Form1();
                    Timer_Game.Stop();
                    MessageBox.Show("Berabere");
                    this.Hide();
                    form.Show();
                }
            }
        }
        private void Movement()
        {
            if (moveUp == true && Picbox_Player.Top > Lbl_Top.Bottom)
            {
                Picbox_Player.Top -= speed;
            }
            if (moveDown == true && Picbox_Player.Bottom < Lbl_Bottom.Top)
            {
                Picbox_Player.Top += speed;
            }
        }
        
        private void BotMove()
        {
            if (PicBox_Ball.Top < PicBox_Bot.Top+30 && PicBox_Bot.Top > Lbl_Top.Bottom)
            {
                PicBox_Bot.Top -= speed;
            }
            else if (PicBox_Ball.Top >= PicBox_Bot.Top+30 && PicBox_Bot.Bottom < Lbl_Bottom.Top)
            {
                PicBox_Bot.Top += speed;
            }
        }
        private void BallMove()
        {
            
            if (vertical == true)
            {
                PicBox_Ball.Top += ball;

            }
            else
            {
                PicBox_Ball.Top -= ball;

            }
            if (horizon == true)
            {
                PicBox_Ball.Left += ball;
            }
            else
            {
                PicBox_Ball.Left -= ball;
            }

            if (PicBox_Ball.Bottom >= Lbl_Bottom.Top)
            {
                vertical = false;
            }
            if (PicBox_Ball.Top <= Lbl_Top.Bottom)
            {
                vertical = true;
            }
            if (Picbox_Player.Bounds.IntersectsWith(PicBox_Ball.Bounds)&&PicBox_Ball.Top > Picbox_Player.Top+30) 
            {
                horizon = true;
                vertical = true;
            }
            else if (Picbox_Player.Bounds.IntersectsWith(PicBox_Ball.Bounds) && PicBox_Ball.Top <= Picbox_Player.Top + 30)
            {
                horizon = true;
                vertical = false;
            }
            if (PicBox_Bot.Bounds.IntersectsWith(PicBox_Ball.Bounds) && PicBox_Ball.Top > PicBox_Bot.Top + 30)
            {
                horizon = false;
                vertical = true;
            }
            else if (PicBox_Bot.Bounds.IntersectsWith(PicBox_Ball.Bounds) && PicBox_Ball.Top <= PicBox_Bot.Top + 30)
            {
                horizon = false;
                vertical = false;
            }

        }
        private void Reset()
        {
                      
            PicBox_Ball.Top = 200;
            PicBox_Ball.Left = 375;
            
            ball = 3;
        }
    }
}
