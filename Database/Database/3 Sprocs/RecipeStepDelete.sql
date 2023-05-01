create or alter proc dbo.RecipeStepDelete(
	@RecipeStepId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeStepId = isnull(@RecipeStepId,0)

	delete RecipeStep where RecipeStepId = @RecipeStepId

	return @return
end
go
