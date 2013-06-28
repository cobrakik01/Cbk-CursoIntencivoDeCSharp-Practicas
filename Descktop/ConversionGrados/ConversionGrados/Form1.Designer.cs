namespace ConversionGrados
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCentigrados = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.proveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDeError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados centigrados";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Fahrenheit";
            // 
            // txtCentigrados
            // 
            this.txtCentigrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCentigrados.Location = new System.Drawing.Point(142, 42);
            this.txtCentigrados.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtCentigrados.Name = "txtCentigrados";
            this.txtCentigrados.Size = new System.Drawing.Size(210, 20);
            this.txtCentigrados.TabIndex = 2;
            this.txtCentigrados.Text = "0.00";
            this.txtCentigrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCentigrados.TextChanged += new System.EventHandler(this.txtCentigrados_TextAlignChanged);
            this.txtCentigrados.Validating += new System.ComponentModel.CancelEventHandler(this.CajaTexto_Validating);
            this.txtCentigrados.Validated += new System.EventHandler(this.CajaTexto_Validated);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFahrenheit.Location = new System.Drawing.Point(142, 73);
            this.txtFahrenheit.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(210, 20);
            this.txtFahrenheit.TabIndex = 3;
            this.txtFahrenheit.Text = "32.00";
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFahrenheit.TextChanged += new System.EventHandler(this.txtCentigrados_TextAlignChanged);
            this.txtFahrenheit.Validating += new System.ComponentModel.CancelEventHandler(this.CajaTexto_Validating);
            this.txtFahrenheit.Validated += new System.EventHandler(this.CajaTexto_Validated);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(142, 112);
            this.btnAceptar.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(210, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // proveedorDeError
            // 
            this.proveedorDeError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(405, 168);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCentigrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de grados";
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCentigrados;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider proveedorDeError;
    }
}

