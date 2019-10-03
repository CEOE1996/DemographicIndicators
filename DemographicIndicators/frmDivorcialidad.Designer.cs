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
            this.label1.Location = new System.Drawing.Point(156, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divorciabilidad";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(275, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Opción";
            // 
            // optConyugalFecundidad
            // 
            this.optConyugalFecundidad.AutoSize = true;
            this.optConyugalFecundidad.Location = new System.Drawing.Point(16, 254);
            this.optConyugalFecundidad.Margin = new System.Windows.Forms.Padding(2);
            this.optConyugalFecundidad.Name = "optConyugalFecundidad";
            this.optConyugalFecundidad.Size = new System.Drawing.Size(165, 22);
            this.optConyugalFecundidad.TabIndex = 5;
            this.optConyugalFecundidad.Text = "Edad media al divorcio";
            this.optConyugalFecundidad.UseVisualStyleBackColor = true;
            // 
            // optFecundidadEdad
            // 
            this.optFecundidadEdad.Location = new System.Drawing.Point(16, 204);
            this.optFecundidadEdad.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidadEdad.Name = "optFecundidadEdad";
            this.optFecundidadEdad.Size = new System.Drawing.Size(223, 42);
            this.optFecundidadEdad.TabIndex = 4;
            this.optFecundidadEdad.Text = "Indicador coyuntural de divorcialidad";
            this.optFecundidadEdad.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optFecundidadEdad.UseVisualStyleBackColor = true;
            // 
            // optFecundidadQuin
            // 
            this.optFecundidadQuin.Location = new System.Drawing.Point(16, 154);
            this.optFecundidadQuin.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidadQuin.Name = "optFecundidadQuin";
            this.optFecundidadQuin.Size = new System.Drawing.Size(241, 42);
            this.optFecundidadQuin.TabIndex = 3;
            this.optFecundidadQuin.Text = "Tasas de divorcialidad por edad";
            this.optFecundidadQuin.UseVisualStyleBackColor = true;
            // 
            // optFecundidad
            // 
            this.optFecundidad.AutoSize = true;
            this.optFecundidad.Location = new System.Drawing.Point(16, 126);
            this.optFecundidad.Margin = new System.Windows.Forms.Padding(2);
            this.optFecundidad.Name = "optFecundidad";
            this.optFecundidad.Size = new System.Drawing.Size(154, 22);
            this.optFecundidad.TabIndex = 2;
            this.optFecundidad.Text = "Tasa de divorcialidad";
            this.optFecundidad.UseVisualStyleBackColor = true;
            // 
            // optRatioMasculinidad
            // 
            this.optRatioMasculinidad.Location = new System.Drawing.Point(12, 51);
            this.optRatioMasculinidad.Margin = new System.Windows.Forms.Padding(2);
            this.optRatioMasculinidad.Name = "optRatioMasculinidad";
            this.optRatioMasculinidad.Size = new System.Drawing.Size(256, 71);
            this.optRatioMasculinidad.TabIndex = 1;
            this.optRatioMasculinidad.Text = "Proporción de divorcios según la duración del matrimonio";
            this.optRatioMasculinidad.UseVisualStyleBackColor = true;
            // 
            // optNatalidad
            // 
            this.optNatalidad.AutoSize = true;
            this.optNatalidad.Checked = true;
            this.optNatalidad.Location = new System.Drawing.Point(12, 23);
            this.optNatalidad.Margin = new System.Windows.Forms.Padding(2);
            this.optNatalidad.Name = "optNatalidad";
            this.optNatalidad.Size = new System.Drawing.Size(167, 22);
            this.optNatalidad.TabIndex = 0;
            this.optNatalidad.TabStop = true;
            this.optNatalidad.Text = "Tasa Bruta de Divorcios";
            this.optNatalidad.UseVisualStyleBackColor = true;
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