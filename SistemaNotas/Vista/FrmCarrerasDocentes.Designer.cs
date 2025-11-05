namespace SistemaNotas.Vista
{
    partial class FrmCarrerasDocentes
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
            this.tvCarreras = new System.Windows.Forms.TreeView();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tvCarreras
            // 
            this.tvCarreras.Location = new System.Drawing.Point(23, 22);
            this.tvCarreras.Name = "tvCarreras";
            this.tvCarreras.Size = new System.Drawing.Size(288, 416);
            this.tvCarreras.TabIndex = 0;
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.ItemHeight = 16;
            this.lbDocentes.Location = new System.Drawing.Point(425, 27);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(312, 404);
            this.lbDocentes.TabIndex = 1;
            // 
            // FrmCarrerasDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.tvCarreras);
            this.Name = "FrmCarrerasDocentes";
            this.Text = "Carreras - Docentes";
            this.Load += new System.EventHandler(this.FrmCarrerasDocentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvCarreras;
        private System.Windows.Forms.ListBox lbDocentes;
    }
}