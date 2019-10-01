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
    }
}
