insert into Tasks (ProjectID, TaskName, Specification, Closed)
select (select ProjectID from Projects where ProjectName = '������ �����'), ProjectName, '������ �� ����� �������', '���'
	from Projects
	where not exists (select TaskName
						  From Tasks
						  where TaskName = ProjectName and ProjectID = (select ProjectID from Projects where ProjectName = '������ �����'))

