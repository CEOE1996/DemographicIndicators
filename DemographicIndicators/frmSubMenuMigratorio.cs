using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemographicIndicators
{
    public partial class frmSubMenuMigratorio : Form
    {
        public frmSubMenuMigratorio()
        {
            InitializeComponent();
        }

        private void BtnNatalidad_Click(object sender, EventArgs e)
        {
            frmMovimientoMigratorio1 movimientoMigratorio1 = new frmMovimientoMigratorio1();
            this.Hide();
            movimientoMigratorio1.ShowDialog();
            this.Show();
        }

        private void BtnMortalidad_Click(object sender, EventArgs e)
        {
            frmMovimientoMigratorio2 movimientoMigratorio2 = new frmMovimientoMigratorio2();
            this.Hide();
            movimientoMigratorio2.ShowDialog();
            this.Show();
        }
    }
}
