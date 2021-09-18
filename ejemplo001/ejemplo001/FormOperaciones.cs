using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace ejemplo001
{
    public partial class FormOperaciones : Form
    {
        public FormOperaciones()
        {
            InitializeComponent();
        }
        Operaciones op = new Operaciones();
        private void FormOperaciones_Load(object sender, EventArgs e)
        {
            cmbopciones.Items.Add("Suma");
            cmbopciones.Items.Add("Resta");
            cmbopciones.Items.Add("Multiplicacion");
            cmbopciones.Items.Add("Divicion");
            cmbopciones.Items.Add("Potencia");
            cmbopciones.Items.Add("radicacion");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            op.num1 = Convert.ToInt32(txtnro1.Text);
            op.num2 = Convert.ToInt32(txtnro2.Text);
            //switch (cmbopciones.Text)
            //{
            //    case "Suma":
            //        op.sumar();
            //        break;
            //    case "Resta":
            //        op.restar();
            //        break;
            //    case "Multiplicacion":
            //        op.multiplicar();
            //        break;
            //    case "Divicion":
            //        op.dividir();
            //        break;
            //    case "Potencia":
            //        op.potencia();
            //        break;
            //    case "radicacion":
            //        op.radicacion();
            //        break;
            //}
            //txtresultado.Text = op.resultado.ToString();


            switch (cmbopciones.Text)
            {
                case "Suma":
                    txtresultado.Text = op.sumar().ToString(); 
                    break;
                case "Resta":
                    op.restar();
                    break;

            }
        }
    }
}
