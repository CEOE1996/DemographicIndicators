namespace DemographicIndicators
{
    partial class frmDivorcialidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optEdadMediaDivorcio = new System.Windows.Forms.RadioButton();
            this.optIndicadorCoyunturalDivorcialidad = new System.Windows.Forms.RadioButton();
            this.optTasaDivorcialidadPorEdad = new System.Windows.Forms.RadioButton();
            this.optTasaDivorcialidad = new System.Windows.Forms.RadioButton();
            this.optDivorciosSegunDuracionMatrimonio = new System.Windows.Forms.RadioButton();
            this.optTasaBrutaDivorcios = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divorciabilidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optEdadMediaDivorcio);
            this.groupBox1.Controls.Add(this.optIndicadorCoyunturalDivorcialidad);
            this.groupBox1.Controls.Add(this.optTasaDivorcialidadPorEdad);
            this.groupBox1.Controls.Add(this.optTasaDivorcialidad);
            this.groupBox1.Controls.Add(this.optDivorciosSegunDuracionMatrimonio);
            this.groupBox1.Controls.Add(this.optTasaBrutaDivorcios);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(275, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optEdadMediaDivorcio
            // 
            this.optEdadMediaDivorcio.AutoSize = true;
            this.optEdadMediaDivorcio.Location = new System.Drawing.Point(16, 254);
            this.optEdadMediaDivorcio.Margin = new System.Windows.Forms.Padding(2);
            this.optEdadMediaDivorcio.Name = "optEdadMediaDivorcio";
            this.optEdadMediaDivorcio.Size = new System.Drawing.Size(165, 22);
            this.optEdadMediaDivorcio.TabIndex = 5;
            this.optEdadMediaDivorcio.Text = "Edad media al divorcio";
            this.optEdadMediaDivorcio.UseVisualStyleBackColor = true;
            this.optEdadMediaDivorcio.CheckedChanged += new System.EventHandler(this.optEdadMediaDivorcio_CheckedChanged);
            // 
            // optIndicadorCoyunturalDivorcialidad
            // 
            this.optIndicadorCoyunturalDivorcialidad.Location = new System.Drawing.Point(16, 204);
            this.optIndicadorCoyunturalDivorcialidad.Margin = new System.Windows.Forms.Padding(2);
            this.optIndicadorCoyunturalDivorcialidad.Name = "optIndicadorCoyunturalDivorcialidad";
            this.optIndicadorCoyunturalDivorcialidad.Size = new System.Drawing.Size(223, 42);
            this.optIndicadorCoyunturalDivorcialidad.TabIndex = 4;
            this.optIndicadorCoyunturalDivorcialidad.Text = "Indicador coyuntural de divorcialidad";
            this.optIndicadorCoyunturalDivorcialidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optIndicadorCoyunturalDivorcialidad.UseVisualStyleBackColor = true;
            this.optIndicadorCoyunturalDivorcialidad.CheckedChanged += new System.EventHandler(this.optIndicadorCoyunturalDivorcialidad_CheckedChanged);
            // 
            // optTasaDivorcialidadPorEdad
            // 
            this.optTasaDivorcialidadPorEdad.Location = new System.Drawing.Point(16, 154);
            this.optTasaDivorcialidadPorEdad.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaDivorcialidadPorEdad.Name = "optTasaDivorcialidadPorEdad";
            this.optTasaDivorcialidadPorEdad.Size = new System.Drawing.Size(241, 42);
            this.optTasaDivorcialidadPorEdad.TabIndex = 3;
            this.optTasaDivorcialidadPorEdad.Text = "Tasas de divorcialidad por edad";
            this.optTasaDivorcialidadPorEdad.UseVisualStyleBackColor = true;
            this.optTasaDivorcialidadPorEdad.CheckedChanged += new System.EventHandler(this.optTasaDivorcialidadPorEdad_CheckedChanged);
            // 
            // optTasaDivorcialidad
            // 
            this.optTasaDivorcialidad.AutoSize = true;
            this.optTasaDivorcialidad.Location = new System.Drawing.Point(16, 126);
            this.optTasaDivorcialidad.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaDivorcialidad.Name = "optTasaDivorcialidad";
            this.optTasaDivorcialidad.Size = new System.Drawing.Size(154, 22);
            this.optTasaDivorcialidad.TabIndex = 2;
            this.optTasaDivorcialidad.Text = "Tasa de divorcialidad";
            this.optTasaDivorcialidad.UseVisualStyleBackColor = true;
            this.optTasaDivorcialidad.CheckedChanged += new System.EventHandler(this.optTasaDivorcialidad_CheckedChanged);
            // 
            // optDivorciosSegunDuracionMatrimonio
            // 
            this.optDivorciosSegunDuracionMatrimonio.Location = new System.Drawing.Point(12, 51);
            this.optDivorciosSegunDuracionMatrimonio.Margin = new System.Windows.Forms.Padding(2);
            this.optDivorciosSegunDuracionMatrimonio.Name = "optDivorciosSegunDuracionMatrimonio";
            this.optDivorciosSegunDuracionMatrimonio.Size = new System.Drawing.Size(256, 71);
            this.optDivorciosSegunDuracionMatrimonio.TabIndex = 1;
            this.optDivorciosSegunDuracionMatrimonio.Text = "Proporción de divorcios según la duración del matrimonio";
            this.optDivorciosSegunDuracionMatrimonio.UseVisualStyleBackColor = true;
            this.optDivorciosSegunDuracionMatrimonio.CheckedChanged += new System.EventHandler(this.OptDivorciosSegunDuracionMatrimonio_CheckedChanged);
            // 
            // optTasaBrutaDivorcios
            // 
            this.optTasaBrutaDivorcios.AutoSize = true;
            this.optTasaBrutaDivorcios.Checked = true;
            this.optTasaBrutaDivorcios.Location = new System.Drawing.Point(12, 23);
            this.optTasaBrutaDivorcios.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaBrutaDivorcios.Name = "optTasaBrutaDivorcios";
            this.optTasaBrutaDivorcios.Size = new System.Drawing.Size(167, 22);
            this.optTasaBrutaDivorcios.TabIndex = 0;
            this.optTasaBrutaDivorcios.TabStop = true;
            this.optTasaBrutaDivorcios.Text = "Tasa Bruta de Divorcios";
            this.optTasaBrutaDivorcios.UseVisualStyleBackColor = true;
            this.optTasaBrutaDivorcios.CheckedChanged += new System.EventHandler(this.OptTasaBrutaDivorcios_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(301, 40);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(241, 44);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Nacimientos Registrados";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(301, 114);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(241, 43);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Población";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(304, 321);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(239, 24);
            this.txtResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(328, 375);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(304, 159);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(238, 24);
            this.txt2.TabIndex = 11;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(304, 86);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(238, 24);
            this.txt1.TabIndex = 12;
            // 
            // frmDivorcialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 440);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDivorcialidad";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optEdadMediaDivorcio;
        private System.Windows.Forms.RadioButton optIndicadorCoyunturalDivorcialidad;
        private System.Windows.Forms.RadioButton optTasaDivorcialidadPorEdad;
        private System.Windows.Forms.RadioButton optTasaDivorcialidad;
        private System.Windows.Forms.RadioButton optDivorciosSegunDuracionMatrimonio;
        private System.Windows.Forms.RadioButton optTasaBrutaDivorcios;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.NumericUpDown txt1;
    }
}