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
    public partial class frmYapayZeka : Form
    {
        public frmYapayZeka()
        {
            InitializeComponent();
        }
        Button b;
        bool turn = true;
        int turn_count = 0;
        int saniye1, saniye2, toplamsaniye1, toplamsaniye2 = 0;
        int playerskor = 0, cpuskor = 0, berabere = 0;

        

        private void computermakemove()
        {
            Button move = null;
            move = Look_for_win_or_block("O");
            if(move==null)
            {
                move = Look_for_win_or_block("X");
                if(move==null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        look_for_open_space();
                    }
                }
            }
            move.PerformClick();
        }
        private Button Look_for_win_or_block(string mark)
        {
            if(btn1.Text==mark && btn2.Text==mark &&btn3.Text=="")
            {
                return btn3;
            }
            if (btn2.Text == mark && btn3.Text == mark && btn1.Text == "")
            {
                return btn1;
            }
            if (btn1.Text == mark && btn3.Text == mark && btn2.Text == "")
            {
                return btn2;
            }
            if (btn4.Text == mark && btn5.Text == mark && btn6.Text == "")
            {
                return btn6;
            }
            if (btn5.Text == mark && btn6.Text == mark && btn4.Text == "")
            {
                return btn4;
            }
            if (btn4.Text == mark && btn6.Text == mark && btn5.Text == "")
            {
                return btn5;
            }
            if (btn7.Text == mark && btn8.Text == mark && btn9.Text == "")
            {
                return btn9;
            }
            if (btn8.Text == mark && btn9.Text == mark && btn7.Text == "")
            {
                return btn7;
            }
            if (btn7.Text == mark && btn9.Text == mark && btn8.Text == "")
            {
                return btn8;
            }


            if(btn1.Text==mark && btn4.Text==mark &&btn7.Text=="")
            {
                return btn7;
            }
            if (btn4.Text == mark && btn7.Text == mark && btn1.Text == "")
            {
                return btn1;
            }
            if (btn1.Text == mark && btn7.Text == mark && btn4.Text == "")
            {
                return btn4;
            }
            if (btn2.Text == mark && btn5.Text == mark && btn8.Text == "")
            {
                return btn8;
            }
            if (btn5.Text == mark && btn8.Text == mark && btn2.Text == "")
            {
                return btn2;
            }
            if (btn2.Text == mark && btn8.Text == mark && btn5.Text == "")
            {
                return btn5;
            }
            if (btn3.Text == mark && btn6.Text == mark && btn9.Text == "")
            {
                return btn9;
            }
            if (btn6.Text == mark && btn9.Text == mark && btn3.Text == "")
            {
                return btn3;
            }
            if (btn3.Text == mark && btn9.Text == mark && btn6.Text == "")
            {
                return btn6;
            }


            if (btn1.Text == mark && btn5.Text == mark && btn9.Text == "")
            {
                return btn9;
            }
            if (btn5.Text == mark && btn9.Text == mark && btn1.Text == "")
            {
                return btn1;
            }
            if (btn1.Text == mark && btn9.Text == mark && btn5.Text == "")
            {
                return btn5;
            }
            if (btn3.Text == mark && btn5.Text == mark && btn7.Text == "")
            {
                return btn7;
            }
            if (btn3.Text == mark && btn7.Text == mark && btn5.Text == "")
            {
                return btn5;
            }
            if (btn5.Text == mark && btn7.Text == mark && btn3.Text == "")
            {
                return btn3;
            }

            return null;
        }

        private Button look_for_corner()
        {
            if(btn1.Text=="O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn7.Text == "")
                    return btn7;
                if (btn9.Text == "")
                    return btn9;
            }
            if (btn3.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn7.Text == "")
                    return btn7;
                if (btn9.Text == "")
                    return btn9;
            }
            if (btn9.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn7.Text == "")
                    return btn7;
                if (btn3.Text == "")
                    return btn3;
            }
            if (btn7.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn3.Text == "")
                    return btn3;
                if (btn9.Text == "")
                    return btn9;
            }
            if(btn1.Text=="")
            {
                return btn1;
            }
            if (btn3.Text == "")
            {
                return btn3;
            }
            if (btn7.Text == "")
            {
                return btn7;
            }
            if (btn9.Text == "")
            {
                return btn9;
            }
            return null;

        }

        private Button look_for_open_space()
        {
            Button b = null;
            foreach(Control c in Controls)
            {
                b = c as Button;
                if(b!=null)
                {
                    if(b.Text == "")
                    {
                        return b;
                    }

                }
            }
            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye1 = saniye1 + 1;
            toplamsaniye1 = toplamsaniye1 + saniye1;
            saniye1 = 0;
            saniye2 = 0;
            saniye2 = saniye2 + 1;
            toplamsaniye2 = toplamsaniye2 + saniye2;
            lblPlayer1Timer.Text = toplamsaniye1.ToString();
            lblPlayer2Timer.Text = toplamsaniye2.ToString();
            computermakemove();
            timer2.Start();
            timer1.Stop();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye2 = saniye2 + 1;
            toplamsaniye2 = toplamsaniye2 + saniye2;
            saniye2 = 0;
            lblPlayer2Timer.Text = toplamsaniye2.ToString();
            if(!turn)
            {
                timer2.Stop();
                timer1.Start();
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                timer2.Interval = 1000;
                timer2.Start();
                timer1.Interval = 1000;
                timer1.Start();
            }

            else
            {
                b.Text = "0";
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
                {
                    winner = "O";
                    cpuskor++;
                }
                else
                {
                    winner = "X";
                    playerskor++;
                }
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show(winner + "kazanan");
                lblBerabere.Text = berabere.ToString();
                lblCPUScore.Text = cpuskor.ToString();
                lblPlayerSkor.Text = playerskor.ToString();
                
            }
            else
            {
                if (turn_count == 9)
                {
                    timer1.Stop();
                    timer2.Stop();
                    if (toplamsaniye1 < toplamsaniye2)
                    {
                        MessageBox.Show("X kazanan(süreyle)");
                        playerskor++;
                    }

                    else if (toplamsaniye1 > toplamsaniye2)
                    {
                        MessageBox.Show("O kazanan(süreyle)");
                        cpuskor++;
                    }
                    else
                    {
                        MessageBox.Show("berabere(süreler eşit)");
                        berabere++;
                    }
                    lblBerabere.Text = berabere.ToString();
                    lblCPUScore.Text = cpuskor.ToString();
                    lblPlayerSkor.Text = playerskor.ToString();
          
                }
            }

        }
    }
}
