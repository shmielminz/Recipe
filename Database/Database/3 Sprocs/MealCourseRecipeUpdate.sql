create or alter proc dbo.MealCourseRecipeUpdate(
	@MealCourseRecipeId int = 0 output,
	@MainDish bit = null,
	@MealCourseId int = 0,
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseRecipeId = ISNULL(@MealCourseRecipeId,0), @MealCourseId = ISNULL(@MealCourseId,0), @RecipeId = ISNULL(@RecipeId,0)

	if @MealCourseRecipeId = 0
	begin
		insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
		values(@MealCourseId, @RecipeId, @MainDish)

		select @MealCourseRecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update MealCourseRecipe
		set
			MealCourseId = @MealCourseId, 
			RecipeId = @RecipeId, 
			MainDish = @MainDish
		where MealCourseRecipeId = @MealCourseRecipeId
	end

	return @return
end
go