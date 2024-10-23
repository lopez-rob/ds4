using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto__1
{
    public partial class Form1 : Form
    {
        private string operacion = "";
        private double resultado = 0;
        private bool nuevoCalculo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            resultado = double.Parse(textBoxResultado.Text);
            textBoxResultado.Clear();
        }

        private void botonRaiz_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBoxResultado.Text);
            resultado = Math.Sqrt(valor);
            textBoxResultado.Text = resultado.ToString();
            operacion = "";
        }

        private void botonElevado_Click(object sender, EventArgs e)
        {
            operacion = "^";
            resultado = double.Parse(textBoxResultado.Text);
            textBoxResultado.Clear();
        }

        private void botonCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            operacion = "";
            resultado = 0;
        }

        private void boton7_Click(object sender, EventArgs e) => AgregarNumero("7");
        private void boton8_Click(object sender, EventArgs e) => AgregarNumero("8");
        private void boton9_Click(object sender, EventArgs e) => AgregarNumero("9");
        private void boton4_Click(object sender, EventArgs e) => AgregarNumero("4");
        private void boton5_Click(object sender, EventArgs e) => AgregarNumero("5");
        private void boton6_Click(object sender, EventArgs e) => AgregarNumero("6");
        private void boton1_Click(object sender, EventArgs e) => AgregarNumero("1");
        private void boton2_Click(object sender, EventArgs e) => AgregarNumero("2");
        private void boton3_Click(object sender, EventArgs e) => AgregarNumero("3");
        private void boton0_Click(object sender, EventArgs e) => AgregarNumero("0");
        private void botonDecimal_Click(object sender, EventArgs e) => AgregarNumero(".");

        private void botonPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            resultado = double.Parse(textBoxResultado.Text);
            textBoxResultado.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            resultado = double.Parse(textBoxResultado.Text);
            textBoxResultado.Clear();
        }

        private void BotonSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            resultado = double.Parse(textBoxResultado.Text);
            textBoxResultado.Clear();
        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            double segundoValor = double.Parse(textBoxResultado.Text);
            switch (operacion)
            {
                case "+":
                    resultado += segundoValor;
                    break;
                case "-":
                    resultado -= segundoValor;
                    break;
                case "*":
                    resultado *= segundoValor;
                    break;
                case "/":
                    resultado /= segundoValor;
                    break;
                case "^":
                    resultado = Math.Pow(resultado, segundoValor);
                    break;
            }
            textBoxResultado.Text = resultado.ToString();
            operacion = "";
            nuevoCalculo = true;
        }

        private void botonResultados_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void AgregarNumero(string numero)
        {
            if (nuevoCalculo)
            {
                textBoxResultado.Clear();
                nuevoCalculo = false;
            }
            textBoxResultado.AppendText(numero);
        }

        private void MostrarResultados()
        {
            string server = "DESKTOP-R8H7AJQ\\SQLEXPRESS";
            string database = "MiBaseDeDatos";
            string userId = "";
            string password = "";

            DatabaseConnection dbConnection = new DatabaseConnection(server, database, userId, password);

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT operacion, resultado FROM historial";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string operacion = reader["operacion"].ToString();
                    string resultado = reader["resultado"].ToString();
                    textBoxResultado.AppendText($"{operacion} = {resultado}\n");
                }
            }
        }
    }

    public class DatabaseConnection
    {
        private string server;
        private string database;
        private string userId;
        private string password;
        private SqlConnection connection;

        public DatabaseConnection(string server, string database, string userId, string password)
        {
            this.server = server;
            this.database = database;
            this.userId = userId;
            this.password = password;

            string connectionString = $"Server={server};Database={database};User Id={userId};Password={password};";
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
