create or alter proc dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CourseId = ISNULL(@CourseId,0)

	begin try
		begin tran
		delete mcr from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId where mc.CourseId = @CourseId
		delete MealCourse where CourseId = @CourseId
		delete Course where CourseId = @CourseId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go