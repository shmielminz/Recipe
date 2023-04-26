create or alter proc dbo.RecipeDetailsGet(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	
	select r.RecipeId, r.CuisineId, r.StaffId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus
	from Recipe r
	where r.RecipeId = @RecipeId

	return @return
end
go