using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLoops
{ 
    public partial class frmExercicio4 : Form
    {
        int producao;
        int gratificacao;
        double salario;
        double salarioBruto;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void txtProdução_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(txtProdução.Text, out producao))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
        }

        private void txtSalario_Validating(object sender, CancelEventArgs e)
        {
            if(!Double.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
        }

        private void txtGratificacao_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(txtGratificacao.Text, out gratificacao))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
        }

        private void btnCalcSalario_Click(object sender, EventArgs e)
        {
            int B = producao >= 100 ? 1 : 0;
            int C = producao >= 120 ? 1 : 0;
            int D = producao >= 150 ? 1 : 0;

            salarioBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (salarioBruto > 7000)
            {
                if(producao <= 150 || gratificacao == 0)
                {
                    salarioBruto = 7000.00;
                    MessageBox.Show($"Salario bruto do funionário: {salarioBruto}");
                }
            }
            else
            {
                MessageBox.Show($"Salario bruto do funionário: {salarioBruto}");
            }
        }
    }
}
