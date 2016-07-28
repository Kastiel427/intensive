use GutyrchikIntensive
go
select Projects.ProjectName as 'Имя проекта', Tasks.TaskName as 'Имя задачи'
	from Tasks inner join Projects on Tasks.ProjectID = Projects.ProjectID