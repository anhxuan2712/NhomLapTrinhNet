namespace bt_on_tap_4
{
    partial class Form1
    {
        private System.Windows.Forms.TableLayoutPanel tblSeats;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTimeFrame;
        private System.Windows.Forms.ComboBox cboTimeFrame;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLegend;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblSeats = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTimeFrame = new System.Windows.Forms.Label();
            this.cboTimeFrame = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLegend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tblSeats
            // 
            this.tblSeats.ColumnCount = 5;
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.Location = new System.Drawing.Point(25, 75);
            this.tblSeats.Name = "tblSeats";
            this.tblSeats.RowCount = 4;
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSeats.Size = new System.Drawing.Size(750, 270);
            this.tblSeats.TabIndex = 0;
            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCount.Location = new System.Drawing.Point(25, 365);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(156, 19);
            this.lblSelectedCount.TabIndex = 1;
            this.lblSelectedCount.Text = "Số vị trí đang chọn: 0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(25, 397);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(141, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Tạm tính tiền: 0đ";
            // 
            // lblTimeFrame
            // 
            this.lblTimeFrame.AutoSize = true;
            this.lblTimeFrame.Location = new System.Drawing.Point(25, 25);
            this.lblTimeFrame.Name = "lblTimeFrame";
            this.lblTimeFrame.Size = new System.Drawing.Size(71, 15);
            this.lblTimeFrame.TabIndex = 3;
            this.lblTimeFrame.Text = "Khung giờ:";
            // 
            // cboTimeFrame
            // 
            this.cboTimeFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeFrame.FormattingEnabled = true;
            this.cboTimeFrame.Items.AddRange(new object[] { "Sáng - 100.000đ", "Tối - 150.000đ" });
            this.cboTimeFrame.Location = new System.Drawing.Point(102, 22);
            this.cboTimeFrame.Name = "cboTimeFrame";
            this.cboTimeFrame.Size = new System.Drawing.Size(180, 23);
            this.cboTimeFrame.TabIndex = 4;
            this.cboTimeFrame.SelectedIndexChanged += new System.EventHandler(this.cboTimeFrame_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(510, 390);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 35);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận đặt";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(650, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Hủy chọn tất cả";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.ForeColor = System.Drawing.Color.DimGray;
            this.lblLegend.Location = new System.Drawing.Point(320, 27);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(422, 15);
            this.lblLegend.TabIndex = 7;
            this.lblLegend.Text = "Trắng: Trống   |   Xanh lá: Đang chọn   |   Đỏ: Đã có người đặt / Đã khóa";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cboTimeFrame);
            this.Controls.Add(this.lblTimeFrame);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSelectedCount);
            this.Controls.Add(this.tblSeats);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sơ đồ chọn vị trí - Đặt bàn hẹn giờ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

