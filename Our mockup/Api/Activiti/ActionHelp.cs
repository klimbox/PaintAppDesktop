using System;

namespace Our_mockup.Api
{
    public class ActionHelp
    {
        private XCommand xCommand;

        public ActionHelp(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Button(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}