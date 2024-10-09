using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        // Este es el evento asociado al botón para conectar a SQL Server
        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la conexión SQL
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {
                // Abrir la conexión
                conexion.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            }
            catch (Exception ex)
            {
                // Capturar cualquier error y mostrarlo en un cuadro de mensaje
                MessageBox.Show("Error al conectar: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                // Cerrar la conexión en el bloque "finally"
                conexion.Close();
                MessageBox.Show("Se cerró la conexión.");
            }
        }
    }
}
