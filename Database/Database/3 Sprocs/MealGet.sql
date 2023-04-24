create or alter proc dbo.MealGet(
	@StaffId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)

	select m.MealId, s.StaffId, m.MealName, m.DateCreated, m.Active, s.Username
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	where s.StaffId = @StaffId
	or @All = 1

	return @return
end
go
exec MealGet @All = 1