namespace PooPractica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularSalarioAnual = new System.Windows.Forms.Button();
            this.btnMostrarInfoGerente = new System.Windows.Forms.Button();
            this.btnMostrarInformacionGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularSalarioAnual
            // 
            this.btnCalcularSalarioAnual.Location = new System.Drawing.Point(82, 40);
            this.btnCalcularSalarioAnual.Name = "btnCalcularSalarioAnual";
            this.btnCalcularSalarioAnual.Size = new System.Drawing.Size(154, 46);
            this.btnCalcularSalarioAnual.TabIndex = 0;
            this.btnCalcularSalarioAnual.Text = "Calcular Salario Anual";
            this.btnCalcularSalarioAnual.UseVisualStyleBackColor = true;
            this.btnCalcularSalarioAnual.Click += new System.EventHandler(this.btnCalcularSalarioAnual_Click);
            // 
            // btnMostrarInfoGerente
            // 
            this.btnMostrarInfoGerente.Location = new System.Drawing.Point(82, 118);
            this.btnMostrarInfoGerente.Name = "btnMostrarInfoGerente";
            this.btnMostrarInfoGerente.Size = new System.Drawing.Size(154, 46);
            this.btnMostrarInfoGerente.TabIndex = 1;
            this.btnMostrarInfoGerente.Text = "Mostrar informacion del gerente";
            this.btnMostrarInfoGerente.UseVisualStyleBackColor = true;
            this.btnMostrarInfoGerente.Click += new System.EventHandler(this.btnMostrarInfoGerente_Click);
            // 
            // btnMostrarInformacionGeneral
            // 
            this.btnMostrarInformacionGeneral.Location = new System.Drawing.Point(82, 202);
            this.btnMostrarInformacionGeneral.Name = "btnMostrarInformacionGeneral";
            this.btnMostrarInformacionGeneral.Size = new System.Drawing.Size(154, 46);
            this.btnMostrarInformacionGeneral.TabIndex = 2;
            this.btnMostrarInformacionGeneral.Text = "Mostrar informacion general";
            this.btnMostrarInformacionGeneral.UseVisualStyleBackColor = true;
            this.btnMostrarInformacionGeneral.Click += new System.EventHandler(this.btnMostrarInformacionGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.btnMostrarInformacionGeneral);
            this.Controls.Add(this.btnMostrarInfoGerente);
            this.Controls.Add(this.btnCalcularSalarioAnual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularSalarioAnual;
        private System.Windows.Forms.Button btnMostrarInfoGerente;
        private System.Windows.Forms.Button btnMostrarInformacionGeneral;
    }
}

