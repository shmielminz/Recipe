create or alter proc dbo.MealDelete(
	@MealId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = ISNULL(@MealId,0)

	begin try
		begin tran
		delete mcr from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId where mc.MealId = @MealId
		delete MealCourse where MealId = @MealId
		delete Meal where MealId = @MealId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go
