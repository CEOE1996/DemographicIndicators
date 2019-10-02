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

        private void optMortalidad_Click(object sender, EventArgs e)
        {
            frmMortalidad mortalidad = new frmMortalidad();
            this.Hide();
            mortalidad.ShowDialog();
            this.Show();
        }

        private void optTasas_Click(object sender, EventArgs e)
        {

        }
    }
}
