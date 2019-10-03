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
    public partial class frmMortalidad : Form
    {
        public frmMortalidad()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txt1.Value < 0 || txt2.Value < 0)
            {
                MessageBox.Show("Error", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsMortalidad mortalidad = new clsMortalidad(txt1.Value, txt2.Value);

            if (optMortalidad.Checked) txtResultado.Text = mortalidad.TBMt.ToString();
            else if (optMortalidadSexo.Checked) txtResultado.Text = mortalidad.TMt.ToString();
            else if (optMortalidadEdad.Checked) txtResultado.Text = mortalidad.mt.ToString();
            else if (optRatioMasculinidad.Checked) txtResultado.Text = mortalidad.RatioMasculinidad(txt1.Value, txt2.Value).ToString();
        }

        private void optMortalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optMortalidad.Checked)
            {
                lbl1.Text = "Defunciones Registradas";
                lbl2.Text = "Población";
            }
        }

        private void optMortalidadSexo_CheckedChanged(object sender, EventArgs e)
        {
            if (optMortalidadSexo.Checked)
            {
                lbl1.Text = "Defunciones Registradas del Sexo s";
                lbl2.Text = "Población del Sexo s";
            }
        }

        private void optMortalidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optMortalidadEdad.Checked)
            {
                lbl1.Text = "Defunciones Teoricas de Edad x";
                lbl2.Text = "Población de Edad x";
            }
        }

        private void optRatioMasculinidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optRatioMasculinidad.Checked)
            {
                lbl1.Text = "Defunciones de Hombres";
                lbl2.Text = "Defunciones de Mujeres";
            }
        }
    }
}
