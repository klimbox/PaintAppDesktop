using Our_mockup.UI.Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_mockup.Api
{
    public class XCommand
    {
        public List<Figuree> listFigur = new List<Figuree>();
        public string str { get; set; }
        public XData data = new XData();
        public ActionSave Save;
        public ActionOpen Open;
        public ActionStrockeWidth StrockeWidth;
        public ActionFigurType FigurType;
        public ActionPlagins Plagins;
        public ActionColor Color;
        public ActionEnterText EnterText;
        public ActionFont Font;
        public ActionSwithTab swithTab;
        public ActionRenameTab RenameTab;
        public ActionNewTab NewTab;
        public ActionHelp Help;
        public ActionRemoveTab RemoveTab;
        public ActionMouse Mouse;
        public ActionLanguage Language;
        public ActionFigurMouse FigurMouse;
        public ActionTheme Theme;

        public XCommand()
        {
            Save = new ActionSave(this);
            Open = new ActionOpen(this);
            StrockeWidth = new ActionStrockeWidth(this);
            FigurType = new ActionFigurType(this);
            Plagins = new ActionPlagins(this);
            Color = new ActionColor(this);
            EnterText = new ActionEnterText(this);
            Font = new ActionFont(this);
            swithTab = new ActionSwithTab(this);
            RenameTab = new ActionRenameTab(this);
            NewTab = new ActionNewTab(this);
            Help = new ActionHelp(this);
            RemoveTab = new ActionRemoveTab(this);
            Mouse = new ActionMouse(this);
            Language = new ActionLanguage(this);
            FigurMouse = new ActionFigurMouse(this);
            Theme = new ActionTheme(this);
        }
    }
}
