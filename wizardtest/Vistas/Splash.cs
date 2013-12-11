using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wizardtest.Dominio;
namespace wizardtest.Vistas
{
    public partial class Splash : Form
    {
        public static Usuario usuario;
        public Splash(ref Usuario usuario)
        {
            //this.usuario = usuario;
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
        private static int intentos = 0;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nick = txtNick.Text;
            string pw = txtPass.Text;
            if (nick == "" || pw == "")
            {
                MessageBox.Show("Ingrese una cuenta de usuario y su password");
            }
            else
            {
                usuario = SerializadorUsuario.getUsuario(nick, pw);
                if (usuario == null || usuario.Password != pw.Trim())
                {
                    MessageBox.Show("Datos erroneos");
                    intentos++;
                }
                if (usuario.Password == pw.Trim())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }   
            }
        }
    }
}
