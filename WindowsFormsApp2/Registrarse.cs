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
    public partial class Registrarse : Form
    {
        private consulta usuarioConsultas;

        public Registrarse()
        {
            InitializeComponent();
            usuarioConsultas = new consulta();
        }

        private bool DatosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(textnomr.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textbaliasr.Text))
            {
                MessageBox.Show("Por favor, ingrese el alias del usuario.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textbemailr.Text))
            {
                MessageBox.Show("Por favor, ingrese el correo del usuario.");
                return false;
            }
            return true;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                nombre = textnomr.Text.Trim(),
                alias = textbaliasr.Text.Trim(),
                correo = textbemailr.Text.Trim()
            };

            if (usuarioConsultas.AgregarUsuario(nuevoUsuario))
            {
                MessageBox.Show("Usuario creado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al crear el usuario.");
            }
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            textidr.ReadOnly = true;
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
