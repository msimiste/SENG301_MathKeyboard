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
            //SendKeys.Send("∀");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊨");
        }

        private void Existential_Click(object sender, EventArgs e)
        {
           
            SendKeys.Send(((Button) sender).Text); 
            //SendKeys.Send(()
            ///SendKeys.Send("∃");
        }

        private void brackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{(}{)}{LEFT}");
        }
        
        private void negation_Click(object sender, EventArgs e)
        {
            SendKeys.Send("¬");
        }

        //private void button1_Click_2(object sender, EventArgs e)
        //{             
        //    Greek1.Show();
        //    Greek1.TopMost = true;   
           
        //}

        private void Conjunction_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∧");
        }

        private void Disjunction_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∨");
        }

        private void Biconditional_Click(object sender, EventArgs e)
        {
            SendKeys.Send("↔");
        }

        private void Conditional_Click(object sender, EventArgs e)
        {
            SendKeys.Send("→");
        }

        private void Provable_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊢");
        }

        private void Verum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊤");
        }

        private void Falsum_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊥");
        }

        private void NotProvable_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊬");
        }

        private void DoesNotEntail_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊭");
        }

        private void RealNumbers_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ℝ");
        }

        private void EmptySet_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∅");
        }

        private void CurlyBrackets_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{{}{}}{LEFT}");
        }

        private void Intersection_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⋂");
        }

        private void SetTheory_Logic_Leave(object sender, EventArgs e)
        {

        }

        private void Union_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⋃");
        }

        private void Subset_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊂");
        }

        private void SuperSet_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊃");
        }

        private void NotSubset_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊄");
        }

        private void NotSuperset_Click(object sender, EventArgs e)
        {
            SendKeys.Send("⊅");
        }

        private void RationalNumbers_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ℚ");
        }

        private void NaturalNumbers_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ℕ");
        }

        private void Integers_Click(object sender, EventArgs e)
        {
            SendKeys.Send("ℤ");
        }

        private void Element_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∈");
        }

        private void NotElement_Click(object sender, EventArgs e)
        {
            SendKeys.Send("∉");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            SendKeys.Send(((Button)sender).Text);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
