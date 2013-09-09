namespace Calculadora
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.btnFK = new System.Windows.Forms.Button();
            this.btnKC = new System.Windows.Forms.Button();
            this.btnKF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(37, 73);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 0;
            // 
            // btnCF
            // 
            this.btnCF.Location = new System.Drawing.Point(174, 12);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(129, 23);
            this.btnCF.TabIndex = 1;
            this.btnCF.Text = "Celcius - Fahrenheit";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // btnCK
            // 
            this.btnCK.Location = new System.Drawing.Point(174, 41);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(126, 23);
            this.btnCK.TabIndex = 2;
            this.btnCK.Text = "Celcius - Kelvin";
            this.btnCK.UseVisualStyleBackColor = true;
            // 
            // btnFC
            // 
            this.btnFC.Location = new System.Drawing.Point(174, 70);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(126, 23);
            this.btnFC.TabIndex = 3;
            this.btnFC.Text = "Fahrenheit - Celcius";
            this.btnFC.UseVisualStyleBackColor = true;
            // 
            // btnFK
            // 
            this.btnFK.Location = new System.Drawing.Point(174, 98);
            this.btnFK.Name = "btnFK";
            this.btnFK.Size = new System.Drawing.Size(126, 23);
            this.btnFK.TabIndex = 4;
            this.btnFK.Text = "Fahrenheit - Kelvin";
            this.btnFK.UseVisualStyleBackColor = true;
            // 
            // btnKC
            // 
            this.btnKC.Location = new System.Drawing.Point(174, 127);
            this.btnKC.Name = "btnKC";
            this.btnKC.Size = new System.Drawing.Size(126, 23);
            this.btnKC.TabIndex = 5;
            this.btnKC.Text = "Kelvin - Celcius";
            this.btnKC.UseVisualStyleBackColor = true;
            // 
            // btnKF
            // 
            this.btnKF.Location = new System.Drawing.Point(174, 156);
            this.btnKF.Name = "btnKF";
            this.btnKF.Size = new System.Drawing.Size(126, 23);
            this.btnKF.TabIndex = 6;
            this.btnKF.Text = "Kelvin - Fahrenheit";
            this.btnKF.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 187);
            this.Controls.Add(this.btnKF);
            this.Controls.Add(this.btnKC);
            this.Controls.Add(this.btnFK);
            this.Controls.Add(this.btnFC);
            this.Controls.Add(this.btnCK);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.txtTemp);
            this.Name = "Form2";
            this.Text = "Calculadora2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnCF;
        private System.Windows.Forms.Button btnCK;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.Button btnFK;
        private System.Windows.Forms.Button btnKC;
        private System.Windows.Forms.Button btnKF;
    }
}