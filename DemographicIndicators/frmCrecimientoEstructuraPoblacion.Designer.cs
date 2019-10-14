namespace DemographicIndicators
{
    partial class frmCrecimientoEstructuraPoblacion
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
            this.optProporcionCasada = new System.Windows.Forms.RadioButton();
            this.optNacidosNacionallidad = new System.Windows.Forms.RadioButton();
            this.optNacidosOrden = new System.Windows.Forms.RadioButton();
            this.optEdadMaternidad = new System.Windows.Forms.RadioButton();
            this.optConyugalFecundidad = new System.Windows.Forms.RadioButton();
            this.optFecundidadEdad = new System.Windows.Forms.RadioButton();
            this.optFecundidadQuin = new System.Windows.Forms.RadioButton();
            this.optFecundidad = new System.Windows.Forms.RadioButton();
            this.optRatioMasculinidad = new System.Windows.Forms.RadioButton();
            this.optNatalidad = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crecimiento y estructura de la población";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optProporcionCasada);
            this.groupBox1.Controls.Add(this.optNacidosNacionallidad);
            this.groupBox1.Controls.Add(this.optNacidosOrden);
            this.groupBox1.Controls.Add(this.optEdadMaternidad);
            this.groupBox1.Controls.Add(this.optConyugalFecundidad);
            this.groupBox1.Controls.Add(this.optFecundidadEdad);
            this.groupBox1.Controls.Add(this.optFecundidadQuin);
            this.groupBox1.Controls.Add(this.optFecundidad);
            this.groupBox1.Controls.Add(this.optRatioMasculinidad);
            this.groupBox1.Controls.Add(this.optNatalidad);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(272, 469);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optProporcionCasada
            // 
            this.optProporcionCasada.Location = new System.Drawing.Point(16, 407);
            this.optProporcionCasada.Margin = new System.Windows.Forms.Padding(2);
            this.optProporcionCasada.Name = "optProporcionCasada";
            this.optProporcionCasada.Size = new System.Drawing.Size(252, 42);
            this.optProporcionCasada.TabIndex = 9;
            this.optProporcionCasada.Text = "Proporción Nacidos Madre no Casada";
            this.optProporcionCasada.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optProporcionCasada.UseVisualStyleBackColor = true;
            // 
            // optNacidosNacionallidad
            // 
            this.optNacidosNacionallidad.Location = new System.Drawing.Point(16, 351);
            this.optNacidosNacionallidad.Margin = new System.Windows.Forms.Padding(2);
            this.optNacidosNacionallidad.Name = "optNacidosNacionallidad";
            this.optNacidosNacionallidad.Size = new System.Drawing.Size(252, 42);
            this.optNacidosNacionallidad.TabIndex = 8;
            this.optNacidosNacionallidad.Text = "% Nacidos por Nacionalidad de la Madre";
            this.optNacidosNacionallidad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optNacidosNacionallidad.UseVisualStyleBackColor = true;
            // 
            // optNacidosOrden
            // 
            this.optNacidosOrden.AutoSize = true;
            this.optNacidosOrden.Location = new System.Drawing.Point(16, 315);
            this.optNacidosOrden.Margin = new System.Windows.Forms.Padding(2);
            this.optNacidosOrden.Name = "optNacidosOrden";
            this.optNacidosOrden.Size = new System.Drawing.Size(249, 22);
            this.optNacidosOrden.TabIndex = 7;
            this.optNacidosOrden.Text = "% Nacidos por Orden de Nacimiento";
            this.optNacidosOrden.UseVisualStyleBackColor = true;
            // 
            // optEdadMaternidad
            // 
            this.optEdadMaternidad.AutoSize = true;
            this.optEdadMaternidad.Location = new System.Drawing.Point(16, 279);
            this.optEdadMaternidad.Margin = new System.Windows.Forms.Padding(2);
            this.optEdadMaternidad.Name = "optEdadMaternidad";
            this.optEdadMaternidad.Size = new System.Drawing.Size(192, 22);
            this.optEdadMaternidad.TabIndex = 6;
            this.optEdadMaternidad.Text = "Edad Media de Maternidad";
            this.optEdadMaternidad.UseVisualStyleBackColor = true;
            // 
            // optConyugalFecundidad
            // 
            this.optConyugalFecundidad.AutoSize = true;
            this.optConyugalFecundidad.Location = new System.Drawing.Point(16, 243);
            this.optConyugalFecundidad.Margin = new System.Windows.Forms.Padding(2);
            this.optConyugalFecundidad.Name = "optConyugalFecundidad";
            this.optConyugalFecundidad.Size = new System.Drawing.Size(238, 22);
            this.optConyugalFecundidad.TabIndex = 5;
            this.optConyugalFecundidad.Text = "Indicador Conyugal de Fecundidad";
            this.optConyugalFecundidad.UseVisualStyleBackColor = true;
            // 
            // optFecundidadEdad
            // 
            this.optFecundidadEdad.Location = new System.Drawing.Point(16, 187);
            this.optFecundidadEdad.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidadEdad.Name = "optFecundidadEdad";
            this.optFecundidadEdad.Size = new System.Drawing.Size(223, 42);
            this.optFecundidadEdad.TabIndex = 4;
            this.optFecundidadEdad.Text = "Tasa de Fecundidad por Edad de la Madre";
            this.optFecundidadEdad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optFecundidadEdad.UseVisualStyleBackColor = true;
            // 
            // optFecundidadQuin
            // 
            this.optFecundidadQuin.Location = new System.Drawing.Point(16, 131);
            this.optFecundidadQuin.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidadQuin.Name = "optFecundidadQuin";
            this.optFecundidadQuin.Size = new System.Drawing.Size(241, 42);
            this.optFecundidadQuin.TabIndex = 3;
            this.optFecundidadQuin.Text = "Tasa de Fecundidad por Grupo Quinquenal de Edad de la Madre";
            this.optFecundidadQuin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optFecundidadQuin.UseVisualStyleBackColor = true;
            // 
            // optFecundidad
            // 
            this.optFecundidad.AutoSize = true;
            this.optFecundidad.Location = new System.Drawing.Point(16, 95);
            this.optFecundidad.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidad.Name = "optFecundidad";
            this.optFecundidad.Size = new System.Drawing.Size(189, 22);
            this.optFecundidad.TabIndex = 2;
            this.optFecundidad.Text = "Tasa Global de Fecundidad";
            this.optFecundidad.UseVisualStyleBackColor = true;
            // 
            // optRatioMasculinidad
            // 
            this.optRatioMasculinidad.AutoSize = true;
            this.optRatioMasculinidad.Location = new System.Drawing.Point(16, 59);
            this.optRatioMasculinidad.Margin = new System.Windows.Forms.Padding(2);
            this.optRatioMasculinidad.Name = "optRatioMasculinidad";
            this.optRatioMasculinidad.Size = new System.Drawing.Size(250, 22);
            this.optRatioMasculinidad.TabIndex = 1;
            this.optRatioMasculinidad.Text = "Ratio de Masculinidad al Nacimiento";
            this.optRatioMasculinidad.UseVisualStyleBackColor = true;
            // 
            // optNatalidad
            // 
            this.optNatalidad.AutoSize = true;
            this.optNatalidad.Checked = true;
            this.optNatalidad.Location = new System.Drawing.Point(16, 23);
            this.optNatalidad.Margin = new System.Windows.Forms.Padding(2);
            this.optNatalidad.Name = "optNatalidad";
            this.optNatalidad.Size = new System.Drawing.Size(170, 22);
            this.optNatalidad.TabIndex = 0;
            this.optNatalidad.TabStop = true;
            this.optNatalidad.Text = "Tasa Bruta de Natalidad";
            this.optNatalidad.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(284, 47);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(241, 44);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Nacimientos Registrados";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(284, 121);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(241, 43);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Población";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 345);
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
            this.txtResultado.Location = new System.Drawing.Point(287, 382);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(239, 24);
            this.txtResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(311, 436);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(287, 166);
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
            this.txt1.Location = new System.Drawing.Point(287, 93);
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
            // frmCrecimientoEstructuraPoblacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 518);
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
            this.Name = "frmCrecimientoEstructuraPoblacion";
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
        private System.Windows.Forms.RadioButton optProporcionCasada;
        private System.Windows.Forms.RadioButton optNacidosNacionallidad;
        private System.Windows.Forms.RadioButton optNacidosOrden;
        private System.Windows.Forms.RadioButton optEdadMaternidad;
        private System.Windows.Forms.RadioButton optConyugalFecundidad;
        private System.Windows.Forms.RadioButton optFecundidadEdad;
        private System.Windows.Forms.RadioButton optFecundidadQuin;
        private System.Windows.Forms.RadioButton optFecundidad;
        private System.Windows.Forms.RadioButton optRatioMasculinidad;
        private System.Windows.Forms.RadioButton optNatalidad;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.NumericUpDown txt1;
    }
}