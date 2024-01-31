create or alter proc dbo.CookbookUpdate(
	@CookbookId int = 0 output,
	@StaffId int = 0,
	@CookbookName varchar(100) = '',
	@Price decimal(5,2) = 0,
	@Active bit = 0,
	@CookbookSkill int = 0,
	@DateCreated date = null output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @CookbookId = isnull(@CookbookId,0), @CookbookSkill = isnull(@CookbookSkill,0), @StaffId = isnull(@StaffId,0), @CookbookName = isnull(@CookbookName,''), @Price = isnull(@Price,0), @Active = isnull(@Active,0), @DateCreated = isnull(@DateCreated,getdate())

	if @CookbookId = 0
	begin
		insert Cookbook(StaffId,CookbookName,Price,Active,CookbookSkill,DateCreated)
		values(@StaffId,@CookbookName,@Price,@Active,@CookbookSkill,@DateCreated)

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
			CookbookSkill = @CookbookSkill,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end

	return @return
end
go