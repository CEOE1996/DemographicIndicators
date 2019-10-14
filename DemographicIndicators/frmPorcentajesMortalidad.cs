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
    public partial class frmPorcentajesMortalidad : Form
    {
        public frmPorcentajesMortalidad()
        {
            InitializeComponent();
        }

        private void optPorcentajes_CheckedChanged(object sender, EventArgs e)
        {
            if(optPorcentajes.Checked)
            {
                lbl1.Text = "Defunciones de menores de 1 año";
                lbl2.Text = "Defunciones Totales";
            }
        }

        private void optPorcentajes2_CheckedChanged(object sender, EventArgs e)
        {
            if (optPorcentajes2.Checked)
            {
                lbl1.Text = "Defunciones de menores de 2 días";
                lbl2.Text = "Defunciones Totales";
            }
        }

        private void optPorcentajes3_CheckedChanged(object sender, EventArgs e)
        {
            if (optPorcentajes3.Checked)
            {
                lbl1.Text = "Defunciones de menores de 7 días";
                lbl2.Text = "Defunciones Totales";
            }
        }

        private void optPorcentajes4_CheckedChanged(object sender, EventArgs e)
        {
            if (optPorcentajes4.Checked)
            {
                lbl1.Text = "Defunciones de menores de 28 días";
                lbl2.Text = "Defunciones de menores de 1 año";
            }
        }

        private void optPorcentaje5_CheckedChanged(object sender, EventArgs e)
        {
            if (optPorcentaje5.Checked)
            {
                lbl1.Text = "Defunciones de menores de 7 días";
                lbl2.Text = "Defunciones de menores de 1 año";
            }
        }

        private void optPorcentajes6_CheckedChanged(object sender, EventArgs e)
        {
            if (optPorcentajes6.Checked)
            {
                lbl1.Text = "Defunciones de menores de 7 días";
                lbl2.Text = "Defunciones de menores de 28 días";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsPorcentajesMortalidad porcentajes = new clsPorcentajesMortalidad(txt1.Value, txt2.Value);

            txtResultado.Text = porcentajes.PDt.ToString();
        }
    }
}
