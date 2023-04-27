create or alter proc dbo.MealCourseRecipeDelete(
	@MealCourseRecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	delete MealCourseRecipe where MealCourseRecipeId = @MealCourseRecipeId

	return @return
end
go
