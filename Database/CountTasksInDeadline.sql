use GutyrchikIntensive
go
select Deadline, count(TaskID) as '���������� �����'
	from [Tasks in Projects]
	group by Deadline