using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Guardado.Visible = true;
            rut.Text = textrut.Text;
            apellido.Text = textapellido.Text;
            nombre.Text = textnom.Text;
            ciudad.Text = combociudad.Text;
            direccion.Text = textdireccion.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardado.Visible = false;
            direccion.Text = "";
            rut.Text = "";
            apellido.Text = "";
            nombre.Text = "";
            ciudad.Text = "";
            
        }
    }
}
