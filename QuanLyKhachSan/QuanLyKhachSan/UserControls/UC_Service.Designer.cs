namespace QuanLyKhachSan.UserControls
{
    partial class UC_Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_SearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_KhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_IDBooking = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AllService = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ShowAllCus = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_Checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nb_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Service = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SearchService = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Order = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_Booking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv_Service = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_SearchCustomer
            // 
            this.txt_SearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchCustomer.DefaultText = "";
            this.txt_SearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchCustomer.Location = new System.Drawing.Point(45, 250);
            this.txt_SearchCustomer.Name = "txt_SearchCustomer";
            this.txt_SearchCustomer.PasswordChar = '\0';
            this.txt_SearchCustomer.PlaceholderText = "Enter Customer Name";
            this.txt_SearchCustomer.SelectedText = "";
            this.txt_SearchCustomer.Size = new System.Drawing.Size(349, 36);
            this.txt_SearchCustomer.TabIndex = 80;
            this.txt_SearchCustomer.TextChanged += new System.EventHandler(this.txt_SearchCustomer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(43, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Khách hàng";
            // 
            // cb_KhachHang
            // 
            this.cb_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cb_KhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_KhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_KhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_KhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_KhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_KhachHang.ItemHeight = 30;
            this.cb_KhachHang.Location = new System.Drawing.Point(45, 74);
            this.cb_KhachHang.Name = "cb_KhachHang";
            this.cb_KhachHang.Size = new System.Drawing.Size(351, 36);
            this.cb_KhachHang.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_IDBooking);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_AllService);
            this.panel2.Controls.Add(this.btn_ShowAllCus);
            this.panel2.Controls.Add(this.dtp_Checkin);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_Total);
            this.panel2.Controls.Add(this.txt_Price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nb_Quantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cb_Service);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_SearchService);
            this.panel2.Controls.Add(this.btn_Order);
            this.panel2.Controls.Add(this.cb_KhachHang);
            this.panel2.Controls.Add(this.txt_SearchCustomer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1644, 291);
            this.panel2.TabIndex = 98;
            // 
            // cb_IDBooking
            // 
            this.cb_IDBooking.BackColor = System.Drawing.Color.Transparent;
            this.cb_IDBooking.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_IDBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IDBooking.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_IDBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_IDBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_IDBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_IDBooking.ItemHeight = 30;
            this.cb_IDBooking.Location = new System.Drawing.Point(47, 172);
            this.cb_IDBooking.Name = "cb_IDBooking";
            this.cb_IDBooking.Size = new System.Drawing.Size(351, 36);
            this.cb_IDBooking.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(45, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 23);
            this.label9.TabIndex = 113;
            this.label9.Text = "Mã hóa đơn";
            // 
            // btn_AllService
            // 
            this.btn_AllService.BorderRadius = 5;
            this.btn_AllService.BorderThickness = 1;
            this.btn_AllService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AllService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AllService.FillColor = System.Drawing.Color.Transparent;
            this.btn_AllService.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AllService.ForeColor = System.Drawing.Color.Black;
            this.btn_AllService.Location = new System.Drawing.Point(1255, 231);
            this.btn_AllService.Name = "btn_AllService";
            this.btn_AllService.Size = new System.Drawing.Size(173, 55);
            this.btn_AllService.TabIndex = 112;
            this.btn_AllService.Text = "Tất cả dịch vụ";
            this.btn_AllService.Click += new System.EventHandler(this.btn_AllService_Click);
            // 
            // btn_ShowAllCus
            // 
            this.btn_ShowAllCus.BorderRadius = 5;
            this.btn_ShowAllCus.BorderThickness = 1;
            this.btn_ShowAllCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowAllCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowAllCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowAllCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowAllCus.FillColor = System.Drawing.Color.Transparent;
            this.btn_ShowAllCus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ShowAllCus.ForeColor = System.Drawing.Color.Black;
            this.btn_ShowAllCus.Location = new System.Drawing.Point(635, 231);
            this.btn_ShowAllCus.Name = "btn_ShowAllCus";
            this.btn_ShowAllCus.Size = new System.Drawing.Size(177, 55);
            this.btn_ShowAllCus.TabIndex = 111;
            this.btn_ShowAllCus.Text = "Tất cả hóa đơn";
            this.btn_ShowAllCus.Click += new System.EventHandler(this.btn_ShowAllCus_Click);
            // 
            // dtp_Checkin
            // 
            this.dtp_Checkin.Checked = true;
            this.dtp_Checkin.CustomFormat = "dd/MM/yyyy";
            this.dtp_Checkin.FillColor = System.Drawing.Color.LightGray;
            this.dtp_Checkin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Checkin.Location = new System.Drawing.Point(461, 74);
            this.dtp_Checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Checkin.Name = "dtp_Checkin";
            this.dtp_Checkin.Size = new System.Drawing.Size(351, 36);
            this.dtp_Checkin.TabIndex = 110;
            this.dtp_Checkin.Value = new System.DateTime(2024, 11, 25, 13, 29, 42, 384);
            this.dtp_Checkin.ValueChanged += new System.EventHandler(this.dtp_Checkin_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(457, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 108;
            this.label8.Text = "Ngày đặt";
            // 
            // txt_Total
            // 
            this.txt_Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total.DefaultText = "";
            this.txt_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Total.Enabled = false;
            this.txt_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Total.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Total.Location = new System.Drawing.Point(1255, 172);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.PasswordChar = '\0';
            this.txt_Total.PlaceholderText = "";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.SelectedText = "";
            this.txt_Total.Size = new System.Drawing.Size(343, 36);
            this.txt_Total.TabIndex = 107;
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.Enabled = false;
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(1255, 74);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(343, 36);
            this.txt_Price.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(1251, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 105;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1251, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 104;
            this.label6.Text = "Tổng tiền";
            // 
            // nb_Quantity
            // 
            this.nb_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.nb_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nb_Quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nb_Quantity.Location = new System.Drawing.Point(891, 172);
            this.nb_Quantity.Name = "nb_Quantity";
            this.nb_Quantity.Size = new System.Drawing.Size(314, 36);
            this.nb_Quantity.TabIndex = 103;
            this.nb_Quantity.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.nb_Quantity.ValueChanged += new System.EventHandler(this.nb_Quantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(887, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Số lượng";
            // 
            // cb_Service
            // 
            this.cb_Service.BackColor = System.Drawing.Color.Transparent;
            this.cb_Service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Service.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Service.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Service.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Service.ItemHeight = 30;
            this.cb_Service.Location = new System.Drawing.Point(889, 74);
            this.cb_Service.Name = "cb_Service";
            this.cb_Service.Size = new System.Drawing.Size(316, 36);
            this.cb_Service.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(887, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Tên sản phẩm";
            // 
            // txt_SearchService
            // 
            this.txt_SearchService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchService.DefaultText = "";
            this.txt_SearchService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SearchService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchService.Location = new System.Drawing.Point(891, 250);
            this.txt_SearchService.Name = "txt_SearchService";
            this.txt_SearchService.PasswordChar = '\0';
            this.txt_SearchService.PlaceholderText = "Enter Product Name";
            this.txt_SearchService.SelectedText = "";
            this.txt_SearchService.Size = new System.Drawing.Size(314, 36);
            this.txt_SearchService.TabIndex = 98;
            this.txt_SearchService.TextChanged += new System.EventHandler(this.txt_SearchService_TextChanged);
            // 
            // btn_Order
            // 
            this.btn_Order.BorderRadius = 5;
            this.btn_Order.BorderThickness = 1;
            this.btn_Order.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Order.FillColor = System.Drawing.Color.White;
            this.btn_Order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.Location = new System.Drawing.Point(1434, 231);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(164, 55);
            this.btn_Order.TabIndex = 97;
            this.btn_Order.Text = "Đặt";
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // dgv_Booking
            // 
            this.dgv_Booking.AllowUserToAddRows = false;
            this.dgv_Booking.AllowUserToDeleteRows = false;
            this.dgv_Booking.AllowUserToResizeColumns = false;
            this.dgv_Booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Booking.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Booking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_Booking.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Booking.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Booking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Booking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Booking.Location = new System.Drawing.Point(3, 391);
            this.dgv_Booking.Name = "dgv_Booking";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Booking.RowHeadersVisible = false;
            this.dgv_Booking.RowHeadersWidth = 51;
            this.dgv_Booking.RowTemplate.Height = 24;
            this.dgv_Booking.Size = new System.Drawing.Size(886, 549);
            this.dgv_Booking.TabIndex = 99;
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
            this.dgv_Booking.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Booking.ThemeStyle.ReadOnly = false;
            this.dgv_Booking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Booking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Booking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Booking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Booking.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Booking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Booking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Booking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Booking_CellClick);
            // 
            // dgv_Service
            // 
            this.dgv_Service.AllowUserToAddRows = false;
            this.dgv_Service.AllowUserToDeleteRows = false;
            this.dgv_Service.AllowUserToResizeColumns = false;
            this.dgv_Service.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Service.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Service.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Service.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_Service.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Service.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Service.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Service.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Service.Location = new System.Drawing.Point(895, 391);
            this.dgv_Service.Name = "dgv_Service";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Service.RowHeadersVisible = false;
            this.dgv_Service.RowHeadersWidth = 51;
            this.dgv_Service.RowTemplate.Height = 24;
            this.dgv_Service.Size = new System.Drawing.Size(752, 549);
            this.dgv_Service.TabIndex = 100;
            this.dgv_Service.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Service.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Service.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Service.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Service.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Service.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Service.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Service.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Service.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Service.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Service.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Service.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Service.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Service.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Service.ThemeStyle.ReadOnly = false;
            this.dgv_Service.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Service.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Service.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Service.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Service.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Service.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Service.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Service_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1669, 85);
            this.panel1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "DỊCH VỤ";
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Service);
            this.Controls.Add(this.dgv_Booking);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1650, 1010);
            this.Load += new System.EventHandler(this.UC_DichVu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchCustomer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_KhachHang;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Total;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown nb_Quantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Service;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchService;
        private Guna.UI2.WinForms.Guna2Button btn_Order;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Booking;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Service;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Checkin;
        private Guna.UI2.WinForms.Guna2Button btn_ShowAllCus;
        private Guna.UI2.WinForms.Guna2Button btn_AllService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_IDBooking;
        private System.Windows.Forms.Label label9;
    }
}
