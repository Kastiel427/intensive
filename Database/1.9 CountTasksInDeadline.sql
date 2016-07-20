use GutyrchikIntensive
go
select Deadline, count(TaskID) as 'Количество задач'
	from Tasks
	group by Deadline