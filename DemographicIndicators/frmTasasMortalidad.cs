using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemographicIndicators.Clases;

namespace DemographicIndicators
{
    public partial class frmTasasMortalidad : Form
    {
        public frmTasasMortalidad()
        {
            InitializeComponent();
        }

        private void optMortalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optMortalidad.Checked)
            {
                lbl1.Text = "Defunciones Registradas";
                lbl2.Text = "Total de Nacidos Vivos Registrdaos";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optNeonatal_CheckedChanged(object sender, EventArgs e)
        {
            if (optNeonatal.Checked)
            {
                lbl1.Text = "Defunciones Registradas de menores de 28 dias";
                lbl2.Text = "Total de Nacidos Vivos Registrados";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optNeonatalTemprana_CheckedChanged(object sender, EventArgs e)
        {
            if (optNeonatalTemprana.Checked)
            {
                lbl1.Text = "Defunciones Registradas de menores de 7 dias";
                lbl2.Text = "Total de Nacidos Vivos Registrdaos";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optNeonatalTardia_CheckedChanged(object sender, EventArgs e)
        {
            if (optNeonatalTardia.Checked)
            {
                lbl1.Text = "Defunciones Registradas de menores de entre 7 y 28 dias";
                lbl2.Text = "Total de Nacidos Vivos Registrados";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optPostneontal_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostneontal.Checked)
            {
                lbl1.Text = "Defunciones Registradas de menores de entre 28 dias y 1 año";
                lbl2.Text = "Total de Nacidos Vivos Registrados";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optFetal_CheckedChanged(object sender, EventArgs e)
        {
            if (optFetal.Checked)
            {
                lbl1.Text = "Muertes Fetales Tardias";
                lbl2.Text = "Total de Nacidos Vivos Registrados";

                lbl3.Visible = false;
                txt3.Visible = false;
            }
        }

        private void optPerinatal_CheckedChanged(object sender, EventArgs e)
        {
            if (optPerinatal.Checked)
            {
                lbl1.Text = "Defunciones Registradas de menores de 7 dias";
                lbl2.Text = "Total de Nacidos Vivos Registrados";

                lbl3.Visible = true;
                txt3.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txt1.Value < 0 || txt2.Value < 0)
            {
                MessageBox.Show("Error", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTasasMortalidad tasasMortalidad = new clsTasasMortalidad(txt1.Value, txt2.Value);

            if (optMortalidad.Checked) txtResultado.Text = tasasMortalidad.TMIt.ToString();
            else if (optNeonatal.Checked) txtResultado.Text = tasasMortalidad.TMINt.ToString();
            else if (optNeonatal.Checked) txtResultado.Text = tasasMortalidad.TMINt.ToString();
            else if (optNeonatalTemprana.Checked) txtResultado.Text = tasasMortalidad.TMINTemp.ToString();
            else if (optNeonatalTardia.Checked) txtResultado.Text = tasasMortalidad.TMINtardía.ToString();
            else if (optPostneontal.Checked) txtResultado.Text = tasasMortalidad.TMIPNt.ToString();
            else if (optFetal.Checked) txtResultado.Text = tasasMortalidad.TMFTt.ToString();
            else if (optPerinatal.Checked) txtResultado.Text = tasasMortalidad.Perinatal(txt3.Value).ToString();

        }
    }
}
