declare @message varchar(500) = '', @return int, @RecipeId int,
	@StaffId int,
	@CuisineId int

select top 1 @StaffId = s.StaffId
from Staff s

select top 1 @CuisineId = c.CuisineId
from Cuisine c

exec @return = RecipeUpdate
	@RecipeId = @RecipeId output,
	@StaffId = @StaffId, 
	@CuisineId = @CuisineId, 
	@RecipeName = 'New recipe for you', 
	@Calories = 100, 
	@DateDrafted = '20211231'

select @return, @message, @RecipeId

select * from Recipe where RecipeId = @RecipeId

delete Recipe where RecipeId = @RecipeId