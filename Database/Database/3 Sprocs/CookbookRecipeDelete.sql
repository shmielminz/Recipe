create or alter proc dbo.CookbookRecipeDelete(
	@CookbookId int,
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	delete CookbookRecipe where CookbookId = @CookbookId or RecipeId = @RecipeId

	return @return
end
go