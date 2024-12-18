CREATE TABLE [dbo].[LoaiGiuong] (
    [IDLoaiGiuong] INT           NOT NULL,
    [Ten]          NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IDLoaiGiuong] ASC)
);

CREATE TABLE [dbo].[LoaiPhong] (
    [IDLoaiPhong] INT           NOT NULL,
    [Ten]         NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IDLoaiPhong] ASC)
);

CREATE TABLE [dbo].[Phong] (
    [SoPhong]    INT           NOT NULL,
    [LoaiPhong]  INT           NOT NULL,
    [LoaiGiuong] INT           NOT NULL,
    [Gia]        BIGINT        NOT NULL,
    [TinhTrang]  NVARCHAR (50) DEFAULT (N'Trống') NULL,
    PRIMARY KEY CLUSTERED ([SoPhong] ASC),
    CONSTRAINT [FK_Phong_ToTable] FOREIGN KEY ([LoaiPhong]) REFERENCES [dbo].[LoaiPhong] ([IDLoaiPhong]),
    CONSTRAINT [FK_Phong_ToTable_1] FOREIGN KEY ([LoaiGiuong]) REFERENCES [dbo].[LoaiGiuong] ([IDLoaiGiuong])
);

CREATE TABLE [dbo].[Quyen] (
    [MaQuyen]  INT           NOT NULL,
    [TenQuyen] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([MaQuyen] ASC)
);

CREATE TABLE [dbo].[SanPham] (
    [IdSanPham]  INT           IDENTITY (1, 1) NOT NULL,
    [TenSanPham] NVARCHAR (50) NULL,
    [Gia]        FLOAT (53)    NULL,
    [SoLuongTon] INT           NULL,
    PRIMARY KEY CLUSTERED ([IdSanPham] ASC)
);

CREATE TABLE [dbo].[TaiKhoan] (
    [Uid]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NULL,
    [UserName]  NCHAR (50)    NULL,
    [Password]  NCHAR (50)    NULL,
    [Quyen]     INT           NULL,
    [TrangThai] INT           DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([Uid] ASC),
    CONSTRAINT [FK_TaiKhoan_ToTable] FOREIGN KEY ([Quyen]) REFERENCES [dbo].[Quyen] ([MaQuyen])
);

CREATE TABLE [dbo].[KhachHang] (
    [IDKH]       INT           IDENTITY (1, 1) NOT NULL,
    [HoTen]      NVARCHAR (50) NULL,
    [CCCD]       NVARCHAR (50) NULL,
    [Phone]      NVARCHAR (50) NULL,
    [Email]      NVARCHAR (50) NULL,
    [DiaChi]     NVARCHAR (50) NULL,
    [NgayDangKy] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IDKH] ASC)
);

CREATE TABLE [dbo].[DatPhong] (
    [IDDatPhong] INT           IDENTITY (1, 1) NOT NULL,
    [IDKH]       INT           NULL,
    [NgayDat]    DATETIME      NULL,
    [Uid]        INT           NULL,
    [TrangThai]  NVARCHAR (50) DEFAULT (N'No') NULL,
    PRIMARY KEY CLUSTERED ([IDDatPhong] ASC),
    CONSTRAINT [FK_DatPhong_ToTable_2] FOREIGN KEY ([Uid]) REFERENCES [dbo].[TaiKhoan] ([Uid]),
    CONSTRAINT [FK_DatPhong_ToTable] FOREIGN KEY ([IDKH]) REFERENCES [dbo].[KhachHang] ([IDKH])
);

CREATE TABLE [dbo].[CTDP] (
    [IDCTDP]     INT        IDENTITY (1, 1) NOT NULL,
    [IDDatPhong] INT        NULL,
    [SoPhong]    INT           NULL,
    [Checkin]    DATETIME      NULL,
    [Checkout]    DATETIME      NULL,
    [SoNguoi]    INT        NULL,
    [TongTien]   FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([IDCTDP] ASC),
    CONSTRAINT [FK_CTDP_ToTable_1] FOREIGN KEY ([SoPhong]) REFERENCES [dbo].[Phong] ([SoPhong]),
    CONSTRAINT [FK_CTDP_ToTable] FOREIGN KEY ([IDDatPhong]) REFERENCES [dbo].[DatPhong] ([IDDatPhong])
);

CREATE TABLE [dbo].[CTDV] (
    [IDCTDV]     INT        IDENTITY (1, 1) NOT NULL,
    [IDDatPhong] INT        NULL,
    [IDSanPham]  INT        NULL,
    [Soluong]    INT        NULL,
    [TongTien]   FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([IDCTDV] ASC),
    CONSTRAINT [FK_CTDV_ToTable] FOREIGN KEY ([IDDatPhong]) REFERENCES [dbo].[DatPhong] ([IDDatPhong]),
    CONSTRAINT [FK_CTDV_ToTable_1] FOREIGN KEY ([IDSanPham]) REFERENCES [dbo].[SanPham] ([IdSanPham])
);

insert into quyen values ('1','Admin'), ('2',N'Nhân viên')
insert into TaiKhoan values (N'Lê Đình Quang','quang','123','1','1')