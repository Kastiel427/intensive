select sys.tables.name as '��� �������',
       sys.indexes.name as '��� �������',
	   sys.sysindexes.rowcnt as '���������� ����� �������',
	   sys.sysindexes.used * 8 as '������������ ������',
	   sys.sysindexes.reserved * 8 as '����� ������', 
	   (sys.sysindexes.reserved - sys.sysindexes.used) * 8 as '�������������� ������'
    
	from (sys.indexes inner join sys.tables on sys.indexes.object_id = sys.tables.object_id)
	                   left join sys.sysindexes on sys.indexes.name = sys.sysindexes.name
