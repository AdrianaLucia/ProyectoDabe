using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace wizardtest
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGestionTipoActividad_Click(object sender, EventArgs e)
        {
            Form gestTipoActividad = new Vistas.FormTipoActividad();
            gestTipoActividad.ShowDialog();
        }

        private void buttonGestionEstadoActividad_Click(object sender, EventArgs e)
        {
            Form gestTipoActividad = new Vistas.FormEstadoActividad();
            gestTipoActividad.ShowDialog();
        }
    }
}
