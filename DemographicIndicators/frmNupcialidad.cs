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
    public partial class frmNupcialidad : Form
    {
        public frmNupcialidad()
        {
            InitializeComponent();
        }

        private void optTasaNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaNupcialidad.Checked)
            {
                lbl1.Text = "Matrimonios Totales";
                lbl2.Text = "Poblacion Total";
            }
        }

        private void optNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNupcialidad.Checked)
            {
                lbl1.Text = "Personas que Contraen Matrimonio";
                lbl2.Text = "Poblacion Residente";
            }
        }

        private void optNupcialidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNupcialidadEdad.Checked)
            {
                lbl1.Text = "Personas de edad x que contraen Matrimonio";
                lbl2.Text = "Poblacion Residente";
            }
        }

        private void optCoyunturalNupcialidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optEdadMedia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optPrimoNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrimoNupcialidad.Checked)
            {
                lbl1.Text = "Personas que contraen matrimonio por primera vez";
                lbl2.Text = "Poblacion Residente";
            }
        }

        private void optPrimoNupcialidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrimoNupcialidadEdad.Checked)
            {
                lbl1.Text = "Personas de edad x que contraen matrimonio por primera vez";
                lbl2.Text = "Poblacion Residente";
            }
        }

        private void optCoyunturalPrimoNupcialidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optPrimerMatrimonio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsNupcialidad nupcialidad = new clsNupcialidad(txt1.Value, txt2.Value);

            if (optTasaNupcialidad.Checked) txtResultado.Text = nupcialidad.TBNup.ToString();
            else if (optNupcialidad.Checked) txtResultado.Text = nupcialidad.TNup.ToString();
            else if (optNupcialidadEdad.Checked) txtResultado.Text = nupcialidad.TNup.ToString();
            else if (optPrimoNupcialidad.Checked) txtResultado.Text = nupcialidad.TPNup.ToString();
            else if (optPrimoNupcialidadEdad.Checked) txtResultado.Text = nupcialidad.TPNup.ToString();
        }
    }
}
