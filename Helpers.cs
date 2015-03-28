using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathKeyBoard
{
    public partial class Helpers
    {
        public buttonCounter btnctr;
        public List<buttonCounter> buttons = new List<buttonCounter>();
        public bool FormOpen(String name)
        {
            bool create = true;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name == name)
                {
                    create = false;
                }

            }
            return create;
        }

        public Form getOpenForm(object sender, String name)
        {

            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name == name)
                {
                    return OpenForm;
                }



            }
            return ((Form)sender);

        }

        //check is symbol.buttontext is in List<buttons>
        //if yes symbol.counter++
        //if no 
        //create symbol
        //add to list
        //and symbol.counter++
        //updating text updates list names
        //some keys dont use sendkeys the same way
        public void updateHotkeys(string btn)
        {
            //foreach (Panel p in SetTheory_Logic)
            //{

            //}

            bool inList = false;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].getName() == btn)
                {
                    inList = true;
                    buttons[i].incCounter(1);
                }


            }

            if (!inList)
            {
                buttonCounter symbol = new buttonCounter(btn, 1);
                buttons.Add(symbol);
            }



        }
    }

}
