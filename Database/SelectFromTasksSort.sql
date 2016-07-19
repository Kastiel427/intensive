use GutyrchikIntensive
go
select *
	from Tasks
	order by YEAR(Deadline), MONTH(Deadline), DAY(Deadline) 