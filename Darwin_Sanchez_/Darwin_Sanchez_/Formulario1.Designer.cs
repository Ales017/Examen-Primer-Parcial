namespace Darwin_Sanchez_
{
    partial class Formulario1
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
            System.Windows.Forms.Button Calcularbutton;
            this.MescomboBox = new System.Windows.Forms.ComboBox();
            this.MostrarCalculolistBox = new System.Windows.Forms.ListBox();
            this.CalculoMeslabel = new System.Windows.Forms.Label();
            Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MescomboBox
            // 
            this.MescomboBox.FormattingEnabled = true;
            this.MescomboBox.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MescomboBox.Location = new System.Drawing.Point(402, 66);
            this.MescomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MescomboBox.Name = "MescomboBox";
            this.MescomboBox.Size = new System.Drawing.Size(267, 24);
            this.MescomboBox.TabIndex = 7;
            // 
            // Calcularbutton
            // 
            Calcularbutton.Location = new System.Drawing.Point(303, 158);
            Calcularbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Calcularbutton.Name = "Calcularbutton";
            Calcularbutton.Size = new System.Drawing.Size(161, 55);
            Calcularbutton.TabIndex = 6;
            Calcularbutton.Text = "Calcular";
            Calcularbutton.UseVisualStyleBackColor = true;
            Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // MostrarCalculolistBox
            // 
            this.MostrarCalculolistBox.FormattingEnabled = true;
            this.MostrarCalculolistBox.ItemHeight = 16;
            this.MostrarCalculolistBox.Location = new System.Drawing.Point(61, 300);
            this.MostrarCalculolistBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MostrarCalculolistBox.Name = "MostrarCalculolistBox";
            this.MostrarCalculolistBox.Size = new System.Drawing.Size(678, 84);
            this.MostrarCalculolistBox.TabIndex = 5;
            // 
            // CalculoMeslabel
            // 
            this.CalculoMeslabel.AutoSize = true;
            this.CalculoMeslabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoMeslabel.Location = new System.Drawing.Point(85, 67);
            this.CalculoMeslabel.Name = "CalculoMeslabel";
            this.CalculoMeslabel.Size = new System.Drawing.Size(271, 24);
            this.CalculoMeslabel.TabIndex = 4;
            this.CalculoMeslabel.Text = "Escoja un mes para hacer el calculo";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MescomboBox);
            this.Controls.Add(Calcularbutton);
            this.Controls.Add(this.MostrarCalculolistBox);
            this.Controls.Add(this.CalculoMeslabel);
            this.Name = "Formulario1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MescomboBox;
        private System.Windows.Forms.ListBox MostrarCalculolistBox;
        private System.Windows.Forms.Label CalculoMeslabel;
    }
}