declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join RecipeStep rs
on rs.RecipeId = r.RecipeId
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where mcr.MealCourseRecipeId is null
and cr.CookbookRecipeId is null
order by r.RecipeId

select * from Recipe where RecipeId = @RecipeId

exec RecipeDelete @RecipeId = @RecipeId

select * from Recipe where RecipeId = @RecipeId