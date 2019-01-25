using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_Games
{
    public partial class frmikiKisi : Form
    {
        public frmikiKisi()
        {
            InitializeComponent();
        }
        Button b;
        bool turn = true;
        int turn_count = 0;
        int saniye1, saniye2, toplamsaniye1, toplamsaniye2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye1 = saniye1 + 1;
            toplamsaniye1 = toplamsaniye1 + saniye1;
            saniye1 = 0;
            lblPlayer1Timer.Text = toplamsaniye1.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye2 = saniye2 + 1;
            toplamsaniye2 = toplamsaniye2 + saniye2;
            saniye2 = 0;
            lblPlayer2Timer.Text = toplamsaniye2.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                timer2.Interval = 1000;
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                b.Text = "O";
                timer1.Interval = 1000;
                timer1.Start();
                timer2.Stop();
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            Kazananlar();



        }

        private void Kazananlar()
        {
            bool kazanan = false;
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                kazanan = true;
            if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                kazanan = true;
            if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                kazanan = true;
            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                kazanan = true;
            if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn5.Enabled))
                kazanan = true;
            if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                kazanan = true;
            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                kazanan = true;
            if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
                kazanan = true;


            if (kazanan)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show(winner + "kazanan");
            }
            else
            {
                if (turn_count == 9)
                {
                    timer1.Stop();
                    timer2.Stop();
                    if (toplamsaniye1 < toplamsaniye2)
                        MessageBox.Show("X kazanan(süreyle)");
                    else if (toplamsaniye1 > toplamsaniye2)
                        MessageBox.Show("O kazanan(süreyle)");
                    else
                        MessageBox.Show("berabere(süreler eşit)");
                    timer1.Stop();
                    timer2.Stop();
                }

            }


        }
    }
}
