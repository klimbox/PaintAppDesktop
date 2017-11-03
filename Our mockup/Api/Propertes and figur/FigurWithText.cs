using Our_mockup.Api;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.Propertes.Figur_with_text;
using Our_mockup.UI.ToolBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_mockup.UI.Panel.Property
{
    public class FigurWithText
    {
        public Figure_with_text figure_With_Text;
        public XCommand command;
        public void FiigurWithText(Panel panel)
        {
            panel.ClearControl();
            figure_With_Text.Dock = DockStyle.Right;
            panel.Controls.Add(figure_With_Text);
            panel.Controls.SetChildIndex(figure_With_Text, 1);
            panel.control = figure_With_Text;
        }
        public void EnablaItemsMenuBars(MenuBarr menuBar)
        {
            menuBar.editToolStripMenuItem.Enabled = true;
            menuBar.swidToolStripMenuItem.Enabled = true;
        }
        public void EnablaItemsToolBar(ToolBarr toolBarr)
        {
            toolBarr.toolStripSplitButton1.Enabled = true;
            toolBarr.toolStripSplitButton2.Enabled = true;
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
                SolidBrush brush = new SolidBrush(command.data.ColorText);
                g.DrawString(command.data.Text, command.data.FontText, brush, (figuree.Width / 2), (figuree.Height / 2));
                figuree.BackgroundImage = bitmap;
            }
        }
    }
}
