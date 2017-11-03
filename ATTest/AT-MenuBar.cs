using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems;
using TestStack.White.UIItems.MenuItems;
using System.Threading;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using System;
namespace ATTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string appPath = @"e:\ORT_projects\DesktopPrototype\PaintAppDesktop\Form from AT\MenuBar.exe";
        private static Window window1;
        [ClassInitialize]
        public static void Class_Init(TestContext context)
        {
            Application application = Application.Launch(appPath);
            window1 = application.GetWindow("Form1AT", InitializeOption.WithCache);
        }
           
        [TestCleanup]
        public void Data_Clean()
        {
            window1.Close();
            Application application = Application.Launch(appPath);
            window1 = application.GetWindow("Form1AT", InitializeOption.NoCache);
        }
        [ClassCleanup]
        public static void Class_Clean()
        {
            window1.Close();
        }
        
        [DataTestMethod]
        [DataRow("File")]
        [DataRow("Edit Tab")]
        [DataRow("Plugins")]
        [DataRow("Cloud")]
        [DataRow("Network")]
        [DataRow("Settings")]
        [DataRow("Help")]
        [TestMethod]
        public void Presence(string id)
        {
            MenuBar menuBar = window1.Get<MenuBar>("menuStrip1");
            Assert.AreEqual(true, menuBar.Visible);
            Menu item = menuBar.MenuItem(id);
            Assert.AreEqual(true, item.Visible);
        }
        [TestMethod]
        [DataRow("File")]
        [DataRow("Edit Tab")]
        [DataRow("Plugins")]
        [DataRow("Cloud")]
        [DataRow("Network")]
        [DataRow("Settings")]
        [DataRow("Help")]
        public void Simple_Check(string id)
        {
            MenuBar menuBar = window1.Get<MenuBar>("menuStrip1");
            Assert.AreEqual(true, menuBar.Visible);
            Menu item = menuBar.MenuItem(id);
            item.Click();
        }
        [TestMethod]
        [DataRow("File")]
        [DataRow("Edit Tab")]
        [DataRow("Plugins")]
        [DataRow("Cloud")]
        [DataRow("Network")]
        [DataRow("Settings")]
        [DataRow("Help")]
        public void Complex_Check(string id)
        {
            MenuBar menuBar = window1.Get<MenuBar>("menuStrip1");
            Assert.AreEqual(true, menuBar.Visible);
            Menu item = menuBar.MenuItem(id);
            for (int i = 0; i < 3; i++)
            {
                item.Click();
            }
        }
    }
}
