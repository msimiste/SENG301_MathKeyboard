using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathKeyBoard
{
    // this class was created in order to monitor the frequency of button presses on the
    // various keyboards, as C# buttons do not have a native counter attribute
    public class buttonCounter
    {
        private String name = "";
        private int count = 0;

        public buttonCounter(String aName, int aCounter)
        {
            name = aName;
            count = aCounter;
        }

        public String getName()
        {
            return name;
        }

        public int getCounter()
        {
            return count;
        }

        public void incCounter(int num)
        {
            count += num;
        }
    }
}
