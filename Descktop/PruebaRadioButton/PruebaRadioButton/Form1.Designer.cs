namespace PruebaRadioButton
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
            this.rbReintentarCancelar = new System.Windows.Forms.RadioButton();
            this.rbSiNo = new System.Windows.Forms.RadioButton();
            this.rbSiNoCancelar = new System.Windows.Forms.RadioButton();
            this.rbAbortarReintentarIgnorar = new System.Windows.Forms.RadioButton();
            this.rbAceptarCancelar = new System.Windows.Forms.RadioButton();
            this.rbAceptar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAdvertencia = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.rbPregunta = new System.Windows.Forms.RadioButton();
            this.rbInformacion = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbExclamacion = new System.Windows.Forms.RadioButton();
            this.rbMano = new System.Windows.Forms.RadioButton();
            this.rbAsterisco = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblBotonOprimido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbReintentarCancelar);
            this.groupBox1.Controls.Add(this.rbSiNo);
            this.groupBox1.Controls.Add(this.rbSiNoCancelar);
            this.groupBox1.Controls.Add(this.rbAbortarReintentarIgnorar);
            this.groupBox1.Controls.Add(this.rbAceptarCancelar);
            this.groupBox1.Controls.Add(this.rbAceptar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de botón a mostrar";
            // 
            // rbReintentarCancelar
            // 
            this.rbReintentarCancelar.AutoSize = true;
            this.rbReintentarCancelar.Location = new System.Drawing.Point(18, 144);
            this.rbReintentarCancelar.Name = "rbReintentarCancelar";
            this.rbReintentarCancelar.Size = new System.Drawing.Size(122, 17);
            this.rbReintentarCancelar.TabIndex = 5;
            this.rbReintentarCancelar.TabStop = true;
            this.rbReintentarCancelar.Text = "Reintentar, Cancelar";
            this.rbReintentarCancelar.UseVisualStyleBackColor = true;
            this.rbReintentarCancelar.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // rbSiNo
            // 
            this.rbSiNo.AutoSize = true;
            this.rbSiNo.Location = new System.Drawing.Point(18, 121);
            this.rbSiNo.Name = "rbSiNo";
            this.rbSiNo.Size = new System.Drawing.Size(54, 17);
            this.rbSiNo.TabIndex = 4;
            this.rbSiNo.TabStop = true;
            this.rbSiNo.Text = "Si, No";
            this.rbSiNo.UseVisualStyleBackColor = true;
            this.rbSiNo.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // rbSiNoCancelar
            // 
            this.rbSiNoCancelar.AutoSize = true;
            this.rbSiNoCancelar.Location = new System.Drawing.Point(18, 98);
            this.rbSiNoCancelar.Name = "rbSiNoCancelar";
            this.rbSiNoCancelar.Size = new System.Drawing.Size(102, 17);
            this.rbSiNoCancelar.TabIndex = 3;
            this.rbSiNoCancelar.TabStop = true;
            this.rbSiNoCancelar.Text = "Si, No, Cancelar";
            this.rbSiNoCancelar.UseVisualStyleBackColor = true;
            this.rbSiNoCancelar.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // rbAbortarReintentarIgnorar
            // 
            this.rbAbortarReintentarIgnorar.AutoSize = true;
            this.rbAbortarReintentarIgnorar.Location = new System.Drawing.Point(18, 75);
            this.rbAbortarReintentarIgnorar.Name = "rbAbortarReintentarIgnorar";
            this.rbAbortarReintentarIgnorar.Size = new System.Drawing.Size(153, 17);
            this.rbAbortarReintentarIgnorar.TabIndex = 2;
            this.rbAbortarReintentarIgnorar.TabStop = true;
            this.rbAbortarReintentarIgnorar.Text = "Abortar, Reintentar, Ignorar";
            this.rbAbortarReintentarIgnorar.UseVisualStyleBackColor = true;
            this.rbAbortarReintentarIgnorar.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // rbAceptarCancelar
            // 
            this.rbAceptarCancelar.AutoSize = true;
            this.rbAceptarCancelar.Location = new System.Drawing.Point(18, 52);
            this.rbAceptarCancelar.Name = "rbAceptarCancelar";
            this.rbAceptarCancelar.Size = new System.Drawing.Size(110, 17);
            this.rbAceptarCancelar.TabIndex = 1;
            this.rbAceptarCancelar.TabStop = true;
            this.rbAceptarCancelar.Text = "Aceptar, Cancelar";
            this.rbAceptarCancelar.UseVisualStyleBackColor = true;
            this.rbAceptarCancelar.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // rbAceptar
            // 
            this.rbAceptar.AutoSize = true;
            this.rbAceptar.Location = new System.Drawing.Point(18, 29);
            this.rbAceptar.Name = "rbAceptar";
            this.rbAceptar.Size = new System.Drawing.Size(62, 17);
            this.rbAceptar.TabIndex = 0;
            this.rbAceptar.TabStop = true;
            this.rbAceptar.Text = "Aceptar";
            this.rbAceptar.UseVisualStyleBackColor = true;
            this.rbAceptar.CheckedChanged += new System.EventHandler(this.TipoBotonCheckedChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbAdvertencia);
            this.groupBox2.Controls.Add(this.rbAlto);
            this.groupBox2.Controls.Add(this.rbPregunta);
            this.groupBox2.Controls.Add(this.rbInformacion);
            this.groupBox2.Controls.Add(this.rbError);
            this.groupBox2.Controls.Add(this.rbExclamacion);
            this.groupBox2.Controls.Add(this.rbMano);
            this.groupBox2.Controls.Add(this.rbAsterisco);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icono";
            // 
            // rbAdvertencia
            // 
            this.rbAdvertencia.AutoSize = true;
            this.rbAdvertencia.Location = new System.Drawing.Point(6, 180);
            this.rbAdvertencia.Name = "rbAdvertencia";
            this.rbAdvertencia.Size = new System.Drawing.Size(82, 17);
            this.rbAdvertencia.TabIndex = 7;
            this.rbAdvertencia.TabStop = true;
            this.rbAdvertencia.Text = "Advertencia";
            this.rbAdvertencia.UseVisualStyleBackColor = true;
            this.rbAdvertencia.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.Location = new System.Drawing.Point(6, 157);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(43, 17);
            this.rbAlto.TabIndex = 6;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Alto";
            this.rbAlto.UseVisualStyleBackColor = true;
            this.rbAlto.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbPregunta
            // 
            this.rbPregunta.AutoSize = true;
            this.rbPregunta.Location = new System.Drawing.Point(6, 134);
            this.rbPregunta.Name = "rbPregunta";
            this.rbPregunta.Size = new System.Drawing.Size(68, 17);
            this.rbPregunta.TabIndex = 5;
            this.rbPregunta.TabStop = true;
            this.rbPregunta.Text = "Pregunta";
            this.rbPregunta.UseVisualStyleBackColor = true;
            this.rbPregunta.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbInformacion
            // 
            this.rbInformacion.AutoSize = true;
            this.rbInformacion.Location = new System.Drawing.Point(6, 111);
            this.rbInformacion.Name = "rbInformacion";
            this.rbInformacion.Size = new System.Drawing.Size(80, 17);
            this.rbInformacion.TabIndex = 4;
            this.rbInformacion.TabStop = true;
            this.rbInformacion.Text = "Informacion";
            this.rbInformacion.UseVisualStyleBackColor = true;
            this.rbInformacion.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(6, 39);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(47, 17);
            this.rbError.TabIndex = 3;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            this.rbError.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbExclamacion
            // 
            this.rbExclamacion.AutoSize = true;
            this.rbExclamacion.Location = new System.Drawing.Point(6, 65);
            this.rbExclamacion.Name = "rbExclamacion";
            this.rbExclamacion.Size = new System.Drawing.Size(85, 17);
            this.rbExclamacion.TabIndex = 2;
            this.rbExclamacion.TabStop = true;
            this.rbExclamacion.Text = "Exclamacion";
            this.rbExclamacion.UseVisualStyleBackColor = true;
            this.rbExclamacion.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbMano
            // 
            this.rbMano.AutoSize = true;
            this.rbMano.Location = new System.Drawing.Point(6, 88);
            this.rbMano.Name = "rbMano";
            this.rbMano.Size = new System.Drawing.Size(52, 17);
            this.rbMano.TabIndex = 1;
            this.rbMano.TabStop = true;
            this.rbMano.Text = "Mano";
            this.rbMano.UseVisualStyleBackColor = true;
            this.rbMano.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // rbAsterisco
            // 
            this.rbAsterisco.AutoSize = true;
            this.rbAsterisco.Location = new System.Drawing.Point(6, 16);
            this.rbAsterisco.Name = "rbAsterisco";
            this.rbAsterisco.Size = new System.Drawing.Size(68, 17);
            this.rbAsterisco.TabIndex = 0;
            this.rbAsterisco.TabStop = true;
            this.rbAsterisco.Text = "Asterisco";
            this.rbAsterisco.UseVisualStyleBackColor = true;
            this.rbAsterisco.CheckedChanged += new System.EventHandler(this.IconoCheckedChange);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrar.Location = new System.Drawing.Point(12, 215);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(200, 44);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblBotonOprimido
            // 
            this.lblBotonOprimido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBotonOprimido.AutoSize = true;
            this.lblBotonOprimido.Location = new System.Drawing.Point(13, 266);
            this.lblBotonOprimido.Name = "lblBotonOprimido";
            this.lblBotonOprimido.Size = new System.Drawing.Size(79, 13);
            this.lblBotonOprimido.TabIndex = 9;
            this.lblBotonOprimido.Text = "Boton Oprimido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 298);
            this.Controls.Add(this.lblBotonOprimido);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Prueba RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAbortarReintentarIgnorar;
        private System.Windows.Forms.RadioButton rbAceptarCancelar;
        private System.Windows.Forms.RadioButton rbAceptar;
        private System.Windows.Forms.RadioButton rbSiNoCancelar;
        private System.Windows.Forms.RadioButton rbReintentarCancelar;
        private System.Windows.Forms.RadioButton rbSiNo;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbExclamacion;
        private System.Windows.Forms.RadioButton rbMano;
        private System.Windows.Forms.RadioButton rbAsterisco;
        private System.Windows.Forms.RadioButton rbInformacion;
        private System.Windows.Forms.RadioButton rbAdvertencia;
        private System.Windows.Forms.RadioButton rbAlto;
        private System.Windows.Forms.RadioButton rbPregunta;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblBotonOprimido;
    }
}

