declare @Message varchar(500) = '', @return int, @RecipeId int,
	@StaffId int,
	@CuisineId int,
	@RecipeName varchar(100),
	@Calories int,
	@DateDrafted datetime, 
	@DatePublished datetime,
	@DateArchived datetime

select top 1
	@RecipeId = r.RecipeId,
	@StaffId = StaffId, 
	@CuisineId = CuisineId, 
	@RecipeName = RecipeName, 
	@Calories = Calories, 
	@DateDrafted = DateDrafted,
	@DatePublished = DatePublished, 
	@DateArchived = DateArchived
from Recipe r
order by r.RecipeId

select @RecipeName = reverse(@RecipeName)

exec @return = RecipeUpdate
	@RecipeId = @RecipeId output,
	@StaffId = @StaffId, 
	@CuisineId = @CuisineId, 
	@RecipeName = @RecipeName, 
	@Calories = @Calories, 
	@DateDrafted = @DateDrafted,
	@DatePublished = @DatePublished, 
	@DateArchived = @DateArchived

select @return, @Message, @RecipeId

select * from Recipe where RecipeId = @RecipeId