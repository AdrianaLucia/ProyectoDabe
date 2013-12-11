using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wizardtest.Vistas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        public void LlenarDataSet()
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");


            System.Data.DataTable t = Controlador.ControladorRegistroPromedio.getDataSetTodos(idPeriodoActual);
            dgEstudiantes.AutoGenerateColumns = true;
            dgEstudiantes.DataSource = t;
            dgEstudiantes.Columns[0].Visible = false;
            
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            cbEstadoEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable listaEstados = Controlador.ControladorEstadoEstudiante.getDataSetTodos();
            cbEstadoEstudiante.DataSource = listaEstados;
            cbEstadoEstudiante.DisplayMember = "nombreestado";
            cbEstadoEstudiante.ValueMember = "idestudiante";
            LlenarDataSet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarDataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarDataSet();
        }
    }
}
