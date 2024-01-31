create or alter procedure dbo.RecipeUpdate(
	@RecipeId int = 0 output,
	@StaffId int = 0,
	@CuisineId int = 0,
	@RecipeName varchar(100) = '',
	@Calories int = 0,
	@IsVegan bit = 0,
	@DateDrafted datetime = null output,
	@DatePublished datetime = null output,
	@DateArchived datetime = null output,
	@RecipeStatus varchar(20) = '' output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select 
		@RecipeId = isnull(@RecipeId,0), 
		@StaffId = isnull(@StaffId,0),
		@CuisineId = isnull(@CuisineId,0),
		@RecipeName = isnull(@RecipeName,''),
		@Calories = isnull(@Calories,0),
		@DatePublished = nullif(@DatePublished,''), 
		@DateArchived = nullif(@DateArchived,''), 
		@DateDrafted = isnull(@DateDrafted,getdate()),
		@IsVegan = isnull(@IsVegan,0)

	if @RecipeId = 0
	begin
		insert Recipe(StaffId, CuisineId, RecipeName, Calories, IsVegan, DateDrafted, DatePublished, DateArchived)
		values(@StaffId, @CuisineId, @RecipeName, @Calories, @IsVegan, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
			StaffId = @StaffId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			IsVegan = @IsVegan,
			DateDrafted = @DateDrafted, 
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end

	select @RecipeStatus = r.RecipeStatus from Recipe r where r.RecipeId = @RecipeId

	return @return
end
go
