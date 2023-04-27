create or alter proc dbo.StaffUpdate(
	@StaffId int output,
	@FirstName varchar(25),
	@LastName varchar(25),
	@Username varchar(50),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @StaffId = ISNULL(@StaffId,0)

	if @StaffId = 0
	begin
		insert Staff(FirstName, LastName, Username)
		values(@FirstName, @LastName, @Username)

		select @StaffId = SCOPE_IDENTITY()
	end
	else
	begin
		update Staff
		set
			FirstName = @FirstName, 
			LastName = @LastName, 
			Username = @Username
		where StaffId = @StaffId
	end

	return @return
end
go
