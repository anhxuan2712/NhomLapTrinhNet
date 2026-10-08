namespace bt_on_tap_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTicketInfo;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.RadioButton rdoLow;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoUrgent;
        private System.Windows.Forms.GroupBox grpClassification;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.ComboBox cboIncidentType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;

        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTicketInfo = new System.Windows.Forms.GroupBox();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lblRequester = new System.Windows.Forms.Label();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.rdoLow = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoUrgent = new System.Windows.Forms.RadioButton();
            this.grpClassification = new System.Windows.Forms.GroupBox();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.cboIncidentType = new System.Windows.Forms.ComboBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picError = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpTicketInfo.SuspendLayout();
            this.grpClassification.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(206, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 26);
            this.lblTitle.Text = "TIẾP NHẬN & PHÂN LOẠI SỰ CỐ IT";
            // grpTicketInfo
            this.grpTicketInfo.Controls.Add(this.lblTicketId);
            this.grpTicketInfo.Controls.Add(this.txtTicketId);
            this.grpTicketInfo.Controls.Add(this.lblRequester);
            this.grpTicketInfo.Controls.Add(this.txtRequester);
            this.grpTicketInfo.Controls.Add(this.lblReceivedDate);
            this.grpTicketInfo.Controls.Add(this.dtpReceivedDate);
            this.grpTicketInfo.Controls.Add(this.lblPriority);
            this.grpTicketInfo.Controls.Add(this.rdoLow);
            this.grpTicketInfo.Controls.Add(this.rdoMedium);
            this.grpTicketInfo.Controls.Add(this.rdoUrgent);
            this.grpTicketInfo.Location = new System.Drawing.Point(20, 58);
            this.grpTicketInfo.Name = "grpTicketInfo";
            this.grpTicketInfo.Size = new System.Drawing.Size(760, 135);
            this.grpTicketInfo.Text = "Thông tin phiếu";
            // ticket information controls
            this.lblTicketId.AutoSize = true; this.lblTicketId.Location = new System.Drawing.Point(20, 30); this.lblTicketId.Text = "Mã phiếu:";
            this.txtTicketId.Location = new System.Drawing.Point(105, 27); this.txtTicketId.Size = new System.Drawing.Size(180, 20); this.txtTicketId.Name = "txtTicketId";
            this.lblRequester.AutoSize = true; this.lblRequester.Location = new System.Drawing.Point(320, 30); this.lblRequester.Text = "Người yêu cầu:";
            this.txtRequester.Location = new System.Drawing.Point(425, 27); this.txtRequester.Size = new System.Drawing.Size(300, 20); this.txtRequester.Name = "txtRequester";
            this.lblReceivedDate.AutoSize = true; this.lblReceivedDate.Location = new System.Drawing.Point(20, 70); this.lblReceivedDate.Text = "Ngày ghi nhận:";
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpReceivedDate.Location = new System.Drawing.Point(105, 67); this.dtpReceivedDate.Name = "dtpReceivedDate"; this.dtpReceivedDate.Size = new System.Drawing.Size(180, 20);
            this.lblPriority.AutoSize = true; this.lblPriority.Location = new System.Drawing.Point(320, 70); this.lblPriority.Text = "Mức độ ưu tiên:";
            this.rdoLow.AutoSize = true; this.rdoLow.Location = new System.Drawing.Point(425, 68); this.rdoLow.Text = "Thấp"; this.rdoLow.Name = "rdoLow";
            this.rdoMedium.AutoSize = true; this.rdoMedium.Location = new System.Drawing.Point(500, 68); this.rdoMedium.Text = "Trung bình"; this.rdoMedium.Name = "rdoMedium";
            this.rdoUrgent.AutoSize = true; this.rdoUrgent.Location = new System.Drawing.Point(610, 68); this.rdoUrgent.Text = "Khẩn cấp"; this.rdoUrgent.Name = "rdoUrgent";
            // grpClassification
            this.grpClassification.Controls.Add(this.lblIncidentType); this.grpClassification.Controls.Add(this.cboIncidentType); this.grpClassification.Controls.Add(this.lblDevices);
            this.grpClassification.Controls.Add(this.chkDesktop); this.grpClassification.Controls.Add(this.chkLaptop); this.grpClassification.Controls.Add(this.chkPrinter); this.grpClassification.Controls.Add(this.chkPhone);
            this.grpClassification.Location = new System.Drawing.Point(20, 205); this.grpClassification.Name = "grpClassification"; this.grpClassification.Size = new System.Drawing.Size(430, 180); this.grpClassification.Text = "Phân loại & thiết bị ảnh hưởng";
            this.lblIncidentType.AutoSize = true; this.lblIncidentType.Location = new System.Drawing.Point(20, 32); this.lblIncidentType.Text = "Loại sự cố:";
            this.cboIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboIncidentType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" }); this.cboIncidentType.Location = new System.Drawing.Point(115, 29); this.cboIncidentType.Name = "cboIncidentType"; this.cboIncidentType.Size = new System.Drawing.Size(280, 21);
            this.lblDevices.AutoSize = true; this.lblDevices.Location = new System.Drawing.Point(20, 70); this.lblDevices.Text = "Thiết bị ảnh hưởng:";
            this.chkDesktop.AutoSize = true; this.chkDesktop.Location = new System.Drawing.Point(23, 98); this.chkDesktop.Text = "Máy tính bàn"; this.chkDesktop.Name = "chkDesktop";
            this.chkLaptop.AutoSize = true; this.chkLaptop.Location = new System.Drawing.Point(160, 98); this.chkLaptop.Text = "Laptop"; this.chkLaptop.Name = "chkLaptop";
            this.chkPrinter.AutoSize = true; this.chkPrinter.Location = new System.Drawing.Point(23, 132); this.chkPrinter.Text = "Máy in"; this.chkPrinter.Name = "chkPrinter";
            this.chkPhone.AutoSize = true; this.chkPhone.Location = new System.Drawing.Point(160, 132); this.chkPhone.Text = "Điện thoại"; this.chkPhone.Name = "chkPhone";
            // grpImage
            this.grpImage.Controls.Add(this.picError); this.grpImage.Controls.Add(this.btnLoadImage); this.grpImage.Location = new System.Drawing.Point(470, 205); this.grpImage.Name = "grpImage"; this.grpImage.Size = new System.Drawing.Size(310, 180); this.grpImage.Text = "Ảnh chụp lỗi";
            this.picError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.picError.Location = new System.Drawing.Point(20, 25); this.picError.Name = "picError"; this.picError.Size = new System.Drawing.Size(270, 105); this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; this.picError.TabStop = false;
            this.btnLoadImage.Location = new System.Drawing.Point(82, 140); this.btnLoadImage.Name = "btnLoadImage"; this.btnLoadImage.Size = new System.Drawing.Size(145, 27); this.btnLoadImage.Text = "Tải ảnh lỗi"; this.btnLoadImage.UseVisualStyleBackColor = true; this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // action buttons
            this.btnSubmit.Location = new System.Drawing.Point(275, 405); this.btnSubmit.Name = "btnSubmit"; this.btnSubmit.Size = new System.Drawing.Size(130, 35); this.btnSubmit.Text = "Gửi yêu cầu"; this.btnSubmit.UseVisualStyleBackColor = true; this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnReset.Location = new System.Drawing.Point(425, 405); this.btnReset.Name = "btnReset"; this.btnReset.Size = new System.Drawing.Size(130, 35); this.btnReset.Text = "Nhập lại"; this.btnReset.UseVisualStyleBackColor = true; this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Support Ticket Form";
            this.Controls.Add(this.lblTitle); this.Controls.Add(this.grpTicketInfo); this.Controls.Add(this.grpClassification); this.Controls.Add(this.grpImage); this.Controls.Add(this.btnSubmit); this.Controls.Add(this.btnReset);
            this.grpTicketInfo.ResumeLayout(false); this.grpTicketInfo.PerformLayout(); this.grpClassification.ResumeLayout(false); this.grpClassification.PerformLayout(); this.grpImage.ResumeLayout(false); ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }

        #endregion
    }
}

