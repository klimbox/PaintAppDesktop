using Our_mockup.UI.MenuBar;
using Our_mockup.UI.Plagins;
using Our_mockup.UI.Propertes.Figur_with_text;
using Our_mockup.UI.Propertes.Propertes_Emty_figure;
using Our_mockup.UI.ToolBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_mockup.Api.Language
{
    
    public class SetapLanuage
    {
        public MenuBarr menuBarr;
        public ToolBarr toolBar;
        public Plagins plagins;
        public Figure_with_text figure_With_Text;
        public Propertes_Emty_figure propertes_Emty_Figure;
        English english;
        Russian russian;
        public void SetapEnglish()
        {
            english = new English();
            english.SetEnglishPropertiWithText(figure_With_Text);
            english.SetEnglishPropertiEmptyFiigur(propertes_Emty_Figure);
            english.SetEnglishMenuBar(menuBarr);
            english.SetEnglishPlagins(plagins);
            english.SetEnglishToolBar(toolBar);
        }
        public void SetapRussian()
        {
            russian = new Russian();
            russian.SetRussianPropertiWithText(figure_With_Text);
            russian.SetRussianMenuBar(menuBarr);
            russian.SetRussianPlagins(plagins);
            russian.SetRussianPropertiEmptyFiigur(propertes_Emty_Figure);
            russian.SetRussianToolBar(toolBar);
        }
    }
}
