namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tNota = new System.Windows.Forms.TextBox();
            this.tNotaMedia = new System.Windows.Forms.TextBox();
            this.lLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lista de los alumnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota media de los alumnos";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(40, 35);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(289, 20);
            this.tNombre.TabIndex = 5;
            // 
            // tNota
            // 
            this.tNota.Location = new System.Drawing.Point(382, 35);
            this.tNota.Name = "tNota";
            this.tNota.Size = new System.Drawing.Size(100, 20);
            this.tNota.TabIndex = 6;
            // 
            // tNotaMedia
            // 
            this.tNotaMedia.Location = new System.Drawing.Point(614, 288);
            this.tNotaMedia.Name = "tNotaMedia";
            this.tNotaMedia.ReadOnly = true;
            this.tNotaMedia.Size = new System.Drawing.Size(100, 20);
            this.tNotaMedia.TabIndex = 8;
            // 
            // lLista
            // 
            this.lLista.FormattingEnabled = true;
            this.lLista.Location = new System.Drawing.Point(40, 107);
            this.lLista.Name = "lLista";
            this.lLista.Size = new System.Drawing.Size(661, 147);
            this.lLista.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 328);
            this.Controls.Add(this.lLista);
            this.Controls.Add(this.tNotaMedia);
            this.Controls.Add(this.tNota);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tNota;
        private System.Windows.Forms.TextBox tNotaMedia;
        private System.Windows.Forms.ListBox lLista;
    }
}

