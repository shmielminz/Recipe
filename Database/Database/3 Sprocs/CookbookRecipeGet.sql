create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

	select c.CookbookRecipeId, c.CookbookId, c.RecipeId, c.SequenceVal
	from CookbookRecipe c
	where c.CookbookRecipeId = @CookbookRecipeId

	return @return
end
go