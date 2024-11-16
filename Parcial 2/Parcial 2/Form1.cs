using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
      
        private List<string> historial = new List<string>();   //historial de cálculos

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadArchivos = int.Parse(txtCantidadArchivos.Text);
                double tamanoArchivoMB = double.Parse(txtTamanoArchivo.Text);
                double tamanoUSBGB = double.Parse(txtTamanoUSB.Text);
                double tamanoUSBMB = tamanoUSBGB * 1024;
                double totalArchivos = tamanoUSBMB / tamanoArchivoMB; //dividir mis cantidades de archivos con la memoria usb

                MessageBox.Show($"Puedes guardar un máximo de {Math.Floor(totalArchivos)} archivos de {tamanoArchivoMB} MB en una unidad USB de {tamanoUSBGB} GB.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                historial.Add($"Cantidad de Archivos: {cantidadArchivos}, Tamaño de Archivo: {tamanoArchivoMB} MB, Tamaño USB: {tamanoUSBGB} GB. Archivos que caben: {Math.Floor(totalArchivos)}.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese datos válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarHist_Click(object sender, EventArgs e)
        {
            if (historial.Count > 0)
            {
                string historialTexto = string.Join(Environment.NewLine, historial);
                MessageBox.Show(historialTexto, "Historial de Cálculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay cálculos en el historial.", "Historial Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}