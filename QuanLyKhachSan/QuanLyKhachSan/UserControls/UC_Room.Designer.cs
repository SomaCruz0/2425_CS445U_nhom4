namespace QuanLyKhachSan.UserControls
{
    partial class UC_Room
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
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbt_NotBooked = new System.Windows.Forms.RadioButton();
            this.rbt_IsBooked = new System.Windows.Forms.RadioButton();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_BedType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_RoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_RoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Count = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Load = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_Room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
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
            this.txt_Search.Location = new System.Drawing.Point(135, 51);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Enter Room No";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(184, 50);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // rbt_NotBooked
            // 
            this.rbt_NotBooked.AutoSize = true;
            this.rbt_NotBooked.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_NotBooked.Location = new System.Drawing.Point(342, 29);
            this.rbt_NotBooked.Name = "rbt_NotBooked";
            this.rbt_NotBooked.Size = new System.Drawing.Size(120, 32);
            this.rbt_NotBooked.TabIndex = 18;
            this.rbt_NotBooked.TabStop = true;
            this.rbt_NotBooked.Text = "Còn trống";
            this.rbt_NotBooked.UseVisualStyleBackColor = true;
            this.rbt_NotBooked.CheckedChanged += new System.EventHandler(this.rbt_NotBooked_CheckedChanged);
            // 
            // rbt_IsBooked
            // 
            this.rbt_IsBooked.AutoSize = true;
            this.rbt_IsBooked.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbt_IsBooked.Location = new System.Drawing.Point(342, 72);
            this.rbt_IsBooked.Name = "rbt_IsBooked";
            this.rbt_IsBooked.Size = new System.Drawing.Size(141, 32);
            this.rbt_IsBooked.TabIndex = 19;
            this.rbt_IsBooked.TabStop = true;
            this.rbt_IsBooked.Text = "Đã được đặt";
            this.rbt_IsBooked.UseVisualStyleBackColor = true;
            this.rbt_IsBooked.CheckedChanged += new System.EventHandler(this.rbt_IsBooked_CheckedChanged);
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Price.ForeColor = System.Drawing.Color.Black;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(103, 660);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(500, 57);
            this.txt_Price.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá tiền";
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.BorderRadius = 5;
            this.btn_AddRoom.BorderThickness = 1;
            this.btn_AddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_AddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_AddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddRoom.FillColor = System.Drawing.Color.White;
            this.btn_AddRoom.Font = new System.Drawing.Font("000 Frank Bellamy iCiel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRoom.ForeColor = System.Drawing.Color.Black;
            this.btn_AddRoom.Location = new System.Drawing.Point(102, 753);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(131, 62);
            this.btn_AddRoom.TabIndex = 11;
            this.btn_AddRoom.Text = "Thêm";
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BorderRadius = 5;
            this.btn_Delete.BorderThickness = 1;
            this.btn_Delete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Delete.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.FillColor = System.Drawing.Color.White;
            this.btn_Delete.Font = new System.Drawing.Font("000 Frank Bellamy iCiel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(468, 753);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(131, 62);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BorderRadius = 5;
            this.btn_Edit.BorderThickness = 1;
            this.btn_Edit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Edit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edit.FillColor = System.Drawing.Color.White;
            this.btn_Edit.Font = new System.Drawing.Font("000 Frank Bellamy iCiel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(285, 753);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(131, 62);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(97, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại giường";
            // 
            // cb_BedType
            // 
            this.cb_BedType.BackColor = System.Drawing.Color.Transparent;
            this.cb_BedType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_BedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BedType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_BedType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_BedType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_BedType.ForeColor = System.Drawing.Color.Black;
            this.cb_BedType.ItemHeight = 30;
            this.cb_BedType.Location = new System.Drawing.Point(103, 534);
            this.cb_BedType.Name = "cb_BedType";
            this.cb_BedType.Size = new System.Drawing.Size(500, 36);
            this.cb_BedType.TabIndex = 4;
            // 
            // cb_RoomType
            // 
            this.cb_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.cb_RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_RoomType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_RoomType.ForeColor = System.Drawing.Color.Black;
            this.cb_RoomType.ItemHeight = 30;
            this.cb_RoomType.Location = new System.Drawing.Point(103, 379);
            this.cb_RoomType.Name = "cb_RoomType";
            this.cb_RoomType.Size = new System.Drawing.Size(499, 36);
            this.cb_RoomType.TabIndex = 3;
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
            this.txt_RoomNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_RoomNo.ForeColor = System.Drawing.Color.Black;
            this.txt_RoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Location = new System.Drawing.Point(102, 223);
            this.txt_RoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.PasswordChar = '\0';
            this.txt_RoomNo.PlaceholderText = "";
            this.txt_RoomNo.SelectedText = "";
            this.txt_RoomNo.Size = new System.Drawing.Size(500, 57);
            this.txt_RoomNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1670, 85);
            this.panel1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // txt_Count
            // 
            this.txt_Count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Count.DefaultText = "";
            this.txt_Count.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Count.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Count.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Count.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Count.Enabled = false;
            this.txt_Count.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Count.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Count.ForeColor = System.Drawing.Color.Black;
            this.txt_Count.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Count.Location = new System.Drawing.Point(855, 61);
            this.txt_Count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.PasswordChar = '\0';
            this.txt_Count.PlaceholderText = "";
            this.txt_Count.ReadOnly = true;
            this.txt_Count.SelectedText = "";
            this.txt_Count.Size = new System.Drawing.Size(78, 43);
            this.txt_Count.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(727, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tổng phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 57);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(116, 34);
            this.label8.TabIndex = 89;
            this.label8.Text = "Tìm phòng:";
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Load.BorderRadius = 5;
            this.btn_Load.BorderThickness = 1;
            this.btn_Load.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Load.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_Load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Load.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Load.ForeColor = System.Drawing.Color.Black;
            this.btn_Load.Location = new System.Drawing.Point(540, 39);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(136, 61);
            this.btn_Load.TabIndex = 90;
            this.btn_Load.Text = "SHOW ALL";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Load);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_Count);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.rbt_IsBooked);
            this.panel3.Controls.Add(this.rbt_NotBooked);
            this.panel3.Controls.Add(this.txt_Search);
            this.panel3.Location = new System.Drawing.Point(3, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 126);
            this.panel3.TabIndex = 91;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_Clear);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_RoomNo);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_Delete);
            this.panel4.Controls.Add(this.btn_Edit);
            this.panel4.Controls.Add(this.cb_RoomType);
            this.panel4.Controls.Add(this.cb_BedType);
            this.panel4.Controls.Add(this.btn_AddRoom);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_Price);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(959, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(688, 844);
            this.panel4.TabIndex = 92;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BorderRadius = 5;
            this.btn_Clear.BorderThickness = 1;
            this.btn_Clear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Clear.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.FillColor = System.Drawing.Color.White;
            this.btn_Clear.Font = new System.Drawing.Font("000 Frank Bellamy iCiel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(471, 39);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(131, 62);
            this.btn_Clear.TabIndex = 85;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            this.dgv_Room.Location = new System.Drawing.Point(3, 223);
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
            this.dgv_Room.Size = new System.Drawing.Size(950, 712);
            this.dgv_Room.TabIndex = 14;
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
            // UC_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Room);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(1650, 1010);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.RadioButton rbt_IsBooked;
        private System.Windows.Forms.RadioButton rbt_NotBooked;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Edit;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_AddRoom;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_RoomNo;
        private Guna.UI2.WinForms.Guna2ComboBox cb_BedType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_RoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_Load;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Room;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
    }
}
