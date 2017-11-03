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
    public class Russian
    {
        public void SetRussianPropertiWithText(Figure_with_text figure_With_Text)
        {
            figure_With_Text.button1.Text = "Прямоугольник";
            figure_With_Text.button2.Text = "Круглый прямоугольник";
            figure_With_Text.button3.Text = "Елипс";
            figure_With_Text.button4.Text = "Линия";
            figure_With_Text.textBox1.Text = "Свойство";
            figure_With_Text.groupBox1.Text = "Тип фигуры";
            figure_With_Text.groupBox2.Text = "Цвет и Ширина";
            figure_With_Text.button5.Text = "Цвет";
            figure_With_Text.groupBox3.Text = "Текст";
            figure_With_Text.button6.Text = "Цвет текста";
            figure_With_Text.button7.Text = "Шрифт";
        }
        public void SetRussianPropertiEmptyFiigur(Propertes_Emty_figure propertes_Emty_Figure)
        {
            propertes_Emty_Figure.textBox1.Text = " Своства";
            propertes_Emty_Figure.groupBox1.Text = "Тип фигуры";
            propertes_Emty_Figure.button1.Text = "Прамоугольник";
            propertes_Emty_Figure.button2.Text = "Круглый прямоугольник";
            propertes_Emty_Figure.button3.Text = "Елипс";
            propertes_Emty_Figure.button4.Text = "Линия";
            propertes_Emty_Figure.groupBox2.Text = "Цвет и Ширина";
            propertes_Emty_Figure.button5.Text = "Цвет";
        }
        public void SetRussianMenuBar(MenuBarr menuBarr)
        {
            menuBarr.fileToolStripMenuItem.Text = "Файл";
            menuBarr.saveToolStripMenuItem.Text = "Сохранить";
            menuBarr.opemToolStripMenuItem.Text = "Открыть";
            menuBarr.editToolStripMenuItem.Text = "Изменить фигуру";
            menuBarr.rectangleToolStripMenuItem1.Text = "Прямоугольник";
            menuBarr.rRectangleToolStripMenuItem1.Text = "Круглы прмоугольник";
            menuBarr.elipseToolStripMenuItem1.Text = "Елипс";
            menuBarr.lineToolStripMenuItem1.Text = "Линя";
            menuBarr.typeleToolStripMenuItem.Text = "Тип";
            menuBarr.colortToolStripMenuItem.Text = "Цвет";
            menuBarr.widthToolStripMenuItem.Text = "Ширина";
            menuBarr.swidToolStripMenuItem.Text = "Изменить текст";
            menuBarr.enterTextToolStripMenuItem.Text = "Ввод текста";
            menuBarr.colorToolStripMenuItem.Text = "Цвет";
            menuBarr.fontToolStripMenuItem.Text = "Шрифт";
            menuBarr.enterAngleToolStripMenuItem.Text = "Ввод угла";
            menuBarr.editTabToolStripMenuItem.Text = "Изменить вклдку";
            menuBarr.removeToolStripMenuItem.Text = "Удалить текущую вкладку";
            menuBarr.renameCurentTabToolStripMenuItem.Text = "Переименовать текущую вкладку";
            menuBarr.newTabToolStripMenuItem.Text = "Новая вкладка";
            menuBarr.switchTabToolStripMenuItem.Text = "Выбрать вкладку";
            menuBarr.plaginsToolStripMenuItem.Text = "Плагины";
            menuBarr.saveLoadToolStripMenuItem.Text = "Сохранение/Загрузить плагин";
            menuBarr.cloudToolStripMenuItem.Text = "Облако";
            menuBarr.saveAsToolStripMenuItem.Text = "Сохранить как";
            menuBarr.loadFromToolStripMenuItem.Text = "Загрузит для";
            menuBarr.networckToolStripMenuItem.Text = "Сеть";
            menuBarr.openGroupSessionToolStripMenuItem.Text = "Открытая групповая сессия";
            menuBarr.settingsToolStripMenuItem.Text = "Настройки";
            menuBarr.chooseThemeToolStripMenuItem.Text = "Выберите тему";
            menuBarr.lightToolStripMenuItem.Text = "Светлая";
            menuBarr.darkToolStripMenuItem.Text = "Темная";
            menuBarr.languageToolStripMenuItem.Text = "Язык";
            menuBarr.helpToolStripMenuItem.Text = "Помошь";
            menuBarr.aboutTheProgramToolStripMenuItem.Text = "О программе";
        }
        public void SetRussianPlagins(Plagins plagins)
        {
            plagins.button1.Text = "Пустая фигура";
            plagins.button3.Text = "Фигура с текст";
            plagins.button3.Text = "фигур с изобржением ";
            plagins.textBox1.Text = "Плагин";
        }
        public void SetRussianToolBar(ToolBarr toolBar)
        {
            toolBar.toolStripButton1.Text = "Сохранить";
            toolBar.toolStripButton2.Text = "Открыть";
            toolBar.toolStripSplitButton1.Text = "Фигура";
            toolBar.typeToolStripMenuItem.Text = "Тип";
            toolBar.rectangleToolStripMenuItem.Text = "Прямогульник";
            toolBar.rRectangleToolStripMenuItem.Text = "Круклый прамоугольни";
            toolBar.eipseToolStripMenuItem.Text = "Елипс";
            toolBar.lineToolStripMenuItem.Text = "Линия";
            toolBar.colorToolStripMenuItem.Text = "Цвет";
            toolBar.widthToolStripMenuItem.Text = "Ширина";
            toolBar.toolStripSplitButton2.Text = "Текст";
            toolBar.enterTexstToolStripMenuItem.Text = "Ввод текста";
            toolBar.colorToolStripMenuItem1.Text = "Цвет";
            toolBar.fontToolStripMenuItem.Text = "Шрифт";
            toolBar.enterToolStripMenuItem.Text = "Ввод текста";
            toolBar.toolStripSplitButton3.Text = "Вкладка";
            toolBar.removeToolStripMenuItem.Text = "Улалить текущую вкладку";
            toolBar.renameCurrentTabToolStripMenuItem.Text = "переименовать текщую вкладу";
            toolBar.toolStripButton3.Text = "Новая вкладка";
        }
    }
}
