using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace wizardtest.Vistas
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        public void LlenarDataSet()
        {
            System.Data.DataTable t = Controlador.ControladorUsuario.getDataSetTodos();
            dataGridListaUsuarios.AutoGenerateColumns = true;
            dataGridListaUsuarios.DataSource = t;
            dataGridListaUsuarios.Columns[0].Visible = false;
            textBoxIdUsuario.Text = "";
        }

        

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            comboBoxPregunta.SelectedIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword2.UseSystemPasswordChar = true;
            LlenarDataSet();
            DataTable listaEstados = Controlador.ControladorRolUsuario.getDataSetTodos();
            comboBoxRoles.DataSource = listaEstados;
            comboBoxRoles.DisplayMember = "nombre";
            comboBoxRoles.ValueMember = "idRolUsuario";
            
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
            if (textBoxPassword.Text == "") 
                errores += "Campo \"Password\" es obligatorio\n";
            if (textBoxPassword2.Text == "") 
                errores += "Campo \"Password 2\" es obligatorio\n";
            if (textBoxRespuesta.Text == "") 
                errores += "Campo \"Respuesta secreta\" es obligatorio\n";
            if (textBoxPassword.Text != textBoxPassword2.Text)
                errores += "Passwords no coinciden\n";
            if (errores != "")
            {
                MessageBox.Show(errores);
                return false;
            }
            return true;

        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            if (camposValidos()){

                int idRol = Int32.Parse(comboBoxRoles.SelectedValue.ToString());
                string pregSec = comboBoxPregunta.SelectedItem.ToString() ;
                Controlador.ControladorUsuario.adicionar(textBoxNombre.Text, textBoxApPat.Text, textBoxApMat.Text, textBoxNick.Text, textBoxPassword.Text, textBoxPassword2.Text, idRol, pregSec, textBoxRespuesta.Text);
            }
            LlenarDataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Int32.Parse(textBoxIdUsuario.Text);
                if (camposValidos())
                {

                    int idRol = Int32.Parse(comboBoxRoles.SelectedValue.ToString());
                    string pregSec = comboBoxPregunta.SelectedItem.ToString();
                    Controlador.ControladorUsuario.modificar(idUsuario, textBoxNombre.Text, textBoxApPat.Text, textBoxApMat.Text, textBoxNick.Text, textBoxPassword.Text, textBoxPassword2.Text, idRol, pregSec, textBoxRespuesta.Text);
                }
            }catch(Exception ex){
            }
            LlenarDataSet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Int32.Parse(textBoxIdUsuario.Text);


                Controlador.ControladorUsuario.eliminar(idUsuario);
               
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
                textBoxIdUsuario.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNombre.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxApPat.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxApMat.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxNick.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxPassword.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxPassword2.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                comboBoxRoles.SelectedValue = dataGridListaUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBoxPregunta.SelectedItem = dataGridListaUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBoxRespuesta.Text = dataGridListaUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                
            }
        }
    }
}
