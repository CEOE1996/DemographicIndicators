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
    public partial class frmNatalidad : Form
    {

        public frmNatalidad()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsNatalidad natalidad = new clsNatalidad(txt1.Value, txt2.Value, txt2.Value);

            if (optNatalidad.Checked) txtResultado.Text = natalidad.TBNt.ToString();
            else if (optRatioMasculinidad.Checked) txtResultado.Text = natalidad.RatioMasculinidad(txt1.Value, txt2.Value).ToString();
            else if (optFecundidad.Checked) txtResultado.Text = natalidad.TGFt.ToString();
            else if (optFecundidadQuin.Checked) txtResultado.Text = natalidad.TEFt.ToString();
            else if (optFecundidadEdad.Checked) txtResultado.Text = natalidad.TEFt.ToString();
            else if (optNacidosOrden.Checked) txtResultado.Text = natalidad.NacidosOrden(txt2.Value).ToString();
            else if (optNacidosNacionallidad.Checked) txtResultado.Text = natalidad.NacidosNacionalidad(txt2.Value).ToString();
            else if (optProporcionCasada.Checked) txtResultado.Text = natalidad.NoCasadas(txt2.Value).ToString();
        }

        private void optNatalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNatalidad.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Población";
            }
        }

        private void optRatioMasculinidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optRatioMasculinidad.Checked)
            {
                lbl1.Text = "Nacimientos de Hombres";
                lbl2.Text = "Nacimientos de Mujeres";
            }
        }

        private void optFecundidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optRatioMasculinidad.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Población de Mujeres";
            }
        }

        private void optFecundidadQuin_CheckedChanged(object sender, EventArgs e)
        {
            if (optFecundidadQuin.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Población media de Mujeres";
            }
        }

        private void optFecundidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optFecundidadEdad.Checked)
            {
                lbl1.Text = "Nacimientos Registrados de Madres de edad X";
                lbl2.Text = "Población media de Mujeres de edad X";
            }
        }

        private void optNacidosOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optNacidosOrden.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Nacimientos de orden r Registrados";
            }
        }

        private void optNacidosNacionallidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNacidosNacionallidad.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Nacimientos de Nacionalidad n Registrados";
            }
        }

        private void optProporcionCasada_CheckedChanged(object sender, EventArgs e)
        {
            if (optProporcionCasada.Checked)
            {
                lbl1.Text = "Nacimientos Registrados";
                lbl2.Text = "Nacimientos Registrados de Madres no casadas";
            }
        }
    }
}
