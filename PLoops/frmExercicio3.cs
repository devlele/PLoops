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
    public partial class frmExercicio3 : Form
    {
        string texto;
        string textoInvertido;
        string textoMinimizado;

        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            texto = txtPalindromo.Text;
            textoMinimizado = texto.Replace(" ","").ToLower();
            textoInvertido = new string(textoMinimizado.Reverse().ToArray());

            if(textoMinimizado == textoInvertido)
            {
                MessageBox.Show("É um palindromo");
            }
            else
            {
                MessageBox.Show("Não é um palindromo");
            }
        }
    }
}
