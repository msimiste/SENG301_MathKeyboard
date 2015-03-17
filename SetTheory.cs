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
    public partial class SetTheory : Form
    {
        public SetTheory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Intersection_Click(object sender, EventArgs e)
        {

        }

        private void Union_Click(object sender, EventArgs e)
        {

        }

        private void LogicLink_Click(object sender, EventArgs e)
        {
            SetTheory_Logic Logic1 = new SetTheory_Logic();
            Logic1.Show();
            Logic1.TopMost = true;

        }

        private void SetTheory_Load(object sender, EventArgs e)
        {

        }

        private void SetTheory_Leave(object sender, EventArgs e)
        {

        }

        private void SetTheory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void EmptySet_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∅");
        }
    }
}