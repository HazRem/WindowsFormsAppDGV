﻿namespace WindowsFormsAppDGV
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.innDgv1 = new WindowsFormsAppDGV.InnDgv();
            this.SuspendLayout();
            // 
            // innDgv1
            // 
            this.innDgv1.DataSource = null;
            this.innDgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innDgv1.Location = new System.Drawing.Point(0, 0);
            this.innDgv1.Name = "innDgv1";
            this.innDgv1.Size = new System.Drawing.Size(1011, 545);
            this.innDgv1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 545);
            this.Controls.Add(this.innDgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InnDgv innDgv1;
    }
}

