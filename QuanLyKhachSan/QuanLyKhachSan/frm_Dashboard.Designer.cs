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
            this.btn_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CustomerReg = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Room = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CustomerRes1 = new QuanLyKhachSan.UserControls.UC_CustomerRes();
            this.uC_AddRoom1 = new QuanLyKhachSan.UserControls.UC_AddRoom();
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
            this.panel1.Controls.Add(this.btn_Employee);
            this.panel1.Controls.Add(this.btn_CustomerDetail);
            this.panel1.Controls.Add(this.btn_Checkout);
            this.panel1.Controls.Add(this.btn_CustomerReg);
            this.panel1.Controls.Add(this.btn_Room);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1030);
            this.panel1.TabIndex = 3;
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Employee.BorderRadius = 20;
            this.btn_Employee.BorderThickness = 1;
            this.btn_Employee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Employee.Font = new System.Drawing.Font("000 Captain Comic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Location = new System.Drawing.Point(4, 416);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(224, 97);
            this.btn_Employee.TabIndex = 4;
            this.btn_Employee.Text = "Nhân viên";
            // 
            // btn_CustomerDetail
            // 
            this.btn_CustomerDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CustomerDetail.BorderRadius = 20;
            this.btn_CustomerDetail.BorderThickness = 1;
            this.btn_CustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CustomerDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CustomerDetail.Font = new System.Drawing.Font("000 Captain Comic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerDetail.Location = new System.Drawing.Point(4, 313);
            this.btn_CustomerDetail.Name = "btn_CustomerDetail";
            this.btn_CustomerDetail.Size = new System.Drawing.Size(224, 97);
            this.btn_CustomerDetail.TabIndex = 3;
            this.btn_CustomerDetail.Text = "Chi tiết khách hàng";
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
            this.btn_Checkout.Font = new System.Drawing.Font("000 Captain Comic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Location = new System.Drawing.Point(4, 210);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(224, 97);
            this.btn_Checkout.TabIndex = 2;
            this.btn_Checkout.Text = "Thanh toán";
            // 
            // btn_CustomerReg
            // 
            this.btn_CustomerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CustomerReg.BorderRadius = 20;
            this.btn_CustomerReg.BorderThickness = 1;
            this.btn_CustomerReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_CustomerReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CustomerReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CustomerReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CustomerReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CustomerReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CustomerReg.Font = new System.Drawing.Font("000 Captain Comic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerReg.ForeColor = System.Drawing.Color.White;
            this.btn_CustomerReg.Location = new System.Drawing.Point(4, 107);
            this.btn_CustomerReg.Name = "btn_CustomerReg";
            this.btn_CustomerReg.Size = new System.Drawing.Size(224, 97);
            this.btn_CustomerReg.TabIndex = 1;
            this.btn_CustomerReg.Text = "Đăng ký khách hàng";
            this.btn_CustomerReg.Click += new System.EventHandler(this.btn_CustomerReg_Click);
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
            this.btn_Room.Font = new System.Drawing.Font("000 Captain Comic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Room.ForeColor = System.Drawing.Color.White;
            this.btn_Room.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_Room.Location = new System.Drawing.Point(4, 4);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(224, 97);
            this.btn_Room.TabIndex = 0;
            this.btn_Room.Text = "Phòng";
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(267, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1663, 1015);
            this.panel2.TabIndex = 4;
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
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRes1.Location = new System.Drawing.Point(-1, -2);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1650, 1010);
            this.uC_CustomerRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 5);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1653, 1003);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
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
        private Guna.UI2.WinForms.Guna2Button btn_CustomerDetail;
        private Guna.UI2.WinForms.Guna2Button btn_Checkout;
        private Guna.UI2.WinForms.Guna2Button btn_CustomerReg;
        private Guna.UI2.WinForms.Guna2Button btn_Employee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UserControls.UC_CustomerRes uC_CustomerRes1;
    }
}