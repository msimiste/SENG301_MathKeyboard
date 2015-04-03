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
        public String  tempText; // This variable is created solely for testing purposes


        // CreateParams is included as it allows focus to remain on an open application instead of transferring to the Windows form
        // This is essential for the proper functionality of SendKeys, the class which allows typing to occur in an open applications.
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

        public Helpers getHelp()
        {
            return this.Help1;
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

        /* Since there is no known way to "capture" the value sent by SendKeys, the variable tempText captures what would be sent
            additionally, the method but_Click will be private when final product is released, 
            but_click is public solely for testing purposes.
         */
        public void but_Click(object sender, EventArgs e)
        {
            tempText = ((Button)sender).Text; // This variable is used only for testing purposes, as observed below, the value tempText is
                                              // the same value send by the method SendKeys

             SendKeys.SendWait(((Button)sender).Text); // This code was changed to "SendWait" soley for testing purposes, released product would
                                                       // use the method "SendKeys.Send() in place of SendKeys.SendWait()"              
        }

        private void LinkToSetTheory_Click(object sender, EventArgs e)
        {
            // opens a setTheory_Logic WindowsForm if the boolean value returned is set to true
            if (Help1.FormOpen("SetTheory_Logic"))
            {
                SetTheory_Logic SetTheory1 = new SetTheory_Logic();
                SetTheory1.Show();
                SetTheory1.TopMost = true;
            }
            else
                Help1.getOpenForm(this.ParentForm, "SetTheory_Logic").Show();
        }
 
        private void LInkToGreek_Click(object sender, EventArgs e)
        {
            // opens a Greek WindowsForm if the boolean value returned is set to true
            if (Help1.FormOpen("Greek"))
            {
                Greek Greek1 = new Greek();
                Greek1.Show();
                Greek1.TopMost = true;
            }
            else
                Help1.getOpenForm(this.ParentForm, "Greek").Show();
        }

        //
        // Special keys are those which do not send their text values to the open application
        //

        // method handles the event "Click" for special key "Integral"
        private void SingleIntegral_Click(object sender, EventArgs e)
        {
            Bounds boundsDialog = new Bounds();
            boundsDialog.TopMost = true;
            boundsDialog.ShowDialog();
            
            SendKeys.Send("^(=)" + low + "^(=)");
            SendKeys.Send("{∫}^+{=}" + up + "^+{=}");
        }

        // method handles the event "Click" for special key "SuperScript"
        private void SuperScript_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^+{=}");
        }

        // method handles the event "Click" for special key "SubScript"
        private void SubScript_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{=}");
        }

        // method handles the event "Click" for special key "Hat_Click"
        private void Hat_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0302%(x)");
        }

        // method handles the event "Click" for special key "BAR_Click"
        private void BAR_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0304%(x)");
        }

        // method handles the event "Click" for special key "Dot_Click"
        private void DOT_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0307%(x)");
        }

       

      
    }
}
