create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0 output,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@SequenceVal int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookId = isnull(@CookbookId,0), @CookbookRecipeId = isnull(@CookbookRecipeId,0), @RecipeId = isnull(@RecipeId,0), @SequenceVal = isnull(@SequenceVal,0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
		values(@CookbookId,@RecipeId,@SequenceVal)

		select @CookbookRecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookbookRecipe
		set
			CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			SequenceVal = @SequenceVal
		where CookbookRecipeId = @CookbookRecipeId
	end

	return @return
end
go