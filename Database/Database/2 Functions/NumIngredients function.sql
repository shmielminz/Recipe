create or alter function dbo.NumIngredients(@RecipeId int)
returns int
as
begin
	declare @value int = 0

	select @value = count(*)
	from RecipeIngredient ri
	where ri.RecipeId = @RecipeId
	group by ri.RecipeId

	return @value
end
go