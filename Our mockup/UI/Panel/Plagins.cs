using System;
using System.Drawing;
using System.Windows.Forms;
using Our_mockup.Api;

namespace Our_mockup.UI.Plagins
{
    public partial class Plagins : UserControl
    {
        public Plagins(XCommand command)
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(command.Plagins.ButtonFocus);
          //button2.MouseEnter += new EventHandler(command.Plagins.ButtonFocus);
            button3.MouseEnter += new EventHandler(command.Plagins.ButtonFocus);
            button1.MouseLeave += new EventHandler(command.Plagins.ButtonNotFocus);
          //button2.MouseLeave += new EventHandler(command.Plagins.ButtonNotFocus);
            button3.MouseLeave += new EventHandler(command.Plagins.ButtonNotFocus);
            button1.Click += new EventHandler(command.Plagins.ButtonClic);
           //button2.Click += new EventHandler(command.Plagins.ButtonClic);
            button3.Click += new EventHandler(command.Plagins.ButtonClic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
           // button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            //button2.BackColor = Color.White;
            button1.BackColor = Color.White;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    button2.BackColor = Color.Green;
        //    button1.BackColor = Color.White;
        //    button3.BackColor = Color.White;
        //}
    }
}
