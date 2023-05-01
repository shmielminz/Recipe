create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select DashboardType = 'Recipes', DashboardText = count(*)
	from Recipe
	union select 'Meals', count(*)
	from Meal
	union select 'Cookbooks', count(*)
	from Cookbook

	return @return
end
go