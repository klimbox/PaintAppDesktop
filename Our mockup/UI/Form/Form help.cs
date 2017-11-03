using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_mockup
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Text = "This program is designed to create drawings in the system Windows 10. The program provides the ability to freely draw, as well as creating shapes like: a rectangle, an ellipse, a rectangular with a rounded edges and a line. In addition, there is the possibility of changing the color, the thickness of the line and the type of the already created figure, as well as changing its size and moving along the canvas. Figures can have their own text, which also has its own, color-independent, font and angle. The created drawings can be saved and loaded into YAML, XML, JSON formats.";
        }
    }
}
