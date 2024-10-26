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
    public partial class frmExercicio2 : Form
    {
        double numeroN;
        double numeroH;

        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void txtNumeroN_Validating(object sender, CancelEventArgs e)
        {      
            if(!Double.TryParse(txtNumeroN.Text, out numeroN))
            {
                MessageBox.Show("Valor inválido");
                e.Cancel = true;
            }
            else
            {
                if (numeroN <= 0)
                {
                    MessageBox.Show("O valor não pode ser menor ou igual a 0");
                }
            }
        }

        private void btnNumeroH_Click(object sender, EventArgs e)
        {
            numeroH = 0;

            for (int i = 1; i <= numeroN; i++)
            {
                numeroH += 1.0 / i;
            }

            MessageBox.Show($"Numero H: {numeroH}");
        }
    }
}
