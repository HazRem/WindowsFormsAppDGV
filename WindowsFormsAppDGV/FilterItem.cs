using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsAppDGV
{
    public partial class FilterItem : UserControl
    {
        public event EventHandler FilterChanged;

        private ControlCollection parentControlCollection;
        public string ColumnName { get; set; }
        public string SortFilterType { get; set; }
        private string value;
        public string Value
        {
            get { return value; }
            set
            {
                this.value = value;
                UpdateLabelText();
            }
        }
        public bool IsChecked
        {
            get { return checkBoxApply.Checked; }
        }
        public bool IsSort { get; set; }
        private string GetLabelText
        {
            get
            {
                string labelText = $"{ColumnName} {SortFilterType}";
                if (Value != null) labelText += $" {Value}";
                return labelText;
            }
        }

        public FilterItem(string columnName, string sortFilterType, ControlCollection parentControlCollection, string value = null, bool isSort = false)
        {
            InitializeComponent();
            ColumnName = columnName;
            SortFilterType = sortFilterType;
            IsSort = isSort;
            if (value != null) Value = value;
            label1.Text = GetLabelText;
            this.parentControlCollection = parentControlCollection;
            checkBoxApply.CheckedChanged += checkBox1_CheckedChanged;
            AdjustControlWidth();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnFilterChanged();
        }

        protected virtual void OnFilterChanged()
        {
            FilterChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateLabelText()
        {
            label1.Text = GetLabelText;
            AdjustControlWidth();
        }

        private void AdjustControlWidth()
        {
            int padding = 5;
            Size textSize = TextRenderer.MeasureText(label1.Text, label1.Font);

            label1.Width = textSize.Width + 5;

            int totalWidth = checkBoxApply.Width + label1.Width + buttonDelete.Width + buttonMoveLeft.Width + buttonMoveRight.Width + panelBorderLeft.Width + panelBorderRight.Width + padding;

            this.Width = totalWidth;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AdjustControlWidth();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            parentControlCollection.Remove(this);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            int indexOf = parentControlCollection.IndexOf(this);
            parentControlCollection.SetChildIndex(this, indexOf + 1);
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            int indexOf = parentControlCollection.IndexOf(this);
            parentControlCollection.SetChildIndex(this, indexOf - 1);
        }
    }
}
