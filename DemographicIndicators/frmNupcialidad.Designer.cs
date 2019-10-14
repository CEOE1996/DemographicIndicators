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
            this.optPorcentajes6 = new System.Windows.Forms.RadioButton();
            this.optPorcentaje5 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes4 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes3 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes2 = new System.Windows.Forms.RadioButton();
            this.optPorcentajes = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
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
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optPorcentajes6
            // 
            this.optPorcentajes6.AutoSize = true;
            this.optPorcentajes6.Location = new System.Drawing.Point(24, 331);
            this.optPorcentajes6.Name = "optPorcentajes6";
            this.optPorcentajes6.Size = new System.Drawing.Size(277, 31);
            this.optPorcentajes6.TabIndex = 6;
            this.optPorcentajes6.Text = "Tasa de Primo-nupcialidad";
            this.optPorcentajes6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes6.UseVisualStyleBackColor = true;
            // 
            // optPorcentaje5
            // 
            this.optPorcentaje5.AutoSize = true;
            this.optPorcentaje5.Location = new System.Drawing.Point(24, 278);
            this.optPorcentaje5.Name = "optPorcentaje5";
            this.optPorcentaje5.Size = new System.Drawing.Size(280, 31);
            this.optPorcentaje5.TabIndex = 5;
            this.optPorcentaje5.Text = "Edad media al Matrimonio";
            this.optPorcentaje5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentaje5.UseVisualStyleBackColor = true;
            // 
            // optPorcentajes4
            // 
            this.optPorcentajes4.Location = new System.Drawing.Point(24, 194);
            this.optPorcentajes4.Name = "optPorcentajes4";
            this.optPorcentajes4.Size = new System.Drawing.Size(370, 62);
            this.optPorcentajes4.TabIndex = 4;
            this.optPorcentajes4.Text = "Indicador Coyuntural de Nupcialidad";
            this.optPorcentajes4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes4.UseVisualStyleBackColor = true;
            // 
            // optPorcentajes3
            // 
            this.optPorcentajes3.AutoSize = true;
            this.optPorcentajes3.Location = new System.Drawing.Point(24, 141);
            this.optPorcentajes3.Name = "optPorcentajes3";
            this.optPorcentajes3.Size = new System.Drawing.Size(315, 31);
            this.optPorcentajes3.TabIndex = 3;
            this.optPorcentajes3.Text = "Tasas de Nupcialidad por edad";
            this.optPorcentajes3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optPorcentajes3.UseVisualStyleBackColor = true;
            // 
            // optPorcentajes2
            // 
            this.optPorcentajes2.AutoSize = true;
            this.optPorcentajes2.Location = new System.Drawing.Point(24, 88);
            this.optPorcentajes2.Name = "optPorcentajes2";
            this.optPorcentajes2.Size = new System.Drawing.Size(218, 31);
            this.optPorcentajes2.TabIndex = 1;
            this.optPorcentajes2.Text = "Tasa de Nupcialidad";
            this.optPorcentajes2.UseVisualStyleBackColor = true;
            // 
            // optPorcentajes
            // 
            this.optPorcentajes.AutoSize = true;
            this.optPorcentajes.Checked = true;
            this.optPorcentajes.Location = new System.Drawing.Point(24, 35);
            this.optPorcentajes.Name = "optPorcentajes";
            this.optPorcentajes.Size = new System.Drawing.Size(273, 31);
            this.optPorcentajes.TabIndex = 0;
            this.optPorcentajes.Text = "Tasa Bruta de Nupcialidad";
            this.optPorcentajes.UseVisualStyleBackColor = true;
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
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(24, 437);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(370, 62);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Indicador Coyuntural de Primo-nupcialidad";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 384);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(375, 31);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Tasas de primo-nupcialidad por edad";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 521);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(347, 31);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Edad media al primer Matirmonio";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.RadioButton optPorcentajes6;
        private System.Windows.Forms.RadioButton optPorcentaje5;
        private System.Windows.Forms.RadioButton optPorcentajes4;
        private System.Windows.Forms.RadioButton optPorcentajes3;
        private System.Windows.Forms.RadioButton optPorcentajes2;
        private System.Windows.Forms.RadioButton optPorcentajes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt1;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}