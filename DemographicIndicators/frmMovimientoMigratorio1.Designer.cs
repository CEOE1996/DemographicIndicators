namespace DemographicIndicators
{
    partial class frmMovimientoMigratorio1
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
            this.optTasaMigracionNetaConExtranjero = new System.Windows.Forms.RadioButton();
            this.optTasaMigracionBrutaExtrajero = new System.Windows.Forms.RadioButton();
            this.optEdadMediaEmigracionDestinoExtranjero = new System.Windows.Forms.RadioButton();
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero = new System.Windows.Forms.RadioButton();
            this.optTasasEmigracionDestinoExtranjeroEdad = new System.Windows.Forms.RadioButton();
            this.optTasaBrutaEmigracionDestinoExtranjero = new System.Windows.Forms.RadioButton();
            this.optEdadMediaInmigrantesDelExtranjero = new System.Windows.Forms.RadioButton();
            this.optTasasInmigracionDelExtranjeroPorEdad = new System.Windows.Forms.RadioButton();
            this.optTasaBrutaInmigracionDelExtranjero = new System.Windows.Forms.RadioButton();
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
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Migracion Exterior";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optTasaMigracionNetaConExtranjero);
            this.groupBox1.Controls.Add(this.optTasaMigracionBrutaExtrajero);
            this.groupBox1.Controls.Add(this.optEdadMediaEmigracionDestinoExtranjero);
            this.groupBox1.Controls.Add(this.optIndicadorCoyunturalEmigraiconDestinoExtranjero);
            this.groupBox1.Controls.Add(this.optTasasEmigracionDestinoExtranjeroEdad);
            this.groupBox1.Controls.Add(this.optTasaBrutaEmigracionDestinoExtranjero);
            this.groupBox1.Controls.Add(this.optEdadMediaInmigrantesDelExtranjero);
            this.groupBox1.Controls.Add(this.optTasasInmigracionDelExtranjeroPorEdad);
            this.groupBox1.Controls.Add(this.optTasaBrutaInmigracionDelExtranjero);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(337, 455);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optTasaMigracionNetaConExtranjero
            // 
            this.optTasaMigracionNetaConExtranjero.Location = new System.Drawing.Point(16, 395);
            this.optTasaMigracionNetaConExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaMigracionNetaConExtranjero.Name = "optTasaMigracionNetaConExtranjero";
            this.optTasaMigracionNetaConExtranjero.Size = new System.Drawing.Size(252, 42);
            this.optTasaMigracionNetaConExtranjero.TabIndex = 8;
            this.optTasaMigracionNetaConExtranjero.Text = "Tasa de migración neta con el extranjero";
            this.optTasaMigracionNetaConExtranjero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optTasaMigracionNetaConExtranjero.UseVisualStyleBackColor = true;
            this.optTasaMigracionNetaConExtranjero.CheckedChanged += new System.EventHandler(this.optTasaMigracionNetaConExtranjero_CheckedChanged);
            // 
            // optTasaMigracionBrutaExtrajero
            // 
            this.optTasaMigracionBrutaExtrajero.AutoSize = true;
            this.optTasaMigracionBrutaExtrajero.Location = new System.Drawing.Point(16, 369);
            this.optTasaMigracionBrutaExtrajero.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaMigracionBrutaExtrajero.Name = "optTasaMigracionBrutaExtrajero";
            this.optTasaMigracionBrutaExtrajero.Size = new System.Drawing.Size(279, 22);
            this.optTasaMigracionBrutaExtrajero.TabIndex = 7;
            this.optTasaMigracionBrutaExtrajero.Text = "Tasa de migración bruta con el extranjero";
            this.optTasaMigracionBrutaExtrajero.UseVisualStyleBackColor = true;
            this.optTasaMigracionBrutaExtrajero.CheckedChanged += new System.EventHandler(this.optTasaMigracionBrutaExtrajero_CheckedChanged);
            // 
            // optEdadMediaEmigracionDestinoExtranjero
            // 
            this.optEdadMediaEmigracionDestinoExtranjero.Location = new System.Drawing.Point(16, 312);
            this.optEdadMediaEmigracionDestinoExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optEdadMediaEmigracionDestinoExtranjero.Name = "optEdadMediaEmigracionDestinoExtranjero";
            this.optEdadMediaEmigracionDestinoExtranjero.Size = new System.Drawing.Size(279, 53);
            this.optEdadMediaEmigracionDestinoExtranjero.TabIndex = 6;
            this.optEdadMediaEmigracionDestinoExtranjero.Text = "Edad media a la emigración con destino al extranjero";
            this.optEdadMediaEmigracionDestinoExtranjero.UseVisualStyleBackColor = true;
            this.optEdadMediaEmigracionDestinoExtranjero.CheckedChanged += new System.EventHandler(this.optEdadMediaEmigracionDestinoExtranjero_CheckedChanged);
            // 
            // optIndicadorCoyunturalEmigraiconDestinoExtranjero
            // 
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.Location = new System.Drawing.Point(16, 266);
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.Name = "optIndicadorCoyunturalEmigraiconDestinoExtranjero";
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.Size = new System.Drawing.Size(279, 42);
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.TabIndex = 5;
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.Text = "Indicador coyuntural de emigración con destino al extranjero";
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.UseVisualStyleBackColor = true;
            this.optIndicadorCoyunturalEmigraiconDestinoExtranjero.CheckedChanged += new System.EventHandler(this.optIndicadorCoyunturalEmigraiconDestinoExtranjero_CheckedChanged);
            // 
            // optTasasEmigracionDestinoExtranjeroEdad
            // 
            this.optTasasEmigracionDestinoExtranjeroEdad.Location = new System.Drawing.Point(16, 220);
            this.optTasasEmigracionDestinoExtranjeroEdad.Margin = new System.Windows.Forms.Padding(2);
            this.optTasasEmigracionDestinoExtranjeroEdad.Name = "optTasasEmigracionDestinoExtranjeroEdad";
            this.optTasasEmigracionDestinoExtranjeroEdad.Size = new System.Drawing.Size(223, 42);
            this.optTasasEmigracionDestinoExtranjeroEdad.TabIndex = 4;
            this.optTasasEmigracionDestinoExtranjeroEdad.Text = "Tasas de emigracion con destino al extranjero por edad";
            this.optTasasEmigracionDestinoExtranjeroEdad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optTasasEmigracionDestinoExtranjeroEdad.UseVisualStyleBackColor = true;
            this.optTasasEmigracionDestinoExtranjeroEdad.CheckedChanged += new System.EventHandler(this.optTasasEmigracionDestinoExtranjeroEdad_CheckedChanged);
            // 
            // optTasaBrutaEmigracionDestinoExtranjero
            // 
            this.optTasaBrutaEmigracionDestinoExtranjero.Location = new System.Drawing.Point(16, 174);
            this.optTasaBrutaEmigracionDestinoExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaBrutaEmigracionDestinoExtranjero.Name = "optTasaBrutaEmigracionDestinoExtranjero";
            this.optTasaBrutaEmigracionDestinoExtranjero.Size = new System.Drawing.Size(241, 42);
            this.optTasaBrutaEmigracionDestinoExtranjero.TabIndex = 3;
            this.optTasaBrutaEmigracionDestinoExtranjero.Text = "Tasa bruta de emigración con destino al extranjero";
            this.optTasaBrutaEmigracionDestinoExtranjero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optTasaBrutaEmigracionDestinoExtranjero.UseVisualStyleBackColor = true;
            this.optTasaBrutaEmigracionDestinoExtranjero.CheckedChanged += new System.EventHandler(this.optTasaBrutaEmigracionDestinoExtranjero_CheckedChanged);
            // 
            // optEdadMediaInmigrantesDelExtranjero
            // 
            this.optEdadMediaInmigrantesDelExtranjero.Location = new System.Drawing.Point(16, 121);
            this.optEdadMediaInmigrantesDelExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optEdadMediaInmigrantesDelExtranjero.Name = "optEdadMediaInmigrantesDelExtranjero";
            this.optEdadMediaInmigrantesDelExtranjero.Size = new System.Drawing.Size(241, 49);
            this.optEdadMediaInmigrantesDelExtranjero.TabIndex = 2;
            this.optEdadMediaInmigrantesDelExtranjero.Text = "Edad media de los inmigrantes procedentes del extranjero";
            this.optEdadMediaInmigrantesDelExtranjero.UseVisualStyleBackColor = true;
            this.optEdadMediaInmigrantesDelExtranjero.CheckedChanged += new System.EventHandler(this.optEdadMediaInmigrantesDelExtranjero_CheckedChanged);
            // 
            // optTasasInmigracionDelExtranjeroPorEdad
            // 
            this.optTasasInmigracionDelExtranjeroPorEdad.Location = new System.Drawing.Point(16, 75);
            this.optTasasInmigracionDelExtranjeroPorEdad.Margin = new System.Windows.Forms.Padding(2);
            this.optTasasInmigracionDelExtranjeroPorEdad.Name = "optTasasInmigracionDelExtranjeroPorEdad";
            this.optTasasInmigracionDelExtranjeroPorEdad.Size = new System.Drawing.Size(250, 42);
            this.optTasasInmigracionDelExtranjeroPorEdad.TabIndex = 1;
            this.optTasasInmigracionDelExtranjeroPorEdad.Text = "Tasas de inmigración procedentes del extranjero por edad";
            this.optTasasInmigracionDelExtranjeroPorEdad.UseVisualStyleBackColor = true;
            this.optTasasInmigracionDelExtranjeroPorEdad.CheckedChanged += new System.EventHandler(this.optTasasInmigracionDelExtranjeroPorEdad_CheckedChanged);
            // 
            // optTasaBrutaInmigracionDelExtranjero
            // 
            this.optTasaBrutaInmigracionDelExtranjero.Checked = true;
            this.optTasaBrutaInmigracionDelExtranjero.Location = new System.Drawing.Point(16, 23);
            this.optTasaBrutaInmigracionDelExtranjero.Margin = new System.Windows.Forms.Padding(2);
            this.optTasaBrutaInmigracionDelExtranjero.Name = "optTasaBrutaInmigracionDelExtranjero";
            this.optTasaBrutaInmigracionDelExtranjero.Size = new System.Drawing.Size(317, 48);
            this.optTasaBrutaInmigracionDelExtranjero.TabIndex = 0;
            this.optTasaBrutaInmigracionDelExtranjero.TabStop = true;
            this.optTasaBrutaInmigracionDelExtranjero.Text = "Tasa bruta de inmigración procedente del extranjero";
            this.optTasaBrutaInmigracionDelExtranjero.UseVisualStyleBackColor = true;
            this.optTasaBrutaInmigracionDelExtranjero.CheckedChanged += new System.EventHandler(this.optTasaBrutaInmigracionDelExtranjero_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(355, 47);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(241, 44);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Nacimientos Registrados";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(355, 121);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(241, 43);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Población";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 291);
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
            this.txtResultado.Location = new System.Drawing.Point(358, 328);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(239, 24);
            this.txtResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(382, 382);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(358, 166);
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
            this.txt1.Location = new System.Drawing.Point(358, 93);
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
            // frmMovimientoMigratorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 525);
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
            this.Name = "frmMovimientoMigratorio1";
            this.Text = "Natalidad y Fecundidad";
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
        private System.Windows.Forms.RadioButton optTasaMigracionNetaConExtranjero;
        private System.Windows.Forms.RadioButton optTasaMigracionBrutaExtrajero;
        private System.Windows.Forms.RadioButton optEdadMediaEmigracionDestinoExtranjero;
        private System.Windows.Forms.RadioButton optIndicadorCoyunturalEmigraiconDestinoExtranjero;
        private System.Windows.Forms.RadioButton optTasasEmigracionDestinoExtranjeroEdad;
        private System.Windows.Forms.RadioButton optTasaBrutaEmigracionDestinoExtranjero;
        private System.Windows.Forms.RadioButton optEdadMediaInmigrantesDelExtranjero;
        private System.Windows.Forms.RadioButton optTasasInmigracionDelExtranjeroPorEdad;
        private System.Windows.Forms.RadioButton optTasaBrutaInmigracionDelExtranjero;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.NumericUpDown txt1;
    }
}