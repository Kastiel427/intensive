use GutyrchikIntensive
go
update Projects
set ProjectName = ProjectName + ' - Гутырчик А.В.'
where ProjectName = 'Интенсив'

select *
	from Projects