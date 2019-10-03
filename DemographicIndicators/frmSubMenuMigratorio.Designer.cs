namespace DemographicIndicators
{
    partial class frmSubMenuMigratorio
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
            this.btnTasas2 = new System.Windows.Forms.Button();
            this.btnTasas1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimientos Migratorios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTasas2);
            this.groupBox1.Controls.Add(this.btnTasas1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la Opción Deseada";
            // 
            // btnTasas2
            // 
            this.btnTasas2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasas2.Location = new System.Drawing.Point(27, 129);
            this.btnTasas2.Name = "btnTasas2";
            this.btnTasas2.Size = new System.Drawing.Size(648, 65);
            this.btnTasas2.TabIndex = 1;
            this.btnTasas2.Text = "Indicadores de Migraciones Exteriores";
            this.btnTasas2.UseVisualStyleBackColor = true;
            this.btnTasas2.Click += new System.EventHandler(this.BtnMortalidad_Click);
            // 
            // btnTasas1
            // 
            this.btnTasas1.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasas1.Location = new System.Drawing.Point(27, 48);
            this.btnTasas1.Name = "btnTasas1";
            this.btnTasas1.Size = new System.Drawing.Size(648, 65);
            this.btnTasas1.TabIndex = 0;
            this.btnTasas1.Text = "Indicadores de Migración Exterior";
            this.btnTasas1.UseVisualStyleBackColor = true;
            this.btnTasas1.Click += new System.EventHandler(this.BtnNatalidad_Click);
            // 
            // frmSubMenuMigratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSubMenuMigratorio";
            this.Text = "Indicadores Demográficos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTasas2;
        private System.Windows.Forms.Button btnTasas1;
    }
}

