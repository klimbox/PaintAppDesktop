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
    public class English
    {

        public void SetEnglishPropertiWithText(Figure_with_text figure_With_Text)
        {
            figure_With_Text.button1.Text = "Rectangle";
            figure_With_Text.button2.Text = "RRectangle";
            figure_With_Text.button3.Text = "Elipse";
            figure_With_Text.button4.Text = "Line";
            figure_With_Text.textBox1.Text = "Propertis";
            figure_With_Text.groupBox1.Text = "Figur type";
            figure_With_Text.groupBox2.Text = "Color and width";
            figure_With_Text.button5.Text = "Color";
            figure_With_Text.groupBox3.Text = "Text";
            figure_With_Text.button6.Text = "Text Color";
            figure_With_Text.button7.Text = "Font";
        }
        public void SetEnglishPropertiEmptyFiigur(Propertes_Emty_figure propertes_Emty_Figure)
        {
            propertes_Emty_Figure.textBox1.Text = " propertis";
            propertes_Emty_Figure.groupBox1.Text = "Figure type";
            propertes_Emty_Figure.button1.Text = "Rectangle";
            propertes_Emty_Figure.button2.Text = "RRectangle";
            propertes_Emty_Figure.button3.Text = "Elipse";
            propertes_Emty_Figure.button4.Text = "Line";
            propertes_Emty_Figure.groupBox2.Text = "Color and width";
            propertes_Emty_Figure.button5.Text = "Color";
        }
        public void SetEnglishMenuBar(MenuBarr menuBarr)
        {
            menuBarr.fileToolStripMenuItem.Text = "File";
            menuBarr.saveToolStripMenuItem.Text = "Save";
            menuBarr.opemToolStripMenuItem.Text = "Open";
            menuBarr.editToolStripMenuItem.Text = "Edit figure";
            menuBarr.rectangleToolStripMenuItem1.Text = "Rectangle";
            menuBarr.rRectangleToolStripMenuItem1.Text = "RRectangle";
            menuBarr.elipseToolStripMenuItem1.Text = "Elipse";
            menuBarr.lineToolStripMenuItem1.Text = "Line";
            menuBarr.typeleToolStripMenuItem.Text = "Type";
            menuBarr.colortToolStripMenuItem.Text = "Color";
            menuBarr.widthToolStripMenuItem.Text = "Width";
            menuBarr.swidToolStripMenuItem.Text = "Edit Text";
            menuBarr.enterTextToolStripMenuItem.Text = "Enter text";
            menuBarr.colorToolStripMenuItem.Text = "Color";
            menuBarr.fontToolStripMenuItem.Text = "Font";
            menuBarr.enterAngleToolStripMenuItem.Text = "Enter angle";
            menuBarr.editTabToolStripMenuItem.Text = "Edit Tab";
            menuBarr.removeToolStripMenuItem.Text = "Remove curent tab ";
            menuBarr.renameCurentTabToolStripMenuItem.Text = "Rename curent tab ";
            menuBarr.newTabToolStripMenuItem.Text = "New Tab";
            menuBarr.switchTabToolStripMenuItem.Text = "Switch tab";
            menuBarr.plaginsToolStripMenuItem.Text = "Plugins";
            menuBarr.saveLoadToolStripMenuItem.Text = "Save/Load plugn";
            menuBarr.cloudToolStripMenuItem.Text = "Cloud";
            menuBarr.saveAsToolStripMenuItem.Text = "Save as";
            menuBarr.loadFromToolStripMenuItem.Text = "Load from";
            menuBarr.networckToolStripMenuItem.Text = "Network";
            menuBarr.openGroupSessionToolStripMenuItem.Text = "Open group session";
            menuBarr.settingsToolStripMenuItem.Text = "Settings";
            menuBarr.chooseThemeToolStripMenuItem.Text = "Choose theme";
            menuBarr.lightToolStripMenuItem.Text = "Light";
            menuBarr.darkToolStripMenuItem.Text = "Dark";
            menuBarr.languageToolStripMenuItem.Text = "Language";
            menuBarr.helpToolStripMenuItem.Text = "Helpe";
            menuBarr.aboutTheProgramToolStripMenuItem.Text = "About the program";
        }
        public void SetEnglishPlagins(Plagins plagins)
        {
            plagins.button1.Text = "Emty figur";
            plagins.button3.Text = "Figur and text";
            plagins.button3.Text = "Figur and image";
            plagins.textBox1.Text = "Plagins";
        }
        public void SetEnglishToolBar(ToolBarr toolBar)
        {
            toolBar.toolStripButton1.Text = "Save";
            toolBar.toolStripButton2.Text = "Open";
            toolBar.toolStripSplitButton1.Text = "Figure";
            toolBar.typeToolStripMenuItem.Text = "Type";
            toolBar.rectangleToolStripMenuItem.Text = "Rectangle";
            toolBar.rRectangleToolStripMenuItem.Text = "RRectangle";
            toolBar.eipseToolStripMenuItem.Text = "Eipse";
            toolBar.lineToolStripMenuItem.Text = "Line";
            toolBar.colorToolStripMenuItem.Text = "Color";
            toolBar.widthToolStripMenuItem.Text = "Width";
            toolBar.toolStripSplitButton2.Text = "Text";
            toolBar.enterTexstToolStripMenuItem.Text = "Enter Text";
            toolBar.colorToolStripMenuItem1.Text = "Color";
            toolBar.fontToolStripMenuItem.Text = "Font";
            toolBar.enterToolStripMenuItem.Text = "Enter angle";
            toolBar.toolStripSplitButton3.Text = "Tab";
            toolBar.removeToolStripMenuItem.Text = "Remove current tab";
            toolBar.renameCurrentTabToolStripMenuItem.Text = "Rename current tab";
            toolBar.toolStripButton3.Text = "New Tab";
        }

    }
}
