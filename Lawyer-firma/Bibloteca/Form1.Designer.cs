namespace Bibloteca
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnExpedient = new System.Windows.Forms.Button();
            this.btnLawyer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(134, 28);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnExpedient
            // 
            this.btnExpedient.Location = new System.Drawing.Point(134, 95);
            this.btnExpedient.Name = "btnExpedient";
            this.btnExpedient.Size = new System.Drawing.Size(75, 23);
            this.btnExpedient.TabIndex = 1;
            this.btnExpedient.Text = "Expedient";
            this.btnExpedient.UseVisualStyleBackColor = true;
            this.btnExpedient.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnLawyer
            // 
            this.btnLawyer.Location = new System.Drawing.Point(134, 162);
            this.btnLawyer.Name = "btnLawyer";
            this.btnLawyer.Size = new System.Drawing.Size(75, 23);
            this.btnLawyer.TabIndex = 2;
            this.btnLawyer.Text = "Lawyer";
            this.btnLawyer.UseVisualStyleBackColor = true;
            this.btnLawyer.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLawyer);
            this.groupBox1.Controls.Add(this.btnExpedient);
            this.groupBox1.Controls.Add(this.btnCustomer);
            this.groupBox1.Location = new System.Drawing.Point(44, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Law Firm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 309);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnExpedient;
        private System.Windows.Forms.Button btnLawyer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

