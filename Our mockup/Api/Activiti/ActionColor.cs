using System;
using System.Drawing;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionColor
    {
        private XCommand xCommand;

        public ActionColor(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Button(object sender, EventArgs e)
        {
            ColorDialog dialogColor = new ColorDialog();
            if (dialogColor.ShowDialog() == DialogResult.OK)
            {
                xCommand.data.StrockeColor = dialogColor.Color;
            }
        }
        public void Buttonn(object sender, EventArgs e)
        {
            ColorDialog dialogColor = new ColorDialog();
            if (dialogColor.ShowDialog() == DialogResult.OK)
            {
                xCommand.data.ColorText = dialogColor.Color;
            }
        }
    }
}