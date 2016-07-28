select sys.tables.name as 'Имя таблицы',
       sys.indexes.name as 'Имя индекса',
	   sys.sysindexes.rowcnt as 'Количество строк индекса',
	   sys.sysindexes.used * 8 as 'Используемый размер',
	   sys.sysindexes.reserved * 8 as 'Общий размер', 
	   (sys.sysindexes.reserved - sys.sysindexes.used) * 8 as 'Неиспользуемый размер'
    
	from (sys.indexes inner join sys.tables on sys.indexes.object_id = sys.tables.object_id)
	                   left join sys.sysindexes on sys.indexes.name = sys.sysindexes.name
