create or alter proc dbo.CookbookGet(
	@StaffId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select c.CookbookId, s.StaffId, s.Username, c.CookbookName, c.DateCreated, c.Price, c.Active
	from Cookbook c
	join Staff s
	on s.StaffId = c.StaffId
	where s.StaffId = @StaffId
	or @All = 1

	return @return
end
go
exec CookbookGet @All = 1