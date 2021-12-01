
namespace ExamenDos
{
    partial class FrmEstudiante
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegistrarAsignatura = new System.Windows.Forms.Button();
            this.nudSist = new System.Windows.Forms.NumericUpDown();
            this.nudPrimerp = new System.Windows.Forms.NumericUpDown();
            this.nud2doParcial = new System.Windows.Forms.NumericUpDown();
            this.lblClase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2doParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(127, 106);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(269, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(127, 157);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(269, 20);
            this.txtCarnet.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(127, 214);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(269, 20);
            this.txtMunicipio.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(127, 262);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(269, 20);
            this.txtDepartamento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Tag = "Canet";
            this.label2.Text = "Carnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Tag = "";
            this.label3.Text = "Municipio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Tag = "";
            this.label4.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Asignatura de ";
            // 
            // RegistrarAsignatura
            // 
            this.RegistrarAsignatura.Location = new System.Drawing.Point(657, 264);
            this.RegistrarAsignatura.Name = "RegistrarAsignatura";
            this.RegistrarAsignatura.Size = new System.Drawing.Size(196, 23);
            this.RegistrarAsignatura.TabIndex = 14;
            this.RegistrarAsignatura.Text = "RegistrarNOta";
            this.RegistrarAsignatura.UseVisualStyleBackColor = true;
            this.RegistrarAsignatura.Click += new System.EventHandler(this.RegistrarAsignatura_Click);
            // 
            // nudSist
            // 
            this.nudSist.Location = new System.Drawing.Point(647, 141);
            this.nudSist.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSist.Name = "nudSist";
            this.nudSist.Size = new System.Drawing.Size(221, 20);
            this.nudSist.TabIndex = 15;
            // 
            // nudPrimerp
            // 
            this.nudPrimerp.Location = new System.Drawing.Point(647, 167);
            this.nudPrimerp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPrimerp.Name = "nudPrimerp";
            this.nudPrimerp.Size = new System.Drawing.Size(221, 20);
            this.nudPrimerp.TabIndex = 16;
            // 
            // nud2doParcial
            // 
            this.nud2doParcial.Location = new System.Drawing.Point(647, 207);
            this.nud2doParcial.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud2doParcial.Name = "nud2doParcial";
            this.nud2doParcial.Size = new System.Drawing.Size(221, 20);
            this.nud2doParcial.TabIndex = 17;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(746, 41);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 18;
            this.lblClase.Text = "Clase";
            this.lblClase.Click += new System.EventHandler(this.lblClase_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.nud2doParcial);
            this.Controls.Add(this.nudPrimerp);
            this.Controls.Add(this.nudSist);
            this.Controls.Add(this.RegistrarAsignatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmEstudiante";
            this.Text = "FrmEstudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimerp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2doParcial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegistrarAsignatura;
        private System.Windows.Forms.NumericUpDown nudSist;
        private System.Windows.Forms.NumericUpDown nudPrimerp;
        private System.Windows.Forms.NumericUpDown nud2doParcial;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label label5;
    }
}