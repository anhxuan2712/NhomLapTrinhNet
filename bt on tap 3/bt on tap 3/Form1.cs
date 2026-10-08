using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace bt_on_tap_3
{
    public partial class Form1 : Form
    {
        private readonly List<VatTu> danhSachVatTu = new List<VatTu>();

        public Form1()
        {
            InitializeComponent();
            lvVatTu.Columns.Add("Mã VT", 110);
            lvVatTu.Columns.Add("Tên VT", 230);
            lvVatTu.Columns.Add("Đơn vị tính", 130);
            lvVatTu.Columns.Add("Đơn giá", 140, HorizontalAlignment.Right);
            cboDonVi.SelectedIndex = 0;
        }

        private bool LayDuLieuNhap(out VatTu vatTu)
        {
            vatTu = null;
            string ma = txtMa.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || cboDonVi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal donGia;
            if (!decimal.TryParse(txtDonGia.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            vatTu = new VatTu
            {
                Ma = ma,
                Ten = ten,
                DonVi = cboDonVi.Text,
                DonGia = donGia
            };
            return true;
        }

        private void HienThiDanhSach()
        {
            lvVatTu.Items.Clear();
            foreach (VatTu vatTu in danhSachVatTu)
            {
                ListViewItem item = new ListViewItem(vatTu.Ma);
                item.SubItems.Add(vatTu.Ten);
                item.SubItems.Add(vatTu.DonVi);
                item.SubItems.Add(vatTu.DonGia.ToString("N0", CultureInfo.CurrentCulture));
                item.Tag = vatTu;
                lvVatTu.Items.Add(item);
            }
        }

        private void XoaTrangNhapLieu()
        {
            txtMa.Clear();
            txtTen.Clear();
            cboDonVi.SelectedIndex = 0;
            txtDonGia.Clear();
            lvVatTu.SelectedItems.Clear();
            txtMa.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            VatTu vatTu;
            if (!LayDuLieuNhap(out vatTu))
            {
                return;
            }

            bool daTonTai = danhSachVatTu.Exists(x => string.Equals(x.Ma, vatTu.Ma, StringComparison.OrdinalIgnoreCase));
            if (daTonTai)
            {
                MessageBox.Show("Mã vật tư đã tồn tại trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }

            danhSachVatTu.Add(vatTu);
            HienThiDanhSach();
            XoaTrangNhapLieu();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VatTu vatTuMoi;
            if (!LayDuLieuNhap(out vatTuMoi))
            {
                return;
            }

            int viTri = lvVatTu.SelectedIndices[0];
            int viTriMa = danhSachVatTu.FindIndex(x =>
                string.Equals(x.Ma, vatTuMoi.Ma, StringComparison.OrdinalIgnoreCase));
            if (viTriMa >= 0 && viTriMa != viTri)
            {
                MessageBox.Show("Mã vật tư đã tồn tại ở dòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }

            danhSachVatTu[viTri] = vatTuMoi;
            HienThiDanhSach();
            lvVatTu.Items[viTri].Selected = true;
            lvVatTu.Focus();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show("Bạn có chắc muốn xóa dòng đang chọn không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            danhSachVatTu.RemoveAt(lvVatTu.SelectedIndices[0]);
            HienThiDanhSach();
            XoaTrangNhapLieu();
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (danhSachVatTu.Count == 0)
            {
                return;
            }

            DialogResult ketQua = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            danhSachVatTu.Clear();
            HienThiDanhSach();
            XoaTrangNhapLieu();
        }

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                return;
            }

            VatTu vatTu = lvVatTu.SelectedItems[0].Tag as VatTu;
            if (vatTu == null)
            {
                return;
            }

            txtMa.Text = vatTu.Ma;
            txtTen.Text = vatTu.Ten;
            cboDonVi.SelectedItem = vatTu.DonVi;
            txtDonGia.Text = vatTu.DonGia.ToString("0.##", CultureInfo.CurrentCulture);
        }
    }

    internal class VatTu
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public decimal DonGia { get; set; }
    }
}
