create or alter function dbo.MealCalories(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.Calories)
	from Recipe r
	join MealCourseRecipe mcr
	on mcr.RecipeId = r.RecipeId
	join MealCourse mc
	on mc.MealCourseId = mcr.MealCourseId
	where mc.MealId = @MealId

	return @value
end
go

select m.MealName, TotalCalories = dbo.MealCalories(m.MealId)
from Meal m