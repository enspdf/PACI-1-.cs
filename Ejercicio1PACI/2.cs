using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1PACI
{
    public partial class _2 : Form
    {
        public _2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Es letra");
                textBox1.Clear();
            }
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Es numero");
                textBox1.Clear();
            }

        }
    }
}
