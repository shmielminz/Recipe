create or alter proc RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, MeasurementId = isnull(ri.MeasurementId,0), ri.MeasurementQty, ri.SequenceVal, i.Ingredient, m.MeasurementType, IngredientDesc = concat(ri.SequenceVal, '. ', ri.MeasurementQty, ' ', case when ri.MeasurementId is not null then ' ' end, m.MeasurementType, ' ', i.Ingredient)
	from RecipeIngredient ri
	join Ingredient i
	on i.IngredientId = ri.IngredientId
	left join Measurement m
	on m.MeasurementId = ri.MeasurementId
	where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.RecipeId = @RecipeId
	union select 0, 0, 0, 0, 0, 0, ' ', ' ', ' '
	where @IncludeBlank = 1
	order by ri.SequenceVal

	return @return
end
go