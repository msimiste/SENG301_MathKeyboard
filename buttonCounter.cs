using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathKeyBoard
{
    public class buttonCounter
    {
        private String name;
        private int counter = 0;

        public buttonCounter(String aName, int aCounter)
        {
            name = aName;
            counter = aCounter;
        }

        public String getName()
        {
            return name;
        }

        public int getCounter()
        {
            return counter;
        }

        public void incCounter(int num)
        {
            counter += 1;
        }
    }
}
