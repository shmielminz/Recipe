create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select DashboardType = 'Recipes', DashboardText = count(*)
	from Recipe
	union select 'Meal', count(*)
	from Meal
	union select 'Cookbook', count(*)
	from Cookbook

	return @return
end
go