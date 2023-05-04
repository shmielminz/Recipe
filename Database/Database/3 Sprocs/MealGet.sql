create or alter proc dbo.MealGet(
	@StaffId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0), @StaffId = ISNULL(@StaffId,0)

	select m.MealId, s.StaffId, m.MealName, s.Username, NumCalories = dbo.MealCalories(m.MealId), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(distinct mcr.MealCourseRecipeId)
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	join MealCourse mc
	on mc.MealId = m.MealId
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	where s.StaffId = @StaffId
	or @All = 1
	group by m.MealId, s.StaffId, m.MealName, s.Username, dbo.MealCalories(m.MealId)
	union select 0,0,' ',' ',0,0,0
	where @IncludeBlank = 1
	order by m.MealId

	return @return
end
go