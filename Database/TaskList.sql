use GutyrchikIntensive
go
insert into Tasks (ProjectID, TaskName, Specification, Closed)
select 6, ProjectName, 'Задача по имени проекта', 'нет'
	from Projects
	where not exists (select TaskName
						  From Tasks
						  where TaskName = ProjectName)
