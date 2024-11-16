namespace Parcial_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblCantidadArchivos = new Label();
            lblTamanoArchivo = new Label();
            lblTamanoUSB = new Label();
            txtCantidadArchivos = new TextBox();
            txtTamanoArchivo = new TextBox();
            txtTamanoUSB = new TextBox();
            btnCalcular = new Button();
            btnMostrarHist = new Button();
            SuspendLayout();
        
            lblCantidadArchivos.AutoSize = true;
            lblCantidadArchivos.Location = new Point(32, 30);
            lblCantidadArchivos.Name = "lblCantidadArchivos";
            lblCantidadArchivos.Size = new Size(245, 32);
            lblCantidadArchivos.TabIndex = 0;
            lblCantidadArchivos.Text = "Cantidad de Archivos:";
           
            lblTamanoArchivo.AutoSize = true;
            lblTamanoArchivo.Location = new Point(32, 90);
            lblTamanoArchivo.Name = "lblTamanoArchivo";
            lblTamanoArchivo.Size = new Size(280, 32);
            lblTamanoArchivo.TabIndex = 1;
            lblTamanoArchivo.Text = "Tamaño de Archivo (MB):";
          
            lblTamanoUSB.AutoSize = true;
            lblTamanoUSB.Location = new Point(32, 150);
            lblTamanoUSB.Name = "lblTamanoUSB";
            lblTamanoUSB.Size = new Size(203, 32);
            lblTamanoUSB.TabIndex = 2;
            lblTamanoUSB.Text = "Tamaño USB (GB):";
           
            txtCantidadArchivos.Location = new Point(320, 30);
            txtCantidadArchivos.Name = "txtCantidadArchivos";
            txtCantidadArchivos.Size = new Size(150, 39);
            txtCantidadArchivos.TabIndex = 3;
         
            txtTamanoArchivo.Location = new Point(320, 90);
            txtTamanoArchivo.Name = "txtTamanoArchivo";
            txtTamanoArchivo.Size = new Size(150, 39);
            txtTamanoArchivo.TabIndex = 4;
         
            txtTamanoUSB.Location = new Point(320, 150);
            txtTamanoUSB.Name = "txtTamanoUSB";
            txtTamanoUSB.Size = new Size(150, 39);
            txtTamanoUSB.TabIndex = 5;
          
            btnCalcular.Location = new Point(201, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 46);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
           
            btnMostrarHist.Location = new Point(490, 229);
            btnMostrarHist.Name = "btnMostrarHist";
            btnMostrarHist.Size = new Size(243, 46);
            btnMostrarHist.TabIndex = 7;
            btnMostrarHist.Text = "Mostrar Historial";
            btnMostrarHist.UseVisualStyleBackColor = true;
            btnMostrarHist.Click += btnMostrarHist_Click;
          
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 300);
            Controls.Add(btnMostrarHist);
            Controls.Add(btnCalcular);
            Controls.Add(txtTamanoUSB);
            Controls.Add(txtTamanoArchivo);
            Controls.Add(txtCantidadArchivos);
            Controls.Add(lblTamanoUSB);
            Controls.Add(lblTamanoArchivo);
            Controls.Add(lblCantidadArchivos);
            Name = "Form1";
            Text = "Cantidad de Archivos en USB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidadArchivos;
        private Label lblTamanoArchivo;
        private Label lblTamanoUSB;
        private TextBox txtCantidadArchivos;
        private TextBox txtTamanoArchivo;
        private TextBox txtTamanoUSB;
        private Button btnCalcular;
        private Button btnMostrarHist;
    }
}
