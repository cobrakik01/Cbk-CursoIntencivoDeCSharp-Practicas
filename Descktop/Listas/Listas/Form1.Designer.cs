namespace Listas
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 12);
            this.lbLista.Name = "lbLista";
            this.lbLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLista.Size = new System.Drawing.Size(195, 277);
            this.lbLista.TabIndex = 0;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAniadir.Location = new System.Drawing.Point(214, 13);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(100, 23);
            this.btnAniadir.TabIndex = 1;
            this.btnAniadir.Text = "&Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBorrar.Location = new System.Drawing.Point(214, 69);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "&Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDato.Location = new System.Drawing.Point(214, 43);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAniadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 300);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.lbLista);
            this.Name = "Form1";
            this.Text = "Ejemplo de Listas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtDato;
    }
}

