CREATE DATABASE DoAn_HQTCSDL
GO

USE DoAn_HQTCSDL
GO

CREATE TABLE TaiKhoan
(
	MaTaiKhoan VARCHAR(10) CONSTRAINT PK_taiKhoan PRIMARY KEY,
	username NVARCHAR(100) NOT NULL,
	password VARCHAR(30),
);
GO


CREATE TABLE KhachHang
(
	MaKhachHang Int CONSTRAINT PK_KhachHang PRIMARY KEY,
	HoTen NVarChar(50),
	NgaySinh Date,
	GioiTinh NVarChar(3),
	DienThoai VarChar(15),
	Email VarChar(50),
	DiemTichLuy Int,
	MaBoPhan Int,
	MaTaiKhoan VarChar(10),
);
GO


CREATE TABLE BoPhan
(
	MaBoPhan INT CONSTRAINT PK_BoPhan PRIMARY KEY,
	TenBoPhan NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE NhanVien
(
	MaNhanVien INT CONSTRAINT PK_NhanVien PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh SMALLDATETIME,
	GioiTinh NVARCHAR(3),
	DienThoai VARCHAR(15),
	Email VARCHAR(50),
	CMND VARCHAR(9),
	MaBoPhan INT,
	MaTaiKhoan VARCHAR(10) 
);
GO


CREATE TABLE TheLoai
(
	MaTheLoai  INT IDENTITY CONSTRAINT PK_TheLoai PRIMARY KEY,
	TenTheLoai NVARCHAR(100)
);
GO
CREATE TABLE DauSach
(
	ISBN INT CONSTRAINT PK_DauSach PRIMARY KEY,
	TenDauSach NVARCHAR(100),
	TacGia NVARCHAR(50),
	NXB NVARCHAR(50),
	NamXuatBan SMALLDATETIME,
	GiaGoc FLOAT,
	GiaBia FLOAT,
	SoLuong INT,
	MaTheLoai INT
);
GO


CREATE TABLE KhuyenMai
(
	MaKhuyenMai VARCHAR(10) CONSTRAINT PK_KhuyenMai PRIMARY KEY,
	TenKhuyenMai NVARCHAR(100),
	DoiTuong NVARCHAR(10),
	ISBN INT,
	DieuKien INT,
	MucGiam INT,
	NgayBatDau DATETIME,
	NgayKetThuc DATETIME
);
GO


CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY CONSTRAINT PK_HoaDon PRIMARY KEY,
	MaKhachHang INT,
	MaNhanVien INT ,
	TongGiaGoc FLOAT,
	MaKhuyenMai VARCHAR(10),
	ThanhTien FLOAT,
	NgayThanhToan DATETIME
);
GO
CREATE TABLE ChiTietHoaDon
(
	MaHoaDon INT,
	ISBN INT,
	MaKhuyenMai VARCHAR(10),
	SoLuong INT,
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(MaHoaDon, ISBN)
);
GO

CREATE TABLE GioHang
(
	MaKhachHang INT,
	ISBN INT,
	SoLuong INT,
	GiaGoc INT NOT NULL,
	MaKhuyenMai VARCHAR(10),
	ThanhTien INT,
	CONSTRAINT PK_GioHang PRIMARY KEY (MaKhachHang, ISBN)
);
GO


