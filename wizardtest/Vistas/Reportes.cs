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
          public void LlenarDataSetIAAMenorProm()
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");


            System.Data.DataTable t = Controlador.ControladorRegistroPromedio.getDataSetTodosMenoProm(idPeriodoActual);
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
            LlenarDataSetIAAMenorProm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarDataSet();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs m = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dgEstudiantes, m);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel ex = new ExportToExcel();
            ex.dt = dgEstudiantes;
            ex.exportToExcel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbEstadoEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;

            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");


            System.Data.DataTable t = Controlador.ControladorRegistroPromedio.getDataSetTodosAsistencia(idPeriodoActual);
            dgEstudiantes.AutoGenerateColumns = true;
            dgEstudiantes.DataSource = t;
            dgEstudiantes.Columns[0].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado");
        }
    }
}
