namespace Laboratorio_7.EJERCICIO_1
{
    partial class B1
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
            this.btnDesencolarPorElFinal = new System.Windows.Forms.Button();
            this.btnDesencolarPorElFrente = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesencolarPorElFinal
            // 
            this.btnDesencolarPorElFinal.Location = new System.Drawing.Point(225, 236);
            this.btnDesencolarPorElFinal.Name = "btnDesencolarPorElFinal";
            this.btnDesencolarPorElFinal.Size = new System.Drawing.Size(122, 29);
            this.btnDesencolarPorElFinal.TabIndex = 17;
            this.btnDesencolarPorElFinal.Text = "Desencolar al Final";
            this.btnDesencolarPorElFinal.UseVisualStyleBackColor = true;
            this.btnDesencolarPorElFinal.Click += new System.EventHandler(this.btnDesencolarPorElFinal_Click);
            // 
            // btnDesencolarPorElFrente
            // 
            this.btnDesencolarPorElFrente.Location = new System.Drawing.Point(225, 201);
            this.btnDesencolarPorElFrente.Name = "btnDesencolarPorElFrente";
            this.btnDesencolarPorElFrente.Size = new System.Drawing.Size(122, 29);
            this.btnDesencolarPorElFrente.TabIndex = 16;
            this.btnDesencolarPorElFrente.Text = "Desencolar al Frente";
            this.btnDesencolarPorElFrente.UseVisualStyleBackColor = true;
            this.btnDesencolarPorElFrente.Click += new System.EventHandler(this.btnDesencolarPorElFrente_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 79);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(190, 186);
            this.lstDatos.TabIndex = 15;
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(225, 37);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(122, 29);
            this.btnEncolar.TabIndex = 14;
            this.btnEncolar.Text = "Encolar ";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 42);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(190, 20);
            this.txtValor.TabIndex = 13;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Valor.Location = new System.Drawing.Point(9, 10);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(58, 22);
            this.Valor.TabIndex = 12;
            this.Valor.Text = "Valor";
            // 
            // B1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(359, 283);
            this.Controls.Add(this.btnDesencolarPorElFinal);
            this.Controls.Add(this.btnDesencolarPorElFrente);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Valor);
            this.Name = "B1";
            this.Text = "B1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesencolarPorElFinal;
        private System.Windows.Forms.Button btnDesencolarPorElFrente;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label Valor;
    }
}