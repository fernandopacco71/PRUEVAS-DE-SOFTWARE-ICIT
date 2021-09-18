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

namespace TAREA03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Opercaciones op = new Opercaciones();
        private void Form1_Load(object sender, EventArgs e)
        {
            C_OPCIONES.Items.Add("Seleccionar");
            C_OPCIONES.Items.Add("PAR_IMPAR");
            C_OPCIONES.Items.Add("PERFECTO_IMPERFECTO");
            C_OPCIONES.Items.Add("DIVICIBLE_5");
            C_OPCIONES.Items.Add("PRIMO");
            C_OPCIONES.Enabled = false;
        }
        private void C_OPCIONES_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (C_OPCIONES.Text)
            {
                case "Seleccionar":
                    LABEL_TITULO.Text = "Calular Operaciones Aritmeticas";
                    break;
                case "PAR_IMPAR":
                    op.par_impar = T_NRO1.Text;
                    T_RESULTADOS.Text = op.par_impar;
                    LABEL_TITULO.Text = "Calcular si el Numero es par o impar";
                    break;
                case "PERFECTO_IMPERFECTO":
                    op.perfecto = T_NRO1.Text;
                    T_RESULTADOS.Text = op.perfecto;
                    LABEL_TITULO.Text = "Calcular si el Numero es Perfecto o Imperfecto";
                    break;
                case "DIVICIBLE_5":
                    op.divisible5 = T_NRO1.Text;
                    T_RESULTADOS.Text = op.divisible5;
                    LABEL_TITULO.Text = "Calcular si el Numero es Divicible O no Divicible entre 5";
                    break;
                case "PRIMO":
                    op.primo = T_NRO1.Text;
                    T_RESULTADOS.Text = op.primo;
                    LABEL_TITULO.Text = "Calcular si el Numero es Primo";
                    break;
            }
        }

        private void T_NRO1_TextChanged(object sender, EventArgs e)
        {
            if (T_NRO1.Text == "")
            {
                C_OPCIONES.Enabled = false;
                T_RESULTADOS.Text = "";
            }
            else
            {
                C_OPCIONES.Enabled = true;
            }
        }
    }
}
