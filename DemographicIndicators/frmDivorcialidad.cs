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
    public partial class frmDivorcialidad : Form
    {

        public frmDivorcialidad()
        {
            InitializeComponent();
        }

        clsDivorcialidad instDivorcialdiad = new clsDivorcialidad();

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            if (optTasaBrutaDivorcios.Checked)
            {
                txtResultado.Text = instDivorcialdiad.TasaBrutaDivorcios(txt1.Value, txt2.Value).ToString();
            }
        }

        private void OptDivorciosSegunDuracionMatrimonio_CheckedChanged(object sender, EventArgs e)
        {
            if(optDivorciosSegunDuracionMatrimonio.Checked) {
                lbl1.Text = "Divorcios de matrimonios de una duración de X años";
                lbl2.Text = "Divorcios registrados durante el año";
            }
        }

        private void OptTasaBrutaDivorcios_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaBrutaDivorcios.Checked) {
                lbl1.Text = "Divorcios durante el año";
                lbl2.Text = "Población residente media en el ámbito de estudio";
            }


        }

        private void optTasaDivorcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaDivorcialidad.Checked){
                lbl1.Text = "Cónyuges que se divorcian durante el año";
                lbl2.Text = "Población residente media en el ámbito de estudio";
            }
        }

        private void optTasaDivorcialidadPorEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaDivorcialidadPorEdad.Checked)
            {
                lbl1.Text = "Cónyuges de edad X que se divorcian durante el año";
                lbl2.Text = "Población residente media en el ámbito de estudio de X años de edad, en el año";
            }
        }

        private void optIndicadorCoyunturalDivorcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optIndicadorCoyunturalDivorcialidad.Checked)
            {
                lbl1.Text = "Cónyuges de edad X que se divorcian durante el año";
                lbl2.Text = "Población residente media en el ámbito de estudio de X años de edad, en el año";
            }
        }

        private void optEdadMediaDivorcio_CheckedChanged(object sender, EventArgs e)
        {
            if (optEdadMediaDivorcio.Checked)
            {
                lbl1.Text = "Pendiente";
                lbl2.Text = "pendiente";
            }
        }
    }
}
