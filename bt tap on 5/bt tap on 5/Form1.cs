using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace bt_tap_on_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clockTimer.Tick += ClockTimer_Tick;
            itemsDataGridView.CellValidating += ItemsDataGridView_CellValidating;
            itemsDataGridView.CellEndEdit += ItemsDataGridView_CellEndEdit;
            itemsDataGridView.CellValueChanged += ItemsDataGridView_CellValueChanged;
            itemsDataGridView.RowsRemoved += ItemsDataGridView_RowsRemoved;
            itemsDataGridView.DataError += ItemsDataGridView_DataError;
            itemsDataGridView.KeyDown += ItemsDataGridView_KeyDown;
            customerNameTextBox.Validating += RequiredTextBox_Validating;
            addressTextBox.Validating += RequiredTextBox_Validating;
            KeyDown += Form1_KeyDown;
            clockTimer.Start();
            ClockTimer_Tick(this, EventArgs.Empty);
            UpdateTotals();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clockStatusLabel.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AddNewItemRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete && itemsDataGridView.Focused)
            {
                DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void ItemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                AddNewItemRow();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void AddNewItemRow()
        {
            int rowIndex = itemsDataGridView.Rows.Add();
            itemsDataGridView.CurrentCell = itemsDataGridView.Rows[rowIndex].Cells[0];
            itemsDataGridView.Focus();
            itemsDataGridView.BeginEdit(true);
        }

        private void DeleteSelectedRows()
        {
            if (itemsDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in itemsDataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    itemsDataGridView.Rows.Remove(row);
                }
            }
            UpdateTotals();
        }

        private void ItemsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < itemsDataGridView.Rows.Count)
            {
                CalculateRowAmount(itemsDataGridView.Rows[e.RowIndex]);
                UpdateTotals();
            }
        }

        private void ItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < itemsDataGridView.Rows.Count)
            {
                CalculateRowAmount(itemsDataGridView.Rows[e.RowIndex]);
                UpdateTotals();
            }
        }

        private void ItemsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotals();
        }

        private void ItemsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            if (e.RowIndex >= 0 && e.RowIndex < itemsDataGridView.Rows.Count)
            {
                itemsDataGridView.Rows[e.RowIndex].ErrorText = "Giá trị không hợp lệ.";
                validationErrorProvider.SetError(itemsDataGridView, "Vui lòng nhập số hợp lệ.");
            }
        }

        private void ItemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= itemsDataGridView.Rows.Count || e.RowIndex == itemsDataGridView.NewRowIndex)
            {
                return;
            }

            if (e.ColumnIndex != quantityColumn.Index && e.ColumnIndex != weightColumn.Index)
            {
                return;
            }

            string value = Convert.ToString(e.FormattedValue).Trim();
            decimal number;
            bool valid = decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out number) && number > 0;
            DataGridViewRow row = itemsDataGridView.Rows[e.RowIndex];
            if (!valid)
            {
                string fieldName = e.ColumnIndex == quantityColumn.Index ? "Số lượng" : "Trọng lượng";
                row.ErrorText = fieldName + " phải lớn hơn 0.";
                validationErrorProvider.SetError(itemsDataGridView, fieldName + " phải lớn hơn 0.");
                e.Cancel = true;
            }
            else
            {
                row.ErrorText = string.Empty;
                validationErrorProvider.SetError(itemsDataGridView, string.Empty);
            }
        }

        private void CalculateRowAmount(DataGridViewRow row)
        {
            if (row == null || row.IsNewRow)
            {
                return;
            }

            decimal quantity;
            decimal unitPrice;
            if (TryGetDecimal(row.Cells[quantityColumn.Index].Value, out quantity) &&
                TryGetDecimal(row.Cells[unitPriceColumn.Index].Value, out unitPrice))
            {
                row.Cells[amountColumn.Index].Value = quantity * unitPrice;
            }
            else
            {
                row.Cells[amountColumn.Index].Value = null;
            }
        }

        private void UpdateTotals()
        {
            decimal quantityTotal = 0;
            decimal weightTotal = 0;
            decimal amountTotal = 0;

            foreach (DataGridViewRow row in itemsDataGridView.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                decimal value;
                if (TryGetDecimal(row.Cells[quantityColumn.Index].Value, out value)) quantityTotal += value;
                if (TryGetDecimal(row.Cells[weightColumn.Index].Value, out value)) weightTotal += value;
                if (TryGetDecimal(row.Cells[amountColumn.Index].Value, out value)) amountTotal += value;
            }

            quantityStatusLabel.Text = "Tổng số lượng: " + quantityTotal.ToString("0.##");
            weightStatusLabel.Text = "Tổng trọng lượng: " + weightTotal.ToString("0.##") + " kg";
            totalStatusLabel.Text = "Tổng tiền: " + amountTotal.ToString("N0") + " VND";
        }

        private static bool TryGetDecimal(object value, out decimal result)
        {
            if (value == null || value == DBNull.Value)
            {
                result = 0;
                return false;
            }

            return decimal.TryParse(Convert.ToString(value), NumberStyles.Number, CultureInfo.CurrentCulture, out result);
        }

        private void RequiredTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
            {
                return;
            }

            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            validationErrorProvider.SetError(textBox, isValid ? string.Empty : "Trường này không được để trống.");
            e.Cancel = false;
        }
    }
}
