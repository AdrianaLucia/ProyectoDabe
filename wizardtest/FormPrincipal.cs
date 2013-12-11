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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form gestActividades = new Vistas.FormActividad();
            gestActividades.ShowDialog(); 
        }

        private void buttonRolUsuario_Click(object sender, EventArgs e)
        {
            Form getRolUsuario = new Vistas.FormRolUsuario();
            getRolUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form getUsuarios = new Vistas.FormUsuario();
            getUsuarios.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form estadosEstudiantes = new Vistas.FormEstadoEstudiante();
            estadosEstudiantes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form periodosAcademicos = new Vistas.FormPeriodoAcademico();
            periodosAcademicos.ShowDialog();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Form estudiantes = new Vistas.FormEstudiante();
            estudiantes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form actper = new Vistas.FormActividadPeriodo();
            actper.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form carr = new Vistas.FormCarrera();
            carr.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private bool yaCargo = false;
        public static Dominio.Usuario UsuarioActual = null;
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioActual = null;
            Form splash = new Vistas.Splash(ref UsuarioActual);
            DialogResult dr=  splash.ShowDialog();
            if (dr==DialogResult.OK)
            {
                UsuarioActual = Vistas.Splash.usuario;
                MessageBox.Show("Bienvenid@: "+UsuarioActual.Nombre);
            }

            if (dr != DialogResult.OK) this.Close();
            yaCargo = false;
            DataTable listaEstados = Controlador.ControladorPeriodoAcademico.getDataSetTodosTexto();
            comboBox1.DataSource = listaEstados;
            comboBox1.DisplayMember = "texto";
            comboBox1.ValueMember = "idPeriodo";
            yaCargo = true;
            if (Properties.Settings.Default.id != -1)
            {
                comboBox1.SelectedValue = Properties.Settings.Default.id;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (yaCargo)
            {
                string indiceSeleccionado = comboBox1.SelectedValue.ToString();
                Properties.Settings.Default.id = Convert.ToInt32(indiceSeleccionado);
                Properties.Settings.Default.Save();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form asistencia = new Vistas.FormRegistroAsistencia();
            asistencia.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form registroEstudianteActividad = new Vistas.FormRegistroEstudianteActividadPeriodo();
            registroEstudianteActividad.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
