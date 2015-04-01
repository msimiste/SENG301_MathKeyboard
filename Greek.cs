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
    public partial class Greek : Form
    {
        private MainKeyboard tempForm;
        public String tempText; // This variable is created solely for testing purposes

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;

            }
        }

        public Greek()
        {
            InitializeComponent();
            setTempForm();
        }

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
    additionally, the method button1_Click (commented out below)  will be private when final product is released, 
    button1_click is public solely for testing purposes.
 */
        public void button1_Click(object sender, EventArgs e)
        {
            tempText = ((Button)sender).Text; // This variable is used only for testing purposes, as observed below, the value tempText is
            // the same value send by the method SendKeys

            SendKeys.SendWait(((Button)sender).Text); // This code was changed to "SendWait" soley for testing purposes, released product would
            // use the method "SendKeys.Send() in place of SendKeys.SendWait()"
            update(sender);           
        }

        public void update(object sender)
        {
            tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
            tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
        }


        /*!!!!!!!!!!!!!!!!! Replace with this when product is released!!!!!!!!!!!!!!!!!!
         * 
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SendKeys.Send(((Button)sender).Text);
        //    tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
        //    tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
        //}
         * */

        private void LinkToSetTheory_Click(object sender, EventArgs e)
        {
            if (tempForm.getHelp().FormOpen("SetTheory_Logic"))
            {
                SetTheory_Logic SetTheory1 = new SetTheory_Logic();
                SetTheory1.Show();
                SetTheory1.TopMost = true;
            }

            else
                tempForm.getHelp().getOpenForm(this.ParentForm, "SetTheory_Logic").Show();


        }
    }
}
