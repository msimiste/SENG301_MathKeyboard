using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("∮");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("{∫}");
        }

        private void cmdCaps_CheckedChanged(object sender, EventArgs e)
        {
            if (cmdCaps.Checked)
                cmdCaps.ForeColor = System.Drawing.Color.Red;
            else
                cmdCaps.ForeColor = SystemColors.ButtonHighlight;

        }

        private void cmdShift_CheckedChanged(object sender, EventArgs e)
        {
            
              if((!(cmdCaps.Checked))&&(cmdShift.Checked))  
                  cmdShift.ForeColor = System.Drawing.Color.Red;
            else
                cmdShift.ForeColor = SystemColors.ButtonHighlight;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("@");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("#");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("$");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("{%}");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("{^}");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("&");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("*");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("{(}");
                cmdShift.Checked = false;
            }
            else
                SendKeys.SendWait("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (cmdCaps.Checked || cmdShift.Checked)
            {
                SendKeys.Send("{)}");
                cmdShift.Checked = false;
            }
            else
                SendKeys.Send("0");
        }

        private void cmdSuperscript_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^+(=)");
        }

        private void cmdSubscript_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^(=)");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

 
    }
}
