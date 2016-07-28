select sys.tables.name as 'Имя таблицы',
	   sys.indexes.name as 'Имя индекса',
	   user_seeks as 'Пользовательских поисков',
	   user_scans as 'Пользовательких сканирований',
	   user_updates as 'Пользовательских обновлений',
	   system_seeks as 'Системных поисков',
	   system_scans as 'Системных сканирований',
	   system_updates as 'Системных обновлений'
	
	from (sys.tables inner join sys.indexes on sys.tables.object_id = sys.indexes.object_id) 
						left join sys.dm_db_index_usage_stats on sys.indexes.object_id = sys.dm_db_index_usage_stats.object_id 