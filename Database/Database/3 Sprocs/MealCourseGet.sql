create or alter proc dbo.MealCourseGet(
	@MealCourseId int,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealCourseId = isnull(@MealCourseId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select mc.MealCourseId, mc.MealId, mc.CourseId
	from MealCourse mc
	where mc.MealCourseId = @MealCourseId
	or @All = 1
	union select 0,0,0
	where @IncludeBlank = 1
	order by mc.MealCourseId

	return @return
end
go