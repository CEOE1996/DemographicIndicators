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
    public partial class frmMovimientoMigratorio2 : Form
    {

        public frmMovimientoMigratorio2()
        {
            InitializeComponent();
        }

        clsMigracion instMigracion = new clsMigracion();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (optTasasMigracionInterautonomicaInterprovincialPorEdad.Checked)
            {
                txtResultado.Text = instMigracion.CalculoTasaBruta(txt1.Value, txt2.Value).ToString();
            }
        }

        private void optTasasMigracionInterautonomicaInterprovincialPorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasMigracionInterautonomicaInterprovincialPorEdad.Checked)
            {
                lbl1.Text = "Migraciones interiores de individuos del ámbito i que cambian de región de residencia";
                lbl2.Text = "Población media de individuos de edad x";
            }
        }

        private void optIndicadorCoyunturalMigracionInterautonomicaInterprovincial_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndicadorCoyunturalMigracionInterautonomicaInterprovincial.Checked)
            {
                lbl1.Text = "Migraciones interiores de individuos del ámbito i que cambian de región de residencia";
                lbl2.Text = "Población media de individuos de edad x";

                //pendiente para la edad
            }
        }

        private void optTasaBrutaInmigracionInterautonomicaInterprovincial_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaBrutaInmigracionInterautonomicaInterprovincial.Checked)
            {
                lbl1.Text = "Inmigraciones interiores de individuos";
                lbl2.Text = "Población residente media";
            }
        }

        private void optTasasInmigracionInterautonomicaInterprovincialPorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasInmigracionInterautonomicaInterprovincialPorEdad.Checked)
            {
                lbl1.Text = "Inmigraciones interiores de individuos de edad X";
                lbl2.Text = "Población residente media de edad X";
            }
        }

        private void optTasaBrutaEmigracionInterautonomicaInterprovincial_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaBrutaEmigracionInterautonomicaInterprovincial.Checked)
            {
                lbl1.Text = "Emigraciones interiores de individuos";
                lbl2.Text = "Población residente media";
            }
        }

        private void optTasasEmigracionInterautonomicaInterprovincialPorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasasEmigracionInterautonomicaInterprovincialPorEdad.Checked)
            {
                lbl1.Text = "Emigraciones interiores de individuos de edad X";
                lbl2.Text = "Población residente media de X edad";
            }
        }

        private void optIndicadorCoyunturalEmigracionInterautonomicaInterprovincial_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndicadorCoyunturalEmigracionInterautonomicaInterprovincial.Checked)
            {
                lbl1.Text = "pendiente";
                lbl2.Text = "pendiente";
            }
        }

        private void optTasaMigracionInterautonomicaInterprovincialBruta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaMigracionInterautonomicaInterprovincialBruta.Checked)
            {
                lbl1.Text = "pendiente2";
                lbl2.Text = "pendiente2";
            }
        }

        private void optTasaMigracionInterautonomicaInterprovincialNeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaMigracionInterautonomicaInterprovincialNeta.Checked)
            {
                lbl1.Text = "pendiente3";
                lbl2.Text = "pendiente3";
            }
        }

        
    }
}
