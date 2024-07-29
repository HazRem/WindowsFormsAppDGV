namespace WindowsFormsAppDGV
{
    partial class InnDgv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonAddSort = new System.Windows.Forms.Button();
            this.groupBoxSortRadioButtons = new System.Windows.Forms.GroupBox();
            this.textBoxFilterValue = new System.Windows.Forms.TextBox();
            this.radioButtonLessThan = new System.Windows.Forms.RadioButton();
            this.radioButtonMoreThan = new System.Windows.Forms.RadioButton();
            this.radioButtonEqualTo = new System.Windows.Forms.RadioButton();
            this.radioButtonSortDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAsc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownTakeTop = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.groupBoxSortRadioButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.numericUpDownTakeTop);
            this.panelTop.Controls.Add(this.buttonAddSort);
            this.panelTop.Controls.Add(this.groupBoxSortRadioButtons);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.flowLayoutPanel1);
            this.panelTop.Controls.Add(this.comboBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelTop.Size = new System.Drawing.Size(843, 66);
            this.panelTop.TabIndex = 1;
            // 
            // buttonAddSort
            // 
            this.buttonAddSort.Location = new System.Drawing.Point(620, 9);
            this.buttonAddSort.Name = "buttonAddSort";
            this.buttonAddSort.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSort.TabIndex = 4;
            this.buttonAddSort.Text = "Add";
            this.buttonAddSort.UseVisualStyleBackColor = true;
            this.buttonAddSort.Click += new System.EventHandler(this.buttonAddSort_Click);
            // 
            // groupBoxSortRadioButtons
            // 
            this.groupBoxSortRadioButtons.Controls.Add(this.textBoxFilterValue);
            this.groupBoxSortRadioButtons.Controls.Add(this.radioButtonLessThan);
            this.groupBoxSortRadioButtons.Controls.Add(this.radioButtonMoreThan);
            this.groupBoxSortRadioButtons.Controls.Add(this.radioButtonEqualTo);
            this.groupBoxSortRadioButtons.Controls.Add(this.radioButtonSortDesc);
            this.groupBoxSortRadioButtons.Controls.Add(this.radioButtonSortAsc);
            this.groupBoxSortRadioButtons.Location = new System.Drawing.Point(239, 0);
            this.groupBoxSortRadioButtons.Name = "groupBoxSortRadioButtons";
            this.groupBoxSortRadioButtons.Size = new System.Drawing.Size(375, 38);
            this.groupBoxSortRadioButtons.TabIndex = 3;
            this.groupBoxSortRadioButtons.TabStop = false;
            this.groupBoxSortRadioButtons.Text = "Sort/Filter";
            // 
            // textBoxFilterValue
            // 
            this.textBoxFilterValue.Enabled = false;
            this.textBoxFilterValue.Location = new System.Drawing.Point(229, 12);
            this.textBoxFilterValue.Name = "textBoxFilterValue";
            this.textBoxFilterValue.Size = new System.Drawing.Size(140, 20);
            this.textBoxFilterValue.TabIndex = 5;
            // 
            // radioButtonLessThan
            // 
            this.radioButtonLessThan.AutoSize = true;
            this.radioButtonLessThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.radioButtonLessThan.Location = new System.Drawing.Point(192, 15);
            this.radioButtonLessThan.Name = "radioButtonLessThan";
            this.radioButtonLessThan.Size = new System.Drawing.Size(31, 17);
            this.radioButtonLessThan.TabIndex = 4;
            this.radioButtonLessThan.Text = "<";
            this.radioButtonLessThan.UseVisualStyleBackColor = true;
            this.radioButtonLessThan.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonMoreThan
            // 
            this.radioButtonMoreThan.AutoSize = true;
            this.radioButtonMoreThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.radioButtonMoreThan.Location = new System.Drawing.Point(155, 15);
            this.radioButtonMoreThan.Name = "radioButtonMoreThan";
            this.radioButtonMoreThan.Size = new System.Drawing.Size(31, 17);
            this.radioButtonMoreThan.TabIndex = 3;
            this.radioButtonMoreThan.Text = ">";
            this.radioButtonMoreThan.UseVisualStyleBackColor = true;
            this.radioButtonMoreThan.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonEqualTo
            // 
            this.radioButtonEqualTo.AutoSize = true;
            this.radioButtonEqualTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.radioButtonEqualTo.Location = new System.Drawing.Point(118, 15);
            this.radioButtonEqualTo.Name = "radioButtonEqualTo";
            this.radioButtonEqualTo.Size = new System.Drawing.Size(31, 17);
            this.radioButtonEqualTo.TabIndex = 2;
            this.radioButtonEqualTo.Text = "=";
            this.radioButtonEqualTo.UseVisualStyleBackColor = true;
            this.radioButtonEqualTo.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonSortDesc
            // 
            this.radioButtonSortDesc.AutoSize = true;
            this.radioButtonSortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.radioButtonSortDesc.Location = new System.Drawing.Point(58, 15);
            this.radioButtonSortDesc.Name = "radioButtonSortDesc";
            this.radioButtonSortDesc.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSortDesc.TabIndex = 1;
            this.radioButtonSortDesc.Text = "DESC";
            this.radioButtonSortDesc.UseVisualStyleBackColor = true;
            this.radioButtonSortDesc.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // radioButtonSortAsc
            // 
            this.radioButtonSortAsc.AutoSize = true;
            this.radioButtonSortAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.radioButtonSortAsc.Location = new System.Drawing.Point(6, 15);
            this.radioButtonSortAsc.Name = "radioButtonSortAsc";
            this.radioButtonSortAsc.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSortAsc.TabIndex = 0;
            this.radioButtonSortAsc.Text = "ASC";
            this.radioButtonSortAsc.UseVisualStyleBackColor = true;
            this.radioButtonSortAsc.CheckedChanged += new System.EventHandler(this.radioButtonSort_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add to filter:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(843, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panelBot
            // 
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 344);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(843, 52);
            this.panelBot.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 278);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDownTakeTop
            // 
            this.numericUpDownTakeTop.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTakeTop.Location = new System.Drawing.Point(788, 15);
            this.numericUpDownTakeTop.Name = "numericUpDownTakeTop";
            this.numericUpDownTakeTop.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownTakeTop.TabIndex = 5;
            this.numericUpDownTakeTop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // InnDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Name = "InnDgv";
            this.Size = new System.Drawing.Size(843, 396);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxSortRadioButtons.ResumeLayout(false);
            this.groupBoxSortRadioButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxSortRadioButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSortDesc;
        private System.Windows.Forms.RadioButton radioButtonSortAsc;
        private System.Windows.Forms.Button buttonAddSort;
        private System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.RadioButton radioButtonLessThan;
        private System.Windows.Forms.RadioButton radioButtonMoreThan;
        private System.Windows.Forms.RadioButton radioButtonEqualTo;
        private System.Windows.Forms.NumericUpDown numericUpDownTakeTop;
    }
}
