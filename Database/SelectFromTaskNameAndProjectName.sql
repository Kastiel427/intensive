use GutyrchikIntensive
go
select Projects.ProjectName as '��� �������', Tasks.TaskName as '��� ������'
	from Tasks inner join Projects on Tasks.ProjectID = Projects.ProjectID