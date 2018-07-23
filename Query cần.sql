delete from TuVung where TenTuVung = 'rice' and TenBoTuVung = N'Food'

select count(*)from TuVung tv where tv.TenBoTuVung = N'admin'

select *from TuVung tv where tv.TenBoTuVung = N'Hải đẹp trai'





Update TuVung set NghiaTuVung = N'(n) di động' where TenBoTuVung = N'Khoa học máy tính' and TenTuVung = 'Mobile'

UpDate TuVung set
SoLanTraLoiSai = SoLanTraLoiSai + 1, 
SoLanLuyenTap = SoLanLuyenTap + 1
where TenTuVung = 'banana' and TenBoTuVung = N'Food'

Update TuVung set TiLeTraLoiSai = 1006, 
SoLanLuyenTap = 0, 
SoLanTraLoiSai = 0 
where TenBoTuVung != N'admin'

UpDate TuVung set
SoLanLuyenTap = SoLanLuyenTap + 1,
SoLanTraLoiSai = SoLanTraLoiSai + 1
where TenBoTuVung = N'Food' and TenTuVung = 'banana'
Go
Update TuVung set TiLeTraLoiSai = CONVERT(float, SoLanTraLoiSai) / SoLanLuyenTap
where TenBoTuVung = N'Food'
Go
select *from TuVung tv 
where tv.TenBoTuVung = N'Food'

Update TuVung set TiLeTraLoiSai = CONVERT(float, SoLanTraLoiSai) / SoLanLuyenTap
where TenBoTuVung = N'Food'



Update TuVung set
SoLanLuyenTap = 0,
SoLanTraLoiSai = 0,
TiLeTraLoiSai = 1006


UpDate TuVung set
TiLeTraLoiSai = SoLanTraLoiSai / SoLanLuyenTap
where TenBoTuVung = N'Food'

Update TuVung set TiLeTraLoiSai = SoLanTraLoiSai / SoLanLuyenTap
where TenTuVung = 'banana' and TenBoTuVung = N'Food'

select *from TuVung
where TenBoTuVung = N'food'
order by TiLeTraLoiSai desc, SoLanLuyenTap asc, newid()


--Select ra 10 từ ngẫu nhiên trong bảng từ vựng
select top 10 TenTuVung, NghiaTuVung from TuVung
where TenBoTuVung = N'admin' 
order by newid()

insert into TuVung(TenTuVung, NghiaTuVung, TenBoTuVung, SoLanLuyenTap, SoLanTraLoiSai, TiLeTraLoiSai)
values
('handsome', N'đẹp trai', N'Hải đẹp trai', 0, 0, 1006)

delete from TuVung where TenTuVung = 'handsome' and TenBoTuVung = N'Hải đẹp trai'



select top 4 TenTuVung 
from TuVung
where TenBoTuVung = N'admin'
and TenTuVung not like '%banana'
and NghiaTuVung not like N'%chuối%'
and NghiaTuVung not like N'%banana%'
order by newid()

select top 4 TenTuVung from TuVung where TenBoTuVung = N'admin' and TenTuVung not like '%ice-cream' and NghiaTuVung not like N'%(n) cây kem%' and NghiaTuVung not like N'%ice-cream%' order by newid()

select top 4 TenTuVung from TuVung where TenBoTuVung = N'admin' and TenTuVung not like '%orange' and NghiaTuVung not like N'%(n) quả cam @(n) trái cam%' and NghiaTuVung not like N'%orange%' order by newid()