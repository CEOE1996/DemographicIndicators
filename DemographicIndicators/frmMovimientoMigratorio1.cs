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
    public partial class frmMovimientoMigratorio1 : Form
    {

        public frmMovimientoMigratorio1()
        {
            InitializeComponent();
        }

        clsMigracion instMigracion = new clsMigracion();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (optTasaBrutaEmigracionDestinoExtranjero.Checked)
            {
                txtResultado.Text = instMigracion.CalculoTasaBruta(txt1.Value, txt2.Value).ToString();
            }
        }

        private void optTasaBrutaInmigracionDelExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaBrutaInmigracionDelExtranjero.Checked)
            {
                lbl1.Text = "Inmigraciones procedentes del extranjero, registradas durante el año";
                lbl2.Text = "Población residente media en el ámbito de estudio, en el año";
            }
        }

        private void optTasasInmigracionDelExtranjeroPorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasInmigracionDelExtranjeroPorEdad.Checked)
            {
                lbl1.Text = "Inmigraciones procedentes del extranjero, individuos de edad X";
                lbl2.Text = "Población residente media de edad X";
            }
        }

        private void optEdadMediaInmigrantesDelExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasInmigracionDelExtranjeroPorEdad.Checked)
            {
                lbl1.Text = "Edad. Toma valores comprendidos entre 0 y 90 años de edad";
                lbl2.Text = "Inmigraciones procedentes del extranjero, registradas durante el año";
            }
        }

        private void optTasaBrutaEmigracionDestinoExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaBrutaEmigracionDestinoExtranjero.Checked)
            {
                lbl1.Text = "Emigraciones con destino al extranjero, registradas durante el año";
                lbl2.Text = "Población residente media";
            }
        }

        private void optTasasEmigracionDestinoExtranjeroEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasEmigracionDestinoExtranjeroEdad.Checked)
            {
                lbl1.Text = "Emigraciones con destino al extranjero, registradas durante el año";
                lbl2.Text = "Población residente media de edad X";
            }
        }

        private void optIndicadorCoyunturalEmigraiconDestinoExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndicadorCoyunturalEmigraiconDestinoExtranjero.Checked)
            {
                lbl1.Text = "Emigraciones con destino al extranjero, registradas durante el año";
                lbl2.Text = "Población residente media de edad X";

                //pendiente label para indicar la edad para la sumatoria
            }
        }

        private void optEdadMediaEmigracionDestinoExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optEdadMediaEmigracionDestinoExtranjero.Checked)
            {
                lbl1.Text = "Emigraciones con destino al extranjero, registradas durante el año";
                lbl2.Text = "Población residente media de edad X";

                //pendiente label para indicar la edad para la ICE
            }
        }

        private void optTasaMigracionBrutaExtrajero_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaMigracionBrutaExtrajero.Checked)
            {
                lbl1.Text = "Inmigraciones procedentes del extranjero, registradas durante el año";
                lbl2.Text = "Emigraciones con destino al extranjero, registradas durante el año";

                //pendiente label para indicar la edad para la poblacion
            }
        }

        private void optTasaMigracionNetaConExtranjero_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaMigracionNetaConExtranjero.Checked)
            {
                lbl1.Text = "Inmigraciones procedentes del extranjero, registradas durante el año";
                lbl2.Text = "Emigraciones con destino al extranjero, registradas durante el año";

                //pendiente label para indicar la edad para la poblacion
            }
        }
    }
}
