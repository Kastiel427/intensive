use GutyrchikIntensive
go
select Deadline, count(TaskID) as '���������� �����'
	from Tasks
	group by Deadline