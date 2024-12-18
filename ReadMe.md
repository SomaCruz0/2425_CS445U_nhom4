Yêu cầu: Visual Studio 2022, SQL server

B1: Mở Project
B2: Chuột phải vào QLKS.mdf chọn Open
B3: Ở cửa sổ server explorer, click vào QLKS.mdf
B4: Ở cửa sổ properties, Copy Connection string của database
B5: tìm đến file function.cs trong folder data
B6: dán đè connection string
B7: Chạy project, username: quang, password: 123

-----------

Trường hợp không mở được QLKS.mdf
B1: Tạo mới 1 Service-based database
B2: ở cửa sổ server explorer, chuột phải vào database vừa tạo
B3: Chọn new query
B4: copy lệnh sql từ file DatabaseQLKS.sql được đính kèm trong folder
B5: chạy lệnh Sql
B6: Thay connection string ở file function.cs
B7: Chạy project, username: quang, password: 123