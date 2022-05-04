namespace DesviacionEstandar
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtCantPersonas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesvMuestra = new System.Windows.Forms.Label();
            this.desvMuestra = new System.Windows.Forms.Label();
            this.txtVarMuestra = new System.Windows.Forms.Label();
            this.VarMuestra = new System.Windows.Forms.Label();
            this.cboAlturas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVar = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDesv = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.Label();
            this.cboDentro = new System.Windows.Forms.ComboBox();
            this.cboAbajo = new System.Windows.Forms.ComboBox();
            this.cboArriba = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.varianza = new System.Windows.Forms.Label();
            this.desviacion = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtCantPersonas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(205, 40);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 20);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCantPersonas
            // 
            this.txtCantPersonas.Location = new System.Drawing.Point(123, 40);
            this.txtCantPersonas.Name = "txtCantPersonas";
            this.txtCantPersonas.Size = new System.Drawing.Size(56, 20);
            this.txtCantPersonas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Personas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtDesvMuestra);
            this.groupBox2.Controls.Add(this.desvMuestra);
            this.groupBox2.Controls.Add(this.txtVarMuestra);
            this.groupBox2.Controls.Add(this.VarMuestra);
            this.groupBox2.Controls.Add(this.cboAlturas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtVar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.txtDesv);
            this.groupBox2.Controls.Add(this.txtMedia);
            this.groupBox2.Controls.Add(this.cboDentro);
            this.groupBox2.Controls.Add(this.cboAbajo);
            this.groupBox2.Controls.Add(this.cboArriba);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.varianza);
            this.groupBox2.Controls.Add(this.desviacion);
            this.groupBox2.Controls.Add(this.media);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 349);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muestra de datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDesvMuestra
            // 
            this.txtDesvMuestra.AutoSize = true;
            this.txtDesvMuestra.Location = new System.Drawing.Point(290, 141);
            this.txtDesvMuestra.Name = "txtDesvMuestra";
            this.txtDesvMuestra.Size = new System.Drawing.Size(0, 13);
            this.txtDesvMuestra.TabIndex = 19;
            // 
            // desvMuestra
            // 
            this.desvMuestra.AutoSize = true;
            this.desvMuestra.Location = new System.Drawing.Point(202, 141);
            this.desvMuestra.Name = "desvMuestra";
            this.desvMuestra.Size = new System.Drawing.Size(75, 13);
            this.desvMuestra.TabIndex = 18;
            this.desvMuestra.Text = "Desviación M:";
            // 
            // txtVarMuestra
            // 
            this.txtVarMuestra.AutoSize = true;
            this.txtVarMuestra.Location = new System.Drawing.Point(280, 101);
            this.txtVarMuestra.Name = "txtVarMuestra";
            this.txtVarMuestra.Size = new System.Drawing.Size(0, 13);
            this.txtVarMuestra.TabIndex = 17;
            // 
            // VarMuestra
            // 
            this.VarMuestra.AutoSize = true;
            this.VarMuestra.Location = new System.Drawing.Point(202, 101);
            this.VarMuestra.Name = "VarMuestra";
            this.VarMuestra.Size = new System.Drawing.Size(63, 13);
            this.VarMuestra.TabIndex = 16;
            this.VarMuestra.Text = "Varianza M:";
            // 
            // cboAlturas
            // 
            this.cboAlturas.FormattingEnabled = true;
            this.cboAlturas.Location = new System.Drawing.Point(205, 51);
            this.cboAlturas.Name = "cboAlturas";
            this.cboAlturas.Size = new System.Drawing.Size(121, 21);
            this.cboAlturas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alturas Ingresadas";
            // 
            // txtVar
            // 
            this.txtVar.AutoSize = true;
            this.txtVar.Location = new System.Drawing.Point(85, 101);
            this.txtVar.Name = "txtVar";
            this.txtVar.Size = new System.Drawing.Size(0, 13);
            this.txtVar.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDesv
            // 
            this.txtDesv.AutoSize = true;
            this.txtDesv.Location = new System.Drawing.Point(99, 141);
            this.txtDesv.Name = "txtDesv";
            this.txtDesv.Size = new System.Drawing.Size(0, 13);
            this.txtDesv.TabIndex = 11;
            // 
            // txtMedia
            // 
            this.txtMedia.AutoSize = true;
            this.txtMedia.Location = new System.Drawing.Point(85, 59);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(0, 13);
            this.txtMedia.TabIndex = 10;
            // 
            // cboDentro
            // 
            this.cboDentro.FormattingEnabled = true;
            this.cboDentro.Location = new System.Drawing.Point(240, 234);
            this.cboDentro.Name = "cboDentro";
            this.cboDentro.Size = new System.Drawing.Size(102, 21);
            this.cboDentro.TabIndex = 9;
            this.cboDentro.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cboAbajo
            // 
            this.cboAbajo.FormattingEnabled = true;
            this.cboAbajo.Location = new System.Drawing.Point(132, 234);
            this.cboAbajo.Name = "cboAbajo";
            this.cboAbajo.Size = new System.Drawing.Size(102, 21);
            this.cboAbajo.TabIndex = 8;
            // 
            // cboArriba
            // 
            this.cboArriba.FormattingEnabled = true;
            this.cboArriba.Location = new System.Drawing.Point(24, 234);
            this.cboArriba.Name = "cboArriba";
            this.cboArriba.Size = new System.Drawing.Size(102, 21);
            this.cboArriba.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dentro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Por debajo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Por arriba";
            // 
            // varianza
            // 
            this.varianza.AutoSize = true;
            this.varianza.Location = new System.Drawing.Point(9, 101);
            this.varianza.Name = "varianza";
            this.varianza.Size = new System.Drawing.Size(51, 13);
            this.varianza.TabIndex = 3;
            this.varianza.Text = "Varianza:";
            this.varianza.Click += new System.EventHandler(this.label4_Click);
            // 
            // desviacion
            // 
            this.desviacion.AutoSize = true;
            this.desviacion.Location = new System.Drawing.Point(9, 141);
            this.desviacion.Name = "desviacion";
            this.desviacion.Size = new System.Drawing.Size(73, 13);
            this.desviacion.TabIndex = 2;
            this.desviacion.Text = "Desviación P:";
            // 
            // media
            // 
            this.media.AutoSize = true;
            this.media.Location = new System.Drawing.Point(9, 59);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(49, 13);
            this.media.TabIndex = 1;
            this.media.Text = "Media P:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(267, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de Desviacion Estandar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtCantPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDentro;
        private System.Windows.Forms.ComboBox cboAbajo;
        private System.Windows.Forms.ComboBox cboArriba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label varianza;
        private System.Windows.Forms.Label desviacion;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.Label txtDesv;
        private System.Windows.Forms.Label txtMedia;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label txtVar;
        private System.Windows.Forms.ComboBox cboAlturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtVarMuestra;
        private System.Windows.Forms.Label VarMuestra;
        private System.Windows.Forms.Label txtDesvMuestra;
        private System.Windows.Forms.Label desvMuestra;
    }
}