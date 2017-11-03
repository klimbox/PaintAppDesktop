using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionEnterText
    {
        private XCommand xCommand;

        public ActionEnterText(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Button(object sende, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            xCommand.data.Text = form2.Text;
        }
        public void Textbox(object sende, EventArgs e)
        {
            xCommand.data.Text = ((TextBox)sende).Text;
        }
    }
}