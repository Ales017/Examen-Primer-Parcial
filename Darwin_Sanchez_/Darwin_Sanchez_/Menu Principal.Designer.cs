namespace Darwin_Sanchez_
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
            this.Formulario1button = new System.Windows.Forms.Button();
            this.Formulario2button = new System.Windows.Forms.Button();
            this.Formulario3button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Formulario1button
            // 
            this.Formulario1button.Location = new System.Drawing.Point(106, 170);
            this.Formulario1button.Name = "Formulario1button";
            this.Formulario1button.Size = new System.Drawing.Size(168, 101);
            this.Formulario1button.TabIndex = 0;
            this.Formulario1button.Text = "Formulario 1";
            this.Formulario1button.UseVisualStyleBackColor = true;
            this.Formulario1button.Click += new System.EventHandler(this.Formulario1button_Click);
            // 
            // Formulario2button
            // 
            this.Formulario2button.Location = new System.Drawing.Point(316, 175);
            this.Formulario2button.Name = "Formulario2button";
            this.Formulario2button.Size = new System.Drawing.Size(168, 101);
            this.Formulario2button.TabIndex = 1;
            this.Formulario2button.Text = "Formulario 2";
            this.Formulario2button.UseVisualStyleBackColor = true;
            this.Formulario2button.Click += new System.EventHandler(this.Formulario2button_Click);
            // 
            // Formulario3button
            // 
            this.Formulario3button.Location = new System.Drawing.Point(524, 175);
            this.Formulario3button.Name = "Formulario3button";
            this.Formulario3button.Size = new System.Drawing.Size(168, 101);
            this.Formulario3button.TabIndex = 2;
            this.Formulario3button.Text = "Formulario 3";
            this.Formulario3button.UseVisualStyleBackColor = true;
            this.Formulario3button.Click += new System.EventHandler(this.Formulario3button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESCOJA EL FORMULARIO QUE DESEA VER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Formulario3button);
            this.Controls.Add(this.Formulario2button);
            this.Controls.Add(this.Formulario1button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Formulario1button;
        private System.Windows.Forms.Button Formulario2button;
        private System.Windows.Forms.Button Formulario3button;
        private System.Windows.Forms.Label label1;
    }
}

