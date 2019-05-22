namespace Diseño
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEspecialidadDoctor = new System.Windows.Forms.Label();
            this.txtEspecialidadDoc = new System.Windows.Forms.TextBox();
            this.lblApellidoDoctor = new System.Windows.Forms.Label();
            this.txtApellidoDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumDoctor = new System.Windows.Forms.Label();
            this.txtNumDoctor = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodHospital = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEspecialidadDoctor);
            this.panel1.Controls.Add(this.txtEspecialidadDoc);
            this.panel1.Controls.Add(this.lblApellidoDoctor);
            this.panel1.Controls.Add(this.txtApellidoDoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNumDoctor);
            this.panel1.Controls.Add(this.txtNumDoctor);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtCodHospital);
            this.panel1.Location = new System.Drawing.Point(182, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 202);
            this.panel1.TabIndex = 7;
            // 
            // lblEspecialidadDoctor
            // 
            this.lblEspecialidadDoctor.AutoSize = true;
            this.lblEspecialidadDoctor.Location = new System.Drawing.Point(23, 99);
            this.lblEspecialidadDoctor.Name = "lblEspecialidadDoctor";
            this.lblEspecialidadDoctor.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidadDoctor.TabIndex = 11;
            this.lblEspecialidadDoctor.Text = "Especialidad";
            // 
            // txtEspecialidadDoc
            // 
            this.txtEspecialidadDoc.Location = new System.Drawing.Point(111, 99);
            this.txtEspecialidadDoc.Name = "txtEspecialidadDoc";
            this.txtEspecialidadDoc.Size = new System.Drawing.Size(168, 20);
            this.txtEspecialidadDoc.TabIndex = 10;
            // 
            // lblApellidoDoctor
            // 
            this.lblApellidoDoctor.AutoSize = true;
            this.lblApellidoDoctor.Location = new System.Drawing.Point(23, 73);
            this.lblApellidoDoctor.Name = "lblApellidoDoctor";
            this.lblApellidoDoctor.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoDoctor.TabIndex = 9;
            this.lblApellidoDoctor.Text = "Apellido";
            // 
            // txtApellidoDoc
            // 
            this.txtApellidoDoc.Location = new System.Drawing.Point(111, 73);
            this.txtApellidoDoc.Name = "txtApellidoDoc";
            this.txtApellidoDoc.Size = new System.Drawing.Size(168, 20);
            this.txtApellidoDoc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo Hospital";
            // 
            // lblNumDoctor
            // 
            this.lblNumDoctor.AutoSize = true;
            this.lblNumDoctor.Location = new System.Drawing.Point(23, 20);
            this.lblNumDoctor.Name = "lblNumDoctor";
            this.lblNumDoctor.Size = new System.Drawing.Size(64, 13);
            this.lblNumDoctor.TabIndex = 6;
            this.lblNumDoctor.Text = "Num Doctor";
            // 
            // txtNumDoctor
            // 
            this.txtNumDoctor.Location = new System.Drawing.Point(111, 13);
            this.txtNumDoctor.Name = "txtNumDoctor";
            this.txtNumDoctor.Size = new System.Drawing.Size(168, 20);
            this.txtNumDoctor.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(99, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodHospital
            // 
            this.txtCodHospital.Location = new System.Drawing.Point(111, 44);
            this.txtCodHospital.Name = "txtCodHospital";
            this.txtCodHospital.Size = new System.Drawing.Size(168, 20);
            this.txtCodHospital.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEspecialidadDoctor;
        private System.Windows.Forms.TextBox txtEspecialidadDoc;
        private System.Windows.Forms.Label lblApellidoDoctor;
        private System.Windows.Forms.TextBox txtApellidoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumDoctor;
        private System.Windows.Forms.TextBox txtNumDoctor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodHospital;
        private System.Windows.Forms.Button button1;
    }
}

