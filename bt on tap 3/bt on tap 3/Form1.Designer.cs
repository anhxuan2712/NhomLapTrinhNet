namespace bt_on_tap_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.ListView lvVatTu;

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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lvVatTu = new System.Windows.Forms.ListView();
            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();

            this.grpInput.Controls.Add(this.lblMa);
            this.grpInput.Controls.Add(this.txtMa);
            this.grpInput.Controls.Add(this.lblTen);
            this.grpInput.Controls.Add(this.txtTen);
            this.grpInput.Controls.Add(this.lblDonVi);
            this.grpInput.Controls.Add(this.cboDonVi);
            this.grpInput.Controls.Add(this.lblDonGia);
            this.grpInput.Controls.Add(this.txtDonGia);
            this.grpInput.Controls.Add(this.btnThemMoi);
            this.grpInput.Controls.Add(this.btnCapNhat);
            this.grpInput.Controls.Add(this.btnXoaDong);
            this.grpInput.Controls.Add(this.btnXoaToanBo);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(275, 426);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin vật tư / linh kiện";

            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(18, 35);
            this.lblMa.Text = "Mã vật tư:";
            this.txtMa.Location = new System.Drawing.Point(18, 55);
            this.txtMa.Size = new System.Drawing.Size(235, 23);
            this.txtMa.TabIndex = 0;
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(18, 92);
            this.lblTen.Text = "Tên vật tư:";
            this.txtTen.Location = new System.Drawing.Point(18, 112);
            this.txtTen.Size = new System.Drawing.Size(235, 23);
            this.txtTen.TabIndex = 1;
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(18, 149);
            this.lblDonVi.Text = "Đơn vị tính:";
            this.cboDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonVi.FormattingEnabled = true;
            this.cboDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mết" });
            this.cboDonVi.Location = new System.Drawing.Point(18, 169);
            this.cboDonVi.Size = new System.Drawing.Size(235, 24);
            this.cboDonVi.TabIndex = 2;
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(18, 206);
            this.lblDonGia.Text = "Đơn giá nhập:";
            this.txtDonGia.Location = new System.Drawing.Point(18, 226);
            this.txtDonGia.Size = new System.Drawing.Size(235, 23);
            this.txtDonGia.TabIndex = 3;

            this.btnThemMoi.Location = new System.Drawing.Point(18, 270);
            this.btnThemMoi.Size = new System.Drawing.Size(112, 35);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            this.btnCapNhat.Location = new System.Drawing.Point(141, 270);
            this.btnCapNhat.Size = new System.Drawing.Size(112, 35);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.btnXoaDong.Location = new System.Drawing.Point(18, 315);
            this.btnXoaDong.Size = new System.Drawing.Size(112, 35);
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = true;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            this.btnXoaToanBo.Location = new System.Drawing.Point(141, 315);
            this.btnXoaToanBo.Size = new System.Drawing.Size(112, 35);
            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);

            this.grpList.Controls.Add(this.lvVatTu);
            this.grpList.Location = new System.Drawing.Point(303, 12);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(669, 426);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách vật tư / linh kiện";
            this.lvVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVatTu.FullRowSelect = true;
            this.lvVatTu.GridLines = true;
            this.lvVatTu.HideSelection = false;
            this.lvVatTu.Location = new System.Drawing.Point(3, 19);
            this.lvVatTu.MultiSelect = false;
            this.lvVatTu.Name = "lvVatTu";
            this.lvVatTu.Size = new System.Drawing.Size(663, 404);
            this.lvVatTu.TabIndex = 0;
            this.lvVatTu.UseCompatibleStateImageBehavior = false;
            this.lvVatTu.View = System.Windows.Forms.View.Details;
            this.lvVatTu.SelectedIndexChanged += new System.EventHandler(this.lvVatTu_SelectedIndexChanged);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpInput);
            this.MinimumSize = new System.Drawing.Size(800, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục vật tư / linh kiện";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}

