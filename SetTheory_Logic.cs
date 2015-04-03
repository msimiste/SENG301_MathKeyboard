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
        public String tempText; // This variable is created solely for testing purposes

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

        public SetTheory_Logic()
        {
            InitializeComponent();
            setTempForm();  // set tempForm in order to have access to the Helpers Class within
        }
        
        // this method was created so that test classes could have access to an "Open" mainKeyboard object
        public void setTempForm()
        {
            foreach (Form tempMainKeyBoard in Application.OpenForms)
            {
                if (tempMainKeyBoard.Name == "MainKeyboard")
                {
                    tempForm = (MainKeyboard)tempMainKeyBoard;
                }
            }
        }

        public void openFormForTest() // used for testing purposes
        {
            tempForm = new MainKeyboard();
            tempForm.Show();
            this.Show();
        }  

        /* Since there is no known way to "capture" the value sent by SendKeys, the variable tempText captures what would be sent
additionally, the method button1_Click will be private when final product is released, 
button1_Click1 is public solely for testing purposes.
*/
        public void button1_Click(object sender, EventArgs e)
        {
            tempText = ((Button)sender).Text; // This variable is used only for testing purposes, as observed below, the value tempText is
            // the same value send by the method SendKeys

            SendKeys.SendWait(((Button)sender).Text); // This code was changed to "SendWait" soley for testing purposes, released product would
            // use the method "SendKeys.Send() in place of SendKeys.SendWait()"

            tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
            tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
        }

         /*!!!!!!!!!!!!!!!!! Replace with this when product is released!!!!!!!!!!!!!!!!!!
                    */

                //private void button1_Click(object sender, EventArgs e)
                //{
                //    SendKeys.Send(((Button)sender).Text);        
            
                //    tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
                //    tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
                //}
        /*!!!!!!!!!!!!!!!!! Replace with this when product is released!!!!!!!!!!!!!!!!!!*/


        //
        // Special keys are those which do not send their text values to the open application
        //
        // method handles the event "brackets_Click" for special key "Brackets"
        private void brackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{(}{)}{LEFT}");
        }

        // method handles the event "CurlyBrackets_Click" for special key "CurlyBrackets"
        private void CurlyBrackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{{}{}}{LEFT}");
        }

        private void LinkToGreek_Click(object sender, EventArgs e)
        {
            // opens a "Greek" WindowsForm if the boolean value returned is set to true
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
