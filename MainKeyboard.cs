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
        public MainKeyboard()
        {
            InitializeComponent();
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
                Help1.getOpenForm(this.ParentForm, "SetTheory_Logic").Focus();
        }

        private void MainKeyboard_Load(object sender, EventArgs e)
        {
            
        }

        private void LinkToMain_Click(object sender, EventArgs e)
        {
            if (Help1.FormOpen("Greek"))
            {
                Greek Greek1 = new Greek();
                Greek1.Show();
                Greek1.TopMost = true;
            }
            else
                Help1.getOpenForm(this.ParentForm, "Greek").Focus();
           
        }

        private void Intersection_Click(object sender, EventArgs e)
        {

        }

        private void MainKeyboard_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MainKeyboard_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

       
     
    }
}
