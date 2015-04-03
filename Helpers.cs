using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathKeyBoard
{

    // class was created in order for all keyboards to have access to each others objects as required
    // hotkey functionality was also included
    public partial class Helpers
    {
        public List<buttonCounter> buttons = new List<buttonCounter>(5);
        private int hotkeyFix = 1000; //to be removed on implementation of bubble sort
        
        public Helpers()
        {
            // buttons must be initialized with 4 empty hotkey buttons
            for (int i = 1; i < 5; i++)
            {
                buttons.Add(new buttonCounter("", 0));                
            }
        }

        // method returns true if there is no Open form with the property "name", ie
        // method instructs caller to create a form if there is not one currently open by that name
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


        // method returns the open form which has the property "name" otherwise method returns the sender, which
        // itself is of type Form
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


        // method updates the list buttons, which contains buttonCounter objects 
        // these objects track the frequency of button clicks as required
        public void updateHotkeys(string btn)
        {
            bool inList = false;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].getName() == btn)
                {
                    inList = true;
                    buttons[i].incCounter(hotkeyFix--);
                }
            }

            if (!inList)
            {
                buttonCounter symbol = new buttonCounter(btn, hotkeyFix--);
                buttons.Add(symbol);
            }
           
            buttons.Sort(new Comparison<buttonCounter>((x, y) => y.getCounter().CompareTo(x.getCounter())));
        }


        // method updates the 4 hotkeys found on mainKeyboard
        public void updateHotkeyDisplay(object sender)
        {
           Form mainForm = getOpenForm(sender, "MainKeyboard");
           var hotKeyPanel = mainForm.Controls.Find("HotkeyPanel", false);
           
            for (int i = 0; i <4; i++)
            {
                hotKeyPanel[0].Controls[i].Text = buttons[i].getName();               
            }
        }
        
        public int gethotkeyFix()
        {
            return hotkeyFix;
        }

    }

}

        //public List<buttonCounter> bubbleSort(List<buttonCounter> ls)
        //{
        //    //buttonCounter tempCounter;
        //    List<buttonCounter> tempList = ls;

        //    for (int i = 0; i < ls.Count; i++)
        //    {
        //        for (int j = 1; j < ls.Count - 1; j++)
        //        {
        //            if (ls[j].getCounter() > ls[i].getCounter())
        //            {
        //                //tempCounter = ls[i];
        //                tempList[i] = ls[j];
        //                //ls[j] = tempCounter;
        //            }
        //            else
        //                tempList[i] = ls[i];
        //        }
        //    }
        //    return tempList;
        //}



