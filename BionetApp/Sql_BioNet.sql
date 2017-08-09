if not exists(select name from sys.columns where Name = N'KieuTraKetQua' and Object_ID = Object_ID(N'PSDanhMucDonViCoSo'))
	alter table PSDanhMucDonViCoSo add KieuTraKetQua int
	else alter table PSDanhMucDonViCoSo  alter column KieuTraKetQua int 
if not exists(select name from sys.columns where Name = N'GioiTinh' and Object_ID = Object_ID(N'PSPatient'))
	alter table PSPatient add GioiTinh int 
	else alter table PSPatient alter column GioiTinh int 
if not exists(select name from sys.columns where Name = N'PhuongPhapSinh' and Object_ID = Object_ID(N'PSPatient'))
	alter table PSPatient add PhuongPhapSinh int 
	else alter table PSPatient alter column PhuongPhapSinh int 
if not exists(select name from sys.columns where Name = N'NgayVao' and Object_ID = Object_ID(N'PSBenhNhanNguyCoCao'))
	alter table PSBenhNhanNguyCoCao add NgayVao datetime 
if not exists(select name from sys.columns where Name = N'KieuCapMa' and Object_ID = Object_ID(N'PSThongTinTrungTam'))
	alter table PSThongTinTrungTam add KieuCapMa int 
	if not exists(select name from sys.columns where Name = N'isChoThucHienXNLan2' and Object_ID = Object_ID(N'PSThongTinTrungTam'))
	alter table PSThongTinTrungTam add isThucHienXNLan2 bit default 1
	if not exists(select name from sys.columns where Name = N'isChoThuMauLai ' and Object_ID = Object_ID(N'PSThongTinTrungTam'))
	alter table PSThongTinTrungTam add isChoThuMauLai bit default 1
	
