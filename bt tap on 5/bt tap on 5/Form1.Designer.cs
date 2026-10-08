namespace bt_tap_on_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label customerTitleLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.ComboBox shippingComboBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TabControl orderTabControl;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label shortcutLabel;
        private System.Windows.Forms.StatusStrip orderStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel clockStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel quantityStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel weightStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalStatusLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ErrorProvider validationErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerTitleLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.shippingComboBox = new System.Windows.Forms.ComboBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.orderTabControl = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcutLabel = new System.Windows.Forms.Label();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.orderStatusStrip = new System.Windows.Forms.StatusStrip();
            this.clockStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.quantityStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.weightStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.validationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.orderTabControl.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.summaryTabPage.SuspendLayout();
            this.orderStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.customerPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.orderTabControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(1353, 673);
            this.mainSplitContainer.SplitterDistance = 330;
            this.mainSplitContainer.SplitterWidth = 5;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.customerPanel.Controls.Add(this.customerTitleLabel);
            this.customerPanel.Controls.Add(this.customerNameLabel);
            this.customerPanel.Controls.Add(this.customerNameTextBox);
            this.customerPanel.Controls.Add(this.phoneLabel);
            this.customerPanel.Controls.Add(this.phoneTextBox);
            this.customerPanel.Controls.Add(this.addressLabel);
            this.customerPanel.Controls.Add(this.addressTextBox);
            this.customerPanel.Controls.Add(this.shippingLabel);
            this.customerPanel.Controls.Add(this.shippingComboBox);
            this.customerPanel.Controls.Add(this.noteLabel);
            this.customerPanel.Controls.Add(this.noteTextBox);
            this.customerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Padding = new System.Windows.Forms.Padding(21, 19, 21, 19);
            this.customerPanel.Size = new System.Drawing.Size(330, 673);
            this.customerPanel.TabIndex = 0;
            // 
            // customerTitleLabel
            // 
            this.customerTitleLabel.AutoSize = true;
            this.customerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.customerTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(78)))), ((int)(((byte)(121)))));
            this.customerTitleLabel.Location = new System.Drawing.Point(21, 21);
            this.customerTitleLabel.Name = "customerTitleLabel";
            this.customerTitleLabel.Size = new System.Drawing.Size(263, 30);
            this.customerTitleLabel.TabIndex = 0;
            this.customerTitleLabel.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(21, 80);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(111, 16);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Tên khách hàng *";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(21, 101);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(314, 22);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(21, 144);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(85, 16);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Số điện thoại";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(21, 165);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(314, 22);
            this.phoneTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(21, 208);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(118, 16);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Địa chỉ giao hàng *";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(21, 229);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(314, 64);
            this.addressTextBox.TabIndex = 6;
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.Location = new System.Drawing.Point(21, 331);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Size = new System.Drawing.Size(104, 16);
            this.shippingLabel.TabIndex = 7;
            this.shippingLabel.Text = "Loại vận chuyển";
            // 
            // shippingComboBox
            // 
            this.shippingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shippingComboBox.Items.AddRange(new object[] {
            "Tiêu chuẩn (3-5 ngày)",
            "Nhanh (1-2 ngày)",
            "Hỏa tốc (trong ngày)"});
            this.shippingComboBox.Location = new System.Drawing.Point(21, 352);
            this.shippingComboBox.Name = "shippingComboBox";
            this.shippingComboBox.Size = new System.Drawing.Size(314, 24);
            this.shippingComboBox.TabIndex = 8;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(21, 395);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(51, 16);
            this.noteLabel.TabIndex = 9;
            this.noteLabel.Text = "Ghi chú";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(21, 416);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(314, 85);
            this.noteTextBox.TabIndex = 10;
            // 
            // orderTabControl
            // 
            this.orderTabControl.Controls.Add(this.itemsTabPage);
            this.orderTabControl.Controls.Add(this.summaryTabPage);
            this.orderTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTabControl.Location = new System.Drawing.Point(0, 0);
            this.orderTabControl.Name = "orderTabControl";
            this.orderTabControl.Padding = new System.Drawing.Point(12, 5);
            this.orderTabControl.SelectedIndex = 0;
            this.orderTabControl.Size = new System.Drawing.Size(1018, 673);
            this.orderTabControl.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsDataGridView);
            this.itemsTabPage.Controls.Add(this.shortcutLabel);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.itemsTabPage.Size = new System.Drawing.Size(1010, 640);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Chi tiết hàng hóa";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantityColumn,
            this.weightColumn,
            this.unitPriceColumn,
            this.amountColumn});
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.itemsDataGridView.Location = new System.Drawing.Point(9, 34);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.RowHeadersVisible = false;
            this.itemsDataGridView.RowHeadersWidth = 51;
            this.itemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDataGridView.Size = new System.Drawing.Size(992, 597);
            this.itemsDataGridView.TabIndex = 0;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Số lượng";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 90;
            // 
            // weightColumn
            // 
            this.weightColumn.HeaderText = "Trọng lượng (kg)";
            this.weightColumn.MinimumWidth = 6;
            this.weightColumn.Name = "weightColumn";
            this.weightColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.HeaderText = "Đơn giá (VND)";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Width = 130;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Thành tiền (VND)";
            this.amountColumn.MinimumWidth = 6;
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            this.amountColumn.Width = 145;
            // 
            // shortcutLabel
            // 
            this.shortcutLabel.AutoSize = true;
            this.shortcutLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shortcutLabel.ForeColor = System.Drawing.Color.DimGray;
            this.shortcutLabel.Location = new System.Drawing.Point(9, 9);
            this.shortcutLabel.Name = "shortcutLabel";
            this.shortcutLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.shortcutLabel.Size = new System.Drawing.Size(565, 25);
            this.shortcutLabel.TabIndex = 1;
            this.shortcutLabel.Text = "F2: thêm dòng nhanh   |   Delete: xóa dòng đang chọn   |   Số lượng và trọng lượn" +
    "g phải lớn hơn 0";
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.Controls.Add(this.summaryLabel);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 29);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Padding = new System.Windows.Forms.Padding(23, 21, 23, 21);
            this.summaryTabPage.Size = new System.Drawing.Size(963, 640);
            this.summaryTabPage.TabIndex = 1;
            this.summaryTabPage.Text = "Hướng dẫn";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.summaryLabel.Location = new System.Drawing.Point(23, 27);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(562, 125);
            this.summaryLabel.TabIndex = 0;
            this.summaryLabel.Text = resources.GetString("summaryLabel.Text");
            // 
            // orderStatusStrip
            // 
            this.orderStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.orderStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockStatusLabel,
            this.quantityStatusLabel,
            this.weightStatusLabel,
            this.totalStatusLabel});
            this.orderStatusStrip.Location = new System.Drawing.Point(0, 673);
            this.orderStatusStrip.Name = "orderStatusStrip";
            this.orderStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.orderStatusStrip.Size = new System.Drawing.Size(1353, 26);
            this.orderStatusStrip.TabIndex = 1;
            // 
            // clockStatusLabel
            // 
            this.clockStatusLabel.Name = "clockStatusLabel";
            this.clockStatusLabel.Size = new System.Drawing.Size(925, 20);
            this.clockStatusLabel.Spring = true;
            this.clockStatusLabel.Text = "Thời gian: --:--:--";
            this.clockStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityStatusLabel
            // 
            this.quantityStatusLabel.Name = "quantityStatusLabel";
            this.quantityStatusLabel.Size = new System.Drawing.Size(120, 20);
            this.quantityStatusLabel.Text = "Tổng số lượng: 0";
            // 
            // weightStatusLabel
            // 
            this.weightStatusLabel.Name = "weightStatusLabel";
            this.weightStatusLabel.Size = new System.Drawing.Size(161, 20);
            this.weightStatusLabel.Text = "Tổng trọng lượng: 0 kg";
            // 
            // totalStatusLabel
            // 
            this.totalStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.totalStatusLabel.Name = "totalStatusLabel";
            this.totalStatusLabel.Size = new System.Drawing.Size(130, 20);
            this.totalStatusLabel.Text = "Tổng tiền: 0 VND";
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            // 
            // validationErrorProvider
            // 
            this.validationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.validationErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 699);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.orderStatusStrip);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1026, 584);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển Quản lý Đơn giao hàng";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.orderTabControl.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.itemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.summaryTabPage.ResumeLayout(false);
            this.summaryTabPage.PerformLayout();
            this.orderStatusStrip.ResumeLayout(false);
            this.orderStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

