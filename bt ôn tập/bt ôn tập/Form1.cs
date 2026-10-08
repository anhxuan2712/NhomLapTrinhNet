using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_ôn_tập
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and parse inputs
                if (!decimal.TryParse(txtServicePrice.Text, out decimal servicePrice))
                {
                    MessageBox.Show("Đơn giá dịch vụ phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtCustomerQuantity.Text, out decimal quantity))
                {
                    MessageBox.Show("Số lượng khách phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtDiscount.Text, out decimal discount))
                {
                    MessageBox.Show("% Giảm giá phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate ranges
                if (servicePrice < 0)
                {
                    MessageBox.Show("Đơn giá dịch vụ không được âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantity < 0)
                {
                    MessageBox.Show("Số lượng khách không được âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (discount < 0 || discount > 100)
                {
                    MessageBox.Show("% Giảm giá phải từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate: Total = (servicePrice × quantity) × (100 - discount) / 100
                decimal totalAmount = (servicePrice * quantity) * (100 - discount) / 100;

                // Display result
                lblTotalAmount.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtServicePrice.Text = "0";
            txtCustomerQuantity.Text = "0";
            txtDiscount.Text = "0";
            lblTotalAmount.Text = "0";
            txtServicePrice.Focus();
        }
    }
}
