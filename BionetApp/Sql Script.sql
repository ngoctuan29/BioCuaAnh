
if not exists(select b.name from sys.objects a inner join sys.columns b on a.object_id=b.object_id where a.name ='PSDanhMucChiCuc' and b.name ='isDongBo')
	alter table PSDanhMucChiCuc add isDongBo bit default 0 not null
go
if not exists(select b.name from sys.objects a inner join sys.columns b on a.object_id=b.object_id where a.name ='PSDanhMucChiCuc' and b.name ='isXoa')
	alter table PSDanhMucChiCuc add isXoa bit default 0 not null
go
if not exists(select b.name from sys.objects a inner join sys.columns b on a.object_id=b.object_id where a.name ='PSDanhMucDonViCoSo' and b.name ='Email')
	alter table PSDanhMucDonViCoSo add Email varchar(200) default 0 not null
go
if not exists(select b.name from sys.objects a inner join sys.columns b on a.object_id=b.object_id where a.name ='PSPatient' and b.name ='Email')
	alter table PSPatient add Email varchar(200) default 0 not null
go

