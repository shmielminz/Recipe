create or alter proc dbo.MealCourseRecipeGet(
	@MealCourseRecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseRecipeId = isnull(@MealCourseRecipeId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select mcr.MealCourseRecipeId, mcr.MealCourseId, mcr.RecipeId, mcr.MainDish
	from MealCourseRecipe mcr
	where mcr.MealCourseRecipeId = @MealCourseRecipeId
	or @All = 1
	union select 0,0,0,0
	where @IncludeBlank = 1
	order by mcr.MealCourseRecipeId

	return @return
end
go