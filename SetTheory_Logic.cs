using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2;


namespace MathKeyBoard
{
    public partial class SetTheory_Logic : Form
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
        public SetTheory_Logic()
        {
            InitializeComponent();
        }

        private void Logic_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            // this.MaximumSize = new System.Drawing.Size((int)System.Windows.PrimaryScreenWidth, (int)System.Windows.SystemParameters.PrimaryScreenHeight);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);
            Help1.updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys

        }

        private void brackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{(}{)}{LEFT}");
        }


        private void CurlyBrackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{{}{}}{LEFT}");
        }


        private void LInkToGreek_Click(object sender, EventArgs e)
        {
            if (Help1.FormOpen("Greek"))
            {
                Greek Greek1 = new Greek();
                Greek1.Show();
                Greek1.TopMost = true;
            }
            else
                Help1.getOpenForm(this.ParentForm, "Greek").Show();
        }

    }
}
