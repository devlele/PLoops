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
    public partial class frmExercicio1 : Form
    {
        string Frase;
        int numEspaco;

        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            Frase = rchtxtFrase.Text;

            foreach (char i in Frase)
            {
                if(i == ' ')
                {
                    numEspaco ++;
                }
            }

            MessageBox.Show($"A frase tem {numEspaco} espaços em branco");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            Frase = rchtxtFrase.Text;
            int i = 0;
            int contR = 0;
            

            while (i < Frase.Length)
            {
                if (Frase[i] == 'R' || Frase[i] == 'r')
                {
                    contR++;
                }

                i++;
            }

            MessageBox.Show($"A frase possui {contR} letras R");
        }

        private void btnDuplas_Click(object sender, EventArgs e)
        {
            Frase = rchtxtFrase.Text;
            int contDuplas = 0;

            for(int i = 1; i < Frase.Length; i++)
            {
                if (Frase[i] == Frase[i - 1])
                {
                    contDuplas ++;
                }
            }

            MessageBox.Show($"A frase possui {contDuplas} pares de letras");
        }
    }
}
