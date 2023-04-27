create or alter proc dbo.CookbookUpdate(
	@CookbookId int output,
	@StaffId int,
	@CookbookName varchar(100),
	@Price decimal(5,2),
	@Active bit,
	@DateCreated date = null output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookId = isnull(@CookbookId,0), @DateCreated = isnull(@DateCreated,getdate())

	if @CookbookId = 0
	begin
		insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
		values(@StaffId,@CookbookName,@Price,@Active,@DateCreated)

		select @CookbookId = SCOPE_IDENTITY()
	end
	else
	begin
		update Cookbook
		set
			StaffId = @StaffId,
			CookbookName = @CookbookName,
			Price = @Price,
			Active = @Active,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end

	return @return
end
go