ALTER TABLE KhachHang ADD CONSTRAINT FK_KhachHang_TaiKhoan FOREIGN KEY(MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_TaiKhoan FOREIGN KEY(MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_BoPhan FOREIGN KEY(MaBoPhan) REFERENCES BoPhan(MaBoPhan)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE DauSach ADD CONSTRAINT FK_DauSach_TheLoai FOREIGN KEY(MaTheLoai) REFERENCES TheLoai(MaTheLoai)
ON UPDATE SET NULL
ON DELETE CASCADE
GO


GO

ALTER TABLE KhuyenMai ADD CONSTRAINT FK_KhuyenMai_DauSach FOREIGN KEY(ISBN) REFERENCES DauSach(ISBN)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO

ALTER TABLE HoaDon ADD CONSTRAINT FK_HoaDon_KhuyenMai FOREIGN KEY(MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
ON UPDATE SET NULL
ON DELETE CASCADE
GO

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_ChiTietHoaDon_DauSach FOREIGN KEY(ISBN) REFERENCES DauSach(ISBN)
GO

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT FK_ChiTietHoaDon_KhuyenMai FOREIGN KEY(MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
GO

ALTER TABLE GioHang ADD CONSTRAINT FK_GioHang_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang)
GO

ALTER TABLE GioHang ADD CONSTRAINT FK_GioHang_DauSach FOREIGN KEY (ISBN) REFERENCES DauSach(ISBN)
GO

ALTER TABLE GioHang ADD CONSTRAINT FK_GioHang_KhuyenMai FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai);
GO
--Inserted
------------------------------------------------------------------------------------------------
INSERT INTO dbo.TaiKhoan
        ( MaTaiKhoan, username, password )
VALUES  ( '0', N'none3','nonenone' ), ( '-1', N'none','nonenone' ), ('1', 'admin', 'admin')
GO

INSERT INTO dbo.BoPhan ( MaBoPhan, TenBoPhan )
VALUES  ( 1, N'Khách hàng'), (2, N'Quản lí') ,('3', N'Thu Ngân'), ('4', N'Nhân viên kho')
GO

--Nhân viên 0
insert NhanVien(MaNhanVien) values(0)

INSERT INTO dbo.KhachHang( MaKhachHang , HoTen , NgaySinh , GioiTinh , DienThoai ,Email , DiemTichLuy , MaBoPhan, MaTaiKhoan )
VALUES  ( -1 , N'None' , N'20000202' ,  N'Nam' , '0000000000' , 'none@gmail.com' ,  0, 1 , '-1' )
GO

INSERT INTO dbo.NhanVien ( MaNhanVien , HoTen , NgaySinh , GioiTinh , DienThoai , Email , CMND , MaBoPhan , MaTaiKhoan )
VALUES  ( -1 , N'None' , N'20000101' , N'Nam' ,'0000000000' ,'none@gmail.com' , '000000000' ,3 , '0'),
 ( 1 , N'Nguyễn Anh Quốc' , N'20000101' , N'Nam' ,'0201929433' ,'anhquoc@gmail.com' , '01020192' ,2 , '1')
GO

INSERT INTO dbo.TheLoai
        ( TenTheLoai )
VALUES  ( N'NONE')

INSERT INTO dbo.DauSach
        ( ISBN ,
          TenDauSach ,
          TacGia ,
          NXB ,
          NamXuatBan ,
          GiaGoc ,
          GiaBia ,
          SoLuong ,
          MaTheLoai
        )
VALUES  ( 0 , -- ISBN - int
          N'' , -- TenDauSach - nvarchar(100)
          N'' , -- TacGia - nvarchar(50)
          N'' , -- NXB - nvarchar(50)
          GETDATE() , -- NamXuatBan - smalldatetime
          0.0 , -- GiaGoc - float
          0.0 , -- GiaBia - float
          0 , -- SoLuong - int
          1  -- MaTheLoai - int
        )

INSERT INTO dbo.KhuyenMai
        ( MaKhuyenMai ,
          TenKhuyenMai ,
          DoiTuong ,
          ISBN ,
          DieuKien ,
          MucGiam ,
          NgayBatDau ,
          NgayKetThuc
        )
VALUES  ( 'NONE' , -- MaKhuyenMai - varchar(10)
          N'NONE' , -- TenKhuyenMai - nvarchar(100)
          N'Sách' , -- DoiTuong - nvarchar(10)
          0 , -- ISBN - int
          0 , -- DieuKien - int
          0 , -- MucGiam - int
          '20000202' , -- NgayBatDau - datetime
          '22220202'  -- NgayKetThuc - datetime
        )
GO

----------------------------
--Xác định nhân viên theo mã tài khoản -- func : nhanVien_theo_MaTaiKhoan(@mataikhoan varchar(10))
--Xác định khách hàng theo mã tài khoản-- func: khachHang_theo_MaTaiKhoan(@mataikhoan varchar(10))
--Tìm mã bộ phận từ MaTaiKhoan: func_TimMaBoPhanTheoMaTaiKhoan(@maTaiKhoan varchar(10))
--login:  loginTaiKhoan(@username nvarchar(100), @password varchar(30))
--Đổi mật khẩu: proc_DoiMatKhau_Theo_id @userid int, @MatKhauCu varchar(30), @MatKhauMoi varchar(30), @matKhauXacNhan varchar(30)
-- Login: create Function login(@username nvarchar(100), @password varchar(30))
--kiểm tra độ dài mật khẩu: trigger TG_DoiMatKhau
--đưa ra các sách cần được nhập thêm nếu dưới 10 cuốn: 
--Sửa thông tin khách hàng:  proc_SuaThongTinKhachHang @MaKhachHang int, @HoTen nvarchar(50), @NgaySinh date, @GioiTinh nvarchar(3), @DienThoai varchar(15), @Email varchar(50)
--Kiểm tra sso điện thoại khi khách hàng thêm, sửa thông tin: trigger TG_KiemTraThongTinKhachHang
--Thêm sách vào giỏ hàng
--Tạo và phân quyền cho nhân viên kho
--Thêm user vào role NhanVienKho:  proc_ThemUserVaoNhomNhanVienKho
--Xóa login và user trong DBMS:  proc_XoaLoginVaUserVaoDBMS @username varchar(50)
--Xóa login và user khi người dùng bị xóa:  trigger trigger_XoaLoginKhiUserBiXoa on TaiKhoan
--Thêm login và login: proc proc_TaoLoginVaUserVaoDBMS @username varchar(50), @password varchar(100)
--Tạo loggin khi tài khoản người dùng được tạo: trigger trigger_TaoLoginVaUserVaoDBMS on TaiKhoan 
--Đổi mật khẩu login: proc proc_DoiMatKhauLogin @username varchar(50), @matKhauMoi varchar(100), @matKhauCu varchar(100)
--Đổi mật khẩu cho login khi mật khẩu user thay đổi: trigger trigger_DoiMatKhauLogin on TaiKhoan
--Tạo nhóm và cấp quyền cho các nhóm
--Thêm user vào role NhanVienKho
--Thêm user vào role NhanVienKho: create proc proc_ThemUserVaoNhomNhanVienKho 
--Thêm user vào role NhanThuNgan: proc proc_ThemUserVaoNhomNhanVienThuNgan @username varchar(50)
--Trigger tự động thêm các user vào nhóm: trigger trigger_ThemUserVaoNhom on NhanVien
--Thêm user vào role KhachHang: proc proc_ThemUserVaoNhomKhachHang @username varchar(50)
----Trigger tự động thêm các user vào nhóm KhachHang: trigger trigger_ThemUserVaoNhomKhacHang on KhachHang
----Thêm vào role db_ddladmin: proc proc_ThemUserVaoNhomAdmin @username varchar(50)


--Xác định nhân viên theo mã tài khoản
CREATE FUNCTION nhanVien_theo_MaTaiKhoan(@mataikhoan VARCHAR(10))
RETURNS TABLE
AS
	RETURN (SELECT * FROM NhanVien WHERE MaTaiKhoan=@mataikhoan);
GO



--Xác định khách hàng theo mã tài khoản
CREATE FUNCTION khachHang_theo_MaTaiKhoan(@mataikhoan VARCHAR(10))
RETURNS TABLE
AS
	RETURN (SELECT *  FROM KhachHang WHERE MaTaiKhoan=@mataikhoan)
GO


--Tìm mã bộ phận từ MaTaiKhoan
CREATE FUNCTION func_LayThongTinDangNhapTheoMaTaiKhoan(@maTaiKhoan VARCHAR(10))
RETURNS @kq TABLE(MaTaiKhoan VARCHAR(10), MaNguoiDung INT, MaBoPhan INT)
AS
BEGIN
	INSERT INTO @kq SELECT MaTaiKhoan, MaKhachHang, MaBoPhan FROM dbo.khachHang_theo_MaTaiKhoan(@maTaiKhoan)
	IF((SELECT COUNT(*) FROM @kq)>0)
		RETURN;

	INSERT INTO @kq SELECT MaTaiKhoan, MaNhanVien, MaBoPhan FROM dbo.nhanVien_theo_MaTaiKhoan(@maTaiKhoan) 
	RETURN;
END;
GO


--login
CREATE FUNCTION loginTaiKhoan(@username NVARCHAR(100), @password VARCHAR(30))
RETURNS @kq TABLE(MaTaiKhoan VARCHAR(10), MaNguoiDung INT, MaBoPhan INT)
AS
BEGIN
	DECLARE @count INT, @mataikhoan VARCHAR(10)
	SELECT @count =COUNT(*),@mataikhoan=MaTaiKhoan
	FROM TaiKhoan
	WHERE @username=username AND @password=password
	GROUP BY MaTaiKhoan
	--Tìm theo khách hàng
	INSERT INTO @kq SELECT MaTaiKhoan, MaKhachHang, MaBoPhan FROM dbo.khachHang_theo_MaTaiKhoan(@mataikhoan)
	IF((SELECT COUNT(*) FROM @kq)>0)
		RETURN;
	--Tìm theo nhân viên
	INSERT INTO @kq SELECT MaTaiKhoan, MaNhanVien, MaBoPhan FROM dbo.nhanVien_theo_MaTaiKhoan(@mataikhoan) 
	RETURN;
END;
GO

------------------------------------------------------
--
--Đổi mật khẩu
CREATE PROC proc_DoiMatKhau_Theo_id @userid INT, @MatKhauCu VARCHAR(30), @MatKhauMoi VARCHAR(30), @matKhauXacNhan VARCHAR(30)
AS
BEGIN TRAN
BEGIN TRY
	DECLARE @MatKhauHienTai VARCHAR(100), @maTaiKhoan VARCHAR(30)
	--xác định là nhân viên hay khách hàng
	SELECT @MatKhauHienTai= TaiKhoan.password, @maTaiKhoan= TaiKhoan.MaTaiKhoan
	FROM  NhanVien  INNER JOIN TaiKhoan ON NhanVien.MaTaiKhoan=TaiKhoan.MaTaiKhoan
	WHERE NhanVien.MaNhanVien=@userid;
	IF(@MatKhauHienTai IS NULL)
	BEGIN
		SELECT @MatKhauHienTai= TaiKhoan.password, @maTaiKhoan= TaiKhoan.MaTaiKhoan
		FROM  KhachHang  INNER JOIN TaiKhoan ON KhachHang.MaTaiKhoan=TaiKhoan.MaTaiKhoan
		WHERE KhachHang.MaKhachHang=@userid;
	END
	--kiểm tra tài khoản có tồn tại ko
	IF (@maTaiKhoan IS NULL)
	BEGIN
		RAISERROR (N'Có lỗi xảy ra! Chúng tôi hiện không tìm thấy tài khoản của bạn', 16, 10);
		ROLLBACK TRAN
	END
	--kiểm tra mật khẩu hiện tại
	IF(@MatKhauHienTai!=@MatKhauCu)
	BEGIN
		RAISERROR( N'Mật khẩu hiện tại sai!', 16, 10)
		ROLLBACK TRAN
	END;
	--kiểm tra độ dài của mật khẩu mới, yêu cầu tối thiểu 8 kí tự
	IF( (SELECT LEN(@MatKhauMoi)) < 8)
	BEGIN
		RAISERROR (N'Mật khẩu yêu cầu tối thiểu 8 kí tự!', 16, 10)
		ROLLBACK TRAN
	END
	--kiểm tra có trùng mật khẩu cũ không
	IF(@MatKhauMoi=@MatKhauCu)
	BEGIN
		RAISERROR(N'Vui lòng nhập mật khẩu khác mật khẩu hiện tại', 16, 10);
		ROLLBACK TRAN
	END
	--2 mật khẩu xác nhận có trùng ko
	IF(@MatKhauMoi!=@matKhauXacNhan)
	BEGIN
		RAISERROR(N'Mật khẩu xác nhận không trùng', 16, 10);
		ROLLBACK TRAN
	END
	--tiến hành đổi mật khẩu
	UPDATE TaiKhoan
	SET password=@MatKhauMoi
	WHERE MaTaiKhoan=@maTaiKhoan
	COMMIT TRAN
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
	ROLLBACK TRAN
END CATCH
GO


--kiểm tra độ dài mật khẩu
CREATE TRIGGER TG_DoiMatKhau ON TaiKhoan
FOR INSERT, UPDATE
AS
BEGIN 
	DECLARE @matKhau VARCHAR(100)
	SELECT @matKhau= inserted.password
	FROM inserted
	--kiểm tra độ dài của mật khẩu mới, yêu cầu tối thiểu 8 kí tự
	IF( (SELECT LEN(@matKhau)) < 8)
	BEGIN
		RAISERROR (N'Mật khẩu yêu cầu tối thiểu 8 kí tự!', 16, 10)
		RETURN
	END	
END
GO


--------------------------------------------------------------------------------
----



---hàm trả về các mã khuyến mãi cho một hóa đơn
CREATE FUNCTION func_DuaMaKhuyenMaiChoHoaDon(@MaHoaDon INT)
RETURNS @returnTable TABLE(MaKhuyenMai VARCHAR(10), TenKhuyenMai NVARCHAR(100), MucGiam INT)
AS
BEGIN
	DECLARE @tongTien INT
	SELECT @tongTien=TongGiaGoc
	FROM HoaDon
	WHERE MaHoaDon=@MaHoaDon
	INSERT INTO @returnTable SELECT MaKhuyenMai, TenKhuyenMai, MucGiam
			FROM KhuyenMai
			WHERE DoiTuong=N'Hóa đơn' AND DieuKien<=100000 
			AND NgayBatDau<=GETDATE() AND NgayKetThuc>=GETDATE() 
	RETURN
END;
GO

------------------------------------------

--------------------------------------------------------------------
-----------------------------------------------------------------
--######################################################################
--Sửa thông tin khách hàng
CREATE PROC proc_SuaThongTinKhachHang @MaKhachHang INT, @HoTen NVARCHAR(50), @NgaySinh DATE, @GioiTinh NVARCHAR(3), 
@DienThoai VARCHAR(15), @Email VARCHAR(50)
AS
BEGIN TRAN
BEGIN TRY
	--ktra khách hàng có tồn tại không
	IF(NOT EXISTS(SELECT * FROM KhachHang WHERE MaKhachHang=@MaKhachHang))
	BEGIN
		RAISERROR (N'Không tìm thấy khách hàng', 16, 10)
		RETURN;
	END
	--Cập nhật họ tên
	SAVE TRAN SP1
	UPDATE KhachHang SET HoTen=@HoTen, NgaySinh= @NgaySinh, GioiTinh=@GioiTinh, DienThoai= @DienThoai, Email =@Email WHERE MaKhachHang=@MaKhachHang
	COMMIT
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(2000)
	SELECT @err = N'Lỗi: ' + ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
	ROLLBACK TRAN
END CATCH
GO

--Kiểm tra sso điện thoại khi khách hàng thêm, sửa thông tin
CREATE TRIGGER TG_KiemTraThongTinKhachHang ON KhachHang
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @count INT
	SELECT @count =COUNT(*)
	FROM inserted INNER JOIN KhachHang ON inserted.DienThoai = KhachHang.DienThoai
	WHERE inserted.MaKhachHang != KhachHang.MaKhachHang
	IF(@count>0)
		RAISERROR(N'Số điện thoại đã đăng kí', 16, 10)
END
GO

--lấy thông tin khách hàng để hiển thị cho khách hàng

CREATE FUNCTION func_HienThiThongTinKhachHangChoKhachHang(@maKhachHang INT)
RETURNS TABLE 
AS
RETURN (SELECT MaKhachHang, HoTen, NgaySinh, GioiTinh, DienThoai, Email, DiemTichLuy
		FROM KhachHang
		WHERE MaKhachHang=@maKhachHang)
GO



-------------------------------------------------------------
--------------------------------------------------------------

----Đưa ra mã giảm giá của từng cuốn sách
CREATE FUNCTION func_DuaKhuyenMaiChoSach(@isbn INT, @Gia FLOAT)
RETURNS @result TABLE(MaKhuyenMai VARCHAR(10), TenKhuyenMai NVARCHAR(100), MucGiam INT)
AS
BEGIN	
	INSERT INTO @result SELECT  KhuyenMai.MaKhuyenMai, TenKhuyenMai, MucGiam
			FROM KhuyenMai 
			WHERE DoiTuong='Sách' AND KhuyenMai.ISBN =1--@isbn 
			AND NgayBatDau<=GETDATE() AND NgayKetThuc>=GETDATE()
			AND DieuKien <= 100000 --@Gia

	IF((SELECT COUNT(*) FROM @result)=0)
		BEGIN
			INSERT INTO @result SELECT KhuyenMai.MaKhuyenMai, TenKhuyenMai, MucGiam	
								FROM KhuyenMai
								WHERE MaKhuyenMai='0'
		END
	RETURN;
END;
GO


--Thêm sách vào giỏ hàng
CREATE PROC proc_ThemSachVaoGioHang @MaKhachHang INT, @ISBN INT, @soLuongThem INT
AS
BEGIN TRAN
	--Kiểm tra biến số lượng nhập vào
	IF(@soLuongThem<0)
		BEGIN
			RAISERROR(N'Số lượng sách không hợp lệ',16, 10)
			RETURN;
		END
	--lấy các thông tin về sách
	DECLARE @gia1cuon FLOAT, @soLuongHienTai INT
	SELECT  @gia1cuon=GiaBia, @soLuongHienTai=SoLuong
	FROM DauSach
	WHERE ISBN = @ISBN
	--kiểm tra có mã sách không
	IF(@gia1cuon IS NULL)
	BEGIN
		RAISERROR(N'Không tìm thấy sách bạn yêu cầu!',16, 10)
			RETURN;
	END
	--nếu đã có sẵn sách thì cộng thêm
	IF(EXISTS(SELECT * FROM GioHang WHERE ISBN=@ISBN AND MaKhachHang=@MaKhachHang))
		BEGIN
			UPDATE	GioHang
			SET SoLuong = SoLuong+@soLuongThem
			WHERE MaKhachHang=@MaKhachHang AND ISBN=@ISBN
		END
	ELSE
	BEGIN
		INSERT INTO GioHang (MaKhachHang, ISBN, SoLuong)
		VALUES(@MaKhachHang, @ISBN, @soLuongThem)
	END
	--Sách trong kho có đủ đáp ứng hay ko
	IF((SELECT SoLuong FROM GioHang WHERE MaKhachHang=@MaKhachHang AND ISBN=@ISBN)>@soLuongHienTai)
	BEGIN
		DECLARE @infor VARCHAR(50)
		SELECT @infor=CONCAT( N'Hiện tại trong kho không đủ sách như bạn yêu cầu! Chúng tôi chỉ còn lại ', @soLuongHienTai, N' cuốn.')
		RAISERROR(@infor, 16, 10)
		ROLLBACK TRAN
	END
	---Cập nhật lại giá gốc cho tổng số sách
	UPDATE GioHang
	SET GiaGoc=@gia1cuon*SoLuong
	WHERE MaKhachHang=@MaKhachHang AND ISBN = @ISBN
	--giá gốc
	DECLARE @giaGoc FLOAT
	SELECT @giaGoc=GiaGoc
	FROM GioHang
	WHERE MaKhachHang=@MaKhachHang AND ISBN=@ISBN
	--lấy maKhuyenMai
	DECLARE @maKhuyenMai VARCHAR(10), @mucgiam INT
	SELECT @maKhuyenMai= A.MaKhuyenMai, @mucgiam=MucGiam
	FROM dbo.func_DuaKhuyenMaiChoSach(@ISBN,@giaGoc) A;
	UPDATE GioHang
	SET MaKhuyenMai=@maKhuyenMai
	WHERE ISBN=@ISBN AND MaKhachHang=@MaKhachHang;
	
	--update ThanhTien
	UPDATE GioHang
	SET ThanhTien= @giaGoc-@giaGoc*@mucgiam/100
	WHERE ISBN=@ISBN AND MaKhachHang=@MaKhachHang;
COMMIT
GO



------------------------------------------
-------------------------------------
--PHẦN TẠO USER LOGIN, PHÂN QUYỀN
--See all logins

--Remove a login in DBMS
CREATE PROC proc_XoaLoginVaUserVaoDBMS @username VARCHAR(50)
AS
BEGIN
BEGIN TRY
	IF EXISTS (SELECT loginname FROM master.dbo.syslogins 
    WHERE name = @username )
	BEGIN
	DECLARE @t NVARCHAR(4000)
	SET @t = N'drop LOGIN ' + @username 
	EXEC sys.sp_executesql @t
	END

	--xóa user
	IF EXISTS (SELECT * FROM sys.sysusers WHERE name=@username)
	BEGIN
	DECLARE @command VARCHAR(500)
	SET @command = 'use DoAn_HQTCSDL  ' 
					+ 'drop user '+ @username 
	PRINT(@command)
	EXEC(@command)
	END
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16,10)
END CATCH
END
GO


---Xóa login và user khi người dùng bị xóa
CREATE TRIGGER trigger_XoaLoginKhiUserBiXoa ON TaiKhoan
FOR DELETE
AS
BEGIN
BEGIN TRY
	DECLARE @username VARCHAR(50)
	SELECT @username = deleted.username
	FROM deleted
	--gọi proc xóa
	EXEC proc_XoaLoginVaUserVaoDBMS @username
END TRY
BEGIN CATCH
END CATCH
END
GO


--add a login in DBMS
CREATE PROC proc_TaoLoginVaUserVaoDBMS @username VARCHAR(50), @password VARCHAR(100)
AS
BEGIN
BEGIN TRY
	
	--tạo login
	DECLARE @t NVARCHAR(4000)
	SET @t = N'CREATE LOGIN ' + QUOTENAME(@username) + ' WITH PASSWORD = ' + QUOTENAME(@password,'''')
	
	EXEC sys.sp_executesql @t
	--tạo user
	DECLARE @command VARCHAR(500)

	SET @command = 'use DoAn_HQTCSDL  ' 
					+ 'create user '+ @username + ' for login '+ @username
					
	EXEC(@command)
	
END TRY
BEGIN CATCH
	--xảy ra lỗi, xóa login đã tạo(nếu có)
	IF( EXISTS(SELECT * FROM master.dbo.syslogins 
    WHERE name = @username))
	BEGIN
		EXEC proc_XoaLoginVaUserVaoDBMS @username
	END
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16,10)
END CATCH
END
GO


--Tạo loggin khi tài khoản người dùng được tạo
CREATE TRIGGER trigger_TaoLoginVaUserVaoDBMS ON TaiKhoan 
AFTER INSERT
AS
BEGIN
BEGIN TRY
	DECLARE @username VARCHAR(50), @password VARCHAR(100)
	SELECT @username =inserted.username, @password = inserted.password FROM inserted 
	EXEC proc_TaoLoginVaUserVaoDBMS @username, @password
END TRY
BEGIN CATCH
DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
END CATCH
END
GO

--Đổi mật khẩu login
CREATE PROC proc_DoiMatKhauLogin @username VARCHAR(50), @matKhauMoi VARCHAR(100), @matKhauCu VARCHAR(100)
AS
BEGIN
	DECLARE @t NVARCHAR(4000)
	SET @t = N'alter login ' + QUOTENAME(@username) +' with password = '+  QUOTENAME(@matKhauMoi,'''')  +' old_password = '+ QUOTENAME(@matKhauCu,'''')
	EXEC sys.sp_executesql @t
END
GO


--Đổi mật khẩu cho login khi mật khẩu user thay đổi
CREATE TRIGGER trigger_DoiMatKhauLogin ON TaiKhoan
FOR UPDATE
AS
BEGIN
BEGIN TRY
	--đã đổi mật khẩu
	DECLARE @matKhauMoi VARCHAR(100), @matKhauCu VARCHAR(100), @username VARCHAR(50)
	SELECT @matKhauCu = deleted.password, @matKhauMoi = inserted.password, @username=inserted.username
	FROM inserted INNER JOIN deleted ON inserted.MaTaiKhoan= deleted.MaTaiKhoan
	EXEC proc_DoiMatKhauLogin @username, @matKhauMoi, @matKhauCu
	PRINT('đã đổi')
END TRY
BEGIN CATCH
	RAISERROR('Không thể đổi mật khẩu',16,10)
END CATCH
END
GO



---------------------------------------
--Tạo nhóm và cấp quyền cho các nhóm
EXEC sp_addrole NhanVienKho
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON DauSach TO NhanVienKho
GO

GRANT SELECT, UPDATE ON  NhanVien TO NhanVienKho
GO



--Thêm user vào role NhanVienKho
CREATE PROC proc_ThemUserVaoNhomNhanVienKho @username VARCHAR(50)
AS
BEGIN
BEGIN TRY
	DECLARE @t NVARCHAR(4000)
	SET @t = N'exec sp_addrolemember NhanVienKho, ' + QUOTENAME(@username) 
	EXEC sys.sp_executesql @t
END TRY
BEGIN CATCH
	RAISERROR(N'Không thể thêm vào nhân viên kho', 16, 10)
END CATCH
END
GO



----------------------------------------------------------
--tạo nhóm nhân viên thu ngân

EXEC sp_addrole NhanVienThuNgan
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON KhachHang TO NhanVienThuNgan
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON HoaDon TO NhanVienThuNgan
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON ChiTietHoaDon TO NhanVienThuNgan
GO

GRANT SELECT,DELETE, UPDATE ON GioHang TO NhanVienThuNgan
GO


--Thêm user vào role NhanVienThuNgan
CREATE PROC proc_ThemUserVaoNhomNhanVienThuNgan @username VARCHAR(50)
AS
BEGIN
BEGIN TRY
	DECLARE @t NVARCHAR(4000)
	SET @t = N'exec sp_addrolemember NhanVienThuNgan, ' + QUOTENAME(@username) 
	EXEC sys.sp_executesql @t
END TRY
BEGIN CATCH
	RAISERROR(N'Không thể thêm vào nhân viên kho', 16, 10)
END CATCH
END
GO


-------------------------------
--ROLE KhachHang
EXEC sp_addrole KhachHang
GO

GRANT SELECT, INSERT  ON KhachHang TO KhachHang
GO

GRANT SELECT  ON DauSach TO KhachHang
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON GioHang TO KhachHang
GO

GRANT SELECT, UPDATE ON TaiKhoan TO KhachHang
GO

--Thêm user vào role KhachHang
CREATE PROC proc_ThemUserVaoNhomKhachHang @username VARCHAR(50)
AS
BEGIN
BEGIN TRY
	DECLARE @t NVARCHAR(4000)
	SET @t = N'exec sp_addrolemember KhachHang, ' + QUOTENAME(@username) 
	EXEC sys.sp_executesql @t
END TRY
BEGIN CATCH
	RAISERROR(N'Không thể thêm khách hàng', 16, 10)
END CATCH
END
GO


--Trigger tự động thêm các user vào nhóm KhachHang
CREATE TRIGGER trigger_ThemUserVaoNhomKhacHang ON KhachHang
AFTER INSERT, UPDATE
AS
BEGIN
BEGIN TRY
	IF((SELECT MaKhachHang FROM Inserted)!=-1)
	begin
		IF((SELECT MaTaiKhoan FROM inserted ) IS NOT NULL)
		BEGIN
			DECLARE  @username VARCHAR(50)
			SELECT  @username= TaiKhoan.username
			FROM inserted INNER JOIN TaiKhoan ON inserted.MaTaiKhoan = TaiKhoan.MaTaiKhoan			
			EXEC proc_ThemUserVaoNhomKhachHang @username			
		END 
	END	
END TRY
BEGIN CATCH
DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
END CATCH
END
GO


-------------------------------
--ROLE QuanLi
EXEC sp_addrole QuanLi
GO
GRANT SELECT, INSERT, DELETE, UPDATE  ON KhuyenMai TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON NhanVien TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON TheLoai TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON HoaDon TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON ChiTietHoaDon TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON KhachHang TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE  ON DauSach TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON GioHang TO QuanLi
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON TaiKhoan TO QuanLi
GO


--Thêm vào role QuanLi
CREATE PROC proc_ThemUserVaoNhomAdmin @username VARCHAR(50)
AS
BEGIN
BEGIN TRY
	DECLARE @t NVARCHAR(4000)
	SET @t = N'exec sp_addrolemember QuanLi, ' + QUOTENAME(@username) 
	EXEC sys.sp_executesql @t
END TRY
BEGIN CATCH
	RAISERROR(N'Không thể thêm quản lí', 16, 10)
END CATCH
END
GO


--Trigger tự động thêm các user vào nhóm nhân viên
CREATE TRIGGER trigger_ThemUserVaoNhom ON NhanVien
AFTER INSERT, UPDATE
AS
BEGIN
BEGIN TRY
	IF((SELECT MaTaiKhoan FROM inserted ) IS NOT NULL)
	BEGIN
		DECLARE @maBoPhan INT, @username VARCHAR(50)
		SELECT @maBoPhan = inserted.MaBoPhan, @username= TaiKhoan.username
		FROM inserted INNER JOIN TaiKhoan ON inserted.MaTaiKhoan = TaiKhoan.MaTaiKhoan

		--xóa khỏi tất cả các nhóm
		DECLARE @t NVARCHAR(4000)
		SET @t = N'ALTER ROLE NhanVienKho DROP MEMBER ' + QUOTENAME(@username) 
		EXEC sys.sp_executesql @t

		SET @t = N'ALTER ROLE KhachHang DROP MEMBER ' + QUOTENAME(@username) 
		EXEC sys.sp_executesql @t

		SET @t = N'ALTER ROLE NhanVienThuNgan DROP MEMBER ' + QUOTENAME(@username) 
		EXEC sys.sp_executesql @t

		SET @t = N'ALTER ROLE QuanLi DROP MEMBER ' + QUOTENAME(@username) 
		EXEC sys.sp_executesql @t

		-- là nhân viên
		IF(@maBoPhan IS NOT NULL)
		BEGIN
			--nhân viên kho
			IF(@maBoPhan=4)
			BEGIN
				EXEC proc_ThemUserVaoNhomNhanVienKho @username
			END
			ELSE IF(@maBoPhan=3)
			BEGIN
				EXEC proc_ThemUserVaoNhomNhanVienThuNgan @username
			END
			ELSE IF(@maBoPhan=2)
			BEGIN
				EXEC proc_ThemUserVaoNhomAdmin @username
			END
		END
	END 
END TRY
BEGIN CATCH
DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
END CATCH
END
GO



--xem các user trong role
--SELECT DP1.name AS DBRole ,   
--   isnull (DP2.name, 'No members') AS DatabaseUserName   
-- FROM sys.database_role_members AS DRM  
-- RIGHT OUTER JOIN sys.database_principals AS DP1  
--   ON DRM.role_principal_id = DP1.principal_id  
-- LEFT OUTER JOIN sys.database_principals AS DP2  
--   ON DRM.member_principal_id = DP2.principal_id  
--WHERE DP1.type = 'R'
--ORDER BY DP1.name;  
--go



------------------------------------------------------------------------------------------------------------------------s-----------------------------------
--Su 
---------------------------------------------------------------------------------------------------------------------------------------------------------
---Cập nhật giá bán của sách---
-----------------------------------------------------------------------------------
--Kiểm tra ISBN
CREATE FUNCTION FN_KiemTraISBN (@ISBN INT)
RETURNS BIT
BEGIN
	DECLARE @return INT
	SET @return = 0
	IF EXISTS(SELECT COUNT(*) FROM DauSach WHERE ISBN = @ISBN GROUP BY ISBN)
		SET @return = 1
	RETURN @return
END;
GO

----------------------------------------------------------------------------------
---Cập nhật DauSach GiaGoc lớn hơn GiaBia
CREATE TRIGGER TG_CapnhatSach ON DauSach
FOR INSERT, UPDATE
AS
BEGIN Tran
	DECLARE @GiaGoc FLOAT, @GiaBia FLOAT
	SELECT @GiaGoc = ins.GiaGoc, @GiaBia = ins.GiaBia FROM inserted AS ins
	IF @GiaGoc IS NOT NULL AND @GiaBia IS NOT NULL
		IF @GiaGoc >= @GiaBia 
		BEGIN
			RAISERROR('Gía nhập phải thấp hơn gia bìa!', 16, 10)
			ROLLBACK TRAN	
		END
COMMIT TRAN
GO
---cập nhật giá sách
CREATE PROC Proc_CapNhatGiaSach @ISBN INT, @TenDauSach NVARCHAR(100), @GiaGoc FLOAT, @GiaBia FLOAT
AS
BEGIN
	IF EXISTS(SELECT * FROM DauSach WHERE ISBN = @ISBN) 
		UPDATE DauSach SET TenDauSach = @TenDauSach, GiaGoc = @GiaGoc, GiaBia = @GiaBia
		WHERE ISBN = @ISBN
END
GO
--------------------------Khuyến Mãi-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--Thêm Khuyến Mãi
CREATE PROC Proc_ThemKhuyenMai @MaKhuyenMai VARCHAR(10), @TenKhuyenMai NVARCHAR(100), @DoiTuong NVARCHAR(10), @ISBN INT, @DieuKien INT, @MucGiam INT, @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai) 
		INSERT INTO KhuyenMai(MaKhuyenMai, TenKhuyenMai, DoiTuong, ISBN, DieuKien, MucGiam, NgayBatDau, NgayKetThuc)
		VALUES (@MaKhuyenMai, @TenKhuyenMai, @DoiTuong, @ISBN, @DieuKien, @MucGiam, CONVERT(DATE, @NgayBatDau), CONVERT(Date, @NgayKetThuc))
END
GO

--Kiểm tra mã khuyến mãi	
CREATE FUNCTION FN_KiemTraMaKhuyenMai(@MaKhuyenMai VARCHAR(10))
RETURNS BIT
AS
BEGIN
	DECLARE @dem INT
	SELECT @dem = COUNT(*) FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
	RETURN @dem
END
GO

-----Cập nhật khuyến mãi
CREATE PROC Proc_SuaKhuyenMaiTheoMa @MaKhuyenMai VARCHAR(10), @TenKhuyenMai NVARCHAR(100), @DoiTuong NVARCHAR(10), @ISBN INT, @DieuKien INT, @MucGiam INT, @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
BEGIN
	IF EXISTS(SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai) 
		UPDATE KhuyenMai SET MaKhuyenMai = @MaKhuyenMai, TenKhuyenMai = @TenKhuyenMai, DoiTuong = @DoiTuong,ISBN = @ISBN, DieuKien = @DieuKien,MucGiam = @MucGiam, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc
		WHERE MaKhuyenMai = @MaKhuyenMai
END
GO
--Ngày bắt đầu khuyến mãi cần trước ngày hiện tại và ngày kết thúc khuyến mãi phải lớn hơn 1 tuần
CREATE TRIGGER TG_KiemTraThoiGianKhuyenMai ON KhuyenMai
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @MaKhuyenMai VARCHAR(10), @Ngaybatdau DATETIME, @NgayKetThuc DATETIME
	SELECT @MaKhuyenMai = inserted.MaKhuyenMai, @Ngaybatdau = inserted.NgayBatDau, @NgayKetThuc = inserted.NgayKetThuc 
	FROM inserted
	IF EXISTS(SELECT * FROM KhuyenMai AS km WHERE km.MaKhuyenMai = @MaKhuyenMai AND km.NgayBatDau = @Ngaybatdau AND km.NgayKetThuc = @NgayKetThuc)
		BEGIN
			IF @Ngaybatdau < CONVERT(date, getdate())
				BEGIN
					RAISERROR('Ngày bắt đầu khuyến mãi phải sau ngày hôm qua', 16, 10)
					ROLLBACK TRAN	
				END
			IF @Ngaybatdau>@NgayKetThuc
				BEGIN
					RAISERROR('Ngày bắt đầu cần trước ngày kết thúc khuyến mãi', 16, 10)
					ROLLBACK TRAN
				END

		END
END;
GO

----------------------------------------------------------------------------------------------------------
---MucGiam của KhuyenMai phải phù hợp(0<=MucGiam<100) và DoiTuong của KhuyenMai không thể khác 'Hóa Đơn' hoặc 'Đầu Sách'
CREATE TRIGGER TG_MucGiam_DoiTuongKhuyenMai ON KhuyenMai
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @MucGiam int, @DoiTuong NVARCHAR(10)
	SELECT @MucGiam = MucGiam, @DoiTuong = DoiTuong FROM inserted
	IF @MucGiam IS NOT NULL
	BEGIN
		IF @MucGiam <-1 OR @MucGiam >100
		BEGIN
			RAISERROR('Mức giảm của Khuyến Mãi không phù hợp.', 16, 10)
			ROLLBACK TRAN
		END
	END
	IF @DoiTuong IS NOT NULL
		BEGIN
			IF (@DoiTuong != N'Hóa Đơn') AND (@DoiTuong != N'Sách')
			BEGIN
				RAISERROR('Đối tượng khuyến mãi không phù hợp.', 16, 10)
				ROLLBACK TRAN
			END
		END
END
GO
--drop trigger TG_MucGiam_DoiTuongKhuyenMai
--------Doanh Thu--------------------------------------------------------------------------------
--Thống kê doanh thu ngày
CREATE PROC PROC_ThongKeDoanhThuNgay @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
BEGIN
	SELECT CONVERT(DATE,HoaDon.NgayThanhToan) AS 'Ngày', SUM(HoaDon.ThanhTien) AS 'Tổng Doanh Thu' 
	FROM HoaDon
	WHERE HoaDon.ThanhTien IS NOT NULL AND CONVERT(DATE, @NgayBatDau) <=  CONVERT(DATE,NgayThanhToan) AND CONVERT(DATE, @NgayKetThuc) >=CONVERT(DATE, NgayThanhToan)
	GROUP BY CONVERT(DATE,NgayThanhToan)
END
GO
---Thong Kê doanh thu theo tháng
CREATE PROC PROC_ThongKeDoanhThuThang @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
BEGIN
	SELECT CONCAT(MONTH(NgayThanhToan), '/', YEAR(NgayThanhToan)) AS 'Tháng', SUM(HoaDon.ThanhTien) AS 'Tổng Doanh Thu' 
	FROM HoaDon 
	WHERE HoaDon.ThanhTien IS NOT NULL AND CONVERT(DATE, @NgayBatDau) <= CONVERT(DATE, NgayThanhToan) AND CONVERT(DATE, @NgayKetThuc) >= CONVERT(DATE, NgayThanhToan)
	GROUP BY CONCAT(MONTH(NgayThanhToan), '/', YEAR(NgayThanhToan))
	
END;
GO
----------Nhân viên-----------------------------------------------------------
-- Mỗi Nhân viên chỉ có 1 số CMND.
CREATE FUNCTION FN_TonTaiSoCMND(@CMND varchar(9))
RETURNS BIT
AS
BEGIN
  DECLARE @dem INT
  SELECT @dem = COUNT(*) FROM dbo.NhanVien WHERE CMND = @CMND
  RETURN @dem
END
GO

--Lấy danh sách nhân viên, không hiển thị nhân viên '0'
CREATE VIEW DanhSachNhanVien
AS
SELECT * FROM NhanVien WHERE MaNhanVien > 0
GO


---Kiểm tra mã nhân viên
CREATE FUNCTION FN_KiemTraMaNhanVien(@MaNhanVien INT)
RETURNS BIT
AS
BEGIN
	DECLARE @dem INT
	SELECT @dem = COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien
	RETURN @dem
END
GO
---Nếu tạo Nhân viên mới thì tự động tạo Tài Khoản mới cho nhân viên đó
--Đã remove
--create Trigger TG_ThemNhanVien_TaiKhoanMoi on NhanVien
--After Insert
--AS
--Begin
--	Declare @MaTaiKhoan VarChar(10)
--	Select @MaTaiKhoan=Convert(varchar(10),inserted.MaNhanVien) From inserted
--	If exists(Select * From TaiKhoan Where MaTaiKhoan = 'NV'+ @MaTaiKhoan)
--		Raiserror('Mã Tài Khoản đã được sử dụng.', 16, 10)
--	Else
--		Insert Into TaiKhoan(MaTaiKhoan, username, password) Values ('NV'+ @MaTaiKhoan, 'NV' + @MaTaiKhoan, '123')
--		Update NhanVien set MaTaiKhoan = 'NV' + @MaTaiKhoan where MaNhanVien = @MaTaiKhoan
--End;
--GO


---Nhân viên cần đủ 18 tuổi

CREATE TRIGGER TG_NhanVienDoTuoi ON NhanVien
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NgaySinh SMALLDATETIME, @Tuoi INT
	SELECT @NgaySinh = NgaySinh FROM inserted
	SET @Tuoi = YEAR(GETDATE()) - YEAR(@NgaySinh)
	IF @Tuoi < 18
	BEGIN
		RAISERROR('Độ tuổi nhân viên Không phù hợp.', 16, 10)
		ROLLBACK
	END
END
GO

--Thêm Nhân viên
CREATE PROC Proc_ThemNhanVien @HoTen NVARCHAR(50), @NgaySinh DATE, @GioiTinh NVARCHAR(3), @DienThoai VARCHAR(15), @Email VARCHAR(50), @CMND VARCHAR(9), @MaBoPhan INT
AS
BEGIN TRAN
BEGIN TRY
	DECLARE @maxMaNhanVien INT
	SELECT @maxMaNhanVien = MAX(MaNhanVien) FROM NhanVien
	IF @maxMaNhanVien IS NULL
	BEGIN
		INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DienThoai, Email, CMND, MaBoPhan)
		VALUES (1, @HoTen, @NgaySinh, @GioiTinh, @DienThoai, @Email, @CMND, @MaBoPhan)
	END
	ELSE
	BEGIN
		INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, DienThoai, Email, CMND, MaBoPhan)
		VALUES (@maxMaNhanVien+ 1, @HoTen, @NgaySinh, @GioiTinh, @DienThoai, @Email, @CMND, @MaBoPhan)
	END
	--thêm tài khoản
	DECLARE @MaTaiKhoan VARCHAR(10)
	SELECT @MaTaiKhoan= @maxMaNhanVien+1
	IF EXISTS(SELECT * FROM TaiKhoan WHERE MaTaiKhoan = 'NV'+ @MaTaiKhoan)
		RAISERROR('Mã Tài Khoản đã được sử dụng.', 16, 10)
	ELSE
		INSERT INTO TaiKhoan(MaTaiKhoan, username, password) VALUES ('NV'+ @MaTaiKhoan, 'NV' + @MaTaiKhoan, 'NV' + @MaTaiKhoan+'11111')
		UPDATE NhanVien SET MaTaiKhoan = 'NV' + @MaTaiKhoan WHERE MaNhanVien = @MaTaiKhoan
	COMMIT TRAN
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
	ROLLBACK TRAN
END CATCH
GO


--Câp nhật nhân viên
CREATE PROC Proc_SuaNhanVienTheoMa @MaNhanVien INT, @HoTen NVARCHAR(50), @NgaySinh SMALLDATETIME, @GioiTinh NVARCHAR(3), @DienThoai VARCHAR(15), @Email VARCHAR(50), @CMND VARCHAR(9), @MaBoPhan INT
AS
BEGIN TRAN
BEGIN TRY
	IF EXISTS(SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
		UPDATE NhanVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DienThoai = @DienThoai, Email = @Email, CMND = @CMND, MaBoPhan = @MaBoPhan
		WHERE MaNhanVien = @MaNhanVien	
	COMMIT TRAN
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16, 10)
	ROLLBACK TRAN
END CATCH
GO


--Khi xóa nhân viên thì mã nhân viên trong hóa đơn của nhân viên đó thành 0
CREATE PROC Proc_XoaNhanVien @MaNhanVien INT
AS
BEGIN TRAN
BEGIN TRY
	--lấy mã tài khoản
	DECLARE @maTaiKhoan VARCHAR(10)
	SELECT @maTaiKhoan=MaTaiKhoan FROM NhanVien WHERE MaNhanVien = @MaNhanVien
	IF @MaNhanVien != 0 AND NOT EXISTS(SELECT MaNhanVien FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
	BEGIN
		RAISERROR('Không tìm thấy Nhân viên trong danh sách', 16, 10)
		ROLLBACK TRAN
	END
	---Cập nhật MaNhanVien trong các Hóa Đơn về 0
	UPDATE HoaDon SET MaNhanVien = 0 WHERE MaNhanVien = @MaNhanVien
	---Xóa
	DELETE NhanVien WHERE MaNhanVien = @MaNhanVien
	--xóa tài khoản
	DELETE FROM TaiKhoan WHERE MaTaiKhoan =@maTaiKhoan
	IF @@ERROR <>0
	BEGIN
		RAISERROR('Không thể xóa nhân viên',10,10)
		ROLLBACK TRAN
	END
	COMMIT TRAN
END TRY
BEGIN CATCH
	DECLARE @err NVARCHAR(500)
	SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
	RAISERROR(@err, 16,10)
END CATCH
GO

--Lấy mã bộ phận
CREATE FUNCTION dbo.FN_LayMaBoPhan( @TenBoPhan NVARCHAR(100) )
RETURNS INT
AS
BEGIN
    DECLARE @MaBoPhan INT
	SELECT @MaBoPhan = MaBoPhan FROM BoPhan WHERE TenBoPhan = @TenBoPhan
	IF @MaBoPhan IS NULL
		BEGIN
		   SET @MaBoPhan = -1
		END
	RETURN @MaBoPhan
END
GO
--Lấy Tên bộ phận
CREATE FUNCTION FN_LayTenBoPhan( @MaBoPhan INT )
RETURNS NVARCHAR(100)
AS
BEGIN
    DECLARE @TenBoPhan NVARCHAR(100)
	SELECT @TenBoPhan = TenBoPhan FROM BoPhan WHERE MaBoPhan = @MaBoPhan
	IF @TenBoPhan IS NULL
		BEGIN
		   SET @TenBoPhan = -1
		END
	RETURN @TenBoPhan
END
GO



------------------------------------------------------------------
--An Tran - Nhan vien thu ngan
-----------------------------------------------------------------------------------------------------------------

-------------------DANH MỤC CHỨC NĂNG:

--Xem thông tin khách hàng theo mã khách hàng -- proc
--Xem toàn bộ thông tin khách hàng theo mã khách hàng -- proc
--Lấy thông tin khách hàng -- poc
--Lấy thông tin khách hàng theo số điện thoại -- proc
--Lấy thông tin khách hàng theo Mã khách hàng, số điện thoại, mã tài khoản, tên khách hàng -- proc
--Thêm khách hàng -proc
--Sửa thông tin khách hàng theo mã khách hàng --proc
--Lấy thông tin điểm tích lũy theo mã khách hàng --proc
--Cập nhật lại điểm tích lũy theo mã khách hàng-- proc
--Thêm hóa đơn -- Cập nhật lại điểm khách hàng --proc
--Xoá hóa đơn --proc
--Thêm chi tiết hóa đơn -- proc
--Tra cứu theo tên sách -- proc
-- Lấy số lượng sách tồn kho theo ISBN -- proc
--Tra cứu theo tên tác giả -- proc
--Tra cứu theo thể loại sách -- proc
--Kiểm tra số sách còn trong kho theo mã sách -- proc
--Lấy danh sách đầu sách trong kho -- proc
--Lấy thông tin đầy đủ của đầu sách -- proc
--Tìm kiếm thông tin đầu sách dựa trên tên sách, tác giả, thể loại -- proc
--Lấy dánh sách đầy đủ thông tin lịch sử mua hàng -- proc 
--Lấy đầy đủ thông tin chi tiết hóa đơn theo mã hóa đơn --proc

--Mỗi số điện thoại được đăng kí một tài khoản --function
--Kiểm tra Username đã tồn tại -- function
--Kiểm tra mã tài khoản đã tồn tại -- function
--Mã khách hàng được hệ thống thiết lập theo quy định lấy mã khách hàng lớn nhất cộng 1 -- function
--Mã hóa đơn mới -- function

--Cập nhật điểm tích lũy cho khách hàng nếu mã khách hàng khác null -- trigger
--Cập nhật số lượng sách còn trong kho khi khách mua hàng --trigger
--Cập nhật số lượng sách khi đơn hàng bị lỗi --trigger
--Cập nhật số lượng sách khi đơn hàng bị lỗi --trigger


--Bỏ dấu tiếng việt
CREATE FUNCTION [dbo].[non_unicode_convert](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER INT
    DECLARE @COUNTER1 INT
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
GO
--------------------------------------------------------------------------------------------------------------PROC

--Lấy thông tin khách hàng
CREATE PROC USP_LayThongTinKhachHang
AS
BEGIN
    SELECT * FROM dbo.KhachHang
END
GO

--Lấy thông tin khách hàng theo Mã khách hàng
CREATE PROC USP_LayThongTinKhachHangTheoMaKhachHang
@MaKhachHang NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang
END
GO

--Lấy toàn bộ thông tin khách hàng theo Mã khách hàng
CREATE PROC USP_LayToanBoThongTinKhachHangTheoMaKhachHang
@MaKhachHang NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.KhachHang, dbo.TaiKhoan WHERE MaKhachHang = @MaKhachHang AND KhachHang.MaTaiKhoan = TaiKhoan.MaTaiKhoan
END
GO

--Lấy thông tin khách hàng theo Mã khách hàng
CREATE PROC USP_LayThongTinKhachHangTheoDienThoai
@DienThoai NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.KhachHang WHERE DienThoai = @DienThoai
END
GO

--Lấy thông tin khách hàng theo Mã khách hàng, số điện thoại, mã tài khoản, tên khách hàng
CREATE PROC USP_LayThongTinKhachHangTheoTuKhoa
@keyword NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.KhachHang
	WHERE CONCAT(MaKhachHang, DienThoai, MaTaiKhoan, dbo.non_unicode_convert(HoTen)) LIKE N'%' + dbo.non_unicode_convert(@keyword) + '%'
END
GO


--Thêm khách hàng
CREATE PROC USP_ThemKhachHang
@MaTaiKhoan NVARCHAR(50), @username NVARCHAR(50), @password NVARCHAR(50), @HoTen NVARCHAR(50), @NgaySinh DATE, @GioiTinh NVARCHAR(3), @DienThoai NVARCHAR(15), @Email NVARCHAR(50)
AS
BEGIN
	BEGIN TRAN
	BEGIN TRY
		INSERT INTO dbo.TaiKhoan( MaTaiKhoan, username, password )
		VALUES  ( @MaTaiKhoan, @username, @password)

		DECLARE @maxMaKhachHang INT
		SELECT @maxMaKhachHang = MAX(MaKhachHang) FROM dbo.KhachHang

		DECLARE @maKhachHang INT
		IF @maxMaKhachHang IS NULL OR @maKhachHang = -1
		BEGIN
			INSERT INTO dbo.KhachHang (MaKhachHang, HoTen , NgaySinh , GioiTinh , DienThoai , Email , DiemTichLuy , MaBoPhan ,  MaTaiKhoan)
			VALUES  (1, @HoTen , @NgaySinh , @GioiTinh , @DienThoai , @Email , 0, 1 , @MaTaiKhoan )
		END
		ELSE
		BEGIN
			INSERT INTO dbo.KhachHang (MaKhachHang, HoTen , NgaySinh , GioiTinh , DienThoai , Email , DiemTichLuy , MaBoPhan , MaTaiKhoan)
			VALUES  (@maxMaKhachHang + 1, @HoTen , @NgaySinh , @GioiTinh , @DienThoai , @Email , 0, 1 , @MaTaiKhoan )
		END
		COMMIT
	END TRY
	BEGIN CATCH
		DECLARE @err NVARCHAR(500)
		SELECT @err = N'Lỗi: '+ ERROR_MESSAGE()
		RAISERROR(@err, 16, 10)
		ROLLBACK TRAN	
	END CATCH
END
GO

--Sửa thông tin khách hàng
CREATE PROC USP_SuaThongTinKhachHangTheoMaKhachHang
@MaKhachHang INT, @Hoten NVARCHAR(50), @NgaySinh DATE, @GioiTinh NVARCHAR(3), @DienThoai NVARCHAR(15), @Email NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.KhachHang SET HoTen = @Hoten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DienThoai = @DienThoai, Email = @Email WHERE MaKhachHang = @MaKhachHang
END
GO

-- Lấy thông tin điểm tích lũy theo mã khách hàng
CREATE PROC USP_LayDiemTichLuyBangMaKhachHang
@MaKhachHang INT
AS
BEGIN
    SELECT DiemTichLuy FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang
END
GO

--Cập nhật lại điểm tích lũy theo mã khách hàng
CREATE PROC USP_CapNhatDiemTichLuyBangMaKhachHang
@MaKhachHang INT, @DiemTichLuy INT
AS
BEGIN
    UPDATE dbo.KhachHang SET DiemTichLuy = @DiemTichLuy WHERE MaKhachHang = @MaKhachHang
END
GO


--Thêm hóa đơn -- Cập nhật lại điểm khách hàng
CREATE PROC USP_ThemHoaDon
@MaKhachHang INT, @maNhanVien INT, @TongGiaGoc FLOAT, @MaKhuyenMai NVARCHAR(10), @ThanhTien FLOAT, @NgayThanhToan DATETIME
AS
BEGIN
	INSERT INTO dbo.HoaDon(MaKhachHang, MaNhanVien, TongGiaGoc, MaKhuyenMai, ThanhTien, NgayThanhToan) VALUES (@MaKhachHang, @maNhanVien, @TongGiaGoc, @MaKhuyenMai, @ThanhTien, @NgayThanhToan)
END
GO

--Thêm chi tiết hóa đơn
CREATE PROC USP_ThemChiTietHoaDon
@MaHoaDon INT, @ISBN INT, @MaKhuyenMai NVARCHAR(10), @SoLuong INT
AS
BEGIN
    INSERT INTO dbo.ChiTietHoaDon (MaHoaDon, ISBN, MaKhuyenMai, SoLuong) VALUES (@MaHoaDon, @ISBN, @MaKhuyenMai, @SoLuong)
END
GO

--Xoá hóa đơn 
CREATE PROC USP_XoaHoaDonTheoMaHoaDon
@MaHoaDon INT
AS
BEGIN
	DELETE dbo.HoaDon WHERE MaHoaDon = @MaHoaDon
END
GO

--Tra cứu theo tên sách, tên tác giả, thể loại sách
--Tra cứu theo tên sách
CREATE PROC USP_TraCuuTheoTenSach
@TenSach NVARCHAR(30)
AS
BEGIN
    SELECT * FROM dbo.DauSach WHERE dbo.non_unicode_convert(TenDauSach) LIKE '%' + dbo.non_unicode_convert(@TenSach) + '%'
END
GO

-- Lấy số lượng sách tồn kho theo ISBN
CREATE PROC USP_LaySoLuongSachTonKhoTheoISBN
@ISBN INT
AS
BEGIN
    SELECT SoLuong FROM dbo.DauSach WHERE ISBN = @ISBN
END
GO

--Tra cứu theo tên tác giả
CREATE PROC USP_TraCuuTheoTenTacGia
@TacGia NVARCHAR(30)
AS
BEGIN
    SELECT * FROM dbo.DauSach WHERE dbo.non_unicode_convert(TacGia) LIKE '%' + dbo.non_unicode_convert(@TacGia) + '%'
END
GO

--Tra cứu theo thể loại sách
CREATE PROC USP_TraCuuTheoTheLoaiSach
@TenTheLoai NVARCHAR(30)
AS
BEGIN
    SELECT * FROM dbo.TheLoai WHERE dbo.non_unicode_convert(TenTheLoai) LIKE '%' + dbo.non_unicode_convert(@TenTheLoai) + '%'
END
GO

-- Lấy danh sách đầu sách trong kho
CREATE PROC USP_LayDanhSachDauSach
AS
BEGIN
    SELECT * FROM dbo.DauSach
END
GO

--Kiểm tra số sách còn trong kho
CREATE PROC  USP_KiemTraSachConTrongKhoTheoMaSach
@ISBN INT
AS
BEGIN
    SELECT * FROM dbo.DauSach WHERE ISBN = @ISBN
END
GO


--Lấy mã giảm giá theo mã khuyến mãi
CREATE PROC USP_LayGiamGiaTheoMaKhuyenMai
@MaKhuyenMai NVARCHAR(30)
AS
BEGIN
    SELECT * FROM dbo.KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai
END
GO

--Lấy thông tin đầy đủ của đầu sách
CREATE PROC USP_LayThongTinDayDuDauSach
AS
BEGIN
    SELECT ds.ISBN, ds.TenDauSach, ds.TacGia, ds.NXB, ds.NamXuatBan, ds.GiaBia, ds.SoLuong, tl.TenTheLoai FROM dbo.DauSach AS ds, dbo.TheLoai AS tl
	WHERE ds.MaTheLoai = tl.MaTheLoai
END
GO


--Tìm kiếm thông tin đầu sách dựa trên ISBN, tên sách, tác giả, thể loại
CREATE PROC USP_LayThongTinDauSachTheoTuKhoa
@keyword NVARCHAR(50)
AS
BEGIN
    SELECT ds.ISBN, ds.TenDauSach, ds.TacGia, ds.NXB, ds.NamXuatBan, ds.GiaBia, ds.SoLuong, tl.TenTheLoai
	 FROM dbo.DauSach AS ds, dbo.TheLoai AS tl
	 WHERE CONCAT(ds.ISBN, dbo.non_unicode_convert(ds.TenDauSach), dbo.non_unicode_convert(ds.TacGia),  dbo.non_unicode_convert(tl.TenTheLoai)) LIKE N'%' + dbo.non_unicode_convert(@keyword) + '%'
	 AND ds.MaTheLoai = tl.MaTheLoai
END
GO

--Tim kiem thong tin đầy đủ của sách trả về kèm mã thể loại
CREATE PROC USP_LayThongTinDuyNhatDauSachTheoTuKhoa
@keyword NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.DauSach AS ds
	WHERE CONCAT(ds.ISBN, dbo.non_unicode_convert(ds.TenDauSach), dbo.non_unicode_convert(ds.TacGia)) LIKE N'%' + dbo.non_unicode_convert(@keyword) + '%'
END
GO

--Lấy dánh sách đầy đủ thông tin lịch sử mua hàng
CREATE PROC USP_LayDayDuThongTinLichSuMuaHang
AS
BEGIN
    SELECT hd.MaHoaDon, kh.HoTen AS HoTenKH, nv.HoTen AS HoTenNV, hd.TongGiaGoc, hd.MaKhuyenMai, hd.ThanhTien, hd.NgayThanhToan
	FROM dbo.HoaDon AS hd, dbo.KhachHang AS kh, dbo.NhanVien AS nv
	WHERE hd.MaKhachHang = kh.MaKhachHang AND hd.MaNhanVien = nv.MaNhanVien ORDER BY hd.MaHoaDon DESC;
END
GO

--Lấy dánh sách đầy đủ thông tin lịch sử mua hàng theo mã khách hàng, tên khách hàng, số điện thoại
CREATE PROC USP_LayDayDuThongTinLichSuMuaHangTheoTuKhoa
@keyword NVARCHAR(50)
AS
BEGIN
	SELECT hd.MaHoaDon, kh.HoTen AS HoTenKH, nv.HoTen AS HoTenNV, hd.TongGiaGoc, hd.MaKhuyenMai, hd.ThanhTien, hd.NgayThanhToan
	FROM dbo.HoaDon AS hd INNER JOIN dbo.KhachHang AS kh ON kh.MaKhachHang = hd.MaKhachHang INNER JOIN dbo.NhanVien AS nv ON nv.MaNhanVien = hd.MaNhanVien
	WHERE CONCAT(hd.MaHoaDon, CAST(kh.MaKhachHang AS NVARCHAR(50)) , dbo.non_unicode_convert(kh.HoTen), kh.DienThoai) LIKE N'%' + dbo.non_unicode_convert(@keyword) + '%'
	ORDER BY hd.MaHoaDon DESC;
END
GO

--Lấy đầy đủ thông tin chi tiết hóa đơn theo mã hóa đơn
CREATE PROC USP_LayDayDuThongTinChiTietHoaDonTheoMaHoaDon
@MaHoaDon INT
AS
BEGIN
    SELECT cthd.ISBN, ds.TenDauSach, ds.GiaBia, cthd.MaKhuyenMai, km.MucGiam, cthd.SoLuong, cthd.SoLuong * ds.GiaBia * (100 - km.MucGiam)/100 AS ThanhTien 
	FROM dbo.ChiTietHoaDon AS cthd, dbo.DauSach AS ds, dbo.KhuyenMai AS km
	WHERE cthd.MaHoaDon = @MaHoaDon AND cthd.ISBN = ds.ISBN AND cthd.MaKhuyenMai = km.MaKhuyenMai
END
GO

--Lấy đầy đủ thông tin nhân viên Theo mã nhân viên
CREATE PROC USP_LayDayDuThongTinNhanVienTheoMaNhanVien
@MaNhanVien INT
AS
BEGIN
    SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DienThoai, nv.Email, nv.CMND, bp.TenBoPhan 
	FROM dbo.NhanVien AS nv, dbo.BoPhan AS bp
	WHERE nv.MaBoPhan = bp.MaBoPhan AND nv.MaNhanVien = @MaNhanVien
END
GO


-----------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------FUNCTION
-- Mỗi số điện thoại được đăng kí một tài khoản.
CREATE FUNCTION FN_TonTaiSoDienThoai(@DienThoai NVARCHAR(15))
RETURNS BIT
AS
BEGIN
  DECLARE @dem INT
  SELECT @dem = COUNT(*) FROM dbo.KhachHang WHERE DienThoai = @DienThoai
  RETURN @dem
END
GO

-- Kiểm tra Username đã tồn tại.
CREATE FUNCTION FN_TonTaiTenDangNhap(@TenDangNhap NVARCHAR(15))
RETURNS BIT
AS
BEGIN
  DECLARE @dem INT
  SELECT @dem = COUNT(*) FROM dbo.TaiKhoan WHERE  username = @TenDangNhap
  RETURN @dem
END
GO

-- Kiểm tra mã tài khoản đã tồn tại.
CREATE FUNCTION FN_TonTaiMaTaiKhoan(@MaTaiKhoan NVARCHAR(15))
RETURNS BIT
AS
BEGIN
  DECLARE @dem INT
  SELECT @dem = COUNT(*) FROM dbo.TaiKhoan WHERE  MaTaiKhoan = @MaTaiKhoan
  RETURN @dem
END
GO


--Mã khách hàng được hệ thống thiết lập theo quy định lấy mã khách hàng lớn nhất cộng 1.
CREATE FUNCTION FN_TaoMaKhachHang()
RETURNS INT
AS
BEGIN
	DECLARE @MaKhachHangMax INT
	SELECT @MaKhachHangMax = MAX(MaKhachHang) FROM dbo.KhachHang
	RETURN @MaKhachHangMax + 1 
END
GO

--Mã hóa đơn mới
CREATE FUNCTION FN_MaHoaDonMoi()
RETURNS INT
AS
BEGIN
    DECLARE @MaHoaDon INT
	SELECT @MaHoaDon = MAX(MaHoaDon) FROM dbo.HoaDon
	IF @MaHoaDon IS NULL
	BEGIN
	    RETURN 1
	END
	RETURN @MaHoaDon + 1
END
GO

-----------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------TRIGGER
--Cập nhật điểm tích lũy cho khách hàng nếu mã khách hàng khác null
CREATE TRIGGER TG_CapNhatDiemTichLuy
ON dbo.HoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @MaKhachHang INT
	DECLARE @ThanhTien FLOAT
	SELECT @MaKhachHang = ins.MaKhachHang, @ThanhTien = ins.ThanhTien FROM Inserted AS ins
	PRINT @MaKhachHang
	IF @MaKhachHang >= 0
	BEGIN
	    UPDATE dbo.KhachHang SET DiemTichLuy += (@ThanhTien * 5 / 100) WHERE MaKhachHang = @MaKhachHang
	END
END
GO

--Xóa chi tiết hóa đơn trước khi xóa hóa đơn
CREATE TRIGGER TG_XoaChiTietHoaDon
ON dbo.HoaDon
FOR DELETE
AS
BEGIN
    DECLARE @MaHoaDon INT
	SELECT @MaHoaDon = MaHoaDon FROM Deleted
	DELETE dbo.ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon
END
GO

--Cập nhật số lượng sách còn trong kho khi khách mua hàng
CREATE TRIGGER TG_CapNhatSoLuongDauSach
ON dbo.ChiTietHoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @SoLuongSachMua INT
	DECLARE @isbn INT
	SELECT @isbn = ins.ISBN, @SoLuongSachMua = ins.SoLuong FROM Inserted AS ins
	UPDATE dbo.DauSach SET SoLuong -= @SoLuongSachMua WHERE ISBN = @isbn
END
GO

--Cập nhật số lượng sách khi đơn hàng bị lỗi
CREATE TRIGGER TG_CapNhatSoLuongDauSachLoi
ON dbo.ChiTietHoaDon
FOR DELETE
AS
BEGIN
    DECLARE @SoLuongSachMua INT
	DECLARE @isbn INT
	SELECT @isbn = del.ISBN, @SoLuongSachMua = del.SoLuong FROM Deleted AS del
	UPDATE dbo.DauSach SET SoLuong += @SoLuongSachMua WHERE ISBN = @isbn
END
GO


---------------------------------------------------------------

--------------------------------------------------------------------------------------------
--HOÀNG THÁI NHƯ QUỲNH
--select S.ISBN, S.TenDauSach [Tên Sách], S.NXB [Nhà xuất bản], S.TacGia [Tác giả], S.NamXuatBan [Năm xuất bản], T.TenTheLoai [Thể loại], G.gia [Giá Gốc], G.giagiam [Giá Khuyến Mãi], G.giam [Giảm(%)], S.SoLuong [Số lượng còn]
-- PROC
CREATE PROC USP_LayDanhSachSachChoKhachHang
AS
BEGIN
	WITH  tableBooks AS (SELECT ds.ISBN, ds.TenDauSach, ds.NXB, ds.TacGia, ds.NamXuatBan, tl.TenTheLoai, ds.GiaBia, km.MucGiam, (ds.GiaBia * (100 - km.MucGiam) /100) AS GiaKhuyenMai, ds.SoLuong
	FROM dbo.DauSach AS ds, dbo.KhuyenMai AS km, dbo.TheLoai AS tl
	WHERE ds.ISBN = km.ISBN AND ds.MaTheLoai = tl.MaTheLoai AND km.DoiTuong = N'Sách' AND km.NgayBatDau <= GETDATE() AND km.NgayKetThuc >= GETDATE() AND km.MaKhuyenMai != 'NONE' AND km.DieuKien <= ds.GiaBia AND ds.ISBN > 0
	UNION
	SELECT ds.ISBN, ds.TenDauSach, ds.NXB, ds.TacGia, ds.NamXuatBan, tl.TenTheLoai, ds.GiaBia, 0 AS MucGiam, ds.GiaBia AS GiaKhuyenMai, ds.SoLuong
	FROM dbo.DauSach AS ds, dbo.TheLoai AS tl
	WHERE ds.MaTheLoai = tl.MaTheLoai AND ds.ISBN > 0)
	SELECT tb.ISBN, tb.TenDauSach, tb.NXB, tb.TacGia, tb.NamXuatBan, tb.TenTheLoai, tb.GiaBia, SUM(tb.MucGiam) AS MucGiam, MIN(tb.GiaKhuyenMai) AS GiaKhuyenMai, tb.SoLuong
	FROM tableBooks AS tb
	GROUP BY tb.ISBN, tb.TenDauSach, tb.NXB, tb.TacGia, tb.NamXuatBan, tb.TenTheLoai, tb.GiaBia, tb.SoLuong
END
GO

--Tìm kiếm sách
CREATE PROC USP_LayDanhSachSachChoKhachHangByKeyword
@keyword NVARCHAR(MAX)
AS
BEGIN
    WITH  tableBooks AS (SELECT ds.ISBN, ds.TenDauSach, ds.NXB, ds.TacGia, ds.NamXuatBan, tl.TenTheLoai, ds.GiaBia, km.MucGiam, (ds.GiaBia * (100 - km.MucGiam) /100) AS GiaKhuyenMai, ds.SoLuong
	FROM dbo.DauSach AS ds, dbo.KhuyenMai AS km, dbo.TheLoai AS tl
	WHERE ds.ISBN = km.ISBN AND ds.MaTheLoai = tl.MaTheLoai AND km.DoiTuong = N'Sách' AND km.NgayBatDau <= GETDATE() AND km.NgayKetThuc >= GETDATE() AND km.MaKhuyenMai != 'NONE' AND km.DieuKien <= ds.GiaBia AND ds.ISBN > 0
	UNION
	SELECT ds.ISBN, ds.TenDauSach, ds.NXB, ds.TacGia, ds.NamXuatBan, tl.TenTheLoai, ds.GiaBia, 0 AS MucGiam, ds.GiaBia AS GiaKhuyenMai, ds.SoLuong
	FROM dbo.DauSach AS ds, dbo.TheLoai AS tl
	WHERE ds.MaTheLoai = tl.MaTheLoai AND ds.ISBN > 0)
	SELECT tb.ISBN, tb.TenDauSach, tb.NXB, tb.TacGia, tb.NamXuatBan, tb.TenTheLoai, tb.GiaBia, SUM(tb.MucGiam) AS MucGiam, MIN(tb.GiaKhuyenMai) AS GiaKhuyenMai, tb.SoLuong
	FROM tableBooks AS tb
	WHERE CONCAT(CAST(tb.ISBN AS NVARCHAR(50)) , dbo.non_unicode_convert(tb.TenDauSach),  dbo.non_unicode_convert(tb.TenTheLoai),  dbo.non_unicode_convert(tb.TacGia)) LIKE N'%' + dbo.non_unicode_convert(@keyword) + '%'
	GROUP BY tb.ISBN, tb.TenDauSach, tb.NXB, tb.TacGia, tb.NamXuatBan, tb.TenTheLoai, tb.GiaBia, tb.SoLuong
END
GO 

--Lấy thông tin giỏ hàng //Cập nhật thêm thông tin khuyến mãi hết hạn...
CREATE PROC USP_LayThongTinGioHangTheoMaKhachHang
@MaKhachHang INT
AS
BEGIN
    SELECT ds.ISBN, ds.TenDauSach, gh.SoLuong, ds.GiaBia, gh.MaKhuyenMai, gh.ThanhTien
	FROM dbo.GioHang AS gh, dbo.DauSach AS ds, dbo.KhuyenMai AS km
	WHERE gh.ISBN = ds.ISBN AND MaKhachHang = @MaKhachHang AND km.MaKhuyenMai = gh.MaKhuyenMai 
END
GO

--Lấy thông tin lịch sử mua hàng của người dùng
CREATE PROC USP_LayThongLichSuMuaHangTheoMaKhachHang
@MaKhachHang INT
AS
BEGIN
    SELECT hd.MaHoaDon, ds.ISBN, ds.TenDauSach, hdct.SoLuong, ds.GiaBia, hdct.MaKhuyenMai, hd.NgayThanhToan
	FROM dbo.HoaDon AS hd, dbo.ChiTietHoaDon AS hdct, dbo.DauSach AS ds
	WHERE hd.MaHoaDon = hdct.MaHoaDon AND hdct.ISBN = ds.ISBN AND hd.MaKhachHang = @MaKhachHang
END
GO

--Thêm sách vào trong Giỏ hang
CREATE PROC USP_ThemSachVaoGioHang
@MaKhachHang INT, @ISBN INT, @GiaGoc FLOAT , @SoLuong INT, @ThanhTien FLOAT
AS
BEGIN
    IF (EXISTS(SELECT * FROM dbo.GioHang WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN))
	    UPDATE dbo.GioHang SET SoLuong += @SoLuong WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN
	ELSE
    BEGIN
        INSERT INTO dbo.GioHang( MaKhachHang, ISBN , SoLuong , GiaGoc, MaKhuyenMai , ThanhTien)
        VALUES  (@MaKhachHang, @ISBN, @SoLuong, @GiaGoc, N'NONE', @ThanhTien)
    END
END
GO


--Cập nhật lại giỏ hàng
CREATE PROC USP_CapNhatGioHang
@MaKhachHang INT, @ISBN INT, @SoLuong INT
AS
BEGIN
    UPDATE dbo.GioHang SET SoLuong = @SoLuong WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN
END
GO

--Xoá tất cả sách trong giỏ hàng
CREATE PROC USP_XoaTatCaSachTrongGioHang
@MaKhachHang INT
AS
BEGIN
    DELETE dbo.GioHang WHERE MaKhachHang = @MaKhachHang
END
GO

-- Xóa sách trong giỏ hàng
CREATE PROC USP_XoaSachTrongGioHang
@MaKhachHang INT, @ISBN INT
AS
BEGIN
    DELETE dbo.GioHang WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN
END
GO

-- Xoá thể loại
CREATE PROC USP_XoaTheLoaiTheMa
@MaTheLoai INT
AS
BEGIN
    DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.DauSach AS ds
	WHERE ds.MaTheLoai = @MaTheLoai
	IF (@count = 0)
	BEGIN
		DELETE dbo.TheLoai WHERE MaTheLoai = @MaTheLoai
	END
END
GO

--FUNCTION


--TRIGGER
-- Khi sách trong giỏ hàng cập nhật số lượng thì số tiền cũng cập nhật theo


--Khi insert sách vào giỏ hàng thì kiểm tra điều kiện mã giảm giá và cập nhật thành tiền
CREATE TRIGGER TG_CapNhatMaKhuyenMaiGioHang
ON dbo.GioHang
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaKhachHang INT
	DECLARE @ISBN INT, @GiaGoc FLOAT, @SoLuong INT, @ThanhTien FLOAT
	SELECT @MaKhachHang = ins.MaKhachHang, @ISBN = ins.ISBN, @GiaGoc = ins.GiaGoc, @SoLuong = ins.SoLuong, @ThanhTien = ins.ThanhTien
	FROM Inserted AS ins

	DECLARE @MaKhuyenMai NVARCHAR(30) = N'NONE', @MucGiam INT = 0
	SELECT @MaKhuyenMai = km.MaKhuyenMai, @MucGiam = km.MucGiam FROM dbo.KhuyenMai AS km WHERE km.ISBN = @ISBN AND km.DoiTuong = N'Sách'
	AND GETDATE() >= km.NgayBatDau AND GETDATE() <= km.NgayKetThuc AND km.DieuKien <= @GiaGoc * @SoLuong

	IF (@MaKhuyenMai IS NULL OR @MucGiam IS NULL)
	BEGIN
	    UPDATE dbo.GioHang SET MaKhuyenMai = 'NONE', ThanhTien = SoLuong * GiaGoc WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN
	END
	ELSE
    BEGIN
         UPDATE dbo.GioHang SET MaKhuyenMai = @MaKhuyenMai, ThanhTien = SoLuong * GiaGoc * (100 - @MucGiam) / 100 WHERE MaKhachHang = @MaKhachHang AND ISBN = @ISBN
    END
END
GO


--==============================================================

