namespace IMC
{
    partial class frmIMC
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIntroduccion = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblDelgadez = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblSobrepeso = new System.Windows.Forms.Label();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultadoNumero = new System.Windows.Forms.Label();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(204, 72);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(144, 26);
            this.txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(204, 116);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(144, 26);
            this.txtAltura.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(19, 78);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(45, 20);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(19, 122);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // lblIntroduccion
            // 
            this.lblIntroduccion.AutoSize = true;
            this.lblIntroduccion.Location = new System.Drawing.Point(19, 30);
            this.lblIntroduccion.Name = "lblIntroduccion";
            this.lblIntroduccion.Size = new System.Drawing.Size(297, 20);
            this.lblIntroduccion.TabIndex = 5;
            this.lblIntroduccion.Text = "Complete los datos para calcular su IMC:";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(19, 222);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(163, 20);
            this.lblIndice.TabIndex = 7;
            this.lblIndice.Text = "Indice Masa Corporal:";
            // 
            // lblDelgadez
            // 
            this.lblDelgadez.AutoSize = true;
            this.lblDelgadez.Location = new System.Drawing.Point(24, 38);
            this.lblDelgadez.Name = "lblDelgadez";
            this.lblDelgadez.Size = new System.Drawing.Size(221, 24);
            this.lblDelgadez.TabIndex = 15;
            this.lblDelgadez.Text = "IMC < 18.49 = Delgadez.";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(24, 62);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(214, 20);
            this.lblNormal.TabIndex = 12;
            this.lblNormal.Text = "18.5 > IMC < 24.99 = Normal.";
            // 
            // lblSobrepeso
            // 
            this.lblSobrepeso.AutoSize = true;
            this.lblSobrepeso.Location = new System.Drawing.Point(24, 86);
            this.lblSobrepeso.Name = "lblSobrepeso";
            this.lblSobrepeso.Size = new System.Drawing.Size(176, 20);
            this.lblSobrepeso.TabIndex = 13;
            this.lblSobrepeso.Text = "IMC  > 25 = Sobrepeso.";
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.lblSobrepeso);
            this.grpInformacion.Controls.Add(this.lblDelgadez);
            this.grpInformacion.Controls.Add(this.lblNormal);
            this.grpInformacion.Location = new System.Drawing.Point(23, 276);
            this.grpInformacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpInformacion.Size = new System.Drawing.Size(303, 133);
            this.grpInformacion.TabIndex = 14;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(251, 149);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 33);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultadoNumero
            // 
            this.lblResultadoNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoNumero.Location = new System.Drawing.Point(204, 216);
            this.lblResultadoNumero.Name = "lblResultadoNumero";
            this.lblResultadoNumero.Size = new System.Drawing.Size(144, 26);
            this.lblResultadoNumero.TabIndex = 16;
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 422);
            this.Controls.Add(this.lblResultadoNumero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblIntroduccion);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIntroduccion;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblDelgadez;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblSobrepeso;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultadoNumero;
    }
}

