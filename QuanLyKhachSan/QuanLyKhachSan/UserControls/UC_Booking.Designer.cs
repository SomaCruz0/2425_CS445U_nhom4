namespace QuanLyKhachSan.UserControls
{
    partial class UC_Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtp_CheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_Checkout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nb_Customer = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_KhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_CalTotal = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ShowAll = new Guna.UI2.WinForms.Guna2Button();
            this.txt_RoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AllotRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_RoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_BedType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_Room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv_Customer = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nb_Customer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dtp_CheckIn
            // 
            this.dtp_CheckIn.Checked = true;
            this.dtp_CheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtp_CheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtp_CheckIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtp_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_CheckIn.Location = new System.Drawing.Point(470, 48);
            this.dtp_CheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_CheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_CheckIn.Name = "dtp_CheckIn";
            this.dtp_CheckIn.Size = new System.Drawing.Size(360, 47);
            this.dtp_CheckIn.TabIndex = 43;
            this.dtp_CheckIn.Value = new System.DateTime(2024, 11, 3, 15, 26, 22, 277);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(466, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ngày nhận phòng";
            // 
            // dtp_Checkout
            // 
            this.dtp_Checkout.Checked = true;
            this.dtp_Checkout.CustomFormat = "dd/MM/yyyy";
            this.dtp_Checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtp_Checkout.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dtp_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Checkout.Location = new System.Drawing.Point(470, 178);
            this.dtp_Checkout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Checkout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Checkout.Name = "dtp_Checkout";
            this.dtp_Checkout.Size = new System.Drawing.Size(360, 47);
            this.dtp_Checkout.TabIndex = 37;
            this.dtp_Checkout.Value = new System.DateTime(2024, 11, 3, 15, 26, 22, 277);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(466, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ngày trả phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Khách hàng";
            // 
            // nb_Customer
            // 
            this.nb_Customer.BackColor = System.Drawing.Color.Transparent;
            this.nb_Customer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nb_Customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nb_Customer.Location = new System.Drawing.Point(17, 177);
            this.nb_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nb_Customer.Name = "nb_Customer";
            this.nb_Customer.Size = new System.Drawing.Size(360, 47);
            this.nb_Customer.TabIndex = 54;
            this.nb_Customer.UpDownButtonFillColor = System.Drawing.Color.Silver;
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(224, 278);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Enter Customer Name";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(349, 36);
            this.txt_Search.TabIndex = 58;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
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
            this.cb_KhachHang.Location = new System.Drawing.Point(17, 48);
            this.cb_KhachHang.Name = "cb_KhachHang";
            this.cb_KhachHang.Size = new System.Drawing.Size(360, 36);
            this.cb_KhachHang.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 85);
            this.panel1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "ĐẶT PHÒNG";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_CalTotal);
            this.panel3.Controls.Add(this.btn_ShowAll);
            this.panel3.Controls.Add(this.txt_RoomNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_AllotRoom);
            this.panel3.Controls.Add(this.txt_Price);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cb_RoomType);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cb_BedType);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cb_KhachHang);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Controls.Add(this.nb_Customer);
            this.panel3.Controls.Add(this.dtp_CheckIn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtp_Checkout);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1644, 319);
            this.panel3.TabIndex = 88;
            // 
            // btn_CalTotal
            // 
            this.btn_CalTotal.BorderRadius = 5;
            this.btn_CalTotal.BorderThickness = 1;
            this.btn_CalTotal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CalTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CalTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CalTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CalTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CalTotal.FillColor = System.Drawing.Color.White;
            this.btn_CalTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CalTotal.ForeColor = System.Drawing.Color.Black;
            this.btn_CalTotal.Location = new System.Drawing.Point(1148, 246);
            this.btn_CalTotal.Name = "btn_CalTotal";
            this.btn_CalTotal.Size = new System.Drawing.Size(231, 64);
            this.btn_CalTotal.TabIndex = 99;
            this.btn_CalTotal.Text = "Tính tổng tiền";
            this.btn_CalTotal.Click += new System.EventHandler(this.btn_CalTotal_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BorderRadius = 5;
            this.btn_ShowAll.BorderThickness = 1;
            this.btn_ShowAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_ShowAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ShowAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ShowAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ShowAll.FillColor = System.Drawing.Color.White;
            this.btn_ShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ShowAll.ForeColor = System.Drawing.Color.Black;
            this.btn_ShowAll.Location = new System.Drawing.Point(929, 246);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(194, 64);
            this.btn_ShowAll.TabIndex = 98;
            this.btn_ShowAll.Text = "Show all";
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RoomNo.DefaultText = "";
            this.txt_RoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_RoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_RoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_RoomNo.ForeColor = System.Drawing.Color.Black;
            this.txt_RoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Location = new System.Drawing.Point(1284, 48);
            this.txt_RoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.PasswordChar = '\0';
            this.txt_RoomNo.PlaceholderText = "";
            this.txt_RoomNo.ReadOnly = true;
            this.txt_RoomNo.SelectedText = "";
            this.txt_RoomNo.Size = new System.Drawing.Size(318, 51);
            this.txt_RoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_RoomNo.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 95;
            this.label1.Text = "Tìm kiếm khách hàng:";
            // 
            // btn_AllotRoom
            // 
            this.btn_AllotRoom.BorderRadius = 5;
            this.btn_AllotRoom.BorderThickness = 1;
            this.btn_AllotRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_AllotRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllotRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AllotRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AllotRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AllotRoom.FillColor = System.Drawing.Color.White;
            this.btn_AllotRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AllotRoom.ForeColor = System.Drawing.Color.Black;
            this.btn_AllotRoom.Location = new System.Drawing.Point(1408, 246);
            this.btn_AllotRoom.Name = "btn_AllotRoom";
            this.btn_AllotRoom.Size = new System.Drawing.Size(194, 64);
            this.btn_AllotRoom.TabIndex = 94;
            this.btn_AllotRoom.Text = "Đặt phòng";
            this.btn_AllotRoom.Click += new System.EventHandler(this.btn_AllotRoom_Click);
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
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Price.ForeColor = System.Drawing.Color.Black;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(1284, 177);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(318, 51);
            this.txt_Price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Price.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(1280, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 23);
            this.label13.TabIndex = 92;
            this.label13.Text = "Tổng tiền";
            this.label13.MouseLeave += new System.EventHandler(this.label13_MouseLeave);
            this.label13.MouseHover += new System.EventHandler(this.label13_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(1280, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 90;
            this.label12.Text = "Số phòng";
            // 
            // cb_RoomType
            // 
            this.cb_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.cb_RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_RoomType.ForeColor = System.Drawing.Color.Black;
            this.cb_RoomType.ItemHeight = 30;
            this.cb_RoomType.Location = new System.Drawing.Point(893, 177);
            this.cb_RoomType.Name = "cb_RoomType";
            this.cb_RoomType.Size = new System.Drawing.Size(332, 36);
            this.cb_RoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_RoomType.TabIndex = 89;
            this.cb_RoomType.SelectedIndexChanged += new System.EventHandler(this.cb_RoomType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(889, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 88;
            this.label11.Text = "Loại phòng";
            // 
            // cb_BedType
            // 
            this.cb_BedType.BackColor = System.Drawing.Color.Transparent;
            this.cb_BedType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BedType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_BedType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_BedType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_BedType.ForeColor = System.Drawing.Color.Black;
            this.cb_BedType.ItemHeight = 30;
            this.cb_BedType.Location = new System.Drawing.Point(893, 48);
            this.cb_BedType.Name = "cb_BedType";
            this.cb_BedType.Size = new System.Drawing.Size(332, 36);
            this.cb_BedType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_BedType.TabIndex = 87;
            this.cb_BedType.SelectedIndexChanged += new System.EventHandler(this.cb_BedType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(889, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 86;
            this.label10.Text = "Loại giường";
            // 
            // dgv_Room
            // 
            this.dgv_Room.AllowUserToAddRows = false;
            this.dgv_Room.AllowUserToDeleteRows = false;
            this.dgv_Room.AllowUserToResizeColumns = false;
            this.dgv_Room.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Room.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_Room.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Room.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Room.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Room.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Room.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Room.Location = new System.Drawing.Point(933, 417);
            this.dgv_Room.Name = "dgv_Room";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Room.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Room.RowHeadersVisible = false;
            this.dgv_Room.RowHeadersWidth = 51;
            this.dgv_Room.RowTemplate.Height = 24;
            this.dgv_Room.Size = new System.Drawing.Size(714, 522);
            this.dgv_Room.TabIndex = 90;
            this.dgv_Room.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Room.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Room.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Room.ThemeStyle.ReadOnly = false;
            this.dgv_Room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Room.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Room_CellClick);
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.AllowUserToAddRows = false;
            this.dgv_Customer.AllowUserToDeleteRows = false;
            this.dgv_Customer.AllowUserToResizeColumns = false;
            this.dgv_Customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Customer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_Customer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Customer.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Customer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Customer.Location = new System.Drawing.Point(3, 417);
            this.dgv_Customer.Name = "dgv_Customer";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Customer.RowHeadersVisible = false;
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.Size = new System.Drawing.Size(924, 522);
            this.dgv_Customer.TabIndex = 89;
            this.dgv_Customer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_Customer.ThemeStyle.ReadOnly = false;
            this.dgv_Customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_Customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            // 
            // UC_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Room);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Booking";
            this.Size = new System.Drawing.Size(1650, 1010);
            this.Load += new System.EventHandler(this.UC_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nb_Customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_CheckIn;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Checkout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nb_Customer;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2ComboBox cb_KhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_AllotRoom;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cb_RoomType;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cb_BedType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_RoomNo;
        private Guna.UI2.WinForms.Guna2Button btn_ShowAll;
        private Guna.UI2.WinForms.Guna2Button btn_CalTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Room;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Customer;
    }
}
