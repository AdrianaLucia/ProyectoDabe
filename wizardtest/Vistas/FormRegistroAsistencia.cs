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
    public partial class FormRegistroAsistencia : Form
    {
        public FormRegistroAsistencia()
        {
            InitializeComponent();
        }

        void llenarDataSet()
        {
            try
            {
                int idPeriodoActual = Properties.Settings.Default.id;

                System.Data.DataTable t = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
                dgActividades.DataSource = t;

                dgActividades.AutoGenerateColumns = true;

                dgActividades.RowHeadersVisible = false;
                dgActividades.Columns["idAsociacion"].Visible = false;
                dgActividades.Columns["idActividad"].Visible = false;
                dgActividades.Columns["idPeriodo"].Visible = false;
                dgActividades.Columns["nombre"].Width = dgActividades.Width;

                dgActividades.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        static int periodoActual = 0;

        private void actualizarListaEstudiantesActividad(int i)
        {

            System.Data.DataTable t = Controlador.ControladorRegistroEstudianteActividadPeriodo.getDataSetEstudiantesAsistencia(i, periodoActual, semanaSeleccionada);
            dgEstudiantesEnActividad.AutoGenerateColumns = true;
            dgEstudiantesEnActividad.DataSource = t;
            dgEstudiantesEnActividad.Columns[0].Visible = false;
            dgEstudiantesEnActividad.AutoResizeColumns();
        }
        private void FormRegistroAsistencia_Load(object sender, EventArgs e)
        {
            semanaSeleccionada = "";
            periodoActual = Properties.Settings.Default.id;
            llenarDataSet();
            dateTimePicker1.Value = DateTime.Now;
        }

        static string semanaSeleccionada;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime escogido = dateTimePicker1.Value;
            int diffLunes = escogido.DayOfWeek - DayOfWeek.Monday;
            if (diffLunes < 0) diffLunes += 7;
            DateTime inicioSemana = escogido.AddDays(-1 * diffLunes);
            DateTime finSemana = inicioSemana.AddDays(6);
            lblSemana.Text = inicioSemana.ToString("dd-MM") + " al " + finSemana.ToString("dd-MM");
            semanaSeleccionada = inicioSemana.ToString("yy-MM-dd");
            RefrescarListas();
        }

        private void dgActividades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RefrescarListas(); 
        }

        private void RefrescarListas()
        {
            int idActividad = -1;
            if (dgActividades.SelectedRows.Count > 0)
            {
                string valorEnCelda = dgActividades.SelectedRows[0].Cells["idActividad"].Value.ToString();
                if (Int32.TryParse(valorEnCelda, out idActividad))
                {
                    actualizarListaEstudiantesActividad(idActividad);
                }
            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            int idReapSeleccionado = -1;
            if (dgEstudiantesEnActividad.SelectedRows.Count > 0)
            {
                string valorEnCelda = dgEstudiantesEnActividad.SelectedRows[0].Cells["id"].Value.ToString();
                int AsistenciaActual = Convert.ToInt32(dgEstudiantesEnActividad.SelectedRows[0].Cells["Asistio"].Value.ToString());
                if (Int32.TryParse(valorEnCelda, out idReapSeleccionado))
                {
                    Controlador.ControladorAsistencia.crearReemplazar(idReapSeleccionado, 1 - AsistenciaActual, semanaSeleccionada);
                }
            }
            RefrescarListas();
            
        }
    }
}
