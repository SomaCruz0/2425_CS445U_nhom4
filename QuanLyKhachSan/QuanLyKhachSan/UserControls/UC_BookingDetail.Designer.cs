namespace QuanLyKhachSan.UserControls
{
    partial class UC_BookingDetail
    {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Print = new Guna.UI2.WinForms.Guna2Button();
            this.fromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Booking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_Load = new Guna.UI2.WinForms.Guna2Button();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDatPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_Print
            // 
            this.btn_Print.BorderRadius = 5;
            this.btn_Print.BorderThickness = 1;
            this.btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Print.FillColor = System.Drawing.Color.White;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Print.ForeColor = System.Drawing.Color.Black;
            this.btn_Print.Location = new System.Drawing.Point(1370, 808);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(218, 138);
            this.btn_Print.TabIndex = 90;
            this.btn_Print.Text = "IN HÓA ĐƠN";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // fromDate
            // 
            this.fromDate.Checked = true;
            this.fromDate.CustomFormat = "dd/MM/yyyy";
            this.fromDate.FillColor = System.Drawing.Color.Silver;
            this.fromDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(281, 117);
            this.fromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(237, 50);
            this.fromDate.TabIndex = 91;
            this.fromDate.Value = new System.DateTime(2024, 12, 2, 21, 29, 25, 58);
            // 
            // toDate
            // 
            this.toDate.Checked = true;
            this.toDate.CustomFormat = "dd/MM/yyyy";
            this.toDate.FillColor = System.Drawing.Color.Silver;
            this.toDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(757, 117);
            this.toDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(237, 50);
            this.toDate.TabIndex = 92;
            this.toDate.Value = new System.DateTime(2024, 12, 2, 21, 29, 25, 55);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(158, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(624, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 94;
            this.label3.Text = "Đến ngày:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 85);
            this.panel1.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "HÓA ĐƠN";
            // 
            // dgv_Booking
            // 
            this.dgv_Booking.AllowUserToAddRows = false;
            this.dgv_Booking.AllowUserToDeleteRows = false;
            this.dgv_Booking.AllowUserToResizeColumns = false;
            this.dgv_Booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Booking.AutoGenerateColumns = false;
            this.dgv_Booking.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Booking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_Booking.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Booking.ColumnHeadersHeight = 40;
            this.dgv_Booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDatPhongDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngayDatDataGridViewTextBoxColumn});
            this.dgv_Booking.DataSource = this.billBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Booking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Booking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Booking.Location = new System.Drawing.Point(63, 201);
            this.dgv_Booking.Name = "dgv_Booking";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Booking.RowHeadersVisible = false;
            this.dgv_Booking.RowHeadersWidth = 51;
            this.dgv_Booking.RowTemplate.Height = 24;
            this.dgv_Booking.Size = new System.Drawing.Size(1240, 745);
            this.dgv_Booking.TabIndex = 101;
            this.dgv_Booking.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Booking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Booking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Booking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Booking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Booking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Booking.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Booking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Booking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Booking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Booking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Booking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Booking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Booking.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_Booking.ThemeStyle.ReadOnly = false;
            this.dgv_Booking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Booking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Booking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Booking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Booking.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Booking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Booking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // btn_Load
            // 
            this.btn_Load.BorderRadius = 5;
            this.btn_Load.BorderThickness = 1;
            this.btn_Load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Load.FillColor = System.Drawing.Color.White;
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Load.ForeColor = System.Drawing.Color.Black;
            this.btn_Load.Location = new System.Drawing.Point(1110, 117);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(157, 50);
            this.btn_Load.TabIndex = 102;
            this.btn_Load.Text = "Load";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(QuanLyKhachSan.Bill);
            // 
            // iDDatPhongDataGridViewTextBoxColumn
            // 
            this.iDDatPhongDataGridViewTextBoxColumn.DataPropertyName = "IDDatPhong";
            this.iDDatPhongDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.iDDatPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDatPhongDataGridViewTextBoxColumn.Name = "iDDatPhongDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Người lập hóa đơn";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // ngayDatDataGridViewTextBoxColumn
            // 
            this.ngayDatDataGridViewTextBoxColumn.DataPropertyName = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.HeaderText = "Ngày đặt";
            this.ngayDatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDatDataGridViewTextBoxColumn.Name = "ngayDatDataGridViewTextBoxColumn";
            // 
            // UC_BookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dgv_Booking);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.btn_Print);
            this.Name = "UC_BookingDetail";
            this.Size = new System.Drawing.Size(1650, 1010);
            this.Load += new System.EventHandler(this.UC_BookingDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_Print;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Booking;
        private Guna.UI2.WinForms.Guna2Button btn_Load;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDatPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatDataGridViewTextBoxColumn;
    }
}
