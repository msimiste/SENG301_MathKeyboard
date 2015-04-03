using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathKeyBoard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            int BC_Expected_Counter = testForm.gethotkeyFix();

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

            //Upon completion of a bubble sort these expected values will change.
            buttonCounter btnCtr1 = new buttonCounter("one", 1000);
            buttonCounter btnCtr2 = new buttonCounter("two", 1997);
            buttonCounter btnCtr3 = new buttonCounter("three", 2988);
            buttonCounter btnCtr4 = new buttonCounter("four", 994);
            buttonCounter btnCtr5 = new buttonCounter("five", 4955);
            buttonCounter btnCtr6 = new buttonCounter("six", 5913);
           
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
                Assert.AreEqual(buttons_test[i].getName(), testForm.buttons[i].getName());
                Assert.AreEqual(buttons_test[i].getCounter(), testForm.buttons[i].getCounter());
            }
        }

        // This method tests the clicking of all non-specialty buttons on MainKeyboard
        // non-specialty buttons means that when the button is pressed it's text value is displayed in the open application.
        [TestMethod]
        public void MainKeyboard_ButtonClick_Test()
        {
              MainKeyboard a = new MainKeyboard();
              EventArgs e = new EventArgs();
              a.but_Click(a.Square, e);
              String testString = a.tempText;
              String testString2 = a.Square.Text;
              Assert.AreEqual(testString, testString2);
        }


        // This method tests the clicking of all non-specialty buttons on The "Greek" keyboard
        // non-specialty buttons means that when the button is pressed it's text value is displayed in the open application.
        [TestMethod]
        public void Greek_ButtonClick_Test()
        {           
            Greek testGreek = new Greek();            
            testGreek.openFormForTest();
            testGreek.setTempForm();
            EventArgs e = new EventArgs();
            testGreek.button1_Click(testGreek.Phi_Upper, e);
            String testString = testGreek.tempText;
            String testString2 = testGreek.Phi_Upper.Text;
            Assert.AreEqual(testString, testString2);
        }

        // This method tests the clicking of all non-specialty buttons on the setTheory_Logic
        // non-specialty buttons means that when the button is pressed it's text value is displayed in the open application.
        [TestMethod]
        public void SetTheory_ButtonClick_Test()
        {
            SetTheory_Logic testSetTheory = new SetTheory_Logic();
            testSetTheory.openFormForTest();
            testSetTheory.setTempForm();
            EventArgs e = new EventArgs();
            testSetTheory.button1_Click(testSetTheory.Universal, e);
            String testString = testSetTheory.tempText;
            String testString2 = testSetTheory.Universal.Text;
            Assert.AreEqual(testString, testString2);
        }


        // Method Tests the helpers method "getOpenForm" which returns an open Windows Form which has the
        // same name as the "name parameter, if an open form of that name exists.
        // Otherwise it returns the sender
        [TestMethod]
        public void Helpers_getOpenForm_Test()
        {
            Helpers testHelpers = new Helpers();
            MainKeyboard testMainKeyboard = new MainKeyboard();

            Greek testGreek = new Greek();
            testGreek.openFormForTest();
            testGreek.setTempForm();
            
            SetTheory_Logic testSetTheory = new SetTheory_Logic();
            testSetTheory.openFormForTest();
            testSetTheory.setTempForm();
           
           
            Form testForm = new Form(); // Creating a Form object with no name, getOpenForms can not possibly return matching name when this object is passed in
            // as an argument and there are no open forms. ie if no forms are open , getOpenforms will return this object, whose name is null

            Form GreekTest = testHelpers.getOpenForm(testForm, "Greek");
            Form MainKeyboardTest = testHelpers.getOpenForm(testForm, "MainKeyboard");
            Form SetTheoryTest = testHelpers.getOpenForm(testForm, "SetTheory_Logic");

            Assert.AreEqual(testGreek.Name, GreekTest.Name);
            Assert.AreEqual(testMainKeyboard.Name, MainKeyboardTest.Name);
            Assert.AreEqual(testSetTheory.Name, SetTheoryTest.Name);

        }
    }
}

