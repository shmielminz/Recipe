declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
left join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
left join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where cr.CookbookRecipeId is null
and mcr.MealCourseRecipeId is null
order by r.RecipeId

select * from Recipe r where r.RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select * from Recipe r where r.RecipeId = @RecipeId