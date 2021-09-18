
namespace TAREA03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label16 = new System.Windows.Forms.Label();
            this.C_OPCIONES = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.T_RESULTADOS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.T_NRO1 = new System.Windows.Forms.TextBox();
            this.LABEL_TITULO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "OPCIONES";
            // 
            // C_OPCIONES
            // 
            this.C_OPCIONES.FormattingEnabled = true;
            this.C_OPCIONES.Location = new System.Drawing.Point(28, 161);
            this.C_OPCIONES.Name = "C_OPCIONES";
            this.C_OPCIONES.Size = new System.Drawing.Size(157, 21);
            this.C_OPCIONES.TabIndex = 27;
            this.C_OPCIONES.Text = "Seleccionar";
            this.C_OPCIONES.SelectedIndexChanged += new System.EventHandler(this.C_OPCIONES_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Resultado";
            // 
            // T_RESULTADOS
            // 
            this.T_RESULTADOS.Location = new System.Drawing.Point(193, 106);
            this.T_RESULTADOS.Name = "T_RESULTADOS";
            this.T_RESULTADOS.Size = new System.Drawing.Size(205, 20);
            this.T_RESULTADOS.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "INGRESE UN NUMERO";
            // 
            // T_NRO1
            // 
            this.T_NRO1.Location = new System.Drawing.Point(24, 106);
            this.T_NRO1.Name = "T_NRO1";
            this.T_NRO1.Size = new System.Drawing.Size(100, 20);
            this.T_NRO1.TabIndex = 25;
            this.T_NRO1.TextChanged += new System.EventHandler(this.T_NRO1_TextChanged);
            // 
            // LABEL_TITULO
            // 
            this.LABEL_TITULO.AutoSize = true;
            this.LABEL_TITULO.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_TITULO.Location = new System.Drawing.Point(12, 28);
            this.LABEL_TITULO.Name = "LABEL_TITULO";
            this.LABEL_TITULO.Size = new System.Drawing.Size(315, 28);
            this.LABEL_TITULO.TabIndex = 23;
            this.LABEL_TITULO.Text = "Calular Operaciones Aritmeticas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.C_OPCIONES);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.T_RESULTADOS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.T_NRO1);
            this.Controls.Add(this.LABEL_TITULO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox C_OPCIONES;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox T_RESULTADOS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox T_NRO1;
        private System.Windows.Forms.Label LABEL_TITULO;
    }
}

