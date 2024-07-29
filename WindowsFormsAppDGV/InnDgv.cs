using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsAppDGV
{
    [ToolboxItem(true)]
    public partial class InnDgv : UserControl
    {
        private object _dataSource;
        private SortableBindingList<object> _bindingList;
        private BindingSource _bindingSource = new BindingSource();
        private RadioButton _checkedOne;

        private int takeTopX;
        private BindingList<object> _topX;

        private List<Control> previousControlOrder = new List<Control> ();

        public InnDgv()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            radioButtonSortAsc.Checked = true;
            _checkedOne = radioButtonSortAsc;
            takeTopX = (int)numericUpDownTakeTop.Value;
        }

        public object DataSource
        {
            get => _dataSource;
            set
            {
                _dataSource = value;
                _bindingList = ConvertToBindingList(_dataSource);
                ApplySortingAndFiltering();
            }
        }
        public void ApplySort(PropertyDescriptor prop, ListSortDirection direction)
        {
            ApplySortCore(prop, direction);
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        private void ApplySortingAndFiltering()
        {
            if (_bindingList == null) return;

            // Apply sorting
            var sortProperty = TypeDescriptor.GetProperties(_bindingList.FirstOrDefault())["Age"]; // Example sort by 'Age'
            _bindingList.ApplySort(sortProperty, ListSortDirection.Descending);

            // Take Top X items
            _topX = new SortableBindingList<object>(_bindingList.Take(takeTopX).ToList());

            // Set DataSource
            _bindingSource.DataSource = _topX;
            dataGridView1.DataSource = _bindingSource;

            // Refresh the DataGridView
            dataGridView1.Refresh();

            // Populate combobox after setting DataSource
            PopulateCombobox();
        }


        private void PopulateCombobox()
        {
            comboBox1.Items.Clear();
            if (_bindingList == null) return;
            var type = _bindingList.FirstOrDefault().GetType().GetProperties();
            var typeName = type.FirstOrDefault().Name;
            comboBox1.DataSource = type;
            comboBox1.SelectedIndex = 0;
            

            comboBox1.DisplayMember = typeName;
            if (_bindingList.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private SortableBindingList<object> ConvertToBindingList(object dataSource)
        {
            if (dataSource is SortableBindingList<object> bindingList)
            {
                return bindingList;
            }

            var list = new SortableBindingList<object>();

            if (dataSource is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    list.Add(item);
                }
            }
            else if (dataSource != null)
            {
                list.Add(dataSource);
            }

            return list;
        }

        private void InitializeFlowLayoutPanel()
        {
            flowLayoutPanel1.ControlAdded += new ControlEventHandler(FlowLayoutPanel_ControlChanged);
            flowLayoutPanel1.ControlRemoved += new ControlEventHandler(FlowLayoutPanel_ControlChanged);
            flowLayoutPanel1.Layout += new LayoutEventHandler(FlowLayoutPanel1_LayoutChanged);
        }

        private void FlowLayoutPanel_ControlChanged(object sender, ControlEventArgs e)
        {
            //MessageBox.Show($"Control {e.Control.Name} was added or removed.");
            UpdatePreviousControlOrder();
            ApplyFilter();
        }

        private void FlowLayoutPanel1_LayoutChanged(object sender, LayoutEventArgs e)
        {
            var currentControlOrder = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            if (!currentControlOrder.SequenceEqual(previousControlOrder))
            {
                //MessageBox.Show("Control order has changed.");
                UpdatePreviousControlOrder();
            }

            ApplyFilter();
        }

        private void UpdatePreviousControlOrder()
        {
            previousControlOrder = flowLayoutPanel1.Controls.Cast<Control>().ToList();
        }

        private void buttonAddSort_Click(object sender, EventArgs e)
        {
            var columnName = comboBox1.Text;
            var sortFilterItem = _checkedOne.Text;
            string textValue = null;
            if (textBoxFilterValue.Text.Length > 0) textValue = textBoxFilterValue.Text;
            var filterItem = new FilterItem(columnName, sortFilterItem, flowLayoutPanel1.Controls, textValue);
            flowLayoutPanel1.Controls.Add(filterItem);
        }

        private void radioButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton checkedOne && checkedOne.Checked)
            {
                _checkedOne = checkedOne;
                if (_checkedOne == radioButtonSortAsc || _checkedOne == radioButtonSortDesc)
                {
                    textBoxFilterValue.Clear();
                    textBoxFilterValue.Enabled = false;
                }
                else
                {
                    textBoxFilterValue.Enabled = true;
                }
            }
        }

        private void ApplyFilter()
        {
            var filters = new List<string>();
            var sorts = new List<string>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is FilterItem filterItem)
                {
                    string filter = BuildFilterString(filterItem);
                    if (!string.IsNullOrEmpty(filter))
                    {
                        filters.Add(filter);
                    }
                    string sort = BuildSortString(filterItem);
                    if (!string.IsNullOrEmpty(sort))
                    {
                        if (!sorts.Any(x => x.Contains(filterItem.SortFilterType))) 
                            sorts.Add(sort);
                    }
                }
            }

            _bindingSource.Filter = string.Join(" AND ", filters);
            _bindingSource.Sort = string.Join(", ", sorts);
            _bindingSource.ResetBindings(false); 
            //MessageBox.Show($"Filters: {string.Join(" AND ", filters)}");
            //MessageBox.Show($"Sorts: {string.Join(", ", sorts)}");
            dataGridView1.Refresh();
        }

        private string BuildSortString(FilterItem filterItem)
        {
            if (string.IsNullOrEmpty(filterItem.ColumnName) || string.IsNullOrEmpty(filterItem.SortFilterType))
            {
                return null;
            }
            if (filterItem.SortFilterType.Contains("ASC")) return $"{filterItem.ColumnName} ASC";
            if (filterItem.SortFilterType.Contains("DESC")) return $"{filterItem.ColumnName} DESC";
            return null;
        }

        private string BuildFilterString(FilterItem filterItem)
        {
            if (string.IsNullOrEmpty(filterItem.ColumnName) || string.IsNullOrEmpty(filterItem.SortFilterType) || string.IsNullOrEmpty(filterItem.Value))
            {
                return null;
            }

            switch (filterItem.SortFilterType)
            {
                case "=":
                    return $"{filterItem.ColumnName} = '{filterItem.Value}'";
                case "LIKE":
                    return $"{filterItem.ColumnName} LIKE '%{filterItem.Value}%'";
                default:
                    return null;
            }
        }
    }

    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            if (prop == null)
                throw new ArgumentNullException(nameof(prop));

            _sortProperty = prop;
            _sortDirection = direction;
            _isSorted = true;

            var sortedList = this.Items
                .OrderBy(item => prop.GetValue(item))
                .ToList();

            if (direction == ListSortDirection.Descending)
            {
                sortedList.Reverse();
            }

            this.ClearItems();
            foreach (var item in sortedList)
            {
                this.Add(item);
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override bool SupportsSortingCore => true;

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override bool IsSortedCore => _isSorted;

        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override ListSortDirection SortDirectionCore => _sortDirection;
    }
}
