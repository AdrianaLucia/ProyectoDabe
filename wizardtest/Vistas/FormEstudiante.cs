using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wizardtest.Controlador;

namespace wizardtest.Vistas
{
    public partial class FormEstudiante : Form
    {
        Dictionary<String, int> listaCarreras;

        public FormEstudiante()
        {
            InitializeComponent();
            /*comboBoxCarrera.DisplayMember = "nombre";
            comboBoxCarrera.ValueMember = "id";

            comboBoxCarrera.DataSource = new[]{
                new {nombre="Ingenieria de Sistemas",id=550},
                new {nombre="Ingenieria Electronica",id=555}
            };*/

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        public void LlenarDataSet()
        {
            System.Data.DataTable t = Controlador.ControladorEstudiante.getDataSetTodos();
            dataGridListaUsuarios.AutoGenerateColumns = true;
            dataGridListaUsuarios.DataSource = t;
            dataGridListaUsuarios.Columns[0].Visible = false;
            textBoxIdEstudiante.Text = "";
        }



        private void FormUsuario_Load(object sender, EventArgs e)
        {
           

        }

        private bool camposValidos()
        {
            String errores = "";
            if (textBoxNombre.Text == "")
                errores += "Campo \"Nombre\" es obligatorio\n";
            if (textBoxApPat.Text == "")
                errores += "Campo \"Apellido Paterno\" es obligatorio\n";
            if (textBoxApMat.Text == "")
                errores += "Campo \"Apellido Materno\" es obligatorio\n";
            if (textBoxRegistroEstudiante.Text == "")
                errores += "Campo \"Registro\" es obligatorio\n";
            
            if (errores != "")
            {
                MessageBox.Show(errores);
                return false;
            }
            return true;

        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {

                
                
                int usoCondicio = 0;
                if (cbCondicionEspecial.Checked) usoCondicio=1;

                Controlador.ControladorEstudiante.adicionar(textBoxRegistroEstudiante.Text, textBoxNombre.Text, textBoxApPat.Text, textBoxApMat.Text, comboBoxFacultad.SelectedItem.ToString(), Int32.Parse(comboBoxCarrera.SelectedValue.ToString()), Int32.Parse(comboEstadoEstudiante.SelectedValue.ToString()), usoCondicio);
            }
            LlenarDataSet();
            limpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Int32.Parse(textBoxIdEstudiante.Text);
                if (camposValidos())
                {
                    int usoCondicio = 0;
                    if (cbCondicionEspecial.Checked) usoCondicio = 1;

                    Controlador.ControladorEstudiante.modificar(idUsuario,textBoxRegistroEstudiante.Text, textBoxNombre.Text, textBoxApPat.Text, textBoxApMat.Text, comboBoxFacultad.SelectedItem.ToString(),Int32.Parse(comboBoxCarrera.SelectedValue.ToString()), Int32.Parse(comboEstadoEstudiante.SelectedValue.ToString()), usoCondicio);
                }
            }
            catch (Exception ex)
            {
            }
            LlenarDataSet();
            limpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Int32.Parse(textBoxIdEstudiante.Text);


                Controlador.ControladorEstudiante.eliminar(idUsuario);

            }
            catch (Exception ex)
            {
            }
            LlenarDataSet();
        }

        private void dataGridListaUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridListaUsuarios.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBoxIdEstudiante.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxRegistroEstudiante.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNombre.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxApPat.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxApMat.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxFacultad.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBoxCarrera.SelectedValue = Int32.Parse(dataGridListaUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString());
                comboEstadoEstudiante.SelectedValue = Int32.Parse(dataGridListaUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString());
                int uso = Int32.Parse(dataGridListaUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString());
                if (uso == 0) cbCondicionEspecial.Checked = false;
                else cbCondicionEspecial.Checked = true;
            }
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            comboBoxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstadoEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxFacultad.SelectedIndex = 0;
            comboBoxCarrera.SelectedIndex = 0;

            DataTable listaEstados = Controlador.ControladorEstadoEstudiante.getDataSetTodos();
            comboEstadoEstudiante.DataSource = listaEstados;
            comboEstadoEstudiante.DisplayMember = "nombreestado";
            comboEstadoEstudiante.ValueMember = "idestudiante";

            /*DataTable listaCarreras = Controlador.ControladorCarrera.getDataSetPorFacultad(comboBoxFacultad.SelectedItem.ToString());
            comboBoxCarrera.DataSource = listaCarreras;
            comboBoxCarrera.DisplayMember = "nombre";
            comboBoxCarrera.ValueMember = "codigo";*/
            LlenarDataSet();
            limpiarCampos();
            /* DataTable listaEstados = Controlador.ControladorRolUsuario.getDataSetTodos();
             comboBoxFacultad.DataSource = listaEstados;
             comboBoxFacultad.DisplayMember = "nombre";
             comboBoxFacultad.ValueMember = "idRolUsuario";*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRegistroEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void comboBoxFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable listaCarreras = Controlador.ControladorCarrera.getDataSetPorFacultad(comboBoxFacultad.SelectedItem.ToString());
            comboBoxCarrera.DataSource = listaCarreras;
            comboBoxCarrera.DisplayMember = "nombre";
            comboBoxCarrera.ValueMember = "codigo";
           // LlenarDataSet();
        }

        private void limpiarCampos()
        {
            textBoxApMat.Text = "";
            textBoxApPat.Text = "";
            textBoxIdEstudiante.Text = "";
            textBoxNombre.Text = "";
            textBoxRegistroEstudiante.Text = "";
            cbCondicionEspecial.Checked = false;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}

