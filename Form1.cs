using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMultidimensional_G2_2024_1
{
    public partial class Form1 : Form
    {
        Multidimensional m1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            m1 = Multidimensional.Leer(txtbDisplay.Text);
            lbMatriz1.Text = m1.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbDisplay.Text = "";
        }
    }
}
