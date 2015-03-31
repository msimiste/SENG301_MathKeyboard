using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathKeyBoard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathKeyBoardTests
{
    [TestClass]
    public class MathKeyboardUnitTests
    {


        // test to ensure that updateHokeys is working for first value typed
        // update hotkeys adds an item of type buttonCounter to a List and then sorts that list
        // this test will only test the "Add" portion of the process
        [TestMethod]
        public void Helpers_updateHotkeys_addItemToEmptyList() 
        {
            Helpers testForm = new Helpers();          
            String BC_Expected_Name = "∃";           
            int BC_Expected_Counter = 1;

            testForm.updateHotkeys("∃"); 

            Assert.AreEqual(BC_Expected_Name, testForm.buttons[0].getName());
            Assert.AreEqual(BC_Expected_Counter, testForm.buttons[0].getCounter());              

        }


        // test to ensure that updateHokeys is working for first value typed
        // update hotkeys adds an item of type buttonCounter to a List and then sorts that list
        // this tests add and sort for a 
          [TestMethod]
        public void Helpers_updateHotkeys_addItemToPopulatedList() 
        {
            Helpers testForm = new Helpers();  

            List<buttonCounter> buttons_test = new List<buttonCounter>(4);

            buttons_test.Add(new buttonCounter("", 0));
            buttons_test.Add(new buttonCounter("", 0));
            buttons_test.Add(new buttonCounter("", 0));
            buttons_test.Add(new buttonCounter("", 0));          
            buttonCounter btnCtr1 = new buttonCounter("one", 1);
            buttonCounter btnCtr2 = new buttonCounter("two", 2);
            buttonCounter btnCtr3 = new buttonCounter("three", 3);
            buttonCounter btnCtr4 = new buttonCounter("four", 1);
            buttonCounter btnCtr5 = new buttonCounter("five", 5);
            buttonCounter btnCtr6 = new buttonCounter("six", 6);
           
            buttons_test.Add(btnCtr1);
            buttons_test.Add(btnCtr2);
            buttons_test.Add(btnCtr3);
            buttons_test.Add(btnCtr4);
            buttons_test.Add(btnCtr5);
            buttons_test.Add(btnCtr6);

            buttons_test.Sort(new Comparison<buttonCounter>((x, y) => y.getCounter().CompareTo(x.getCounter())));

            String[] temp = { "one", "two", "three", "four", "five", "six" };

            testForm.updateHotkeys("one");
            testForm.updateHotkeys("two");
            testForm.updateHotkeys("two");
            testForm.updateHotkeys("three");
            testForm.updateHotkeys("three");
            testForm.updateHotkeys("three");
            testForm.updateHotkeys("four");
            testForm.updateHotkeys("five");
            testForm.updateHotkeys("five");
            testForm.updateHotkeys("five");
            testForm.updateHotkeys("five");
            testForm.updateHotkeys("five");
            testForm.updateHotkeys("six");
            testForm.updateHotkeys("six");
            testForm.updateHotkeys("six");
            testForm.updateHotkeys("six");
            testForm.updateHotkeys("six");
            testForm.updateHotkeys("six");

            for (int i = 0; i < 10; i++)
            {
                //Assert.AreEqual(buttons_test[i], testForm.buttons[i]); ASK ALA ABOUT THIS
               Assert.AreEqual(buttons_test[i].getName(), testForm.buttons[i].getName());
                Assert.AreEqual(buttons_test[i].getCounter(), testForm.buttons[i].getCounter());
            }
        

            

            



           
        }
    }
}

