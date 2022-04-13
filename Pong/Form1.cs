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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Basla_Click(object sender, EventArgs e)
        {
            FormPong pong = new FormPong();
            pong.Show();
            pong.Verial(Convert.ToInt32(Cmb_Countdown.SelectedItem), Convert.ToInt32(Cmb_ScoreLimit.SelectedItem), Txt_PlayerName.Text, Txt_BotName.Text);
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_Countdown.Items.Add("60");
            Cmb_Countdown.SelectedIndex = 0;
            Cmb_Countdown.Items.Add("120");
            Cmb_Countdown.Items.Add("180");
            Cmb_Countdown.Items.Add("240");
            Cmb_Countdown.Items.Add("300");

            Cmb_ScoreLimit.Items.Add("3");
            Cmb_ScoreLimit.SelectedIndex = 0;
            Cmb_ScoreLimit.Items.Add("5");
            Cmb_ScoreLimit.Items.Add("7");
            Cmb_ScoreLimit.Items.Add("10");
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
