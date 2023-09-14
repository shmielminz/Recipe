create or alter proc dbo.RecipeGet(
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@RecipeName varchar(50) = '',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0), @RecipeName = isnull(@RecipeName,'')
	
	select r.RecipeId, r.CuisineId, r.StaffId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, RecipeDesc = dbo.RecipeDesc(r.RecipeId)
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	union select 0,0,0,' ',0,null,null,null,' ', ' '
	where @IncludeBlank = 1
	order by r.RecipeId

	return @return
end
go