use GutyrchikIntensive
go
insert into Projects
values (1, '�������� ����� �����')
insert into Projects
values (2, '�������� VirtualSystem')
insert into Projects
values (3, '���������� ������')
insert into Projects
values (4, 'C����� �����, ��� �������')
insert into Projects
values (5, '�������� ��������')

insert into Tasks
values (1, '������� ���� ������', '�������� �������� � �����, ������ �����������')
insert into Tasks
values (2, '�������� ����', '�������� ��������, ���������� ��������')
insert into Tasks
values (3, '�������� ������', '������������� �������� �� ��������������')
insert into Tasks
values (4, '�����-������������', '�������� ������������ ����� ������������� ���������� ����� � ������� ��������')
insert into Tasks
values (5, '����-������������', '�������� �������� ������������ � ������� ������������� ��������')

insert into [Tasks in Projects]
values(1, 1, '���', '08/1/2016')
insert into [Tasks in Projects]
values(1, 2, '���','09/1/2016')
insert into [Tasks in Projects]
values(1, 3, '���', '11/15/2016')
insert into [Tasks in Projects]
values(2, 1, '���', '07/23/2016')
insert into [Tasks in Projects]
values(2, 2, '���', '08/1/2016')
insert into [Tasks in Projects]
values(2, 3, '���', '11/10/2016')
insert into [Tasks in Projects]
values(2, 4, '���', '12/1/2016')
insert into [Tasks in Projects]
values(2, 5, '���', '01/31/2017')
insert into [Tasks in Projects]
values(3, 1, '���', '01/31/2017')
insert into [Tasks in Projects]
values(3, 2, '���', '02/23/2017')
insert into [Tasks in Projects]
values(3, 3, '���', '03/1/2017')
insert into [Tasks in Projects]
values(4, 2, '���', '03/1/2017')
insert into [Tasks in Projects]
values(5, 2, '���', '08/1/2016')


