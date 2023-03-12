set nocount on
declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
order by r.RecipeId

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'Meal',mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'Meal',mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId
