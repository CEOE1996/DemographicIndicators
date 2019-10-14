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

        private void ShowLabels(string text1, string text2)
        {
            dtgIndicador.Hide();
            lbl1.Text = text1;
            lbl2.Text = text2;
            lbl1.Show();
            lbl2.Show();
            txt1.Show();
            txt2.Show();
            txt1.Value = 1;
            txt2.Value = 1;
        }

        private void ShowTable()
        {
            dtgIndicador.Rows.Clear();
            dtgIndicador.Show();
            for(int i = 14; i <= 60; i++)
            {
                dtgIndicador.Rows.Add(i.ToString(), "1", "1");
            }

            lbl1.Hide();
            lbl2.Hide();
            txt1.Hide();
            txt2.Hide();

            txt1.Value = 1;
            txt2.Value = 1;
        }

        private void optTasaNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optTasaNupcialidad.Checked)
            {
                ShowLabels("Matrimonios Totales", "Poblacion Total");
            }
        }

        private void optNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNupcialidad.Checked)
            {
                ShowLabels("Personas que Contraen Matrimonio", "Poblacion Residente");
            }
        }

        private void optNupcialidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optNupcialidadEdad.Checked)
            {
                ShowLabels("Personas de edad x que contraen Matrimonio", "Poblacion Residente");
            }
        }

        private void optCoyunturalNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if(optCoyunturalNupcialidad.Checked) ShowTable();
        }

        private void optEdadMedia_CheckedChanged(object sender, EventArgs e)
        {
            if(optEdadMedia.Checked) ShowTable();
        }

        private void optPrimoNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrimoNupcialidad.Checked)
            {
                ShowLabels("Personas que contraen matrimonio por primera vez", "Poblacion Residente");
            }
        }

        private void optPrimoNupcialidadEdad_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrimoNupcialidadEdad.Checked)
            {
                ShowLabels("Personas de edad x que contraen matrimonio por primera vez", "Poblacion Residente");
            }
        }

        private void optCoyunturalPrimoNupcialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (optCoyunturalPrimoNupcialidad.Checked) ShowTable();
        }

        private void optPrimerMatrimonio_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrimerMatrimonio.Checked) ShowTable();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsNupcialidad nupcialidad = new clsNupcialidad(txt1.Value, txt2.Value);

            if (optTasaNupcialidad.Checked) txtResultado.Text = nupcialidad.TBNup.ToString();
            else if (optNupcialidad.Checked) txtResultado.Text = nupcialidad.TNup.ToString();
            else if (optNupcialidadEdad.Checked) txtResultado.Text = nupcialidad.TNup.ToString();
            else if (optPrimoNupcialidad.Checked) txtResultado.Text = nupcialidad.TPNup.ToString();
            else if (optPrimoNupcialidadEdad.Checked) txtResultado.Text = nupcialidad.TPNup.ToString();

            else if(optCoyunturalNupcialidad.Checked || optCoyunturalPrimoNupcialidad.Checked)
            {
                decimal Suma = 0;

                foreach(DataGridViewRow row in dtgIndicador.Rows)
                {
                    Suma += decimal.Parse(row.Cells[1].Value.ToString()) / decimal.Parse(row.Cells[2].Value.ToString());
                }

                txtResultado.Text = Suma.ToString();
            }
            else
            {
                decimal Suma = 0, Suma2 = 0;

                foreach (DataGridViewRow row in dtgIndicador.Rows)
                {
                    Suma += decimal.Parse(row.Cells[1].Value.ToString()) / decimal.Parse(row.Cells[2].Value.ToString());
                }

                foreach (DataGridViewRow row in dtgIndicador.Rows)
                {
                    Suma2 += decimal.Parse(row.Cells[0].Value.ToString()) * 0.5M * ((decimal.Parse(row.Cells[1].Value.ToString()) / decimal.Parse(row.Cells[2].Value.ToString())) / Suma);
                }

                txtResultado.Text = Suma2.ToString();
            }
        }
    }
}
