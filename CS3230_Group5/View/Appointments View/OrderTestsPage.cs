using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS3230_Group5.DAL;
using CS3230_Group5.Model;

namespace CS3230_Group5.View.Appointments_View
{
    /// <summary>
    /// Lets a nurse order tests for a visit. Tests can be added to or removed
    /// from the order until the nurse confirms it.
    /// </summary>
    public partial class OrderTestsPage : Form
    {
        private const string DateTimeFormat = "MM/dd/yyyy h:mm tt";

        private readonly int _appointmentId;
        private readonly OrderedTestDal _visitDal = new OrderedTestDal();
        private readonly TestOrderDal _orderDal = new TestOrderDal();

        private List<OrderedTest> _standardTests = new List<OrderedTest>();
        private List<OrderedTest> _alreadyOrdered = new List<OrderedTest>();
        private readonly List<string> _pendingCodes = new List<string>();

        private string _patientName = string.Empty;
        private bool _canOrder;

        public OrderTestsPage(int appointmentId)
        {
            InitializeComponent();

            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            }

            _appointmentId = appointmentId;

            ConfigureLists();
            ClearError();
            AttachEventHandlers();
            CancelButton = closeButton;
        }

        private void ConfigureLists()
        {
            foreach (ListView list in new[] { availableList, pendingList })
            {
                list.Columns.Clear();
                list.Columns.Add("Code", 50);
                list.Columns.Add("Test", 150);
                list.Columns.Add("Normal Range", 150);
            }

            orderedList.Columns.Clear();
            orderedList.Columns.Add("Code", 80);
            orderedList.Columns.Add("Test", 300);
            orderedList.Columns.Add("Status", 200);
        }

        /// <summary>
        /// Sizes the columns as a share of the list width so they fit any screen scaling.
        /// </summary>
        private static void ResizeColumns(ListView list, double[] share)
        {
            int total = list.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

            if (total <= 0 || list.Columns.Count != share.Length)
            {
                return;
            }

            for (int i = 0; i < share.Length; i++)
            {
                list.Columns[i].Width = (int)(total * share[i]);
            }
        }

        private void ResizeAllColumns()
        {
            double[] pickShare = { 0.20, 0.40, 0.40 };
            ResizeColumns(availableList, pickShare);
            ResizeColumns(pendingList, pickShare);
            ResizeColumns(orderedList, new[] { 0.12, 0.50, 0.38 });
        }

        private void AttachEventHandlers()
        {
            availableList.SizeChanged += (s, e) => ResizeAllColumns();
            pendingList.SizeChanged += (s, e) => ResizeAllColumns();
            orderedList.SizeChanged += (s, e) => ResizeAllColumns();

            availableList.DoubleClick += (s, e) => AddSelectedTests();
            pendingList.DoubleClick += (s, e) => RemoveSelectedTests();

            addButton.Click += (s, e) => AddSelectedTests();
            removeButton.Click += (s, e) => RemoveSelectedTests();
            orderButton.Click += orderButton_Click;
            closeButton.Click += (s, e) => Close();
        }

        private void OrderTestsPage_Load(object? sender, EventArgs e)
        {
            ResizeAllColumns();
            LoadVisit();
        }

        // ---------- Loading ----------

