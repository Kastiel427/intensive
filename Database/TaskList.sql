use GutyrchikIntensive
go
insert into Tasks (ProjectID, TaskName, Specification, Closed)
select 6, ProjectName, '������ �� ����� �������', '���'
	from Projects
	where not exists (select TaskName
						  From Tasks
						  where TaskName = ProjectName)
