namespace DemographicIndicators
{
    partial class frmNupcialidad
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
            this.optPrimerMatrimonio = new System.Windows.Forms.RadioButton();
            this.optCoyunturalPrimoNupcialidad = new System.Windows.Forms.RadioButton();
            this.optPrimoNupcialidadEdad = new System.Windows.Forms.RadioButton();
            this.optPrimoNupcialidad = new System.Windows.Forms.RadioButton();
            this.optEdadMedia = new System.Windows.Forms.RadioButton();
            this.optCoyunturalNupcialidad = new System.Windows.Forms.RadioButton();
            this.optNupcialidadEdad = new System.Windows.Forms.RadioButton();
            this.optNupcialidad = new System.Windows.Forms.RadioButton();
            this.optTasaNupcialidad = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
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
            this.groupBox1.Controls.Add(this.optPrimerMatrimonio);
            this.groupBox1.Controls.Add(this.optCoyunturalPrimoNupcialidad);
            this.groupBox1.Controls.Add(this.optPrimoNupcialidadEdad);
            this.groupBox1.Controls.Add(this.optPrimoNupcialidad);
            this.groupBox1.Controls.Add(this.optEdadMedia);
            this.groupBox1.Controls.Add(this.optCoyunturalNupcialidad);
            this.groupBox1.Controls.Add(this.optNupcialidadEdad);
            this.groupBox1.Controls.Add(this.optNupcialidad);
            this.groupBox1.Controls.Add(this.optTasaNupcialidad);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 577);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optPrimerMatrimonio
            // 
            this.optPrimerMatrimonio.AutoSize = true;
            this.optPrimerMatrimonio.Location = new System.Drawing.Point(24, 521);
            this.optPrimerMatrimonio.Name = "optPrimerMatrimonio";
            this.optPrimerMatrimonio.Size = new System.Drawing.Size(347, 31);
            this.optPrimerMatrimonio.TabIndex = 9;
            this.optPrimerMatrimonio.Text = "Edad media al primer Matrimonio";
            this.optPrimerMatrimonio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPrimerMatrimonio.UseVisualStyleBackColor = true;
            this.optPrimerMatrimonio.CheckedChanged += new System.EventHandler(this.optPrimerMatrimonio_CheckedChanged);
            // 
            // optCoyunturalPrimoNupcialidad
            // 
            this.optCoyunturalPrimoNupcialidad.Location = new System.Drawing.Point(24, 437);
            this.optCoyunturalPrimoNupcialidad.Name = "optCoyunturalPrimoNupcialidad";
            this.optCoyunturalPrimoNupcialidad.Size = new System.Drawing.Size(370, 62);
            this.optCoyunturalPrimoNupcialidad.TabIndex = 8;
            this.optCoyunturalPrimoNupcialidad.Text = "Indicador Coyuntural de Primo-nupcialidad";
            this.optCoyunturalPrimoNupcialidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optCoyunturalPrimoNupcialidad.UseVisualStyleBackColor = true;
            this.optCoyunturalPrimoNupcialidad.CheckedChanged += new System.EventHandler(this.optCoyunturalPrimoNupcialidad_CheckedChanged);
            // 
            // optPrimoNupcialidadEdad
            // 
            this.optPrimoNupcialidadEdad.AutoSize = true;
            this.optPrimoNupcialidadEdad.Location = new System.Drawing.Point(24, 384);
            this.optPrimoNupcialidadEdad.Name = "optPrimoNupcialidadEdad";
            this.optPrimoNupcialidadEdad.Size = new System.Drawing.Size(375, 31);
            this.optPrimoNupcialidadEdad.TabIndex = 7;
            this.optPrimoNupcialidadEdad.Text = "Tasas de primo-nupcialidad por edad";
            this.optPrimoNupcialidadEdad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPrimoNupcialidadEdad.UseVisualStyleBackColor = true;
            this.optPrimoNupcialidadEdad.CheckedChanged += new System.EventHandler(this.optPrimoNupcialidadEdad_CheckedChanged);
            // 
            // optPrimoNupcialidad
            // 
            this.optPrimoNupcialidad.AutoSize = true;
            this.optPrimoNupcialidad.Location = new System.Drawing.Point(24, 331);
            this.optPrimoNupcialidad.Name = "optPrimoNupcialidad";
            this.optPrimoNupcialidad.Size = new System.Drawing.Size(277, 31);
            this.optPrimoNupcialidad.TabIndex = 6;
            this.optPrimoNupcialidad.Text = "Tasa de Primo-nupcialidad";
            this.optPrimoNupcialidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPrimoNupcialidad.UseVisualStyleBackColor = true;
            this.optPrimoNupcialidad.CheckedChanged += new System.EventHandler(this.optPrimoNupcialidad_CheckedChanged);
            // 
            // optEdadMedia
            // 
            this.optEdadMedia.AutoSize = true;
            this.optEdadMedia.Location = new System.Drawing.Point(24, 278);
            this.optEdadMedia.Name = "optEdadMedia";
            this.optEdadMedia.Size = new System.Drawing.Size(280, 31);
            this.optEdadMedia.TabIndex = 5;
            this.optEdadMedia.Text = "Edad media al Matrimonio";
            this.optEdadMedia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optEdadMedia.UseVisualStyleBackColor = true;
            this.optEdadMedia.CheckedChanged += new System.EventHandler(this.optEdadMedia_CheckedChanged);
            // 
            // optCoyunturalNupcialidad
            // 
            this.optCoyunturalNupcialidad.Location = new System.Drawing.Point(24, 194);
            this.optCoyunturalNupcialidad.Name = "optCoyunturalNupcialidad";
            this.optCoyunturalNupcialidad.Size = new System.Drawing.Size(370, 62);
            this.optCoyunturalNupcialidad.TabIndex = 4;
            this.optCoyunturalNupcialidad.Text = "Indicador Coyuntural de Nupcialidad";
            this.optCoyunturalNupcialidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optCoyunturalNupcialidad.UseVisualStyleBackColor = true;
            this.optCoyunturalNupcialidad.CheckedChanged += new System.EventHandler(this.optCoyunturalNupcialidad_CheckedChanged);
            // 
            // optNupcialidadEdad
            // 
            this.optNupcialidadEdad.AutoSize = true;
            this.optNupcialidadEdad.Location = new System.Drawing.Point(24, 141);
            this.optNupcialidadEdad.Name = "optNupcialidadEdad";
            this.optNupcialidadEdad.Size = new System.Drawing.Size(315, 31);
            this.optNupcialidadEdad.TabIndex = 3;
            this.optNupcialidadEdad.Text = "Tasas de Nupcialidad por edad";
            this.optNupcialidadEdad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optNupcialidadEdad.UseVisualStyleBackColor = true;
            this.optNupcialidadEdad.CheckedChanged += new System.EventHandler(this.optNupcialidadEdad_CheckedChanged);
            // 
            // optNupcialidad
            // 
            this.optNupcialidad.AutoSize = true;
            this.optNupcialidad.Location = new System.Drawing.Point(24, 88);
            this.optNupcialidad.Name = "optNupcialidad";
            this.optNupcialidad.Size = new System.Drawing.Size(218, 31);
            this.optNupcialidad.TabIndex = 1;
            this.optNupcialidad.Text = "Tasa de Nupcialidad";
            this.optNupcialidad.UseVisualStyleBackColor = true;
            this.optNupcialidad.CheckedChanged += new System.EventHandler(this.optNupcialidad_CheckedChanged);
            // 
            // optTasaNupcialidad
            // 
            this.optTasaNupcialidad.AutoSize = true;
            this.optTasaNupcialidad.Checked = true;
            this.optTasaNupcialidad.Location = new System.Drawing.Point(24, 35);
            this.optTasaNupcialidad.Name = "optTasaNupcialidad";
            this.optTasaNupcialidad.Size = new System.Drawing.Size(273, 31);
            this.optTasaNupcialidad.TabIndex = 0;
            this.optTasaNupcialidad.TabStop = true;
            this.optTasaNupcialidad.Text = "Tasa Bruta de Nupcialidad";
            this.optTasaNupcialidad.UseVisualStyleBackColor = true;
            this.optTasaNupcialidad.CheckedChanged += new System.EventHandler(this.optTasaNupcialidad_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(471, 558);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(290, 59);
            this.btnCalcular.TabIndex = 39;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Indicadores de Nupcialidad";
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
            this.txt1.TabIndex = 41;
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
            this.txt2.TabIndex = 40;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(432, 493);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(357, 32);
            this.txtResultado.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 46);
            this.label2.TabIndex = 37;
            this.label2.Text = "Resultado:";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(426, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(362, 66);
            this.lbl2.TabIndex = 36;
            this.lbl2.Text = "Población Total";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(426, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(362, 68);
            this.lbl1.TabIndex = 35;
            this.lbl1.Text = "Matrimonios totales";
            // 
            // frmNupcialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmNupcialidad";
            this.Text = "frmNupcialidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPrimoNupcialidad;
        private System.Windows.Forms.RadioButton optEdadMedia;
        private System.Windows.Forms.RadioButton optCoyunturalNupcialidad;
        private System.Windows.Forms.RadioButton optNupcialidadEdad;
        private System.Windows.Forms.RadioButton optNupcialidad;
        private System.Windows.Forms.RadioButton optTasaNupcialidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt1;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton optPrimerMatrimonio;
        private System.Windows.Forms.RadioButton optCoyunturalPrimoNupcialidad;
        private System.Windows.Forms.RadioButton optPrimoNupcialidadEdad;
    }
}