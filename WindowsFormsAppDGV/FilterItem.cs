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

namespace WindowsFormsAppDGV
{
    public partial class FilterItem : UserControl
    {
        private ControlCollection parentControlCollection;
        public string ColumnName;
        public string SortFilterType;
        public string Value;
        private string GetLabelText
        { 
            get
            {
                string labelText = $"{ColumnName} {SortFilterType}";
                if (Value != null) labelText += $" {Value}";
                return labelText;
            } 
        }
        public FilterItem(string columnName, string sortFilterType, ControlCollection parentControlCollection, string value = null)
        {
            InitializeComponent();
            ColumnName = columnName;
            SortFilterType = sortFilterType;
            if (value != null) Value = value;
            label1.Text = GetLabelText;
            this.parentControlCollection = parentControlCollection;
        }

        private void AdjustControlWidth()
        {
            int padding = 5;
            Size textSize = TextRenderer.MeasureText(label1.Text, label1.Font);

            int totalWidth = textSize.Width + buttonDelete.Width + buttonMoveLeft.Width + buttonMoveRight.Width + padding;

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
