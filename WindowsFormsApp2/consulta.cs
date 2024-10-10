using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class consulta
    {
        private conexion2 conexionMysql;

        public consulta()
        {
            conexionMysql = new conexion2();
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            string INSERT = "INSERT INTO tbl_user (nombre, alias, correo) VALUES (@nombre, @alias, @correo)";

            try
            {
                using (var connection = conexionMysql.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(INSERT, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", usuario.nombre);
                        command.Parameters.AddWithValue("@alias", usuario.alias);
                        command.Parameters.AddWithValue("@correo", usuario.correo);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar usuario: {ex.Message}");
                return false;
            }
        }

        public bool ValidarUsuario(string alias, string correo, string nombre)
        {
            string QUERY = "SELECT COUNT(*) FROM tbl_user WHERE alias = @alias AND correo = @correo AND nombre = @nombre";

            try
            {
                using (var connection = conexionMysql.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(QUERY, connection))
                    {
                        command.Parameters.AddWithValue("@alias", alias);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@nombre", nombre);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}");
                return false;
            }
        }
    }
}
