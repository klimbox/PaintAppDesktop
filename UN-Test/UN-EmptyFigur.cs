using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Our_mockup.Api;
using Our_mockup.UI.Propertes.Propertes_Emty_figure;

namespace UN_Test
{
    [TestClass]
    public class UnitTest1
    {
        event EventHandler hand;
        XCommand command = new XCommand();
        Propertes_Emty_figure propertes_Emty_Figure;
        [TestMethod]
        public void Typefigur()
        {
            propertes_Emty_Figure = new Propertes_Emty_figure(command);
            hand += command.FigurType.Button;
            string exp = "Rectangle";
            hand(propertes_Emty_Figure.button1, new EventArgs());
            string res = command.data.FigureType;
            Assert.AreEqual(exp, res);
        }
    }
}
