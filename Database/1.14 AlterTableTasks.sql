use GutyrchikIntensive
go
alter table Tasks
	ADD [���� �����������] datetime  NULL

create trigger update_Tasks
on Tasks after update, insert
as
begin
	update Tasks
		set [���� �����������] = GetDate()
		where TaskID in (select TaskID from inserted)
end
