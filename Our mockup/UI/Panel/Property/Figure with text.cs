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

namespace Our_mockup.UI.Propertes.Figur_with_text
{
    public partial class Figure_with_text : UserControl
    {
        public Figure_with_text(XCommand command)
        {
            InitializeComponent();
            button1.Click += new EventHandler(command.FigurType.Button);
            button2.Click += new EventHandler(command.FigurType.Button);
            button3.Click += new EventHandler(command.FigurType.Button);
            button4.Click += new EventHandler(command.FigurType.Button);
            comboBox1.SelectionChangeCommitted += new EventHandler(command.StrockeWidth.ComboBox);
            button5.Click += new EventHandler(command.Color.Button);
            textBox3.TextChanged += new EventHandler(command.EnterText.Textbox);
            button6.Click += new EventHandler(command.Color.Buttonn);
            button7.Click += new EventHandler(command.Font.Button);
        }
    }
}
