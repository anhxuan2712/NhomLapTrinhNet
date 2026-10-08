using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bt_on_tap_4
{
    public partial class Form1 : Form
    {
        private readonly HashSet<Button> selectedSeats = new HashSet<Button>();
        private readonly HashSet<int> lockedSeatNumbers = new HashSet<int> { 3, 8, 14, 19 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            cboTimeFrame.SelectedIndex = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    int seatNumber = row * 5 + column + 1;
                    Button seatButton = new Button
                    {
                        Name = "btnSeat" + seatNumber,
                        Text = "Vị trí " + seatNumber,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(5),
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Tag = seatNumber
                    };

                    seatButton.Click += SeatButton_Click;
                    SetSeatColor(seatButton, lockedSeatNumbers.Contains(seatNumber));
                    tblSeats.Controls.Add(seatButton, column, row);
                }
            }

            UpdateSummary();
        }

        private void SeatButton_Click(object sender, System.EventArgs e)
        {
            Button seatButton = (Button)sender;
            int seatNumber = (int)seatButton.Tag;

            if (lockedSeatNumbers.Contains(seatNumber))
            {
                MessageBox.Show(
                    "Vị trí này đã có người đặt hoặc đã bị khóa.",
                    "Vị trí không khả dụng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (selectedSeats.Contains(seatButton))
            {
                selectedSeats.Remove(seatButton);
            }
            else
            {
                selectedSeats.Add(seatButton);
            }

            SetSeatColor(seatButton, false);
            UpdateSummary();
        }

        private void SetSeatColor(Button seatButton, bool isLocked)
        {
            if (isLocked)
            {
                seatButton.BackColor = Color.IndianRed;
                seatButton.ForeColor = Color.White;
            }
            else if (selectedSeats.Contains(seatButton))
            {
                seatButton.BackColor = Color.LightGreen;
                seatButton.ForeColor = Color.DarkGreen;
            }
            else
            {
                seatButton.BackColor = Color.WhiteSmoke;
                seatButton.ForeColor = Color.Black;
            }
        }

        private void UpdateSummary()
        {
            int price = cboTimeFrame.SelectedIndex == 1 ? 150000 : 100000;
            lblSelectedCount.Text = "Số vị trí đang chọn: " + selectedSeats.Count;
            lblTotal.Text = "Tạm tính tiền: " + (selectedSeats.Count * price).ToString("N0") + "đ";
        }

        private void cboTimeFrame_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateSummary();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            int clearedCount = selectedSeats.Count;
            selectedSeats.Clear();

            foreach (Control control in tblSeats.Controls)
            {
                Button seatButton = control as Button;
                if (seatButton != null)
                {
                    SetSeatColor(seatButton, lockedSeatNumbers.Contains((int)seatButton.Tag));
                }
            }

            UpdateSummary();
            tblSeats.Refresh();

            if (clearedCount > 0)
            {
                MessageBox.Show(
                    "Đã hủy chọn " + clearedCount + " vị trí.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Hiện chưa có vị trí nào đang được chọn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int price = cboTimeFrame.SelectedIndex == 1 ? 150000 : 100000;
            string total = (selectedSeats.Count * price).ToString("N0") + "đ";
            DialogResult result = MessageBox.Show(
                "Xác nhận đặt " + selectedSeats.Count + " vị trí với số tiền " + total + "?",
                "Xác nhận đặt bàn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            foreach (Button seatButton in selectedSeats)
            {
                lockedSeatNumbers.Add((int)seatButton.Tag);
                SetSeatColor(seatButton, true);
            }

            selectedSeats.Clear();
            UpdateSummary();
            MessageBox.Show("Đặt vị trí thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
