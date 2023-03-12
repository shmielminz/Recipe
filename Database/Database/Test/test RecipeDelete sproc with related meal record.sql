declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
order by r.RecipeId

select * from Recipe r where r.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select * from Recipe r where r.RecipeId = @RecipeId