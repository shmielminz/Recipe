create or alter procedure dbo.StaffGet(
	@All bit = 0, 
	@StaffId int = 0, 
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select s.StaffId, s.FirstName, s.LastName, s.Username
	from Staff s
	where s.StaffId = @StaffId
	or @All = 1
	union select 0,'','',''
	where @IncludeBlank = 1
	order by s.StaffId

	return @return
end
go
/*
exec StaffGet

exec StaffGet @All = 1, @IncludeBlank = 1

declare @Id int
select top 1 @Id = s.StaffId from Staff s
exec StaffGet @StaffId = @Id
*/