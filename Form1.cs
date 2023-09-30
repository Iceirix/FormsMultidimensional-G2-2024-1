using System;
using System.Windows.Forms;

namespace FormsMultidimensional_G2_2024_1
{
    public partial class Form1 : Form
    {
        private bool Intro = true;
        private Multidimensional m1;
        private Multidimensional m2;
        private Multidimensional m3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            if (Intro)
            {
                m1 = Multidimensional.Leer(txtbDisplay.Text);
                lbMatriz1.Text = m1.ToString();
                Intro = false;
            }
            else
            {
                m2 = Multidimensional.Leer(txtbDisplay.Text);
                lbMatriz2.Text = m2.ToString();
                Intro = true;
            }
            txtbDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbDisplay.Text = "";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            m3 = m1 + m2;
            lbResultado.Text = m3.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            m3 = m1 - m2;
            lbResultado.Text = m3.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            m3 = m1 * m2;
            lbResultado.Text = m3.ToString();
        }
        private void btnSeno_Click(object sender, EventArgs e)
        {

            if (rdbRad.Checked)
                lbResultado.Text = Multidimensional.senoMatriz(m3, true).ToString();
            else if (rdbDeg.Checked)
                lbResultado.Text = Multidimensional.senoMatriz(m3, false).ToString();
            else
                MessageBox.Show("Selecicone una opción: rad o deg");
        }
    }
}
