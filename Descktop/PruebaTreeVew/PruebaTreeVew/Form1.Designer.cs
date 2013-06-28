namespace PruebaTreeVew
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
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.tvCarpetas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectorio.Location = new System.Drawing.Point(15, 43);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(247, 20);
            this.txtDirectorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe la ruta completa de la carpeta que quieres examinar";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.Location = new System.Drawing.Point(268, 40);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(114, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar Carpeta";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // tvCarpetas
            // 
            this.tvCarpetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvCarpetas.Location = new System.Drawing.Point(12, 69);
            this.tvCarpetas.Name = "tvCarpetas";
            this.tvCarpetas.Size = new System.Drawing.Size(367, 268);
            this.tvCarpetas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnExaminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 349);
            this.Controls.Add(this.tvCarpetas);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prueba TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TreeView tvCarpetas;
    }
}

