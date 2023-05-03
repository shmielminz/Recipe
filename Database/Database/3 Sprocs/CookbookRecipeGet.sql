create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select c.CookbookRecipeId, c.CookbookId, c.RecipeId, c.SequenceVal
	from CookbookRecipe c
	where c.CookbookRecipeId = @CookbookRecipeId
	or c.CookbookId = @CookbookId
	or @All = 1
	union select 0,0,0,0
	where @IncludeBlank = 1
	order by c.CookbookRecipeId

	return @return
end
go