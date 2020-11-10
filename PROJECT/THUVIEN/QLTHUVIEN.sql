

create database QuanLyThuVien
go
use QuanLyThuVien
go

-----

create table DOCGIA
(
	MaDocGia int Identity(1,1),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh date,
	PRIMARY KEY (MaDocGia),
)
go

create proc ThemDG
@HoTen nchar(30),
@GioiTinh nchar(5),
@NamSinh date
as
insert into DOCGIA(HoTen, GioiTinh,NamSinh) values (@HoTen, @GioiTinh, @NamSinh)
go

create proc GetDG as  select* from DOCGIA
go

create proc XoaDg 
@MaDocGia int
as
delete from DOCGIA
go

create proc SuaDg
@MaDocGia int,
@OrinMaDocGia int,
@HoTen nchar(30),
@GioiTinh nchar(5),
@NamSinh date as update DOCGIA set	
									HoTen = @HoTen,
									GioiTinh = @GioiTinh,
									NamSinh = @NamSinh
									where MaDocGia = @OrinMaDocGia
go


insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Thị Hoàng Ngọc',N'Nữ','2000')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Nguyễn Lê Phúc Hậu',N'Nữ','1979')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Phạm Huỳnh Tín','Nam','2000')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lư Hưng Vương',N'Khác','2000')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lý Hồng Loan',N'Nữ','1999')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lê Hồng Phát',N'Nữ','1994')
insert into DOCGIA (HoTen,GioiTinh,NamSinh) values (N'Lưu Đặng Thiên Phúc',N'Nam','1994')
go


create table NHANVIEN
(
	MaNV int Identity(1,1),
	HoTen nchar(30),
	TenDangNhap nchar(30),
	NamSinh date,
	DiaChi nchar(100),
	PRIMARY KEY (MaNV),
)
go

create proc XoaNV
@MaNV int
as
delete from NHANVIEN
go

create proc SuaNV
@MaNV int,
@OrinMaNV int,
@HoTen nchar(30),
@TenDangNhap nchar(30),
@NamSinh date,
@DiaChi nchar(100)
as update NHANVIEN set
					HoTen = @HoTen,
					TenDangNhap = @TenDangNhap,
					NamSinh = @NamSinh,
					DiaChi = @DiaChi
					where MaNV = @OrinMaNV
go
create proc ThemNV
@HoTen nchar(30),
@TenDangNhap nchar(30),
@NamSinh date,
@DiaChi nchar(100)
as
insert into NHANVIEN(HoTen, TenDangNhap,NamSinh,DiaChi) values (@HoTen, @TenDangNhap,@NamSinh, @DiaChi)
go


create proc GetNV as  select* from NHANVIEN
go

insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Lê Thị Hoàng Ngọc', N'hoangngoc','2000',N'Phú Quốc Kiên Giang')
insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Nguyễn Lê Phúc Hậu', N'phuchau','1998',N'Phú Quốc Kiên Giang')
insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Phạm Huỳnh Tín', N'huynhtin','1999',N'Phú Quốc Kiên Giang')
insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Lư Hưng Vương', N'hungvuong','2001',N'Bà Rịa Tây Ninh')
insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Hoàn Văn Thành', N'hoanthanh','2000',N'Vũng Tàu Hà Nội')
insert into NHANVIEN (HoTen,TenDangNhap,NamSinh,DiaChi) values (N'Bùi Thẩm Đoàn', N'doanbui','2002',N'Bến Tre Phú Yên')
go






create table SACH
(
	MaSach int Identity(1,1),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nvarchar(11),
	PRIMARY KEY (MaSach),
)
go



