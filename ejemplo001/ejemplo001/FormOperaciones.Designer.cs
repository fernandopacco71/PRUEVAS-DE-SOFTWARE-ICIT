
namespace ejemplo001
{
    partial class FormOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnro1 = new System.Windows.Forms.TextBox();
            this.cmbopciones = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnro2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            // 
            // txtnro1
            // 
            this.txtnro1.Location = new System.Drawing.Point(52, 67);
            this.txtnro1.Name = "txtnro1";
            this.txtnro1.Size = new System.Drawing.Size(100, 20);
            this.txtnro1.TabIndex = 1;
            // 
            // cmbopciones
            // 
            this.cmbopciones.FormattingEnabled = true;
            this.cmbopciones.Location = new System.Drawing.Point(52, 125);
            this.cmbopciones.Name = "cmbopciones";
            this.cmbopciones.Size = new System.Drawing.Size(121, 21);
            this.cmbopciones.TabIndex = 2;
            this.cmbopciones.Text = "Selecionar";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(354, 123);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnro2
            // 
            this.txtnro2.Location = new System.Drawing.Point(192, 67);
            this.txtnro2.Name = "txtnro2";
            this.txtnro2.Size = new System.Drawing.Size(100, 20);
            this.txtnro2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero2";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(329, 67);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opciones";
            // 
            // FormOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnro2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cmbopciones);
            this.Controls.Add(this.txtnro1);
            this.Controls.Add(this.label1);
            this.Name = "FormOperaciones";
            this.Text = "Operaciones Aritmeticas";
            this.Load += new System.EventHandler(this.FormOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnro1;
        private System.Windows.Forms.ComboBox cmbopciones;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

