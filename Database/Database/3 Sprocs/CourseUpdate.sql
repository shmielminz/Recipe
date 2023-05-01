create or alter proc dbo.CourseUpdate(
	@CourseId int = 0 output,
	@CourseName varchar(20) = '',
	@SequenceVal int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CourseId = ISNULL(@CourseId,0), @CourseName = ISNULL(@CourseName,''), @SequenceVal = ISNULL(@SequenceVal,0)

	if @CourseId = 0
	begin
		insert Course(CourseName,SequenceVal)
		values(@CourseName,@SequenceVal)

		select @CourseId = SCOPE_IDENTITY()
	end
	else
	begin
		update Course
		set
			CourseName = @CourseName,
			SequenceVal = @SequenceVal
		where CourseId = @CourseId
	end

	return @return
end
go