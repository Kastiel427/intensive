use GutyrchikIntensive
go
select Projects.ProjectName as '��� �������', Tasks.TaskName as '��� ������'
	from ([Tasks in Projects] inner join Tasks on [Tasks in Projects].TaskID = Tasks.TaskID)
									 inner join Projects on [Tasks in Projects].ProjectID = Projects.ProjectID