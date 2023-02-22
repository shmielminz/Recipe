create or alter procedure dbo.RecipeGet(
	@All bit = 0,
	@RecipeId int = 0,
	@RecipeName varchar(100) = ''
)
as
begin
	select r.RecipeId, r.StaffId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus
	from Recipe r
	where r.RecipeId = @RecipeId
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	or @All = 1
	order by r.RecipeStatus, r.RecipeName
end
go
/*
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = null

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'g'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId
*/