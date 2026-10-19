namespace Actividad07EncenderLEDC
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
            this.Btn_Encender = new System.Windows.Forms.Button();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Encender
            // 
            this.Btn_Encender.Location = new System.Drawing.Point(139, 88);
            this.Btn_Encender.Name = "Btn_Encender";
            this.Btn_Encender.Size = new System.Drawing.Size(108, 48);
            this.Btn_Encender.TabIndex = 0;
            this.Btn_Encender.Text = "ENCENDER";
            this.Btn_Encender.UseVisualStyleBackColor = true;
            this.Btn_Encender.Click += new System.EventHandler(this.Btn_Encender_Click);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Location = new System.Drawing.Point(139, 163);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(108, 48);
            this.Btn_Apagar.TabIndex = 1;
            this.Btn_Apagar.Text = "APAGAR";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn_Encender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Encender;
        private System.Windows.Forms.Button Btn_Apagar;
    }
}

