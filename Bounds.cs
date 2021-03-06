﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathKeyBoard
{
    public partial class Bounds : Form
    {  
        
        public Bounds()
        {
            InitializeComponent();
        }

        // logic for OK_button click, method verifies if bounds are selected. If not, none are printed.
        // error checking in case upper is entered without lower and vice versa is included
        private void OK_Click(object sender, EventArgs e)
        {
            if (this.UpperBound_txt.Text != "" && this.LowerBound_txt.Text != "")
            {
                MainKeyboard a = (MainKeyboard)help1.getOpenForm(this, "MainKeyboard");
                a.setUp(this.UpperBound_txt.Text); // mutator method found in MainKeyboard class
                a.setLow(this.LowerBound_txt.Text); // mutator method found in MainKeyboard class 
                this.Dispose();
            }

            else if (this.UpperBound_txt.Text != "" && this.LowerBound_txt.Text == "")
            {
                var result = MessageBox.Show("Please Enter a Lower Bound", "Bounds Error", MessageBoxButtons.OK);
                
            }

            else if (this.UpperBound_txt.Text == "" && this.LowerBound_txt.Text != "")
            {
                var result = MessageBox.Show("Please Enter an Upper Bound", "Bounds Error", MessageBoxButtons.OK);
            }

            else
                this.Dispose();
        }


        private void None_Click(object sender, EventArgs e)
        {
            this.Dispose();
        } 
    }
}
