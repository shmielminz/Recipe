create or alter proc dbo.MealUpdate(
	@MealId int = 0 output,
	@StaffId int = 0,
	@MealName varchar(100) = '',
	@Active bit = 0,
	@MealDesc varchar(500) = '',
	@DateCreated date = null output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = ISNULL(@MealId,0), @MealDesc = isnull(@MealDesc,''), @DateCreated = isnull(@DateCreated,GETDATE()), @StaffId = ISNULL(@StaffId,0), @MealName = isnull(@MealName,''), @Active = isnull(@Active,0)

	if @MealId = 0
	begin
		insert Meal(StaffId, MealName, Active, MealDesc, DateCreated)
		values(@StaffId, @MealName, @Active, @MealDesc, @DateCreated)

		select @MealId = SCOPE_IDENTITY()
	end
	else
	begin
		update Meal
		set
			StaffId = @StaffId, 
			MealName = @MealName, 
			Active = @Active, 
			MealDesc = @MealDesc,
			DateCreated = @DateCreated
		where MealId = @MealId
	end

	return @return
end
go