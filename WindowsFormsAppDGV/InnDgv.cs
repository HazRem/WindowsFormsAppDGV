using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDGV
{
    [ToolboxItem(true)]
    public partial class InnDgv : UserControl
    {
        private object _dataSource;
        private SortableBindingList<object> _bindingList;
        private readonly BindingSource _bindingSource = new BindingSource();

        private int takeTopX;

        private List<Control> previousControlOrder = new List<Control>();

        private Timer searchTimer = new Timer();

        private bool IsFilteringSuspended()
        {
            return toolStripMenuItemSuspendFiltering.Checked;
        }

        public InnDgv()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            takeTopX = (int)numericUpDownTakeTop.Value;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;
            textBoxSearch.TextChanged += textBoxGlobalFilter_TextChanged;
            searchTimer.Interval = 1000;
            searchTimer.Tick += SearchTimer_Tick;
        }

        public object DataSource
        {
            get => _dataSource;
            set
            {
                _dataSource = value;
                _bindingList = ConvertToBindingList(_dataSource);
                ShowRowNumber(_bindingList);
                ShowTotalRowNumber(_bindingList);
                ApplySortingAndFiltering();
            }
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            ApplyFilter();
        }

        private void ApplySortingAndFiltering()
        {
            if (_bindingList == null) return;

            // Apply sorting
            var sortProperty = TypeDescriptor.GetProperties(_bindingList.FirstOrDefault())["Age"]; // Example sort by 'Age'
            _bindingList.ApplySortCorePublic(sortProperty, ListSortDirection.Descending);

            TakeTopXAndSetDataSource();
        }

        private void TakeTopXAndSetDataSource(bool repopulateCombobox = true)
        {
            // Take Top X items

            // Set DataSource
            _bindingSource.DataSource = _bindingList?.TakeTopX(takeTopX);
            dataGridView1.DataSource = _bindingSource;

            // Refresh the DataGridView
            dataGridView1.Refresh();

            // Populate combobox after setting DataSource
            if (repopulateCombobox)
                PopulateCombobox();
        }

        private void numericUpDownTakeTop_ValueChanged(object sender, EventArgs e)
        {
            takeTopX = (int)numericUpDownTakeTop.Value;
            TakeTopXAndSetDataSource(false);
            ApplyFilter();
        }

        private void PopulateCombobox()
        {
            comboBox1.Items.Clear();
            if (_bindingList == null || _bindingList.Count == 0) return;
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
            if (e.Control is FilterItem filterItem)
            {
                if (!flowLayoutPanel1.Controls.Contains(filterItem))
                {
                    var prop = TypeDescriptor.GetProperties(typeof(Person)).Find(filterItem.ColumnName, false);
                    if (prop != null && filterItem.IsSort)
                    {
                        _bindingList.RemoveSortCorePublic(prop);
                    }
                }
            }

            // Reset sortowanie i ponownie zastosuj sortowanie z istniejących kontrolek
            _bindingList.ClearSort();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is FilterItem item && item.IsSort)
                {
                    var prop = TypeDescriptor.GetProperties(typeof(Person)).Find(item.ColumnName, false);
                    if (prop != null)
                    {
                        _bindingList.ApplySortCorePublic(prop, item.SortFilterType == "ASC" ? ListSortDirection.Ascending : ListSortDirection.Descending);
                    }
                }
            }

            UpdatePreviousControlOrder();
            ApplyFilter();
        }

        private void FlowLayoutPanel1_LayoutChanged(object sender, LayoutEventArgs e)
        {
            var currentControlOrder = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            if (!currentControlOrder.SequenceEqual(previousControlOrder))
            {
                UpdatePreviousControlOrder();
            }

            ApplyFilter();
        }

        private void UpdatePreviousControlOrder()
        {
            previousControlOrder = flowLayoutPanel1.Controls.Cast<Control>().ToList();
        }

        private void AddOrUpdateFilter(string columnName, string sortFilterItem, string textValue)
        {
            bool filterUpdated = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is FilterItem filterItem)
                {
                    filterItem.FilterChanged -= (s, e) => ApplyFilter(); // Usuń poprzednie przypisania, jeśli istnieją
                }
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is FilterItem filterItem && filterItem.ColumnName == columnName && filterItem.SortFilterType == sortFilterItem)
                {
                    filterItem.Value = textValue;
                    filterUpdated = true;
                    break;
                }
            }

            if (!filterUpdated)
            {
                bool isSort = sortFilterItem == "ASC" || sortFilterItem == "DESC";
                var newFilterItem = new FilterItem(columnName, sortFilterItem, flowLayoutPanel1.Controls, textValue, isSort);
                flowLayoutPanel1.Controls.Add(newFilterItem);
            }

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is FilterItem filterItem)
                {
                    filterItem.FilterChanged += (s, e) => ApplyFilter();
                }
            }
        }

        private void buttonAddSort_Click(object sender, EventArgs e)
        {
            AddFilter();
        }

        private void AddFilter()
        {
            var columnName = comboBox1.Text;
            var sortFilterItem = comboBoxFilterOptions.Text;
            string textValue = null;
            if (textBoxFilterValue.Text.Length > 0) textValue = textBoxFilterValue.Text;

            AddOrUpdateFilter(columnName, sortFilterItem, textValue);
            ApplyFilter();
        }

        private void radioButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            //if (!(sender is RadioButton checkedOne) || !checkedOne.Checked) return;
            //_checkedOne = checkedOne;
            //if (x)
            //{
            //    textBoxFilterValue.Clear();
            //    textBoxFilterValue.Enabled = false;
            //}
            //else
            //{
            //    textBoxFilterValue.Enabled = true;
            //}
        }

        private void ApplyFilter()
        {
            if (IsFilteringSuspended()) return;
            if (_bindingList == null) return;

            var filters = flowLayoutPanel1.Controls.OfType<FilterItem>().Where(fi => fi.IsChecked && !fi.IsSort).ToList();
            var sorters = flowLayoutPanel1.Controls.OfType<FilterItem>().Where(fi => fi.IsChecked && fi.IsSort).ToList();
            string globalFilter = textBoxSearch.Text;

            // Reset sortowanie i ponownie zastosuj sortowanie z istniejących kontrolek
            _bindingList.ClearSort();
            foreach (var sorter in sorters)
            {
                var prop = TypeDescriptor.GetProperties(typeof(Person)).Find(sorter.ColumnName, false);
                if (prop != null)
                {
                    _bindingList.ApplySortCorePublic(prop, sorter.SortFilterType == "ASC" ? ListSortDirection.Ascending : ListSortDirection.Descending);
                }
            }

            var filteredList = ApplyFiltersWithProgress(_bindingList, filters, globalFilter);
            _bindingSource.DataSource = filteredList.Take(takeTopX).ToList();
            dataGridView1.DataSource = _bindingSource;
            UpdateRowHeaders();
            dataGridView1.Refresh();
            ShowRowNumber(filteredList);
        }

        private IEnumerable<object> ApplyFiltersWithProgress(IEnumerable<object> list, List<FilterItem> filters, string globalFilter)
        {
            IEnumerable<object> filteredList = list;

            // Stosujemy wszystkie filtry
            foreach (var filterItem in filters)
            {
                filteredList = ApplyFilterToList(filteredList, filterItem);
            }

            if (!string.IsNullOrEmpty(globalFilter))
            {
                filteredList = ApplyGlobalFilter(filteredList, globalFilter);
            }

            ShowRowNumber(filteredList);  // Dodaj wywołanie ShowRowNumber tutaj

            return filteredList;
        }

        private IEnumerable<object> ApplyGlobalFilter(IEnumerable<object> list, string filter)
        {
            return list.Where(item => item.GetType().GetProperties().Any(prop =>
                prop.GetValue(item)?.ToString().IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0));
        }
        private IEnumerable<object> ApplyFilterToList(IEnumerable<object> list, FilterItem filterItem)
        {
            if (string.IsNullOrEmpty(filterItem.ColumnName) || string.IsNullOrEmpty(filterItem.SortFilterType))
            {
                ShowRowNumber(list); // Pokaż liczbę linii, nawet jeśli nie ma filtru
                return list;
            }

            var prop = TypeDescriptor.GetProperties(typeof(Person)).Find(filterItem.ColumnName, false);
            if (prop == null)
            {
                ShowRowNumber(list); // Pokaż liczbę linii, jeśli kolumna nie istnieje
                return list;
            }

            // Sprawdź, czy typ właściwości jest bool
            bool isBoolType = prop.PropertyType == typeof(bool);

            // Convert the filter value to the property type if it's not a bool column
            IEnumerable<object> filteredList = list;

            if (!filterItem.IsSort)
            {
                var value = !isBoolType ? Convert.ChangeType(filterItem.Value, prop.PropertyType) : null;
                switch (filterItem.SortFilterType)
                {
                    case "=":
                        filteredList = list.Where(item => isBoolType
                            ? prop.GetValue(item).ToString().Equals(filterItem.Value, StringComparison.OrdinalIgnoreCase)
                            : prop.GetValue(item).Equals(value));
                        break;
                    case ">":
                        filteredList = list.Where(item => !isBoolType && Comparer.DefaultInvariant.Compare(prop.GetValue(item), value) > 0);
                        break;
                    case "<":
                        filteredList = list.Where(item => !isBoolType && Comparer.DefaultInvariant.Compare(prop.GetValue(item), value) < 0);
                        break;
                    case ">=":
                        filteredList = list.Where(item => !isBoolType && Comparer.DefaultInvariant.Compare(prop.GetValue(item), value) >= 0);
                        break;
                    case "<=":
                        filteredList = list.Where(item => !isBoolType && Comparer.DefaultInvariant.Compare(prop.GetValue(item), value) <= 0);
                        break;
                    case "CONTAINS":
                        {
                            var stringValue = value.ToString();
                            filteredList = list.Where(item => prop.GetValue(item).ToString().Contains(stringValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "DOESN'T CONTAIN":
                        {
                            var stringValue = value.ToString();
                            filteredList = list.Where(item => !prop.GetValue(item).ToString().Contains(stringValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "STARTS WITH":
                        {
                            var startsWithValue = value.ToString();
                            filteredList = list.Where(item => prop.GetValue(item).ToString().StartsWith(startsWithValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "DOESN'T START WITH":
                        {
                            var startsWithValue = value.ToString();
                            filteredList = list.Where(item => !prop.GetValue(item).ToString().StartsWith(startsWithValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "ENDS WITH":
                        {
                            var endsWithValue = value.ToString();
                            filteredList = list.Where(item => prop.GetValue(item).ToString().EndsWith(endsWithValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "DOESN'T END WITH":
                        {
                            var endsWithValue = value.ToString();
                            filteredList = list.Where(item => !prop.GetValue(item).ToString().EndsWith(endsWithValue, StringComparison.InvariantCultureIgnoreCase));
                            break;
                        }
                    case "SKIM X":
                        if (int.TryParse(filterItem.Value, out int topX))
                        {
                            filteredList = list.Take(topX);
                        }
                        break;
                }
            }
            else
            {
                // Sortowanie powinno być stosowane jako ostatnie
                switch (filterItem.SortFilterType)
                {
                    case "ASC":
                        _bindingList.ApplySortCorePublic(prop, ListSortDirection.Ascending);
                        break;
                    case "DESC":
                        _bindingList.ApplySortCorePublic(prop, ListSortDirection.Descending);
                        break;
                }
            }

            ShowRowNumber(filteredList); // Pokaż liczbę linii po przefiltrowaniu
            return filteredList;
        }
        private void ShowRowNumber(IEnumerable<object> filteredList)
        {
            var count = filteredList != null ? filteredList.Count() : -1;
            string value = count == -1 ? "-" : count.ToString();
            toolStripStatusLabel2.Text = $"Filtered: {value}";
        }

        private void ShowTotalRowNumber(IEnumerable<object> unfilteredList)
        {
            var count = unfilteredList != null ? unfilteredList.Count() : -1;
            string value = count == -1 ? "-" : count.ToString();
            toolStripStatusLabel1.Text = $"Total: {value}";
        }

        private void UpdateRowHeaders()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                var dataBoundItem = row.DataBoundItem;

                if (dataBoundItem != null)
                {
                    int indexInList = _bindingList.IndexOf(dataBoundItem);
                    row.HeaderCell.Value = (indexInList + 1).ToString();
                }
            }
        }

        private void textBoxGlobalFilter_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Start();
            //ApplyFilter();
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddFilter();
            }
        }

        private void comboBoxFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilterValue.Enabled = true;
            comboBox1.Enabled = true;
            if (comboBoxFilterOptions.Text.Length > 0)
            {
                if (comboBoxFilterOptions.Text == "ASC" || comboBoxFilterOptions.Text == "DESC") 
                {
                    textBoxFilterValue.Clear();
                    textBoxFilterValue.Enabled = false;
                }
                if (comboBoxFilterOptions.Text == "SKIM X")
                {
                    comboBox1.Enabled = false;
                }
            }
        }

        private void buttonOpenMenuStripFilterBar_Click(object sender, EventArgs e)
        {
            //if (contextMenuStripFilterBar.Visible)
            //{
            //    contextMenuStripFilterBar.Close();
            //    return;
            //}

            Button button = sender as Button;

            if (button != null)
            {
                Point buttonLocation = button.Location;

                int buttonHeight = button.Height;

                Point screenPoint = button.PointToScreen(new Point(buttonLocation.X, buttonLocation.Y + buttonHeight));
                
                contextMenuStripFilterBar.Show(screenPoint);
            }
        }

        private void SuspendFilteringToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Jeżeli filtracja została wznowiona, zastosuj filtr
            if (!IsFilteringSuspended())
            {
                ApplyFilter();
                flowLayoutPanel1.BackColor = Color.Lavender;
            }
            else
            {
                flowLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
            }
        }
    }

    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;
        private List<SortDescription> _sortDescriptions = new List<SortDescription>();

        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        public SortableBindingList<T> TakeTopX(int x) => new SortableBindingList<T>(this.Take(x).ToList());

        public void ApplySortCorePublic(PropertyDescriptor prop, ListSortDirection direction)
        {
            ApplySortCore(prop, direction);
        }

        public void RemoveSortCorePublic(PropertyDescriptor prop)
        {
            RemoveSortCore(prop);
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            if (prop == null)
                return;

            // Add or update the sort description
            var existingSortDescription = _sortDescriptions.FirstOrDefault(sd => sd.Property == prop);
            if (existingSortDescription != null)
            {
                existingSortDescription.Direction = direction;
            }
            else
            {
                _sortDescriptions.Add(new SortDescription(prop, direction));
            }

            ApplySort();
        }

        protected void RemoveSortCore(PropertyDescriptor prop)
        {
            var existingSortDescription = _sortDescriptions.FirstOrDefault(sd => sd.Property == prop);
            if (existingSortDescription != null)
            {
                _sortDescriptions.Remove(existingSortDescription);
                ApplySort();
            }
        }

        private void ApplySort()
        {
            var sortedList = Items.AsEnumerable();

            foreach (var sortDescription in _sortDescriptions.Reverse<SortDescription>())
            {
                sortedList = sortDescription.Direction == ListSortDirection.Ascending
                    ? sortedList.OrderBy(item => sortDescription.Property.GetValue(item))
                    : sortedList.OrderByDescending(item => sortDescription.Property.GetValue(item));
            }

            ResetItems(sortedList.ToList());
        }

        private void ResetItems(List<T> items)
        {
            this.ClearItems();
            foreach (var item in items)
            {
                this.Add(item);
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override bool SupportsSortingCore => true;

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortDescriptions.Clear();
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override bool IsSortedCore => _isSorted;

        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override ListSortDirection SortDirectionCore => _sortDirection;

        private class SortDescription
        {
            public PropertyDescriptor Property { get; }
            public ListSortDirection Direction { get; set; }

            public SortDescription(PropertyDescriptor property, ListSortDirection direction)
            {
                Property = property;
                Direction = direction;
            }
        }

        public void ClearSort()
        {
            _sortDescriptions.Clear();
            ApplySort();
        }
    }
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static bool StartsWith(this string source, string toCheck, StringComparison comp)
        {
            return source.StartsWith(toCheck, comp);
        }

        public static bool EndsWith(this string source, string toCheck, StringComparison comp)
        {
            return source.EndsWith(toCheck, comp);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("code")]
    public class FlowLayoutPanelNoScrollbars : FlowLayoutPanel, IMessageFilter
    {
        public FlowLayoutPanelNoScrollbars()
        {
            SetStyle(ControlStyles.UserMouse | ControlStyles.Selectable, true);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Application.AddMessageFilter(this);

            VerticalScroll.LargeChange = 60;
            VerticalScroll.SmallChange = 20;
            HorizontalScroll.LargeChange = 60;
            HorizontalScroll.SmallChange = 20;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            Application.RemoveMessageFilter(this);
            base.OnHandleDestroyed(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_PAINT:
                case WM_ERASEBKGND:
                case WM_NCCALCSIZE:
                    if (DesignMode || !AutoScroll) break;
                    ShowScrollBar(this.Handle, SB_SHOW_BOTH, false);
                    break;
                case WM_MOUSEWHEEL:
                    // Handle Mouse Wheel for other specific cases
                    int delta = (int)(m.WParam.ToInt64() >> 16);
                    int direction = Math.Sign(delta);
                    ShowScrollBar(this.Handle, SB_SHOW_BOTH, false);
                    break;
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_MOUSEWHEEL:
                case WM_MOUSEHWHEEL:
                    if (DesignMode || !AutoScroll) return false;
                    if (VerticalScroll.Maximum <= ClientSize.Height) return false;
                    // Should also check whether the ForegroundWindow matches the parent Form.
                    if (RectangleToScreen(ClientRectangle).Contains(MousePosition))
                    {
                        SendMessage(this.Handle, WM_MOUSEWHEEL, m.WParam, m.LParam);
                        return true;
                    }
                    break;
                case WM_LBUTTONDOWN:
                    // Pre-handle Left Mouse clicks for all child Controls
                    //Console.WriteLine($"WM_LBUTTONDOWN");
                    if (RectangleToScreen(ClientRectangle).Contains(MousePosition))
                    {
                        var mousePos = MousePosition;
                        if (GetForegroundWindow() != TopLevelControl.Handle) return false;
                        // The hosted Control that contains the mouse pointer 
                        var ctrl = FromHandle(ChildWindowFromPoint(this.Handle, PointToClient(mousePos)));
                        // A child Control of the hosted Control that will be clicked 
                        // If no child Controls at that position the Parent's handle
                        var child = FromHandle(WindowFromPoint(mousePos));
                    }
                    return false;
                    // Eventually, if you don't want the message to reach the child Control
                    // return true; 
            }
            return false;
        }

        private const int WM_PAINT = 0x000F;
        private const int WM_ERASEBKGND = 0x0014;
        private const int WM_NCCALCSIZE = 0x0083;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_MOUSEHWHEEL = 0x020E;
        private const int SB_SHOW_VERT = 0x1;
        private const int SB_SHOW_BOTH = 0x3;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        internal static extern IntPtr WindowFromPoint(Point point);

        [DllImport("user32.dll")]
        internal static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point point);
    }
}
