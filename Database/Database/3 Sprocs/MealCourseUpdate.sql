create or alter proc dbo.MealCourseUpdate(
	@MealCourseId int = 0 output,
	@CourseId int = 0,
	@MealId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseId = ISNULL(@MealCourseId,0), @CourseId = ISNULL(@CourseId,0), @MealId = ISNULL(@MealId,0)

	if @MealCourseId = 0
	begin
		insert MealCourse(MealId, CourseId)
		values(@MealId, @CourseId)

		select @MealCourseId = SCOPE_IDENTITY()
	end
	else
	begin
		update MealCourse
		set
			MealId = @MealId, 
			CourseId = @CourseId
		where MealCourseId = @MealCourseId
	end

	return @return
end
go