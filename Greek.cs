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


        private void Greek_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);
            tempForm.getHelp().updateHotkeys(((Button)sender).Text); // this in mainkeyboard after a sendkeys
            tempForm.getHelp().updateHotkeyDisplay(this.ParentForm);
        }

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
