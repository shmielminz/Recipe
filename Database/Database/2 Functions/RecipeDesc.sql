create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(150)
as
begin
	declare @value varchar(150) = ''

	select @value = concat(r.RecipeName, ' (', c.CuisineType, ') has ', count(distinct ri.RecipeIngredientId), ' ingredients, and ', count(distinct rs.RecipeStepId), ' steps.')
	from Cuisine c
	join Recipe r
	on r.CuisineId = c.CuisineId
	join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	join RecipeStep rs
	on rs.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, c.CuisineType

	return @value
end
go

select r.RecipeName, RecipeDesc = dbo.RecipeDesc(r.RecipeId)
from Recipe r