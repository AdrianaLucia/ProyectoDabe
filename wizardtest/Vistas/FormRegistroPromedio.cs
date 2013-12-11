using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace wizardtest.Vistas
{
    public partial class FormRegistroPromedio : Form
    {
        public FormRegistroPromedio()
        {
            InitializeComponent();
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo guardado como CSV (CSV)|*.csv";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                textBox1.Text = openFileDialog1.FileName;
                try
                {
                    string[][] elems = CSVParser.ParsearArchivo(fname);
                    int numFils = elems.Count();
                    int numCols = elems[0].Count();
                    dgCSV.RowCount = numFils;
                    dgCSV.ColumnCount = elems[0].Count();

                    for (int i = 0; i < numFils; ++i)
                        for (int j = 0; j < numCols; ++j)
                            dgCSV[j, i].Value = elems[i][j];


                }	
                catch(Exception ex)
                    {
                      MessageBox.Show("El archivo no existe o esta siendo usado por otra aplicacion.");
                 }
    
            }
        }

        private void FormRegistroPromedio_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
              int idPeriodoActual = Properties.Settings.Default.id;
            if (idPeriodoActual == -1)
                MessageBox.Show("Periodo no seleccionado"); 
            int numFilas = dgCSV.RowCount;
            int numCols = dgCSV.ColumnCount;

            if (numFilas == 0 || numCols == 0)
            {
                MessageBox.Show("Seleccione un archivo");
            }
            else
            {
                if (MessageBox.Show("Desea importar los datos?", "IMPORTAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Fila 0 es de headers asi que la saltamos.
                    for (int i = 1; i < numFilas; ++i)
                    {
                        try {
                        string nroRegistro = dgCSV.Rows[i].Cells[0].Value.ToString();
                        string nombre = dgCSV.Rows[i].Cells[1].Value.ToString();
                        int carrera = Int32.Parse(dgCSV.Rows[i].Cells[2].Value.ToString());
                        Double promCarrera = Double.Parse(dgCSV.Rows[i].Cells[3].Value.ToString());
                        int IAA = Int32.Parse(dgCSV.Rows[i].Cells[4].Value.ToString());
                        int IAP = Int32.Parse(dgCSV.Rows[i].Cells[5].Value.ToString());
                        Controlador.ControladorRegistroPromedio.modificar(nroRegistro, idPeriodoActual, nombre, carrera, promCarrera, IAA, IAP);

                        } catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
  
                    }
                    MessageBox.Show("Datos actualizados");
                }
            }

        }
    }
}
