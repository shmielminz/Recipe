create or alter procedure dbo.StaffGet(
	@All bit = 0, 
	@StaffId int = 0, 
	@Username varchar(50) = ''
)
as
begin
	select s.StaffId, s.FirstName, s.LastName, s.Username
	from Staff s
	where s.StaffId = @StaffId
	or (@Username <> '' and s.Username like '%' + @Username + '%')
	or @All = 1
end
go
/*
exec StaffGet

exec StaffGet @Username = ''

exec StaffGet @Username = null

exec StaffGet @Username = 's'

exec StaffGet @All = 1

declare @Id int
select top 1 @Id = s.StaffId from Staff s
exec StaffGet @StaffId = @Id
*/