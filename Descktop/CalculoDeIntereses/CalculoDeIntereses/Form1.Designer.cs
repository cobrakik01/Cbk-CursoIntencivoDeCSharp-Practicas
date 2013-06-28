namespace CalculoDeIntereses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.txtTasaIntereses = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAnios = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaldoAnual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tasa Intereses";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(86, 12);
            this.txtPrincipal.Mask = "00000";
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(176, 20);
            this.txtPrincipal.TabIndex = 2;
            this.txtPrincipal.ValidatingType = typeof(int);
            // 
            // txtTasaIntereses
            // 
            this.txtTasaIntereses.Location = new System.Drawing.Point(86, 38);
            this.txtTasaIntereses.Mask = "00000";
            this.txtTasaIntereses.Name = "txtTasaIntereses";
            this.txtTasaIntereses.Size = new System.Drawing.Size(176, 20);
            this.txtTasaIntereses.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Años";
            // 
            // nudAnios
            // 
            this.nudAnios.Location = new System.Drawing.Point(86, 67);
            this.nudAnios.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnios.Name = "nudAnios";
            this.nudAnios.Size = new System.Drawing.Size(120, 20);
            this.nudAnios.TabIndex = 5;
            this.nudAnios.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(268, 12);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSaldoAnual);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo anual de la cuenta";
            // 
            // txtSaldoAnual
            // 
            this.txtSaldoAnual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSaldoAnual.Location = new System.Drawing.Point(3, 16);
            this.txtSaldoAnual.Multiline = true;
            this.txtSaldoAnual.Name = "txtSaldoAnual";
            this.txtSaldoAnual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSaldoAnual.Size = new System.Drawing.Size(348, 201);
            this.txtSaldoAnual.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudAnios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTasaIntereses);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Intereses";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPrincipal;
        private System.Windows.Forms.MaskedTextBox txtTasaIntereses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAnios;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSaldoAnual;
    }
}

