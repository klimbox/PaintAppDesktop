

using Our_mockup.Api;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.Propertes.Figur_with_text;
using System.Windows.Forms;

namespace ATTest
{
    public partial class Form1AT : Form
    {
        Figure_with_text figure_With_Text;
        XCommand command;
        public Form1AT()
        {
            command = new XCommand();          
            InitializeComponent();
            figure_With_Text = new Figure_with_text(command);
            Controls.Add(figure_With_Text);
            figure_With_Text.Dock = DockStyle.Right;
        }
    }
}
