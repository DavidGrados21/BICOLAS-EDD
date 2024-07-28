namespace Laboratorio_7.EJERCICIO_4
{
    partial class B4
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.Dato = new System.Windows.Forms.Label();
            this.rbtB1 = new System.Windows.Forms.RadioButton();
            this.rbtB2 = new System.Windows.Forms.RadioButton();
            this.lstBicola1 = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstBicola2 = new System.Windows.Forms.ListBox();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 35);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(189, 20);
            this.txtDato.TabIndex = 0;
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dato.Location = new System.Drawing.Point(12, 9);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(53, 22);
            this.Dato.TabIndex = 1;
            this.Dato.Text = "Dato";
            // 
            // rbtB1
            // 
            this.rbtB1.AutoSize = true;
            this.rbtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtB1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtB1.Location = new System.Drawing.Point(15, 61);
            this.rbtB1.Name = "rbtB1";
            this.rbtB1.Size = new System.Drawing.Size(79, 22);
            this.rbtB1.TabIndex = 2;
            this.rbtB1.TabStop = true;
            this.rbtB1.Text = "Bicola 1";
            this.rbtB1.UseVisualStyleBackColor = true;
            // 
            // rbtB2
            // 
            this.rbtB2.AutoSize = true;
            this.rbtB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtB2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtB2.Location = new System.Drawing.Point(118, 61);
            this.rbtB2.Name = "rbtB2";
            this.rbtB2.Size = new System.Drawing.Size(79, 22);
            this.rbtB2.TabIndex = 3;
            this.rbtB2.TabStop = true;
            this.rbtB2.Text = "Bicola 2";
            this.rbtB2.UseVisualStyleBackColor = true;
            // 
            // lstBicola1
            // 
            this.lstBicola1.FormattingEnabled = true;
            this.lstBicola1.Location = new System.Drawing.Point(12, 89);
            this.lstBicola1.Name = "lstBicola1";
            this.lstBicola1.Size = new System.Drawing.Size(83, 186);
            this.lstBicola1.TabIndex = 4;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(207, 33);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(71, 22);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstBicola2
            // 
            this.lstBicola2.FormattingEnabled = true;
            this.lstBicola2.Location = new System.Drawing.Point(118, 89);
            this.lstBicola2.Name = "lstBicola2";
            this.lstBicola2.Size = new System.Drawing.Size(83, 186);
            this.lstBicola2.TabIndex = 6;
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(208, 253);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(71, 22);
            this.btnDesencolar.TabIndex = 7;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // B4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(291, 284);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.lstBicola2);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstBicola1);
            this.Controls.Add(this.rbtB2);
            this.Controls.Add(this.rbtB1);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.txtDato);
            this.Name = "B4";
            this.Text = "B4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label Dato;
        private System.Windows.Forms.RadioButton rbtB1;
        private System.Windows.Forms.RadioButton rbtB2;
        private System.Windows.Forms.ListBox lstBicola1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListBox lstBicola2;
        private System.Windows.Forms.Button btnDesencolar;
    }
}