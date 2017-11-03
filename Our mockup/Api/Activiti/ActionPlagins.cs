using Our_mockup.UI.MenuBar;
using Our_mockup.UI.Panel;
using Our_mockup.UI.Panel.Property;
using Our_mockup.UI.Propertes.Figur_with_text;
using Our_mockup.UI.ToolBar;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;




namespace Our_mockup.Api
{
    
    public class ActionPlagins
    {
        private XCommand xCommand;
        public UI.Panel.Panel panel;
        public EmtyFcigure emtyFcigure;
        public FigurWithText figure_With_Text;
        public MenuBarr menuBar;
        public ToolBarr toolBarr;

        public ActionPlagins(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void ButtonFocus (object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.FromArgb(192, 255, 192);
            }
        }
        public void ButtonNotFocus(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.FromArgb(192, 255, 192))
            {
                ((Button)sender).BackColor = Color.White;
            }
        }
        public void ButtonClic(object sender, EventArgs e)
        {
            Thread.Sleep(5);
            string butt = ((Button)sender).Name;
            switch(butt)
            {
                case "button1":
                    {
                        emtyFcigure.EmmtyFigure(panel);
                        emtyFcigure.EnablaItemsMenuBars(menuBar);
                        emtyFcigure.EnablaItemsToolBar(toolBarr);
                        xCommand.str = butt;
                        break;
                    }
                case "button3":
                    {
                        figure_With_Text.FiigurWithText(panel);
                        figure_With_Text.EnablaItemsMenuBars(menuBar);
                        figure_With_Text.EnablaItemsToolBar(toolBarr);
                        xCommand.str = butt;
                        break;
                    }
            }
        }
    }
}   