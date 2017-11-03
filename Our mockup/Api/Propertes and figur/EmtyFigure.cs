

using Our_mockup.UI.Propertes.Propertes_Emty_figure;
using System.Windows.Forms;
using Our_mockup.Api;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.ToolBar;
using System.Drawing;
using System.Collections.Generic;

namespace Our_mockup.UI.Panel.Property
{
    public class EmtyFcigure
    {
        public XCommand command;
        public Propertes_Emty_figure propertes_Emty_Figure;
        public void EmmtyFigure(Panel panel)
        {
            panel.ClearControl();
            propertes_Emty_Figure.Dock = DockStyle.Right;
            panel.Controls.Add(propertes_Emty_Figure);
            panel.Controls.SetChildIndex(propertes_Emty_Figure, 1);
            panel.control = propertes_Emty_Figure;
        }
        public void EnablaItemsMenuBars(MenuBarr menuBar)
        {
            menuBar.editToolStripMenuItem.Enabled = true;
            menuBar.swidToolStripMenuItem.Enabled = false;
        }
        public void EnablaItemsToolBar(ToolBarr toolBarr)
        {
            toolBarr.toolStripSplitButton1.Enabled = true;
            toolBarr.toolStripSplitButton2.Enabled = false;
        }
        public void SetFigur(Figuree figuree)
        {
            if ((figuree.Width > 1) && (figuree.Height > 1))
            {
                Bitmap bitmap = new Bitmap(figuree.Width, figuree.Height);

                Graphics g = Graphics.FromImage(bitmap);

                Pen pen = new Pen(command.data.StrockeColor, command.data.StrockeWidth);
                if ((command.data.FigureType == "Rectangle") || (command.data.FigureType == "Прямоугольник"))
                {
                    g.DrawRectangle(pen, 10, 10, figuree.Width - 20, figuree.Height - 20);
                }
                else if ((command.data.FigureType == "Elipse") || (command.data.FigureType == "Елипс"))
                {
                    g.DrawEllipse(pen, 10, 10, figuree.Width - 20, figuree.Height - 20);
                }
                figuree.BackgroundImage = bitmap;
            }
        }
    }
}
