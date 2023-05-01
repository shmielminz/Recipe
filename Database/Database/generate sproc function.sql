create or alter function dbo.GetSprocName(@TableName varchar(100), @SprocType varchar(10))
returns @t table (Id int not null identity primary key, Sproc varchar(1000)) 
as
begin
	declare @i int = 0, @value varchar(1000) = '', @colname varchar(50) = ''
	insert @t(Sproc)
	values('create or alter proc dbo.'+@TableName+@SprocType+'(')
	select @TableName = isnull(@TableName,''), @SprocType = isnull(@SprocType,'')
	if @SprocType = 'Update'
	begin
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1))
		begin
			select @i += 1
			select @value = concat('@',c.COLUMN_NAME,' ',c.DATA_TYPE,case when c.CHARACTER_MAXIMUM_LENGTH is not null then concat('(',c.CHARACTER_MAXIMUM_LENGTH,')') end, case c.COLUMN_NAME when @TableName + 'Id' then ' output' end,',') 
			from INFORMATION_SCHEMA.COLUMNS c 
			where c.TABLE_NAME = @TableName 
			and c.ORDINAL_POSITION = @i
		
			insert @t(Sproc)
			select  @value
		end
	end
	else if @SprocType in('Delete','Get')
	begin
		select @value = concat('@',c.COLUMN_NAME,' ',c.DATA_TYPE,case when c.CHARACTER_MAXIMUM_LENGTH is not null then concat('(',c.CHARACTER_MAXIMUM_LENGTH,')') end,',') 
		from INFORMATION_SCHEMA.COLUMNS c 
		where c.TABLE_NAME = @TableName 
		and c.COLUMN_NAME = @TableName + 'Id'

		insert @t(Sproc)
		select  @value
	end
	insert @t(Sproc)
	values ('@Message varchar(500) = '''' output'),
	(')'),
	('as'),
	('begin'),
	('declare @return int = 0'),
	('select ')

	select @i = 0
	if @SprocType = 'Update'
	begin
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.IS_NULLABLE = 'no' and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1))
		begin
			select @i += 1
			select @value = concat('@',c.COLUMN_NAME,' = isnull(@',c.COLUMN_NAME,',',case when c.DATA_TYPE = 'bit' then '0' when c.DATA_TYPE='int' then '0' when c.DATA_TYPE='varchar' then '''''' when c.DATA_TYPE like 'date%' then 'getdate()' end,'),')
			from INFORMATION_SCHEMA.COLUMNS c 
			where c.TABLE_NAME = @TableName 
			and c.ORDINAL_POSITION = @i
			and c.IS_NULLABLE = 'no'
		
			insert @t(Sproc)
			select  @value
		end
	end
	else if @SprocType in('Delete','Get')
	begin
		select @value = concat('@',c.COLUMN_NAME,' = isnull(@',c.COLUMN_NAME,',',case when c.DATA_TYPE = 'bit' then '0' when c.DATA_TYPE='int' then '0' when c.DATA_TYPE='varchar' then '''''' when c.DATA_TYPE like 'date%' then 'getdate()' end,')')
		from INFORMATION_SCHEMA.COLUMNS c 
		where c.TABLE_NAME = @TableName 
		and c.COLUMN_NAME = @TableName + 'Id'
		
		insert @t(Sproc)
		select  @value
	end
	select @i = 0

	if @SprocType = 'Get'
	begin
		insert @t(Sproc)
		values('select')
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.IS_NULLABLE = 'no' and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1))
		begin
			select @i += 1
			select @value = c.COLUMN_NAME + ','
			from INFORMATION_SCHEMA.COLUMNS c
			where c.TABLE_NAME = @TableName
			and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)
			and c.ORDINAL_POSITION = @i

			insert @t(Sproc)
			select @value
		end
		select @value = CONCAT('from ', @TableName,' where ',@TableName,'Id = @',@TableName,'Id')
		insert @t(Sproc)
		select @value
	end
	else if @SprocType = 'Update'
	begin
		insert @t(Sproc)
		values ('if @' + @TableName + 'Id = 0'),('begin'),('insert ' + @TableName + ' (')
		select @i = 0
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)) - 1
		begin
			select @i += 1
			select @value = concat(c.COLUMN_NAME,',')
			from INFORMATION_SCHEMA.COLUMNS c
			where c.TABLE_NAME = @TableName 
			and c.ORDINAL_POSITION = @i + 1
			and c.COLUMN_NAME <> @TableName + 'Id'

			insert @t(Sproc)
			select @value
		end
		insert @t(Sproc)
		values(') values(')
		select @i = 0
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)) - 1
		begin
			select @i += 1
			select @value = concat('@',c.COLUMN_NAME,',')
			from INFORMATION_SCHEMA.COLUMNS c 
			where c.TABLE_NAME = @TableName 
			and c.ORDINAL_POSITION = @i + 1
			and c.COLUMN_NAME <> @TableName + 'Id'
		
			insert @t(Sproc)
			select  @value
		end
		insert @t(Sproc)
		values(')'), ('select @'+@TableName + 'Id = scope_identity()')

		insert @t(Sproc)
		values('end'),('else'),('begin'),('update ' + @TableName +' set')
		select @i = 0
		while @i < (select COUNT(*) from INFORMATION_SCHEMA.COLUMNS c where c.TABLE_NAME = @TableName and c.COLUMN_NAME not in(select co.name from sys.objects o join sys.columns co on o.object_id = co.object_id where co.is_computed = 1)) - 1
		begin
			select @i += 1
			select @value = concat(c.COLUMN_NAME,' = @',c.COLUMN_NAME,',')
			from INFORMATION_SCHEMA.COLUMNS c
			where c.TABLE_NAME = @TableName 
			and c.ORDINAL_POSITION = @i + 1
			and c.COLUMN_NAME <> @TableName + 'Id'

			insert @t(Sproc)
			select @value
		end

		insert @t(Sproc)
		values ('from ' + @TableName + ' where ' + @TableName + 'Id = @' + @TableName + 'Id'),('end')
	end
	else if @SprocType = 'Delete'
	begin
		if (select count(*) from INFORMATION_SCHEMA.COLUMNS m join INFORMATION_SCHEMA.COLUMNS c on c.COLUMN_NAME = m.COLUMN_NAME where m.TABLE_NAME = @TableName and m.COLUMN_NAME = @TableName + 'Id') > 1
		begin
			insert @t(Sproc)
			values ('begin try'), ('begin tran')

			select @i = 0
			while @i < (select count(*) from INFORMATION_SCHEMA.COLUMNS m join INFORMATION_SCHEMA.COLUMNS c on c.COLUMN_NAME = m.COLUMN_NAME where m.TABLE_NAME = @TableName and m.COLUMN_NAME = @TableName + 'Id')
			begin
				select @i += 1
				declare @child_table varchar(20) = @tablename
				while @child_table in (select Obj = fk.TABLE_NAME from INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS c join INFORMATION_SCHEMA.TABLE_CONSTRAINTS fk on c.CONSTRAINT_NAME = fk.CONSTRAINT_NAME join INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk on c.UNIQUE_CONSTRAINT_NAME = pk.CONSTRAINT_NAME)
				begin
					select @child_table = pk.TABLE_NAME 
					from INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS c 
					join INFORMATION_SCHEMA.TABLE_CONSTRAINTS fk 
					on c.CONSTRAINT_NAME = fk.CONSTRAINT_NAME 
					join INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk 
					on c.UNIQUE_CONSTRAINT_NAME = pk.CONSTRAINT_NAME
				end
				insert @t
				select concat('delete ', @child_table)
			end

			insert @t(Sproc)
			values ('commit'), ('end try'), ('begin catch'), ('rollback;'), ('throw'), ('end catch')
		end
	end

	insert @t(Sproc)
	values('return @return'),
	('end'),
	('go')
	return
end
go
select * from dbo.GetSprocName('Recipe','Get')