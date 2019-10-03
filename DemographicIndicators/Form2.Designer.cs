namespace DemographicIndicators
{
    partial class frmTasasMortalidad
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
            this.optNeonatalTemprana = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optPerinatal = new System.Windows.Forms.RadioButton();
            this.optFetal = new System.Windows.Forms.RadioButton();
            this.optPostneontal = new System.Windows.Forms.RadioButton();
            this.optNeonatalTardia = new System.Windows.Forms.RadioButton();
            this.optNeonatal = new System.Windows.Forms.RadioButton();
            this.optMortalidad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.NumericUpDown();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt3)).BeginInit();
            this.SuspendLayout();
            // 
            // optNeonatalTemprana
            // 
            this.optNeonatalTemprana.Location = new System.Drawing.Point(24, 125);
            this.optNeonatalTemprana.Name = "optNeonatalTemprana";
            this.optNeonatalTemprana.Size = new System.Drawing.Size(362, 65);
            this.optNeonatalTemprana.TabIndex = 3;
            this.optNeonatalTemprana.Text = "Tasa de Mortalidad Infantil Neonatal Temprana";
            this.optNeonatalTemprana.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optNeonatalTemprana.UseVisualStyleBackColor = true;
            this.optNeonatalTemprana.CheckedChanged += new System.EventHandler(this.optNeonatalTemprana_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPerinatal);
            this.groupBox1.Controls.Add(this.optFetal);
            this.groupBox1.Controls.Add(this.optPostneontal);
            this.groupBox1.Controls.Add(this.optNeonatalTardia);
            this.groupBox1.Controls.Add(this.optNeonatalTemprana);
            this.groupBox1.Controls.Add(this.optNeonatal);
            this.groupBox1.Controls.Add(this.optMortalidad);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 530);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optPerinatal
            // 
            this.optPerinatal.AutoSize = true;
            this.optPerinatal.Location = new System.Drawing.Point(24, 407);
            this.optPerinatal.Name = "optPerinatal";
            this.optPerinatal.Size = new System.Drawing.Size(298, 31);
            this.optPerinatal.TabIndex = 7;
            this.optPerinatal.Text = "Tasa de Mortalidad Perinatal";
            this.optPerinatal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPerinatal.UseVisualStyleBackColor = true;
            this.optPerinatal.CheckedChanged += new System.EventHandler(this.optPerinatal_CheckedChanged);
            // 
            // optFetal
            // 
            this.optFetal.AutoSize = true;
            this.optFetal.Location = new System.Drawing.Point(24, 362);
            this.optFetal.Name = "optFetal";
            this.optFetal.Size = new System.Drawing.Size(322, 31);
            this.optFetal.TabIndex = 6;
            this.optFetal.Text = "Tasa de Mortalidad Fetal Tardia";
            this.optFetal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optFetal.UseVisualStyleBackColor = true;
            this.optFetal.CheckedChanged += new System.EventHandler(this.optFetal_CheckedChanged);
            // 
            // optPostneontal
            // 
            this.optPostneontal.Location = new System.Drawing.Point(24, 283);
            this.optPostneontal.Name = "optPostneontal";
            this.optPostneontal.Size = new System.Drawing.Size(362, 65);
            this.optPostneontal.TabIndex = 5;
            this.optPostneontal.Text = "Tasa de Mortalidad Infantil Postneonatal";
            this.optPostneontal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPostneontal.UseVisualStyleBackColor = true;
            this.optPostneontal.CheckedChanged += new System.EventHandler(this.optPostneontal_CheckedChanged);
            // 
            // optNeonatalTardia
            // 
            this.optNeonatalTardia.Location = new System.Drawing.Point(24, 204);
            this.optNeonatalTardia.Name = "optNeonatalTardia";
            this.optNeonatalTardia.Size = new System.Drawing.Size(362, 65);
            this.optNeonatalTardia.TabIndex = 4;
            this.optNeonatalTardia.Text = "Tasa de Mortalidad Infantil Neonatal Tardia";
            this.optNeonatalTardia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optNeonatalTardia.UseVisualStyleBackColor = true;
            this.optNeonatalTardia.CheckedChanged += new System.EventHandler(this.optNeonatalTardia_CheckedChanged);
            // 
            // optNeonatal
            // 
            this.optNeonatal.AutoSize = true;
            this.optNeonatal.Location = new System.Drawing.Point(24, 80);
            this.optNeonatal.Name = "optNeonatal";
            this.optNeonatal.Size = new System.Drawing.Size(370, 31);
            this.optNeonatal.TabIndex = 1;
            this.optNeonatal.Text = "Tasa de Mortalidad Infantil Neonatal";
            this.optNeonatal.UseVisualStyleBackColor = true;
            this.optNeonatal.CheckedChanged += new System.EventHandler(this.optNeonatal_CheckedChanged);
            // 
            // optMortalidad
            // 
            this.optMortalidad.AutoSize = true;
            this.optMortalidad.Checked = true;
            this.optMortalidad.Location = new System.Drawing.Point(24, 35);
            this.optMortalidad.Name = "optMortalidad";
            this.optMortalidad.Size = new System.Drawing.Size(282, 31);
            this.optMortalidad.TabIndex = 0;
            this.optMortalidad.TabStop = true;
            this.optMortalidad.Text = "Tasa de Mortalidad Infantil";
            this.optMortalidad.UseVisualStyleBackColor = true;
            this.optMortalidad.CheckedChanged += new System.EventHandler(this.optMortalidad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tasas de Mortalidad Infantil";
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
            this.txt1.TabIndex = 21;
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
            this.txt2.TabIndex = 20;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(470, 529);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(290, 59);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(431, 464);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(357, 32);
            this.txtResultado.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Resultado:";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(426, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(362, 66);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "Total de Nacidos vivos Registrados";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(426, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(362, 68);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Defunciones Registradas";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(431, 383);
            this.txt3.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(357, 32);
            this.txt3.TabIndex = 23;
            this.txt3.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(426, 314);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(362, 66);
            this.lbl3.TabIndex = 22;
            this.lbl3.Text = "Muertes Fetales Tardias";
            this.lbl3.Visible = false;
            // 
            // frmTasasMortalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmTasasMortalidad";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNeonatalTemprana;
        private System.Windows.Forms.RadioButton optNeonatal;
        private System.Windows.Forms.RadioButton optMortalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt1;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton optPerinatal;
        private System.Windows.Forms.RadioButton optFetal;
        private System.Windows.Forms.RadioButton optPostneontal;
        private System.Windows.Forms.RadioButton optNeonatalTardia;
        private System.Windows.Forms.NumericUpDown txt3;
        private System.Windows.Forms.Label lbl3;
    }
}