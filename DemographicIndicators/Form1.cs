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
    public partial class Form1 : Form
    {
        clsNatalidad Nat = new clsNatalidad();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Text = Nat.getNacimientos().ToString();

            MessageBox.Show("Hello World!", "Hello",MessageBoxButtons.OK);

            string Numero = "1";

            int Num = int.Parse(Numero);

            frmNatalidad Natalidad = new frmNatalidad();
            this.Hide();
            Natalidad.ShowDialog();
            this.Show();

            button1.
        }

        private int Suma(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public void Mensaje(string msj)
        {
            MessageBox.Show(msj, "Hello", MessageBoxButtons.OK);
        }
    }
}
