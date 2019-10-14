namespace DemographicIndicators
{
    partial class frmMenu
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
            this.btnPoblacion = new System.Windows.Forms.Button();
            this.btnMigratorio = new System.Windows.Forms.Button();
            this.btnDivorcialidad = new System.Windows.Forms.Button();
            this.btnNupcialidad = new System.Windows.Forms.Button();
            this.btnMortalidad = new System.Windows.Forms.Button();
            this.btnNatalidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicadores Demográficos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPoblacion);
            this.groupBox1.Controls.Add(this.btnMigratorio);
            this.groupBox1.Controls.Add(this.btnDivorcialidad);
            this.groupBox1.Controls.Add(this.btnNupcialidad);
            this.groupBox1.Controls.Add(this.btnMortalidad);
            this.groupBox1.Controls.Add(this.btnNatalidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 548);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Opción Deseada";
            // 
            // btnPoblacion
            // 
            this.btnPoblacion.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoblacion.Location = new System.Drawing.Point(27, 452);
            this.btnPoblacion.Name = "btnPoblacion";
            this.btnPoblacion.Size = new System.Drawing.Size(648, 65);
            this.btnPoblacion.TabIndex = 5;
            this.btnPoblacion.Text = "Crecimiento y Estructura de la Población";
            this.btnPoblacion.UseVisualStyleBackColor = true;
            this.btnPoblacion.Click += new System.EventHandler(this.BtnPoblacion_Click);
            // 
            // btnMigratorio
            // 
            this.btnMigratorio.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigratorio.Location = new System.Drawing.Point(27, 372);
            this.btnMigratorio.Name = "btnMigratorio";
            this.btnMigratorio.Size = new System.Drawing.Size(648, 65);
            this.btnMigratorio.TabIndex = 4;
            this.btnMigratorio.Text = "Movimiento Migratorio";
            this.btnMigratorio.UseVisualStyleBackColor = true;
            this.btnMigratorio.Click += new System.EventHandler(this.BtnMigratorio_Click);
            // 
            // btnDivorcialidad
            // 
            this.btnDivorcialidad.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivorcialidad.Location = new System.Drawing.Point(27, 291);
            this.btnDivorcialidad.Name = "btnDivorcialidad";
            this.btnDivorcialidad.Size = new System.Drawing.Size(648, 65);
            this.btnDivorcialidad.TabIndex = 3;
            this.btnDivorcialidad.Text = "Divorcialidad";
            this.btnDivorcialidad.UseVisualStyleBackColor = true;
            this.btnDivorcialidad.Click += new System.EventHandler(this.BtnDivorcialidad_Click);
            // 
            // btnNupcialidad
            // 
            this.btnNupcialidad.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNupcialidad.Location = new System.Drawing.Point(27, 209);
            this.btnNupcialidad.Name = "btnNupcialidad";
            this.btnNupcialidad.Size = new System.Drawing.Size(648, 65);
            this.btnNupcialidad.TabIndex = 2;
            this.btnNupcialidad.Text = "Nupcialidad";
            this.btnNupcialidad.UseVisualStyleBackColor = true;
            // 
            // btnMortalidad
            // 
            this.btnMortalidad.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortalidad.Location = new System.Drawing.Point(27, 129);
            this.btnMortalidad.Name = "btnMortalidad";
            this.btnMortalidad.Size = new System.Drawing.Size(648, 65);
            this.btnMortalidad.TabIndex = 1;
            this.btnMortalidad.Text = "Mortalidad";
            this.btnMortalidad.UseVisualStyleBackColor = true;
            this.btnMortalidad.Click += new System.EventHandler(this.btnMortalidad_Click);
            // 
            // btnNatalidad
            // 
            this.btnNatalidad.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatalidad.Location = new System.Drawing.Point(27, 48);
            this.btnNatalidad.Name = "btnNatalidad";
            this.btnNatalidad.Size = new System.Drawing.Size(648, 65);
            this.btnNatalidad.TabIndex = 0;
            this.btnNatalidad.Text = "Natalidad y Fecundidad";
            this.btnNatalidad.UseVisualStyleBackColor = true;
            this.btnNatalidad.Click += new System.EventHandler(this.btnNatalidad_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Indicadores Demográficos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPoblacion;
        private System.Windows.Forms.Button btnMigratorio;
        private System.Windows.Forms.Button btnDivorcialidad;
        private System.Windows.Forms.Button btnNupcialidad;
        private System.Windows.Forms.Button btnMortalidad;
        private System.Windows.Forms.Button btnNatalidad;
    }
}

