create or alter proc dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)

	begin try
		begin tran
		delete mcr from MealCourseRecipe mcr join Recipe r on mcr.RecipeId = r.RecipeId where r.CuisineId = @CuisineId
		delete cr from CookbookRecipe cr join Recipe r on cr.RecipeId = r.RecipeId where r.CuisineId = @CuisineId
		delete Recipe where CuisineId = @CuisineId
		delete Cuisine where CuisineId = @CuisineId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go