use GutyrchikIntensive
go
select Deadline, count(TaskID) as 'Количество задач'
	from [Tasks in Projects]
	group by Deadline