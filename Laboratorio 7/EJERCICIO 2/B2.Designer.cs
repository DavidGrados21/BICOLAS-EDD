namespace Laboratorio_7.EJERCICIO_2
{
    partial class B2
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
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolarPorElFrente = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnEncolarAlFinal = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(225, 237);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(95, 29);
            this.btnDesencolar.TabIndex = 11;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolarPorElFrente
            // 
            this.btnEncolarPorElFrente.Location = new System.Drawing.Point(225, 80);
            this.btnEncolarPorElFrente.Name = "btnEncolarPorElFrente";
            this.btnEncolarPorElFrente.Size = new System.Drawing.Size(95, 29);
            this.btnEncolarPorElFrente.TabIndex = 10;
            this.btnEncolarPorElFrente.Text = "Encolar al Frente";
            this.btnEncolarPorElFrente.UseVisualStyleBackColor = true;
            this.btnEncolarPorElFrente.Click += new System.EventHandler(this.btnEncolarPorElFrente_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 80);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(190, 186);
            this.lstDatos.TabIndex = 9;
            // 
            // btnEncolarAlFinal
            // 
            this.btnEncolarAlFinal.Location = new System.Drawing.Point(225, 38);
            this.btnEncolarAlFinal.Name = "btnEncolarAlFinal";
            this.btnEncolarAlFinal.Size = new System.Drawing.Size(95, 29);
            this.btnEncolarAlFinal.TabIndex = 8;
            this.btnEncolarAlFinal.Text = "Encolar al Final";
            this.btnEncolarAlFinal.UseVisualStyleBackColor = true;
            this.btnEncolarAlFinal.Click += new System.EventHandler(this.btnEncolarAlFinal_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(190, 20);
            this.txtValor.TabIndex = 7;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Valor.Location = new System.Drawing.Point(9, 11);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(58, 22);
            this.Valor.TabIndex = 6;
            this.Valor.Text = "Valor";
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(335, 282);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolarPorElFrente);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnEncolarAlFinal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Valor);
            this.Name = "B2";
            this.Text = "B2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolarPorElFrente;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnEncolarAlFinal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label Valor;
    }
}