using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.StatusBar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_mockup.Api.Tab
{
    public class NewTab
    {
        int i = -1;   
        TabPage tabPage;
        public void NeewTab(pDraw draw, Form2 form2, MenuBarr menuBarr, XCommand command)
        {
            if(form2.Text == null)
            {
                form2.Text = "New Tab";
            }
            tabPage = new TabPage(form2.Text);
            tabPage.MouseDown += new MouseEventHandler(command.Mouse.MouseDown);
            tabPage.MouseMove += new MouseEventHandler(command.Mouse.MouseMove);
            tabPage.MouseUp += new MouseEventHandler(command.Mouse.MouseUp);
            tabPage.BackColor = Color.White;
            draw.tabControl1.TabPages.Add(tabPage);
            AddMenuStatusTab(menuBarr, form2);
        }
        public void RenameTab(pDraw draw, Form2 form2, MenuBarr menuBarr)
        {
            if (tabPage != null)
            {
                draw.tabControl1.SelectedTab.Text = form2.Text;
                RenameMenuStatusTab(menuBarr, draw);
            }
        }
        public void RemoveTab(pDraw draw, MenuBarr menuBarr)
        {
            if (tabPage != null) 
            {
                TabPage control = draw.tabControl1.SelectedTab;
                RemoveMenuStatusTab(menuBarr, draw);
                draw.tabControl1.TabPages.Remove(control);
                
            }
        }
        public void AddMenuStatusTab(MenuBarr menuBarr, Form2 form2)
        {
            if (tabPage != null)
            {
                i += 1;
                ToolStripMenuItem menuItem = new ToolStripMenuItem(form2.Text);
                menuItem.MergeIndex = i;
                menuBarr.switchTabToolStripMenuItem.Enabled = true;
                menuBarr.switchTabToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }
        public void RemoveMenuStatusTab(MenuBarr menuBarr, pDraw draw)
        {
            if (tabPage != null)
            {
                i -= 1;
                menuBarr.switchTabToolStripMenuItem.DropDownItems.RemoveAt(draw.tabControl1.SelectedIndex);
                for (int i = 0; i < menuBarr.switchTabToolStripMenuItem.DropDownItems.Count; i++)
                {
                    menuBarr.switchTabToolStripMenuItem.DropDownItems[i].MergeIndex = i;
                }
            }
        }
        public void RenameMenuStatusTab(MenuBarr menuBarr, pDraw draw)
        {
            menuBarr.switchTabToolStripMenuItem.DropDownItems[(draw.tabControl1.SelectedIndex)].Text = draw.tabControl1.SelectedTab.Text;
        }
        public void SwithTabstatusMenuBarr(pDraw draw, ToolStripItemClickedEventArgs e)
        {
            int i = e.ClickedItem.MergeIndex;
            draw.tabControl1.SelectTab(i);
        }
        public void SwidthTabStatusBar(UI.StatusBar.StatusBar statusBar, pDraw draw)
        {
            if (draw.tabControl1.SelectedTab != null)
            {
                statusBar.toolStripStatusLabel3.Text = draw.tabControl1.SelectedTab.Text;
            }
            else
            {
                statusBar.toolStripStatusLabel3.Text = "Nam Tab";
            }
        }
    }
}
