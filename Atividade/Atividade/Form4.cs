using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class frmReajuste : Form
    {
        public frmReajuste()
        {
            InitializeComponent();
        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text);
            double salarioAjustado = 0;

            if(salario <= 300)
            {
                salarioAjustado = salario+(salario/2);
                MessageBox.Show(Convert.ToString(salarioAjustado));
            }
            else
            {
                salarioAjustado = salario + ((salario * 30)/100);
                MessageBox.Show(Convert.ToString(salarioAjustado));
            }
        }
    }
}
