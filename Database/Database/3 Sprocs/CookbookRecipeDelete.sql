create or alter proc dbo.CookbookRecipeDelete(
	@CookbookId int = 0,
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = ISNULL(@CookbookId,0), @RecipeId = ISNULL(@RecipeId,0)

	delete CookbookRecipe where CookbookId = @CookbookId or RecipeId = @RecipeId

	return @return
end
go