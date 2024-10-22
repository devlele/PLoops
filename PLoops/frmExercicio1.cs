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
    }
}
