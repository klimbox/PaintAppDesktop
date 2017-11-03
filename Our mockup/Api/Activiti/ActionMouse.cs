

using Our_mockup.UI;
using Our_mockup.UI.Panel;
using Our_mockup.UI.Panel.Property;
using Our_mockup.UI.StatusBar;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionMouse
    {
        public UI.StatusBar.StatusBar StatusBar;
        private XCommand xCommand;
        public EmtyFcigure emtyFcigure;
        public FigurWithText figurWithText;
        public pDraw draw;
        public Figuree figuree;
        Point point;

        public ActionMouse(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            figuree = new Figuree(xCommand);
            point = e.Location;
            figuree.Location = point;
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            if ((figuree != null) && (e.Button == MouseButtons.Left))
            {
                figuree.Width = e.X - point.X;
                figuree.Height = e.Y - point.Y;
            }
            
            StatusBar.toolStripStatusLabel1.Text = $"X : {e.X}";
            StatusBar.toolStripStatusLabel2.Text = $"Y : {e.Y}";
            xCommand.FigurMouse.Point = e.Location;
        }
        
        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (figuree != null)
            {
                switch (xCommand.str)
                {
                    case "button1":
                        {
                            draw.tabControl1.TabPages[draw.tabControl1.SelectedIndex].Controls.Add(figuree);
                            xCommand.listFigur.Add(figuree);
                            emtyFcigure.SetFigur(figuree);
                            break;
                        }
                    case "button3":
                        {
                            draw.tabControl1.TabPages[draw.tabControl1.SelectedIndex].Controls.Add(figuree);
                            xCommand.listFigur.Add(figuree);
                            figurWithText.SetFigur(figuree);
                            break;
                        }
                }
            }
        }
    }
}
