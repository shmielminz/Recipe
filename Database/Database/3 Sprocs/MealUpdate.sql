create or alter proc dbo.MealUpdate(
	@MealId int = 0 output,
	@StaffId int = 0,
	@MealName varchar(100) = '',
	@Active bit = 0,
	@DateCreated date = null output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = ISNULL(@MealId,0), @DateCreated = isnull(@DateCreated,GETDATE()), @StaffId = ISNULL(@StaffId,0), @MealName = isnull(@MealName,''), @Active = isnull(@Active,0)

	if @MealId = 0
	begin
		insert Meal(StaffId, MealName, Active, DateCreated)
		values(@StaffId, @MealName, @Active, @DateCreated)

		select @MealId = SCOPE_IDENTITY()
	end
	else
	begin
		update Meal
		set
			StaffId = @StaffId, 
			MealName = @MealName, 
			Active = @Active, 
			DateCreated = @DateCreated
		where MealId = @MealId
	end

	return @return
end
go