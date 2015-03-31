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
        private MainKeyboard tempForm;
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
            setTempForm();  // set tempForm in order to have access to the Helpers Class within
        }

        private void setTempForm()
        {
            foreach (Form tempMainKeyBoard in Application.OpenForms)
            {
                if (tempMainKeyBoard.Name == "MainKeyboard")
                {
                    tempForm = (MainKeyboard)tempMainKeyBoard;
                }
            }
        }


        private void Logic_Load(object sender, EventArgs e)
        {
           

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);        
            
            tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
            tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
        }

 
        private void brackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{(}{)}{LEFT}");
        }


        private void CurlyBrackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{{}{}}{LEFT}");
        }


        private void LinkToGreek_Click(object sender, EventArgs e)
        {
            if (tempForm.getHelp().FormOpen("Greek"))
            {
                Greek Greek1 = new Greek();
                Greek1.Show();
                Greek1.TopMost = true;
            }
            else
                tempForm.getHelp().getOpenForm(this.ParentForm, "Greek").Show();

            
        }

    }
}
