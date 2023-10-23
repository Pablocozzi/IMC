using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 peso = 0;
            Int32 altura = 0;
            Double alturaTotal = 0;
            Double resultado = 0;


            peso = Convert.ToInt32(txtPeso.Text);
            altura = Convert.ToInt32(txtAltura.Text);

            alturaTotal =(Double)peso/((Double)altura*(Double)altura);
            resultado = alturaTotal * 100;

            lblResultadoNumero.Text = resultado.ToString("0.00%");


        }
    }
}
