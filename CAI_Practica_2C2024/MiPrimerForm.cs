using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_Practica_2C2024
{
    public partial class MiPrimerForm : Form
    {
        public MiPrimerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MiPrimerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)

        {
            // Mostrar el texto ingresado en los textbox de nombre y apellido

            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string nombrecompleto = $"Nombre: {nombre}\nApellido: {apellido}";

            MessageBox.Show(nombrecompleto, "Alta correcta");


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
