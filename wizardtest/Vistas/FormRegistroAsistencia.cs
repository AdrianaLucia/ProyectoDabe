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
            int idPeriodoActual = Properties.Settings.Default.id;

            System.Data.DataTable t = Controlador.ControladorActividadPeriodo.getDataSetTodosActividadNombre(idPeriodoActual);
            dgActividades.AutoGenerateColumns = true;
            dgActividades.DataSource = t;
            dgActividades.Columns[0].Visible = false;
            

        }



        private void FormRegistroAsistencia_Load(object sender, EventArgs e)
        {
           
            llenarDataSet();

        }
    }
}
