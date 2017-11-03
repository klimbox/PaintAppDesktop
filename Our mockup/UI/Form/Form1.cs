using Our_mockup.Api;
using Our_mockup.Api.Language;
using Our_mockup.Api.Tab;
using Our_mockup.Api.Theme;
using Our_mockup.UI.Panel.Property;
using Our_mockup.UI.Propertes.Figur_with_text;
using Our_mockup.UI.Propertes.Propertes_Emty_figure;
using System.Windows.Forms;

namespace Our_mockup
{
    public partial class Form1 : Form
    {
        XCommand command;
        EmtyFcigure emtyFigure;
        FigurWithText figurWithText;
        NewTab newTab;
        Propertes_Emty_figure propertes_Emty_Figure;
        Figure_with_text figure_With_Text;
        SetapLanuage setapLanuage;
        SetapTheme setapTheme;
        public Form1()
        {
            setapTheme = new SetapTheme();
            setapLanuage = new SetapLanuage();
            newTab = new NewTab();
            emtyFigure = new EmtyFcigure();
            figurWithText = new FigurWithText();
            command = new XCommand();
            propertes_Emty_Figure = new Propertes_Emty_figure(command);
            figure_With_Text = new Figure_with_text(command);
            InitializeComponent();
            SetControls();
            SetClass();
            SetapLanuage();
            SetapTheme();
            Size = new System.Drawing.Size(1000, 500);
        }
        public void SetControls()
        {
            command.NewTab.menuBarr = panel2.menuBar1;
            command.Plagins.panel = panel2;
            command.Plagins.menuBar = panel2.menuBar1;
            command.Plagins.toolBarr = panel2.toolBar1;
            command.NewTab.draw = panel2.pDraw1;
            command.RenameTab.draw = panel2.pDraw1;
            command.RemoveTab.draw = panel2.pDraw1;
            command.Save.menuBarr = panel2.menuBar1;
            command.Open.menuBarr = panel2.menuBar1;
            command.swithTab.draw = panel2.pDraw1;
            command.RemoveTab.menuBarr = panel2.menuBar1;
            command.RenameTab.menuBarr = panel2.menuBar1;
            command.swithTab.statusBar = panel2.statusBar1;
            command.NewTab.statusBat = panel2.statusBar1;
            command.RemoveTab.statusBar = panel2.statusBar1;
            command.RenameTab.statusBar = panel2.statusBar1;
            command.Mouse.StatusBar = panel2.statusBar1;
            command.Mouse.draw = panel2.pDraw1;
        }
        public void SetClass()
        {
            command.Plagins.emtyFcigure = emtyFigure;
            command.Plagins.figure_With_Text = figurWithText;
            command.NewTab.newTab = newTab;
            command.RenameTab.newTab = newTab;
            command.RemoveTab.newTab = newTab;
            figurWithText.command = command;
            emtyFigure.command = command;
            command.swithTab.newTab = newTab;
            command.NewTab.command = command;
            command.Language.setapLanuage = setapLanuage;
            command.Mouse.emtyFcigure = emtyFigure;
            command.Mouse.figurWithText = figurWithText;
            emtyFigure.propertes_Emty_Figure = propertes_Emty_Figure;
            figurWithText.figure_With_Text = figure_With_Text;
            command.Theme.setapTheme = setapTheme;
        }
        public void SetapLanuage()
        {
            setapLanuage.figure_With_Text = figure_With_Text;
            setapLanuage.propertes_Emty_Figure = propertes_Emty_Figure;
            setapLanuage.menuBarr = panel2.menuBar1;
            setapLanuage.plagins = panel2.plagins1;
            setapLanuage.toolBar = panel2.toolBar1;
        }
        public void SetapTheme()
        {
            setapTheme.draw = panel2.pDraw1;
            setapTheme.figure_With_Text = figure_With_Text;
            setapTheme.menuBarr = panel2.menuBar1;
            setapTheme.plagins = panel2.plagins1;
            setapTheme.propertes_Emty_Figure = propertes_Emty_Figure;
            setapTheme.statusBar = panel2.statusBar1;
            setapTheme.toolBar = panel2.toolBar1;
        }
    }
}
