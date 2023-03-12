exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = null

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'g'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId