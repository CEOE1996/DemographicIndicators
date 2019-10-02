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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNatalidad_Click(object sender, EventArgs e)
        {
            frmNatalidad natalidad = new frmNatalidad();
            this.Hide();
            natalidad.ShowDialog();
            this.Show();
        }

        private void BtnDivorcialidad_Click(object sender, EventArgs e)
        {
            frmDivorcialidad divorcialidad = new frmDivorcialidad();
            this.Hide();
            divorcialidad.ShowDialog();
            this.Show();
        }

        private void BtnMigratorio_Click(object sender, EventArgs e)
        {
            frmSubMenuMigratorio subMenuMigratorio = new frmSubMenuMigratorio();
            this.Hide();
            subMenuMigratorio.ShowDialog();
            this.Show();
        }

        private void BtnPoblacion_Click(object sender, EventArgs e)
        {
            frmCrecimientoEstructuraPoblacion crecimientoEstructuraPoblacion = new frmCrecimientoEstructuraPoblacion();
            this.Hide();
            crecimientoEstructuraPoblacion.ShowDialog();
            this.Show();
        }
    }
}
