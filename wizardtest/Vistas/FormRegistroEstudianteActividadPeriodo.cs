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
    public partial class FormRegistroEstudianteActividadPeriodo : Form
    {
        public FormRegistroEstudianteActividadPeriodo()
        {
            InitializeComponent();
        }

        private void FormRegistroEstudianteActividadPeriodo_Load(object sender, EventArgs e)
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");
            
            System.Data.DataTable t = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
            dgActividadesPeriodo.AutoGenerateColumns = true;
            dgActividadesPeriodo.DataSource = t;
            dgActividadesPeriodo.Columns[0].Visible = false;


            DataTable listaAct = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
            cbActividadesPeriodo.DataSource = listaAct;
            cbActividadesPeriodo.ValueMember = "idAsociacion";
            cbActividadesPeriodo.DisplayMember = "nombre";
            cbActividadesPeriodo.SelectedIndex = 0;

            DataTable listaEstudiantes = Controlador.ControladorEstudiante.getDataSetTodos();
            dgEstudiantes.AutoGenerateColumns = true;
            dgEstudiantes.DataSource = listaEstudiantes;
            dgEstudiantes.Columns[0].Visible = false;

            
        }
    }
}
