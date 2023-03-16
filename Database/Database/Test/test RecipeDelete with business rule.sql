set nocount on
declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where mcr.MealCourseRecipeId is null
and cr.CookbookRecipeId is null
and (
	r.RecipeStatus = 'Published'
	or (
		r.RecipeStatus = 'Archived'
		and datediff(day,r.DateArchived,getdate()) <= 30
	)
)
order by r.RecipeId

select 'Recipe', r.RecipeId, concat(r.RecipeName, ' ', r.RecipeStatus) from Recipe r where r.RecipeId = @RecipeId

declare @return int, @message varchar(500)
exec @return = RecipeDelete @RecipeId = @RecipeId, @Message = @message output

select @return, @message

select 'Recipe', r.RecipeId, concat(r.RecipeName, ' ', r.RecipeStatus) from Recipe r where r.RecipeId = @RecipeId
