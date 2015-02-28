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
    public partial class Form1 : Form
    {
        double nota = 0;
        double acomulador = 0;
        double prom;
        string conv;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        int[] notas = new int[4];

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text != null)
            {
                if (txtNota1.Text == "")
                {
                    MessageBox.Show("Debe ingresar un valor");
                }
                else
                {
                    lbNotas.Items.Add(cbMaterias.SelectedItem + " " + txtNota1.Text);
                    nota = Convert.ToInt16(txtNota1.Text);
                    acomulador = acomulador + nota;
                    prom = acomulador / 4;
                    conv = prom.ToString();
                }
                //MessageBox.Show(conv);                
            }
                /*nota[i] = int.Parse(txtNota.Text);
                int suma = nota[0] + nota[1] + nota[2] + nota[3];
                string resultado = suma.ToString();
                MessageBox.Show(resultado);*/

            //for (int i = 0; i <= 4; i++)
            //{
                //txtNota.Text[i];
            //}
            
            

            
            //notas = string(txtNota.Text);
            //List<int> notas = new List<int>();
            //notas.Add(int.Parse(txtNota.Text)[0]);
            //string[] materia = new string[4];
            //materia = cbMaterias.Text[];

            //lbNotas.Items.Add(cbMaterias.Text + " " + txtNota1.Text);
            //lbNotas.Items.Add(cbMaterias.Text);
            //lbNotas.Items.Add(txtNota.Text);
            //txtNota1.Text = "";
            //txtNota2.Text = "";
            //txtNota3.Text = "";
            //txtNota4.Text = "";
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (prom < 3.5)
            {
                pbResultado.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\NOMG.jpg");
            }
            else if (prom >= 3.5)
            {
                pbResultado.Image = Image.FromFile(@"C:\Users\Sebastian-pc\Desktop\phtss\visual\MG.jpg");
            }
        }
    }
}


