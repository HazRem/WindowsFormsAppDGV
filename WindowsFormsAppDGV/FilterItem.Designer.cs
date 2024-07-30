namespace WindowsFormsAppDGV
{
    partial class FilterItem
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelBorderBot = new System.Windows.Forms.Panel();
            this.panelBorderTop = new System.Windows.Forms.Panel();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.checkBoxApply = new System.Windows.Forms.CheckBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(101, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(19, 24);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMoveRight.FlatAppearance.BorderSize = 0;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveRight.Location = new System.Drawing.Point(82, 0);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(19, 24);
            this.buttonMoveRight.TabIndex = 2;
            this.buttonMoveRight.Text = ">";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMoveLeft.FlatAppearance.BorderSize = 0;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveLeft.Location = new System.Drawing.Point(63, 0);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(19, 24);
            this.buttonMoveLeft.TabIndex = 3;
            this.buttonMoveLeft.Text = "<";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(121, 1);
            this.panelBorderRight.MaximumSize = new System.Drawing.Size(1, 0);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(1, 24);
            this.panelBorderRight.TabIndex = 4;
            // 
            // panelBorderBot
            // 
            this.panelBorderBot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBorderBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBot.Location = new System.Drawing.Point(1, 25);
            this.panelBorderBot.MaximumSize = new System.Drawing.Size(0, 1);
            this.panelBorderBot.Name = "panelBorderBot";
            this.panelBorderBot.Size = new System.Drawing.Size(121, 1);
            this.panelBorderBot.TabIndex = 5;
            // 
            // panelBorderTop
            // 
            this.panelBorderTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderTop.Location = new System.Drawing.Point(0, 0);
            this.panelBorderTop.MaximumSize = new System.Drawing.Size(0, 1);
            this.panelBorderTop.Name = "panelBorderTop";
            this.panelBorderTop.Size = new System.Drawing.Size(122, 1);
            this.panelBorderTop.TabIndex = 6;
            // 
            // panelBorderLeft
            // 
            this.panelBorderLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorderLeft.Location = new System.Drawing.Point(0, 1);
            this.panelBorderLeft.MaximumSize = new System.Drawing.Size(1, 0);
            this.panelBorderLeft.Name = "panelBorderLeft";
            this.panelBorderLeft.Size = new System.Drawing.Size(1, 25);
            this.panelBorderLeft.TabIndex = 5;
            // 
            // checkBoxApply
            // 
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxApply.Checked = true;
            this.checkBoxApply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxApply.Location = new System.Drawing.Point(0, 0);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.checkBoxApply.Size = new System.Drawing.Size(20, 24);
            this.checkBoxApply.TabIndex = 7;
            this.checkBoxApply.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.checkBoxApply);
            this.panelContent.Controls.Add(this.buttonMoveLeft);
            this.panelContent.Controls.Add(this.buttonMoveRight);
            this.panelContent.Controls.Add(this.buttonDelete);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(1, 1);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(120, 24);
            this.panelContent.TabIndex = 8;
            // 
            // FilterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelBorderRight);
            this.Controls.Add(this.panelBorderBot);
            this.Controls.Add(this.panelBorderLeft);
            this.Controls.Add(this.panelBorderTop);
            this.Name = "FilterItem";
            this.Size = new System.Drawing.Size(122, 26);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel panelBorderBot;
        private System.Windows.Forms.Panel panelBorderTop;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.CheckBox checkBoxApply;
        private System.Windows.Forms.Panel panelContent;
    }
}
