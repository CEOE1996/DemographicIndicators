namespace DemographicIndicators
{
    partial class frmMortalidad
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
            this.optRatioMasculinidad = new System.Windows.Forms.RadioButton();
            this.optMortalidadEdad = new System.Windows.Forms.RadioButton();
            this.optMortalidadSexo = new System.Windows.Forms.RadioButton();
            this.optMortalidad = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indicadores de Mortalidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optRatioMasculinidad);
            this.groupBox1.Controls.Add(this.optMortalidadEdad);
            this.groupBox1.Controls.Add(this.optMortalidadSexo);
            this.groupBox1.Controls.Add(this.optMortalidad);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optRatioMasculinidad
            // 
            this.optRatioMasculinidad.Location = new System.Drawing.Point(24, 197);
            this.optRatioMasculinidad.Name = "optRatioMasculinidad";
            this.optRatioMasculinidad.Size = new System.Drawing.Size(362, 65);
            this.optRatioMasculinidad.TabIndex = 3;
            this.optRatioMasculinidad.Text = "Ratio de Masculinidad a la Definción";
            this.optRatioMasculinidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optRatioMasculinidad.UseVisualStyleBackColor = true;
            this.optRatioMasculinidad.CheckedChanged += new System.EventHandler(this.optRatioMasculinidad_CheckedChanged);
            // 
            // optMortalidadEdad
            // 
            this.optMortalidadEdad.AutoSize = true;
            this.optMortalidadEdad.Location = new System.Drawing.Point(24, 143);
            this.optMortalidadEdad.Name = "optMortalidadEdad";
            this.optMortalidadEdad.Size = new System.Drawing.Size(300, 31);
            this.optMortalidadEdad.TabIndex = 2;
            this.optMortalidadEdad.Text = "Tasa de Mortalidad por Edad";
            this.optMortalidadEdad.UseVisualStyleBackColor = true;
            this.optMortalidadEdad.CheckedChanged += new System.EventHandler(this.optMortalidadEdad_CheckedChanged);
            // 
            // optMortalidadSexo
            // 
            this.optMortalidadSexo.AutoSize = true;
            this.optMortalidadSexo.Location = new System.Drawing.Point(24, 89);
            this.optMortalidadSexo.Name = "optMortalidadSexo";
            this.optMortalidadSexo.Size = new System.Drawing.Size(296, 31);
            this.optMortalidadSexo.TabIndex = 1;
            this.optMortalidadSexo.Text = "Tasa de Mortalidad por Sexo";
            this.optMortalidadSexo.UseVisualStyleBackColor = true;
            this.optMortalidadSexo.CheckedChanged += new System.EventHandler(this.optMortalidadSexo_CheckedChanged);
            // 
            // optMortalidad
            // 
            this.optMortalidad.AutoSize = true;
            this.optMortalidad.Checked = true;
            this.optMortalidad.Location = new System.Drawing.Point(24, 35);
            this.optMortalidad.Name = "optMortalidad";
            this.optMortalidad.Size = new System.Drawing.Size(267, 31);
            this.optMortalidad.TabIndex = 0;
            this.optMortalidad.TabStop = true;
            this.optMortalidad.Text = "Tasa Bruta de Mortalidad";
            this.optMortalidad.UseVisualStyleBackColor = true;
            this.optMortalidad.CheckedChanged += new System.EventHandler(this.optMortalidad_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(426, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(362, 68);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Defunciones Registradas";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(426, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(362, 66);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Población";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(431, 360);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(357, 32);
            this.txtResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(466, 410);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(290, 59);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
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
            this.txt2.TabIndex = 11;
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
            this.txt1.TabIndex = 12;
            // 
            // frmMortalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMortalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicadores de Masculinidad";
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
        private System.Windows.Forms.RadioButton optRatioMasculinidad;
        private System.Windows.Forms.RadioButton optMortalidadEdad;
        private System.Windows.Forms.RadioButton optMortalidadSexo;
        private System.Windows.Forms.RadioButton optMortalidad;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.NumericUpDown txt1;
    }
}