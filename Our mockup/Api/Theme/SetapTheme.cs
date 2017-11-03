using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.Panel;
using Our_mockup.UI.Plagins;
using Our_mockup.UI.Propertes.Figur_with_text;
using Our_mockup.UI.Propertes.Propertes_Emty_figure;
using Our_mockup.UI.StatusBar;
using Our_mockup.UI.ToolBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_mockup.Api.Theme
{
    public class SetapTheme
    {
        public MenuBarr menuBarr;
        public ToolBarr toolBar;
        public Plagins plagins;
        public Figure_with_text figure_With_Text;
        public Propertes_Emty_figure propertes_Emty_Figure;
        public pDraw draw;
        public StatusBar statusBar;
        Light light;
        Dark dark;
        public void SetapLight()
        {
            light = new Light();
            light.SetDraw(draw);
            light.SetFigure_With_Text(figure_With_Text);
            light.SetMenuBar(menuBarr);
            light.SetPlagins(plagins);
            light.SetPropertes_Emty_Figure(propertes_Emty_Figure);
            light.SetstatusBar(statusBar);
            light.SetToolBar(toolBar);
        }
        public void SetapDark()
        {
            dark = new Dark();
            dark.SetDraw(draw);
            dark.SetFigure_With_Text(figure_With_Text);
            dark.SetMenuBar(menuBarr);
            dark.SetPlagins(plagins);
            dark.SetPropertes_Emty_Figure(propertes_Emty_Figure);
            dark.SetToolBar(toolBar);
            dark.SetstatusBar(statusBar);
        }
    }
}
