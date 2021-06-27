drop database qldv
go

create database qldv
go
use qldv




create table acc (
	name varchar(10) primary key,
	pass varchar(15) not null,
	type varchar(10) not null,
	cauhoi nvarchar(50),
	trl nvarchar(30)
) 


create table info_co_so_doan (
	macs varchar(10) primary key,
	tencs nvarchar(30) not null,
	diachi nvarchar(30) not null
)

go

create table doan_vien(
	madv varchar(10) primary key,
	macs varchar(10),
	tendv nvarchar(30) not null,
	ngaysinh date,
	gioitinh nvarchar(5),
	diachi nvarchar(30),
	sdt varchar(11),
	ngayvaodoan date,
	llct nvarchar(15),
	tdhv nvarchar(15),
	FOREIGN KEY (macs) REFERENCES info_co_so_doan(macs)
)

go

create table kt_kl(
	madv varchar(10) primary key,
	khenthuong nvarchar(20),
	kiluat nvarchar(20)
	FOREIGN KEY (madv) REFERENCES doan_vien(madv)
)


go

create procedure del_coso
(@macs varchar(10))

as
begin
	delete  kt_kl  
	where madv in 
	(select madv from doan_vien where macs = @macs)

	delete doan_vien where macs = @macs
	delete info_co_so_doan where macs = @macs
end;

go

create procedure del_doanvien
(@madv varchar(10))
as
begin
	delete kt_kl where madv = @madv
	delete doan_vien where madv = @madv
end;

go

insert into acc(name,pass,type) values
('admin', '123','admin'),
('user1', 'user1','user')

