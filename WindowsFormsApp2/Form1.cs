using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        private consulta usuarioConsultas;
        private int intentos = 0;

        public Form1()
        {
            InitializeComponent();
            usuarioConsultas = new consulta();
        }

        private bool DatosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(textb_alias.Text))
            {
                MessageBox.Show("Por favor, ingrese el alias.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textb_email.Text))
            {
                MessageBox.Show("Por favor, ingrese el correo.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textb_nombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre.");
                return false;
            }
            return true;
        }

        private void tres_errores()
        {
            btniniciar.Enabled = false;
            MessageBox.Show("Demasiados intentos fallidos. Esperando 15 segundos...");

            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += (s, args) =>
            {
                timer.Stop();
                this.Invoke((MethodInvoker)delegate {
                    btniniciar.Enabled = true;
                    intentos = 0;
                });
            };
            timer.Start();
        }

        private void btnregistrarse_Click_1(object sender, EventArgs e)
        {
            Registrarse Registrarse = new Registrarse();
            Registrarse.Show();
        }

        private void btniniciar_Click_1(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }

            string alias = textb_alias.Text.Trim();
            string correo = textb_email.Text.Trim();
            string nombre = textb_nombre.Text.Trim();

            // Validar el usuario
            bool esValido = usuarioConsultas.ValidarUsuario(alias, correo, nombre);

            if (esValido)
            {
                MessageBox.Show("Login exitoso.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Alias, correo o nombre incorrectos.");
                intentos++;

                if (intentos >= 3)
                {
                    tres_errores();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textb_id.ReadOnly = true;
        }
    }
}
