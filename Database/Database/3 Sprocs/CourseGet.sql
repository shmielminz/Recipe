create or alter proc dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select c.CourseId, c.CourseName, c.SequenceVal
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	union select 0, ' ',0
	where @IncludeBlank = 1
	order by c.CourseName

	return @return
end
go