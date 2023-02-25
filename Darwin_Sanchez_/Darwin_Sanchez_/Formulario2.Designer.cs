namespace Darwin_Sanchez_
{
    partial class Formulario2
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
            this.components = new System.ComponentModel.Container();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.Promediolabel = new System.Windows.Forms.Label();
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.MostrarlistBox = new System.Windows.Forms.ListBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.Productolabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(86, 106);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(61, 16);
            this.Cantidadlabel.TabIndex = 21;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(192, 166);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 22);
            this.PreciotextBox.TabIndex = 20;
            // 
            // Promediolabel
            // 
            this.Promediolabel.AutoSize = true;
            this.Promediolabel.Location = new System.Drawing.Point(189, 364);
            this.Promediolabel.Name = "Promediolabel";
            this.Promediolabel.Size = new System.Drawing.Size(92, 16);
            this.Promediolabel.TabIndex = 19;
            this.Promediolabel.Text = "Total a Pagar ";
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(174, 324);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.Size = new System.Drawing.Size(118, 22);
            this.PromediotextBox.TabIndex = 18;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(161, 224);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(150, 66);
            this.Agregarbutton.TabIndex = 17;
            this.Agregarbutton.Text = "Agregar Y Calcular";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // MostrarlistBox
            // 
            this.MostrarlistBox.FormattingEnabled = true;
            this.MostrarlistBox.ItemHeight = 16;
            this.MostrarlistBox.Location = new System.Drawing.Point(317, 47);
            this.MostrarlistBox.Name = "MostrarlistBox";
            this.MostrarlistBox.Size = new System.Drawing.Size(397, 356);
            this.MostrarlistBox.TabIndex = 16;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(192, 103);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadtextBox.TabIndex = 15;
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(86, 169);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(46, 16);
            this.Preciolabel.TabIndex = 14;
            this.Preciolabel.Text = "Precio";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(192, 47);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(100, 22);
            this.ProductotextBox.TabIndex = 13;
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(86, 50);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(61, 16);
            this.Productolabel.TabIndex = 12;
            this.Productolabel.Text = "Producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cantidadlabel);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.Promediolabel);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.MostrarlistBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.Productolabel);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label Promediolabel;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ListBox MostrarlistBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.Label Productolabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}