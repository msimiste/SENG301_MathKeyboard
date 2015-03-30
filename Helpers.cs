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
        public List<buttonCounter> buttons = new List<buttonCounter>(4);
        public List<buttonCounter> buttonsShort = new List<buttonCounter>(4);



        public Helpers()
        {
            for (int i = 0; i < 4; i++)
            {
                buttonsShort.Add(new buttonCounter("", 0));
                buttons.Add(new buttonCounter("", 0));
            }
        }


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

       
        public void updateHotkeys(string btn)
        {
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

        public void updateButtonsShortList()
        {

            buttons.Sort(new Comparison<buttonCounter>((x, y) => y.getCounter().CompareTo(x.getCounter())));
            for (int i = 0; i < 4; i++)
            {
                buttonsShort[i]=buttons[i];
            }

        
        }

        public void updateHotkeyDisplay(object sender)
        {
            updateButtonsShortList();
            Form mainForm = getOpenForm(sender, "MainKeyboard");            
            var hotKeyPanel = mainForm.Controls.Find("HotkeyPanel", false);

            int i = 0;
            foreach (Button b in hotKeyPanel[0].Controls)
            {
                b.Text = buttonsShort[i].getName();
                i++;
                //can i send to githun?
            }



        }
    }

}

