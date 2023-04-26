create or alter proc RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.MeasurementId, ri.MeasurementQty, ri.SequenceVal
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.RecipeId = @RecipeId

	return @return
end
go