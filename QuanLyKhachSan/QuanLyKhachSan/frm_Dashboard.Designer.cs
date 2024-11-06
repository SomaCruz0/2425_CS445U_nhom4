namespace QuanLyKhachSan
{
    partial class frm_Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.btn_Exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Minisize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Account = new Guna.UI2.WinForms.Guna2Button();
            this.btn_System = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Service = new Guna.UI2.WinForms.Guna2Button();
            this.btn_BookingDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Category = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_User = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Booking = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Room = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Booking1 = new QuanLyKhachSan.UserControls.UC_Booking();
            this.uC_CustomerRes1 = new QuanLyKhachSan.UserControls.UC_CustomerRes();
            this.uC_AddRoom1 = new QuanLyKhachSan.UserControls.UC_AddRoom();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_Authority = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Exit.Location = new System.Drawing.Point(1882, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.PressedColor = System.Drawing.Color.BlueViolet;
            this.btn_Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Exit.Size = new System.Drawing.Size(57, 52);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minisize
            // 
            this.btn_Minisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Minisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Minisize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Minisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minisize.ForeColor = System.Drawing.Color.White;
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Minisize.Location = new System.Drawing.Point(1819, 2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.PressedColor = System.Drawing.Color.BlueViolet;
            this.btn_Minisize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Minisize.Size = new System.Drawing.Size(57, 52);
            this.btn_Minisize.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.btn_System);
            this.panel1.Controls.Add(this.btn_Service);
            this.panel1.Controls.Add(this.btn_BookingDetail);
            this.panel1.Controls.Add(this.btn_Category);
            this.panel1.Controls.Add(this.btn_Checkout);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_User);
            this.panel1.Controls.Add(this.btn_Booking);
            this.panel1.Controls.Add(this.btn_Customer);
            this.panel1.Controls.Add(this.btn_Room);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1002);
            this.panel1.TabIndex = 3;
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Account.BorderRadius = 20;
            this.btn_Account.BorderThickness = 1;
            this.btn_Account.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Account.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Account.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Account.Location = new System.Drawing.Point(4, 780);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(224, 72);
            this.btn_Account.TabIndex = 11;
            this.btn_Account.Text = "Tài khoản";
            // 
            // btn_System
            // 
            this.btn_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_System.BorderRadius = 20;
            this.btn_System.BorderThickness = 1;
            this.btn_System.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_System.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_System.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_System.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_System.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_System.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_System.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_System.ForeColor = System.Drawing.Color.White;
            this.btn_System.Image = ((System.Drawing.Image)(resources.GetObject("btn_System.Image")));
            this.btn_System.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_System.Location = new System.Drawing.Point(4, 702);
            this.btn_System.Name = "btn_System";
            this.btn_System.Size = new System.Drawing.Size(224, 72);
            this.btn_System.TabIndex = 10;
            this.btn_System.Text = "Hệ thống";
            // 
            // btn_Service
            // 
            this.btn_Service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Service.BorderRadius = 20;
            this.btn_Service.BorderThickness = 1;
            this.btn_Service.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Service.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Service.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Service.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Service.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Service.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Service.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Service.ForeColor = System.Drawing.Color.White;
            this.btn_Service.Image = ((System.Drawing.Image)(resources.GetObject("btn_Service.Image")));
            this.btn_Service.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Service.Location = new System.Drawing.Point(4, 232);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(224, 72);
            this.btn_Service.TabIndex = 9;
            this.btn_Service.Text = "Dịch vụ";
            // 
            // btn_BookingDetail
            // 
            this.btn_BookingDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_BookingDetail.BorderRadius = 20;
            this.btn_BookingDetail.BorderThickness = 1;
            this.btn_BookingDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_BookingDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BookingDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BookingDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BookingDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BookingDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_BookingDetail.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookingDetail.ForeColor = System.Drawing.Color.White;
            this.btn_BookingDetail.Image = ((System.Drawing.Image)(resources.GetObject("btn_BookingDetail.Image")));
            this.btn_BookingDetail.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_BookingDetail.Location = new System.Drawing.Point(4, 466);
            this.btn_BookingDetail.Name = "btn_BookingDetail";
            this.btn_BookingDetail.Size = new System.Drawing.Size(224, 72);
            this.btn_BookingDetail.TabIndex = 8;
            this.btn_BookingDetail.Text = "Hóa đơn";
            // 
            // btn_Category
            // 
            this.btn_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Category.BorderRadius = 20;
            this.btn_Category.BorderThickness = 1;
            this.btn_Category.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Category.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.ForeColor = System.Drawing.Color.White;
            this.btn_Category.Image = ((System.Drawing.Image)(resources.GetObject("btn_Category.Image")));
            this.btn_Category.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Category.Location = new System.Drawing.Point(4, 310);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(224, 72);
            this.btn_Category.TabIndex = 7;
            this.btn_Category.Text = "Danh mục";
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Checkout.BorderRadius = 20;
            this.btn_Checkout.BorderThickness = 1;
            this.btn_Checkout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Checkout.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Checkout.Image")));
            this.btn_Checkout.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Checkout.Location = new System.Drawing.Point(4, 388);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(224, 72);
            this.btn_Checkout.TabIndex = 3;
            this.btn_Checkout.Text = "Thanh toán";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Dashboard.BorderRadius = 20;
            this.btn_Dashboard.BorderThickness = 1;
            this.btn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Dashboard.Location = new System.Drawing.Point(2, 624);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(224, 72);
            this.btn_Dashboard.TabIndex = 5;
            this.btn_Dashboard.Text = "Thống kê";
            // 
            // btn_User
            // 
            this.btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_User.BorderRadius = 20;
            this.btn_User.BorderThickness = 1;
            this.btn_User.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_User.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_User.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.Color.White;
            this.btn_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_User.Image")));
            this.btn_User.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_User.Location = new System.Drawing.Point(3, 546);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(224, 72);
            this.btn_User.TabIndex = 4;
            this.btn_User.Text = "Người dùng";
            // 
            // btn_Booking
            // 
            this.btn_Booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Booking.BorderRadius = 20;
            this.btn_Booking.BorderThickness = 1;
            this.btn_Booking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Booking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Booking.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Booking.ForeColor = System.Drawing.Color.White;
            this.btn_Booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_Booking.Image")));
            this.btn_Booking.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Booking.Location = new System.Drawing.Point(4, 154);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(224, 72);
            this.btn_Booking.TabIndex = 2;
            this.btn_Booking.Text = "Đặt phòng";
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Customer.BorderRadius = 20;
            this.btn_Customer.BorderThickness = 1;
            this.btn_Customer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Customer.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer.Image")));
            this.btn_Customer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Customer.Location = new System.Drawing.Point(4, 78);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(224, 70);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Khách hàng";
            this.btn_Customer.Click += new System.EventHandler(this.btn_CustomerReg_Click);
            // 
            // btn_Room
            // 
            this.btn_Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Room.BorderRadius = 20;
            this.btn_Room.BorderThickness = 1;
            this.btn_Room.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Room.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Room.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Room.ForeColor = System.Drawing.Color.White;
            this.btn_Room.Image = ((System.Drawing.Image)(resources.GetObject("btn_Room.Image")));
            this.btn_Room.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Room.Location = new System.Drawing.Point(4, 4);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(224, 68);
            this.btn_Room.TabIndex = 0;
            this.btn_Room.Text = "Phòng";
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_Booking1);
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(267, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1663, 1002);
            this.panel2.TabIndex = 4;
            // 
            // uC_Booking1
            // 
            this.uC_Booking1.BackColor = System.Drawing.Color.White;
            this.uC_Booking1.Location = new System.Drawing.Point(3, 3);
            this.uC_Booking1.Name = "uC_Booking1";
            this.uC_Booking1.Size = new System.Drawing.Size(1653, 991);
            this.uC_Booking1.TabIndex = 2;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(3, 3);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1653, 991);
            this.uC_CustomerRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 5);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1653, 991);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(47, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // txt_Authority
            // 
            this.txt_Authority.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Authority.DefaultText = "";
            this.txt_Authority.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Authority.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Authority.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Authority.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Authority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Authority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Authority.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Authority.Location = new System.Drawing.Point(267, 11);
            this.txt_Authority.Name = "txt_Authority";
            this.txt_Authority.PasswordChar = '\0';
            this.txt_Authority.PlaceholderText = "";
            this.txt_Authority.ReadOnly = true;
            this.txt_Authority.SelectedText = "";
            this.txt_Authority.Size = new System.Drawing.Size(200, 36);
            this.txt_Authority.TabIndex = 6;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Logout.BorderThickness = 1;
            this.btn_Logout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Logout.FillColor = System.Drawing.Color.IndianRed;
            this.btn_Logout.Font = new System.Drawing.Font("MTO Canun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Logout.Location = new System.Drawing.Point(4, 921);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(224, 72);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "Đăng xuất";
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.txt_Authority);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Minisize);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btn_Exit;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Minisize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Room;
        private Guna.UI2.WinForms.Guna2Button btn_Checkout;
        private Guna.UI2.WinForms.Guna2Button btn_Booking;
        private Guna.UI2.WinForms.Guna2Button btn_Customer;
        private Guna.UI2.WinForms.Guna2Button btn_User;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btn_Dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_Category;
        private UserControls.UC_CustomerRes uC_CustomerRes1;
        private UserControls.UC_Booking uC_Booking1;
        private Guna.UI2.WinForms.Guna2Button btn_BookingDetail;
        private Guna.UI2.WinForms.Guna2Button btn_Service;
        private Guna.UI2.WinForms.Guna2Button btn_System;
        private Guna.UI2.WinForms.Guna2Button btn_Account;
        private Guna.UI2.WinForms.Guna2TextBox txt_Authority;
        private Guna.UI2.WinForms.Guna2Button btn_Logout;
    }
}