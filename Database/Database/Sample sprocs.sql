create or alter proc dbo.Delete(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	begin try
		begin tran
		delete
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go

create or alter proc dbo.Update(
	@Id int output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @Id = ISNULL(@Id,0)

	if @Id = 0
	begin
		insert ()
		values()

		select @Id = SCOPE_IDENTITY()
	end
	else
	begin
		update 
		set
			
		where  = @Id
	end

	return @return
end
go

create or alter proc dbo.Get(
	@Id int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @Id = isnull(@Id,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select *
	from 
	where  = @Id
	or @All = 1
	union select 
	where @IncludeBlank = 1
	order by 

	return @return
end
go