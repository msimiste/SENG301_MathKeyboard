using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathKeyBoard
{
    public partial class MainKeyboard : Form
    {
        private String up;
        private String low;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;

            }
        }
        public MainKeyboard()
        {
            InitializeComponent();
        }

        public String getUp()
        {
            return this.up;
        }
        public String getLow()
        {
            return this.low;
        }
        public void setUp(String newUpValue)
        {
            up = newUpValue;
        }
        public void setLow(String newLowValue)
        {
            low = newLowValue;
        }




        private void but_Click(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);
            

        }



        private void LinkToSetTheory_Click(object sender, EventArgs e)
        {
            if (Help1.FormOpen("SetTheory_Logic"))
            {
                SetTheory_Logic SetTheory1 = new SetTheory_Logic();
                SetTheory1.Show();
                SetTheory1.TopMost = true;
            }

            else
                Help1.getOpenForm(this.ParentForm, "SetTheory_Logic").Show();
        }
        private void MainKeyboard_Load(object sender, EventArgs e)
        {

        }

        private void LInkToGreek_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            if (Help1.FormOpen("Greek"))
            {
                Greek Greek1 = new Greek();
                Greek1.Show();
                Greek1.TopMost = true;
            }
            else
                Help1.getOpenForm(this.ParentForm, "Greek").Show();
        }

        private void SingleIntegral_Click(object sender, EventArgs e)
        {
            Bounds boundsDialog = new Bounds();
            boundsDialog.TopMost = true;
            boundsDialog.ShowDialog();

            String tst = ("{F}^+{=}" + up);
            SendKeys.Send("^(=)" + low + "^(=)");
            SendKeys.Send("{∫}^+{=}" + up + "^+{=}");

        }

        private void SuperScript_Click(object sender, EventArgs e)
        {

        }

        private void Hat_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0302%(x)");
        }

        private void BAR_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0304%(x)");
        }

        private void DOT_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0307%(x)");
        }
    }
}
