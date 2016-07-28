select sys.tables.name as '��� �������',
	   sys.indexes.name as '��� �������',
	   user_seeks as '���������������� �������',
	   user_scans as '��������������� ������������',
	   user_updates as '���������������� ����������',
	   system_seeks as '��������� �������',
	   system_scans as '��������� ������������',
	   system_updates as '��������� ����������'
	
	from (sys.tables inner join sys.indexes on sys.tables.object_id = sys.indexes.object_id) 
						left join sys.dm_db_index_usage_stats on sys.indexes.object_id = sys.dm_db_index_usage_stats.object_id 