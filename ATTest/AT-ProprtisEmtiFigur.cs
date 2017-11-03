using Microsoft.VisualStudio.TestTools.UnitTesting;
using Our_mockup.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

namespace ATTest
{ 
    class AT_ProprtisEmtiFigur
    {
        XCommand command = new XCommand();
        private static Window window1;
        [ClassInitialize]
        public static void Class_Init(TestContext context)
        {
            Application application = Application.Launch(@"C:\Users\Roman\source\repos\НУжные\Our mockup\Form from AT\MenuBar.exe");
            window1 = application.GetWindow("Form1AT", InitializeOption.WithCache);
        }
        [TestCleanup]
        public void Data_Clean()
        {
            window1.Close();
            Application application = Application.Launch(@"C:\Users\Roman\source\repos\НУжные\Our mockup\Form from AT\MenuBar.exe");
            window1 = application.GetWindow("Form1AT", InitializeOption.NoCache);
        }
        [ClassCleanup]
        public static void Class_Clean()
        {
            window1.Close();
        }
    }
}
