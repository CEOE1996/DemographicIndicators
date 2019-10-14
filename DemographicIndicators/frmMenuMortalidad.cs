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
    public partial class frmMenuMortalidad : Form
    {
        public frmMenuMortalidad()
        {
            InitializeComponent();
        }

        private void btnMortalidad_Click(object sender, EventArgs e)
        {
            frmMortalidad mortalidad = new frmMortalidad();
            this.Hide();
            mortalidad.ShowDialog();
            this.Show();
        }

        private void btnTasas_Click(object sender, EventArgs e)
        {
            frmTasasMortalidad tasasMortalidad = new frmTasasMortalidad();
            this.Hide();
            tasasMortalidad.ShowDialog();
            this.Show();
        }

        private void btmPorcentajes_Click(object sender, EventArgs e)
        {
            frmPorcentajesMortalidad porcentajesMortalidad = new frmPorcentajesMortalidad();
            this.Hide();
            porcentajesMortalidad.ShowDialog();
            this.Show();
        }
    }
}
