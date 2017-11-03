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
    public partial class Form2 : Form
    {
        public string Text { get; set; }
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "New Tab";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text != "")
            {
                Text = textBox1.Text;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
                button1.BackColor = Color.Silver;
            }
            else
            {
                button1.Enabled = true;
                button1.BackColor = Color.White;
            }
        }
    }
}
