﻿namespace DemographicIndicators
{
    partial class frmPorcentajesMortalidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optPorcentajes6 = new System.Windows.Forms.RadioButton();
            this.optPorcentaje5 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes4 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes3 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes2 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPorcentajes6);
            this.groupBox1.Controls.Add(this.optPorcentaje5);
            this.groupBox1.Controls.Add(this.optPorcentajes4);
            this.groupBox1.Controls.Add(this.optPorcentajes3);
            this.groupBox1.Controls.Add(this.optPorcentajes2);
            this.groupBox1.Controls.Add(this.optPorcentajes);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 577);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optPorcentajes6
            // 
            this.optPorcentajes6.Location = new System.Drawing.Point(24, 466);
            this.optPorcentajes6.Name = "optPorcentajes6";
            this.optPorcentajes6.Size = new System.Drawing.Size(370, 93);
            this.optPorcentajes6.TabIndex = 6;
            this.optPorcentajes6.Text = "Porcentajes de Fallecidos Menores a 7 días respecto a defunciones de menores a 28" +
    " días";
            this.optPorcentajes6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes6.UseVisualStyleBackColor = true;
            this.optPorcentajes6.CheckedChanged += new System.EventHandler(this.optPorcentajes6_CheckedChanged);
            // 
            // optPorcentaje5
            // 
            this.optPorcentaje5.Location = new System.Drawing.Point(24, 363);
            this.optPorcentaje5.Name = "optPorcentaje5";
            this.optPorcentaje5.Size = new System.Drawing.Size(370, 93);
            this.optPorcentaje5.TabIndex = 5;
            this.optPorcentaje5.Text = "Porcentajes de Fallecidos Menores a 7 días respecto a defunciones de menores a 1 " +
    "año";
            this.optPorcentaje5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentaje5.UseVisualStyleBackColor = true;
            this.optPorcentaje5.CheckedChanged += new System.EventHandler(this.optPorcentaje5_CheckedChanged);
            // 
            // optPorcentajes4
            // 
            this.optPorcentajes4.Location = new System.Drawing.Point(24, 260);
            this.optPorcentajes4.Name = "optPorcentajes4";
            this.optPorcentajes4.Size = new System.Drawing.Size(370, 93);
            this.optPorcentajes4.TabIndex = 4;
            this.optPorcentajes4.Text = "Porcentajes de Fallecidos Menores a 28 días respecto a defunciones de menores a 1" +
    " año";
            this.optPorcentajes4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes4.UseVisualStyleBackColor = true;
            this.optPorcentajes4.CheckedChanged += new System.EventHandler(this.optPorcentajes4_CheckedChanged);
            // 
            // optPorcentajes3
            // 
            this.optPorcentajes3.Location = new System.Drawing.Point(24, 185);
            this.optPorcentajes3.Name = "optPorcentajes3";
            this.optPorcentajes3.Size = new System.Drawing.Size(370, 65);
            this.optPorcentajes3.TabIndex = 3;
            this.optPorcentajes3.Text = "Porcentajes de Fallecidos Menores a 7 días respecto a muertes Totales";
            this.optPorcentajes3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes3.UseVisualStyleBackColor = true;
            this.optPorcentajes3.CheckedChanged += new System.EventHandler(this.optPorcentajes3_CheckedChanged);
            // 
            // optPorcentajes2
            // 
            this.optPorcentajes2.Location = new System.Drawing.Point(24, 110);
            this.optPorcentajes2.Name = "optPorcentajes2";
            this.optPorcentajes2.Size = new System.Drawing.Size(370, 65);
            this.optPorcentajes2.TabIndex = 1;
            this.optPorcentajes2.Text = "Porcentajes de Fallecidos Menores a 28 días respecto a muertes Totales";
            this.optPorcentajes2.UseVisualStyleBackColor = true;
            this.optPorcentajes2.CheckedChanged += new System.EventHandler(this.optPorcentajes2_CheckedChanged);
            // 
            // optPorcentajes
            // 
            this.optPorcentajes.Checked = true;
            this.optPorcentajes.Location = new System.Drawing.Point(24, 35);
            this.optPorcentajes.Name = "optPorcentajes";
            this.optPorcentajes.Size = new System.Drawing.Size(370, 65);
            this.optPorcentajes.TabIndex = 0;
            this.optPorcentajes.TabStop = true;
            this.optPorcentajes.Text = "Porcentajes de Fallecidos Menores a un año respecto a muertes Totales";
            this.optPorcentajes.UseVisualStyleBackColor = true;
            this.optPorcentajes.CheckedChanged += new System.EventHandler(this.optPorcentajes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Porcentajes de Mortalidad Infantil";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(431, 143);
            this.txt1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(357, 32);
            this.txt1.TabIndex = 32;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(431, 255);
            this.txt2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(357, 32);
            this.txt2.TabIndex = 31;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(471, 558);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(290, 59);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(432, 493);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(357, 32);
            this.txtResultado.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 46);
            this.label2.TabIndex = 28;
            this.label2.Text = "Resultado:";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(426, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(362, 66);
            this.lbl2.TabIndex = 27;
            this.lbl2.Text = "Defunciones Totales";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(426, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(362, 68);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "Defunciones Registradas de menores de 1 año";
            // 
            // frmPorcentajesMortalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmPorcentajesMortalidad";
            this.Text = "frmPorcentajesMortalidad";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPorcentajes6;
        private System.Windows.Forms.RadioButton optPorcentaje5;
        private System.Windows.Forms.RadioButton optPorcentajes4;
        private System.Windows.Forms.RadioButton optPorcentajes3;
        private System.Windows.Forms.RadioButton optPorcentajes2;
        private System.Windows.Forms.RadioButton optPorcentajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt1;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}