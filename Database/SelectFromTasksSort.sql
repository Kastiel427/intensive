use GutyrchikIntensive
go
select *
	from [Tasks in projects]
	order by YEAR(Deadline), MONTH(Deadline), DAY(Deadline) desc