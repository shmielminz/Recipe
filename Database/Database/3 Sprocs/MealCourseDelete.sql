create or alter proc dbo.MealCourseDelete(
	@MealCourseId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseId = isnull(@MealCourseId,0)

	begin try
		begin tran
		delete MealCourseRecipe where MealCourseId = @MealCourseId
		delete MealCourse where MealCourseId = @MealCourseId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go