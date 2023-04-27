create or alter proc dbo.IngredientUpdate(
	@IngredientId int output,
	@Ingredient varchar(25),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = ISNULL(@IngredientId,0)

	if @IngredientId = 0
	begin
		insert Ingredient(Ingredient)
		values(@Ingredient)

		select @IngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient
		set
			Ingredient = @Ingredient 
		where Ingredient = @IngredientId
	end

	return @return
end
go