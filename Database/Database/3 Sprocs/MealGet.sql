create or alter proc dbo.MealGet(
	@StaffId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select m.MealId, s.StaffId, m.MealName, m.DateCreated, m.Active, s.Username
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	where s.StaffId = @StaffId
	or @All = 1
	union select 0,0,'',null,null,''
	where @IncludeBlank = 1
	order by m.MealId

	return @return
end
go