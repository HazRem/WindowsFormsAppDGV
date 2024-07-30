﻿namespace WindowsFormsAppDGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxSortRadioButtons = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterOptions = new System.Windows.Forms.ComboBox();
            this.buttonAddSort = new System.Windows.Forms.Button();
            this.textBoxFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new WindowsFormsAppDGV.FlowLayoutPanelNoScrollbars();
            this.numericUpDownTakeTop = new System.Windows.Forms.NumericUpDown();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxSortRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeTop)).BeginInit();
            this.panelBot.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(995, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.flowLayoutPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(995, 98);
            this.panelTop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxSortRadioButtons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.panel2.Size = new System.Drawing.Size(995, 66);
            this.panel2.TabIndex = 7;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClearSearch.FlatAppearance.BorderSize = 0;
            this.buttonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.buttonClearSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearSearch.Location = new System.Drawing.Point(223, 39);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(17, 17);
            this.buttonClearSearch.TabIndex = 8;
            this.buttonClearSearch.Text = "X";
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(81, 37);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(140, 20);
            this.textBoxSearch.TabIndex = 6;
            // 
            // groupBoxSortRadioButtons
            // 
            this.groupBoxSortRadioButtons.Controls.Add(this.buttonClearSearch);
            this.groupBoxSortRadioButtons.Controls.Add(this.comboBoxFilterOptions);
            this.groupBoxSortRadioButtons.Controls.Add(this.label3);
            this.groupBoxSortRadioButtons.Controls.Add(this.buttonAddSort);
            this.groupBoxSortRadioButtons.Controls.Add(this.textBoxSearch);
            this.groupBoxSortRadioButtons.Controls.Add(this.textBoxFilterValue);
            this.groupBoxSortRadioButtons.Controls.Add(this.label1);
            this.groupBoxSortRadioButtons.Controls.Add(this.comboBox1);
            this.groupBoxSortRadioButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSortRadioButtons.Location = new System.Drawing.Point(0, 2);
            this.groupBoxSortRadioButtons.Name = "groupBoxSortRadioButtons";
            this.groupBoxSortRadioButtons.Size = new System.Drawing.Size(535, 62);
            this.groupBoxSortRadioButtons.TabIndex = 3;
            this.groupBoxSortRadioButtons.TabStop = false;
            // 
            // comboBoxFilterOptions
            // 
            this.comboBoxFilterOptions.FormattingEnabled = true;
            this.comboBoxFilterOptions.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "STARTS WITH",
            "DOESN\'T START WITH",
            "ENDS WITH",
            "DOESN\'T END WITH",
            "CONTAINS",
            "DOESN\'T CONTAIN",
            "ASC",
            "DESC"});
            this.comboBoxFilterOptions.Location = new System.Drawing.Point(211, 10);
            this.comboBoxFilterOptions.Name = "comboBoxFilterOptions";
            this.comboBoxFilterOptions.Size = new System.Drawing.Size(112, 21);
            this.comboBoxFilterOptions.TabIndex = 6;
            this.comboBoxFilterOptions.Text = "=";
            // 
            // buttonAddSort
            // 
            this.buttonAddSort.Location = new System.Drawing.Point(473, 10);
            this.buttonAddSort.Name = "buttonAddSort";
            this.buttonAddSort.Size = new System.Drawing.Size(58, 23);
            this.buttonAddSort.TabIndex = 4;
            this.buttonAddSort.Text = "Add";
            this.buttonAddSort.UseVisualStyleBackColor = true;
            this.buttonAddSort.Click += new System.EventHandler(this.buttonAddSort_Click);
            // 
            // textBoxFilterValue
            // 
            this.textBoxFilterValue.Location = new System.Drawing.Point(329, 11);
            this.textBoxFilterValue.Name = "textBoxFilterValue";
            this.textBoxFilterValue.Size = new System.Drawing.Size(140, 20);
            this.textBoxFilterValue.TabIndex = 5;
            this.textBoxFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add to filter:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(995, 30);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // numericUpDownTakeTop
            // 
            this.numericUpDownTakeTop.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTakeTop.Location = new System.Drawing.Point(46, 3);
            this.numericUpDownTakeTop.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownTakeTop.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTakeTop.Name = "numericUpDownTakeTop";
            this.numericUpDownTakeTop.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownTakeTop.TabIndex = 5;
            this.numericUpDownTakeTop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownTakeTop.ValueChanged += new System.EventHandler(this.numericUpDownTakeTop_ValueChanged);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.panel3);
            this.panelBot.Controls.Add(this.statusStrip1);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 526);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(995, 46);
            this.panelBot.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownTakeTop);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(896, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 24);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(995, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel1.Tag = "";
            this.toolStripStatusLabel1.Text = "---";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "---";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(936, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 428);
            this.panel1.TabIndex = 3;
            // 
            // InnDgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Name = "InnDgv";
            this.Size = new System.Drawing.Size(995, 572);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxSortRadioButtons.ResumeLayout(false);
            this.groupBoxSortRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTakeTop)).EndInit();
            this.panelBot.ResumeLayout(false);
            this.panelBot.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxSortRadioButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSort;
        private System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.NumericUpDown numericUpDownTakeTop;
        private System.Windows.Forms.ComboBox comboBoxFilterOptions;
        private FlowLayoutPanelNoScrollbars flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}
