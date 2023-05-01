create or alter procedure dbo.RecipeDelete(
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	if exists(select * from Recipe r where r.RecipeId = @RecipeId and (datediff(day, r.DateArchived, getdate()) <= 30 or r.RecipeStatus = 'Published'))
	begin
		select @return = 1, @Message = 'Can only delete recipes that are drafted, or archived for more than 30 days'
		goto finished
	end
	begin try
		begin tran
		delete RecipeIngredient where RecipeId = @RecipeId
		delete RecipeStep where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go