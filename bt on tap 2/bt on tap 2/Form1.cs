using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_on_tap_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh chụp lỗi";
                dialog.Filter = "Tệp hình ảnh (*.jpg;*.png)|*.jpg;*.png";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (Image selectedImage = Image.FromFile(dialog.FileName))
                    {
                        Image oldImage = picError.Image;
                        picError.Image = new Bitmap(selectedImage);
                        if (oldImage != null)
                        {
                            oldImage.Dispose();
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTicketId.Text) || string.IsNullOrWhiteSpace(txtRequester.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu và người yêu cầu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboIncidentType.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại sự cố.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string priority = rdoLow.Checked ? rdoLow.Text : rdoMedium.Checked ? rdoMedium.Text : rdoUrgent.Checked ? rdoUrgent.Text : string.Empty;
            if (string.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Vui lòng chọn mức độ ưu tiên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> devices = new List<string>();
            if (chkDesktop.Checked) devices.Add(chkDesktop.Text);
            if (chkLaptop.Checked) devices.Add(chkLaptop.Text);
            if (chkPrinter.Checked) devices.Add(chkPrinter.Text);
            if (chkPhone.Checked) devices.Add(chkPhone.Text);

            string deviceSummary = devices.Count == 0 ? "Không chọn" : string.Join(", ", devices);
            string imageSummary = picError.Image == null ? "Chưa tải ảnh" : "Đã tải ảnh lỗi";
            string summary = "THÔNG TIN PHIẾU HỖ TRỢ\n\n"
                + "Mã phiếu: " + txtTicketId.Text.Trim() + "\n"
                + "Người yêu cầu: " + txtRequester.Text.Trim() + "\n"
                + "Ngày ghi nhận: " + dtpReceivedDate.Value.ToShortDateString() + "\n"
                + "Mức độ ưu tiên: " + priority + "\n"
                + "Loại sự cố: " + cboIncidentType.SelectedItem + "\n"
                + "Thiết bị ảnh hưởng: " + deviceSummary + "\n"
                + "Ảnh chụp lỗi: " + imageSummary;

            MessageBox.Show(summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Clear();
            txtRequester.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            rdoLow.Checked = false;
            rdoMedium.Checked = false;
            rdoUrgent.Checked = false;
            cboIncidentType.SelectedIndex = -1;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;

            if (picError.Image != null)
            {
                Image oldImage = picError.Image;
                picError.Image = null;
                oldImage.Dispose();
            }

            txtTicketId.Focus();
        }
    }
}
