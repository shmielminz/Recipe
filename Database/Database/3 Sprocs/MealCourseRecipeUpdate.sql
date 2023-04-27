create or alter proc dbo.MealCourseRecipeUpdate(
	@MealCourseRecipeId int output,
	@MainDish bit,
	@MealCourseId int,
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseRecipeId = ISNULL(@MealCourseRecipeId,0)

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