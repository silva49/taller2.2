namespace taller2._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su fecha de nacimiento";
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(353, 165);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(181, 29);
            this.txtfecha.TabIndex = 2;
            // 
            // btnenviar
            // 
            this.btnenviar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.Location = new System.Drawing.Point(560, 165);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(165, 29);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(110, 341);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 23);
            this.label.TabIndex = 4;
            this.label.Text = "Su edad es: ";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbledad.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(224, 339);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(23, 25);
            this.lbledad.TabIndex = 5;
            this.lbledad.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbledad;
    }
}

