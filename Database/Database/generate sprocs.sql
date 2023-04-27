select code = 1, c.TABLE_NAME, pro = concat(
	'create or alter proc ',
	t.TABLE_SCHEMA,
	'.',
	t.TABLE_NAME,
	'Get(')
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 2, c.TABLE_NAME,concat('@',
	c.COLUMN_NAME,
	' ',
	c.DATA_TYPE,
	case when c.CHARACTER_MAXIMUM_LENGTH is not null then concat('(',c.CHARACTER_MAXIMUM_LENGTH,')') end,
	case c.COLUMN_NAME when c.TABLE_NAME + 'Id' then ' output' end,
	',')
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
where c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)
union select 3,c.TABLE_NAME,')'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 4,c.TABLE_NAME,'as'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 5,c.TABLE_NAME,'begin'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 6,c.TABLE_NAME,'declare @return int = 0'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 7,c.TABLE_NAME,'return @return'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 8,c.TABLE_NAME,'end'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
union select 9,c.TABLE_NAME,'go'
from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c
on c.TABLE_NAME = t.TABLE_NAME
order by c.TABLE_NAME,code