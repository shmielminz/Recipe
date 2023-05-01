create or alter proc dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0)

	begin try
		begin tran
		delete CookbookRecipe where CookbookId = @CookbookId
		delete Cookbook where CookbookId = @CookbookId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go