namespace Notas.Registro
{
    partial class frmRegistroNotas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtparcial = new System.Windows.Forms.TextBox();
            this.txteva2 = new System.Windows.Forms.TextBox();
            this.txteva1 = new System.Windows.Forms.TextBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE NOTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EVA1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EVA2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "FINAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PARCIAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfinal);
            this.groupBox1.Controls.Add(this.txtparcial);
            this.groupBox1.Controls.Add(this.txteva2);
            this.groupBox1.Controls.Add(this.txteva1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de notas";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(276, 91);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 11;
            // 
            // txtparcial
            // 
            this.txtparcial.Location = new System.Drawing.Point(276, 32);
            this.txtparcial.Name = "txtparcial";
            this.txtparcial.Size = new System.Drawing.Size(100, 20);
            this.txtparcial.TabIndex = 10;
            // 
            // txteva2
            // 
            this.txteva2.Location = new System.Drawing.Point(55, 91);
            this.txteva2.Name = "txteva2";
            this.txteva2.Size = new System.Drawing.Size(143, 20);
            this.txteva2.TabIndex = 9;
            // 
            // txteva1
            // 
            this.txteva1.Location = new System.Drawing.Point(55, 29);
            this.txteva1.Name = "txteva1";
            this.txteva1.Size = new System.Drawing.Size(143, 20);
            this.txteva1.TabIndex = 8;
            // 
            // cboAlumno
            // 
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(78, 77);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(335, 21);
            this.cboAlumno.TabIndex = 10;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(78, 142);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(335, 21);
            this.cboCurso.TabIndex = 11;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(22, 373);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 12;
            this.btnregistrar.Text = "registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 67);
            this.panel1.TabIndex = 13;
            // 
            // frmRegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistroNotas";
            this.Text = "Registro de Notas";
            this.Load += new System.EventHandler(this.CargarFormulario);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtparcial;
        private System.Windows.Forms.TextBox txteva2;
        private System.Windows.Forms.TextBox txteva1;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Panel panel1;
    }
}

