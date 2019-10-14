namespace DemographicIndicators
{
    partial class frmMenuMortalidad
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
            this.btmPorcentajes = new System.Windows.Forms.Button();
            this.btnTasas = new System.Windows.Forms.Button();
            this.btnMortalidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmPorcentajes);
            this.groupBox1.Controls.Add(this.btnTasas);
            this.groupBox1.Controls.Add(this.btnMortalidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Opción Deseada";
            // 
            // btmPorcentajes
            // 
            this.btmPorcentajes.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPorcentajes.Location = new System.Drawing.Point(27, 209);
            this.btmPorcentajes.Name = "btmPorcentajes";
            this.btmPorcentajes.Size = new System.Drawing.Size(648, 65);
            this.btmPorcentajes.TabIndex = 2;
            this.btmPorcentajes.Text = "Porcentaje Infantil de Fallecidos";
            this.btmPorcentajes.UseVisualStyleBackColor = true;
            this.btmPorcentajes.Click += new System.EventHandler(this.btmPorcentajes_Click);
            // 
            // btnTasas
            // 
            this.btnTasas.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasas.Location = new System.Drawing.Point(27, 129);
            this.btnTasas.Name = "btnTasas";
            this.btnTasas.Size = new System.Drawing.Size(648, 65);
            this.btnTasas.TabIndex = 1;
            this.btnTasas.Text = "Tasas de Mortalidad Infantil";
            this.btnTasas.UseVisualStyleBackColor = true;
            this.btnTasas.Click += new System.EventHandler(this.btnTasas_Click);
            // 
            // btnMortalidad
            // 
            this.btnMortalidad.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortalidad.Location = new System.Drawing.Point(27, 48);
            this.btnMortalidad.Name = "btnMortalidad";
            this.btnMortalidad.Size = new System.Drawing.Size(648, 65);
            this.btnMortalidad.TabIndex = 0;
            this.btnMortalidad.Text = "Indicadores de Mortalidad";
            this.btnMortalidad.UseVisualStyleBackColor = true;
            this.btnMortalidad.Click += new System.EventHandler(this.btnMortalidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mortalidad";
            // 
            // frmMenuMortalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuMortalidad";
            this.Text = "frmMenuMortalidad";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btmPorcentajes;
        private System.Windows.Forms.Button btnTasas;
        private System.Windows.Forms.Button btnMortalidad;
        private System.Windows.Forms.Label label1;
    }
}