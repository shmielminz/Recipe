declare @tablename varchar(50) = 'president'

select 
	concat('@', 
		c.COLUMN_NAME, 
		' ', 
		c.DATA_TYPE, 
		case when c.CHARACTER_MAXIMUM_LENGTH is null then '' else concat('(',c.CHARACTER_MAXIMUM_LENGTH,')') end,
		case when c.TABLE_NAME + 'Id' = c.COLUMN_NAME then ' output' end,
		','
	)
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)

declare @insertlist varchar(5000) = ''

select @insertlist = @insertlist + concat(c.COLUMN_NAME, ', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'
and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)

select @insertlist

select @insertlist = ''

select @insertlist = @insertlist + concat('@', c.COLUMN_NAME, ', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'
and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)

select @insertlist

select concat(c.COLUMN_NAME, ' = @', c.COLUMN_NAME, ', ')
from INFORMATION_SCHEMA.COLUMNS c
where c.TABLE_NAME = @tablename
and c.COLUMN_NAME <> c.TABLE_NAME + 'Id'
and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)