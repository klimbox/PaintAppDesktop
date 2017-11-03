
using Our_mockup.UI.Panel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionFigurMouse
    {
        private XCommand xCommand;
        Figuree figuree;
        public ActionFigurMouse(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public Point Point;
        public void move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
            }

        }
        public void figurDown(object sender, MouseEventArgs e)
        {
            if(figuree != null)
            {
                figuree.BorderStyle = BorderStyle.None;
            }
           
            for (int i = 0; i < xCommand.listFigur.Count; i++)
            {
                if(xCommand.listFigur[i].Focused)
                {
                    figuree = xCommand.listFigur[i];
                    figuree.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
    }
}