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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnLanBasla_Click(object sender, EventArgs e)
        {
            if(rbtnYeniServer.Checked ==true)
            {
                frmServer frm = new frmServer();
                frm.Show();
            }
            if(rbtnAgaKatil.Checked == true)
            {
                frmClient frm2 = new frmClient();
                frm2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void rbtnbotakarsi_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void rbtnIkiKisilik_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void rbtnLan_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (rbtnbotakarsi.Checked == true)
            {
                frmYapayZeka frm3 = new frmYapayZeka();
                frm3.Show();
            }
            if (rbtnIkiKisilik.Checked == true)
            {
                frmikiKisi frm4 = new frmikiKisi();
                frm4.Show();
            }
        }
    }
}
