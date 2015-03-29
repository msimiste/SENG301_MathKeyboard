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



        public Helpers()
        {
            for (int i = 0; i < 4; i++)
            {
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

        //public Panel getOpenPanel(object sender, String name)
        //{

        //    foreach (Panel OpenPanel in Application.OpenForms)
        //    {
        //        if (OpenPanel.Name == name)
        //        {
        //            return OpenPanel;
        //        }



        //    }
        //    return ((Panel)sender);

        //}

        //test
        //check is symbol.buttontext is in List<buttons>
        //if yes symbol.counter++
        //if no 
        //create symbol
        //add to list
        //and symbol.counter++
        //updating text updates list names
        //some keys dont use sendkeys the same way
        //sorts
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

            buttons.Sort(new Comparison<buttonCounter>((x, y) => y.getCounter().CompareTo(x.getCounter())));
        }

        public void updateHotkeyDisplay(object sender)
        {
            Form mainForm = getOpenForm(sender, "MainKeyboard");
            //Panel hotKeyPanel = getOpenPanel(mainForm, "HotkeyPanel");
            var hotKeyPanel = mainForm.Controls.Find("HotkeyPanel", false);
            Button hotKey1 = (Button)hotKeyPanel[0].Controls[0];
            Button hotKey2 = (Button)hotKeyPanel[0].Controls[1];
            Button hotKey3 = (Button)hotKeyPanel[0].Controls[2];
            Button hotKey4 = (Button)hotKeyPanel[0].Controls[3];
            hotKey1.Text = buttons[0].getName();
            hotKey2.Text = buttons[1].getName();
            hotKey3.Text = buttons[2].getName();
            hotKey4.Text = buttons[3].getName();

            



            //foreach (Button b in hotKeyPanel.Container.Components)
            //{
            //    Button a = b;

            //}
        

        }
    }

}

