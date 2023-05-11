create or alter proc dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0)

	begin try
		begin tran
		delete RecipeIngredient where IngredientId = @IngredientId
		delete Ingredient where IngredientId = @IngredientId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go