create proc ThemS
@TenSach nchar(50),
@TacGia nchar(30),
@TheLoai nchar(30),
@NhaXuatBan nchar(50),
@GiaSach int,
@SoLuong int,
@TinhTrang nvarchar(11)
as
insert into SACH(TenSach, TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (@TenSach, @TacGia,@TheLoai, @NhaXuatBan,@GiaSach,@SoLuong,@TinhTrang)
go

create proc GetS as select*from SACH
go

create proc XoaS
@MaSach int
as delete from SACH
go

create proc SuaS
@MaSach int,
@OrinMaSach int,
@TenSach nchar(50),
@TacGia nchar(30),
@TheLoai nchar(30),
@NhaXuatBan nchar(50),
@GiaSach int,
@SoLuong int,
@TinhTrang nvarchar(11)
as update SACH set
					TenSach = @TenSach,
					TacGia = @TacGia,
					TheLoai = @TheLoai,
					NhaXuatBan = @NhaXuatBan,
					GiaSach = @GiaSach,
					SoLuong = @SoLuong,
					TinhTrang = @TinhTrang
					where MaSach = @OrinMaSach
go

insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Thiên Tử',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Chưa Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Thiên Tử',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Đã Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Đại số tuyến tính',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Đã Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Đại số tuyến tính',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Đã Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Toán rời rạc',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Đã Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'MAC',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Chưa Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Thiên Tử',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Chưa Trả')
insert into SACH (TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) values (N'Thiên Tử',N'Thiên Hương',N'Truyện',N'TP.HCM','150000','50',N'Chưa Trả')
go



create table PHIEUMUON(
	MaPhieuMuon int Identity(1,1),
	MaNV int,
	MaSach int,
	NgayMuon date,
	NgayPhaiTra date,
	PRIMARY KEY (MaPhieuMuon),
)
go

create proc XoaPM
@MaPhieuMuon int
as 
delete from PHIEUMUON
go

create proc SuaPM
@MaPhieuMuon int,
@OrinMaPhieuMuon int,
@MaNV int,
@MaSach int,
@NgayMuon date,
@NgayPhaiTra date
as update PHIEUMUON set
					MaNV = @MaNV,
					MaSach = @MaSach,
					NgayMuon = @NgayMuon,
					NgayPhaiTra = @NgayPhaiTra
					where 
					MaPhieuMuon = @OrinMaPhieuMuon
go

create proc GetPM as  select* from PHIEUMUON
go

create proc ThemPM
@MaNV int,
@MaSach int,
@NgayMuon date,
@NgayPhaiTra date
as
insert into PHIEUMUON(MaNV, MaSach,NgayMuon,NgayPhaiTra) values (@MaNV, @MaSach,@NgayMuon, @NgayPhaiTra)
go


insert into PHIEUMUON (MaNV,MaSach,NgayMuon,NgayPhaiTra) values ('1','1','2020/10/16','2020/10/18')
insert into PHIEUMUON (MaNV,MaSach,NgayMuon,NgayPhaiTra) values ('2','2','2020/10/16','2020/10/18')
insert into PHIEUMUON (MaNV,MaSach,NgayMuon,NgayPhaiTra) values ('3','3','2020/10/16','2020/10/18')
insert into PHIEUMUON (MaNV,MaSach,NgayMuon,NgayPhaiTra) values ('4','4','2020/10/16','2020/10/18')
go


create table PHIEUTRA
(
	MaPhieuTra int Identity(1,1),
	MaPhieuMuon int ,
	MaSach int,
	NgayTra date,
	PRIMARY KEY (MaPhieuTra),
)
go

create proc XoaPT
@MaPhieuTra int
as 
delete from PHIEUTRA
go

create proc SuaPT
@MaPhieuTra int,
@OrinMaPhieuTra int,
@MaPhieuMuon int,
@MaSach int,
@NgayTra date
as update PHIEUTRA set MaPhieuMuon = @MaPhieuMuon,
						MaSach = @MaSach,
						NgayTra = @NgayTra
						where MaPhieuTra = @OrinMaPhieuTra
						go


create proc ThemPT 
@MaPhieuMuon int,
@MaSach int,
@NgayTra date
as
insert into PHIEUTRA(MaPhieuMuon, MaSach, NgayTra) values(@MaPhieuMuon,@MaSach,@NgayTra)
go

create proc GetPT as  select* from PHIEUTRA
go



insert into PHIEUTRA (MaPhieuMuon,MaSach,NgayTra) values ('1','1','2020-10-23')
insert into PHIEUTRA (MaPhieuMuon,MaSach,NgayTra) values ('2','2','2020-10-23')
insert into PHIEUTRA (MaPhieuMuon,MaSach,NgayTra) values ('3','3','2020-10-23')
go



create table QLMUONTRA
(
	MaQL int Identity(1,1),
	MaDocGia int,
	MaSach int,
	MaPhieuMuon int,
	MaPhieuTra int,
	TinhTrang nvarchar(11),
	PRIMARY KEY (MaQL),
)
go

create proc ThemQLMT
@MaDocGia int,
@MaSach int,
@MaPhieuMuon int,
@MaPhieuTra int,
@TinhTrang nvarchar(11)
as
insert into QLMUONTRA(MaDocGia,MaSach,MaPhieuMuon,MaPhieuTra,TinhTrang) values(@MaDocGia,@MaSach,@MaPhieuMuon,@MaPhieuTra,@TinhTrang)
go

create proc XoaQLMT
@MaQL int
as delete from QLMUONTRA
go

create proc SuaQLMT
@MaQL int,
@OrinMaQL int,
@MaDocGia int,
@MaSach int,
@MaPhieuMuon int,
@MaPhieuTra int,
@TinhTrang nvarchar(11)
as update QLMUONTRA set MaDocGia = @MaDocGia,
						MaSach = @MaSach,
						MaPhieuMuon = @MaPhieuMuon,
						MaPhieuTra = @MaPhieuTra,
						TinhTrang = @TinhTrang
						where MaQL = @OrinMaQL
						go

create proc GetQlMT as  select* from QLMUONTRA
go

insert into QLMUONTRA(MaDocGia,MaSach,MaPhieuMuon,MaPhieuTra,TinhTrang)values(1,1,1,1,N'Chưa Trả')
insert into QLMUONTRA(MaDocGia,MaSach,MaPhieuMuon,MaPhieuTra,TinhTrang)values(2,2,2,2,N'Đã Trả')
insert into QLMUONTRA(MaDocGia,MaSach,MaPhieuMuon,MaPhieuTra,TinhTrang)values(3,3,3,3,N'Đã Trả')
go





create table ACCOUNT
(
	MaAcc int Identity(1,1) ,
	MaNV int,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	PRIMARY KEY (MaAcc),
	
)
go

create proc XoaAC
@MaNV int
as delete from ACCOUNT
go



create proc GetAC as  select* from ACCOUNT
go

insert into ACCOUNT (MaNV,TenDangNhap,MatKhau) values ('1','hoangngoc','hoangngoc')
insert into ACCOUNT (MaNV,TenDangNhap,MatKhau) values ('2','phuchau','phuchau')
insert into ACCOUNT (MaNV,TenDangNhap,MatKhau) values ('2','hongphat','hongphat')

go

create proc DangNhap
@TenDangNhap nchar(30),
@MatKhau nchar(30)
as select* from ACCOUNT
where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau
go





alter table PHIEUMUON add
	constraint FK_PHIEUMUON_NHANVIEN foreign key (MaNV) references NHANVIEN (MaNV),
	constraint FK_PHIEUMUON_SACH foreign key (MaSach) references SACH (MaSach)


alter table QLMUONTRA add
	constraint FK_QLMUONTRA_PHIEUMUON foreign key (MaPhieuMuon) references PHIEUMUON (MaPhieuMuon),
	constraint FK_QLMUONTRA_PHIEUTRA foreign key (MaPhieuTra) references PHIEUTRA (MaPhieuTra),
	constraint FK_QLMUONTRA_SACH foreign key (MaSach) references SACH (MaSach),
	constraint FK_QLMUONTRA_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGIa)
	
alter table PHIEUTRA add
	constraint FK_PHIEUTRA_PHIEUMUON foreign key (MaPhieuMuon) references PHIEUMUON (MaPHieuMuon),
	constraint FK_PHIEUTRA_SACH foreign key (MaSach) references SACH (MaSach)

alter table ACCOUNT add
	constraint FK_ACCOUNT_NHANVIEN foreign key (MaNV) references NHANVIEN (MaNV)










