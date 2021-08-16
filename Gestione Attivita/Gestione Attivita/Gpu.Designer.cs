
namespace Gestione_Attivita
{
    partial class Gpu
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
            this.prova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prova
            // 
            this.prova.AutoSize = true;
            this.prova.Location = new System.Drawing.Point(341, 227);
            this.prova.Name = "prova";
            this.prova.Size = new System.Drawing.Size(35, 13);
            this.prova.TabIndex = 0;
            this.prova.Text = "label1";
            // 
            // Gpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prova);
            this.Name = "Gpu";
            this.Text = "Gpu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prova;
    }
}