using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Our_mockup.Api;

namespace Our_mockup.UI.Propertes.Propertes_Emty_figure
{
    public partial class Propertes_Emty_figure : UserControl
    {
        public Propertes_Emty_figure(XCommand command)
        {
            InitializeComponent();
            button1.Click += new EventHandler(command.FigurType.Button);
            button2.Click += new EventHandler(command.FigurType.Button);
            button3.Click += new EventHandler(command.FigurType.Button);
            button4.Click += new EventHandler(command.FigurType.Button);
            comboBox1.SelectionChangeCommitted += new EventHandler(command.StrockeWidth.ComboBox);
            button5.Click += new EventHandler(command.Color.Button);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