        private void LoadVisit()
        {
            try
            {
                VisitHeader? header = _visitDal.GetVisitHeader(_appointmentId);

                if (header == null)
                {
                    MessageBox.Show(
                        "The selected appointment could not be found.",
                        "Appointment Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    BeginInvoke(new Action(Close));
                    return;
                }

                _patientName = header.PatientName;

                patientInfoLabel.Text =
                    $"Patient: {header.PatientName}      DOB: {header.PatientDateOfBirth:MM/dd/yyyy}";

                visitInfoLabel.Text =
                    $"Doctor: {header.DoctorName}      " +
                    $"Nurse: {header.NurseName ?? "Not recorded"}      " +
                    $"Visit: {header.AppointmentDateTime.ToString(DateTimeFormat)}";

                _standardTests = _orderDal.GetStandardTests();
                _alreadyOrdered = _visitDal.GetOrderedTests(_appointmentId);
                _pendingCodes.Clear();

                string notice = string.Empty;

                if (header.IsFinalized)
                {
                    notice = "A final diagnosis has been entered, so this visit is read-only.";
                }
                else if (header.NurseName == null)
                {
                    notice = "Save the routine check-up before ordering tests.";
                }

                _canOrder = notice.Length == 0;
                noticeLabel.Text = notice;
                noticeLabel.Visible = notice.Length > 0;

                RefreshLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the visit: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                _canOrder = false;
                UpdateButtons();
            }
        }

        // ---------- Lists ----------

        private void RefreshLists()
        {
            var alreadyCodes = new HashSet<string>(
                _alreadyOrdered.Select(t => t.TestCode),
                StringComparer.OrdinalIgnoreCase);

            availableList.BeginUpdate();
            pendingList.BeginUpdate();
            orderedList.BeginUpdate();

            availableList.Items.Clear();
            pendingList.Items.Clear();
            orderedList.Items.Clear();

            foreach (OrderedTest test in _standardTests)
            {
                if (alreadyCodes.Contains(test.TestCode) || _pendingCodes.Contains(test.TestCode))
                {
                    continue;
                }

                availableList.Items.Add(CreatePickItem(test));
            }

            foreach (string code in _pendingCodes)
            {
                OrderedTest? test = _standardTests.FirstOrDefault(t => t.TestCode == code);

                if (test != null)
                {
                    pendingList.Items.Add(CreatePickItem(test));
                }
            }

            foreach (OrderedTest test in _alreadyOrdered)
            {
                var item = new ListViewItem(test.TestCode);
                item.SubItems.Add(test.TestName);
                item.SubItems.Add(test.StatusText);
                orderedList.Items.Add(item);
            }

            availableList.EndUpdate();
            pendingList.EndUpdate();
            orderedList.EndUpdate();

            orderedLabel.Text = _alreadyOrdered.Count == 0
                ? "Already Ordered For This Visit: none"
                : "Already Ordered For This Visit:";

            UpdateButtons();
        }

        private static ListViewItem CreatePickItem(OrderedTest test)
        {
            var item = new ListViewItem(test.TestCode) { Tag = test };
            item.SubItems.Add(test.TestName);
            item.SubItems.Add(test.NormalRangeText);
            return item;
        }

        private void UpdateButtons()
        {
            addButton.Enabled = _canOrder;
            removeButton.Enabled = _canOrder;
            availableList.Enabled = _canOrder;
            pendingList.Enabled = _canOrder;

            orderButton.Enabled = _canOrder && _pendingCodes.Count > 0;
            orderButton.Text = _pendingCodes.Count == 0
                ? "Order Tests"
                : $"Order {_pendingCodes.Count} Test(s)";
        }

        private void AddSelectedTests()
        {
            if (!_canOrder)
            {
                return;
            }

            ClearError();

            foreach (ListViewItem item in availableList.SelectedItems)
            {
                if (item.Tag is OrderedTest test && !_pendingCodes.Contains(test.TestCode))
                {
                    _pendingCodes.Add(test.TestCode);
                }
            }

            RefreshLists();
        }

        private void RemoveSelectedTests()
        {
            if (!_canOrder)
            {
                return;
            }

            ClearError();

            foreach (ListViewItem item in pendingList.SelectedItems)
            {
                if (item.Tag is OrderedTest test)
                {
                    _pendingCodes.Remove(test.TestCode);
                }
            }

            RefreshLists();
        }

        // ---------- Ordering ----------

        private void orderButton_Click(object? sender, EventArgs e)
        {
            ClearError();

            if (_pendingCodes.Count == 0)
            {
                ShowError("Add at least one test to the order.");
                return;
            }

            var summary = new StringBuilder();

            foreach (string code in _pendingCodes)
            {
                OrderedTest? test = _standardTests.FirstOrDefault(t => t.TestCode == code);
                summary.AppendLine($"   {code} - {test?.TestName ?? code}");
            }

            DialogResult answer = MessageBox.Show(
                $"Order these tests for {_patientName}?\n\n{summary}\n" +
                "You can still enter results for them afterwards.",
                "Confirm Test Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _orderDal.OrderTests(_appointmentId, _pendingCodes);

                MessageBox.Show(
                    $"{_pendingCodes.Count} test(s) ordered.",
                    "Tests Ordered",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (InvalidOperationException ex)
            {
                // No check-up, finalized meanwhile, or already ordered.
                MessageBox.Show(
                    ex.Message,
                    "Unable to Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                LoadVisit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to order the tests: " + ex.Message,
                    "Order Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ---------- Error label ----------

        private void ShowError(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void ClearError()
        {
            errorLabel.Text = string.Empty;
            errorLabel.Visible = false;
        }
    }
}
