create or alter proc dbo.IngredientGet(
	@IngredientId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select i.IngredientId, i.Ingredient
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	union select 0,' '
	where @IncludeBlank = 1
	order by i.Ingredient

	return @return
end
go