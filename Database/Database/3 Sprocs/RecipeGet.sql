create or alter procedure dbo.RecipeGet(
	@All bit = 0,
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId,0), @RecipeName = isnull(@RecipeName,'')

	select 
		r.RecipeId, 
		r.RecipeName,
		r.RecipeStatus,  
		s.Username,
		r.Calories, 
		NumIngredient = count(ri.RecipeIngredientId)
	from Recipe r
	join Staff s
	on s.StaffId = r.StaffId
	join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	group by r.RecipeId, r.RecipeName, r.RecipeStatus, s.Username, r.Calories
	order by r.RecipeStatus desc, r.RecipeName

	return @return
end
go
/*
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = null

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'g'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId
*/