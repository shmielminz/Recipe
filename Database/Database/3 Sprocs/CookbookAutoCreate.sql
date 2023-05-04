create or alter proc dbo.CookbookAutoCreate(
	@StaffId int = 0,
	@CookbookId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)

	;with x as(
		select s.Username, CookbookName = concat('Recipes by ',s.FirstName,' ',s.LastName), Price = count(*) * 1.33, Active = 1
		from Staff s
		join Recipe r
		on r.StaffId = s.StaffId
		where s.StaffId = @StaffId
		group by s.LastName, s.FirstName, s.Username
	)
	insert Cookbook(StaffId,CookbookName,Price,Active)
	select s.StaffId, x.CookbookName, x.Price, x.Active
	from x
	join Staff s
	on s.Username = x.Username
	
	select @CookbookId = SCOPE_IDENTITY()

	;with x as(
		select CookbookName = concat('Recipes by ',s.FirstName,' ',s.LastName), r.RecipeName, SequenceVal = row_number() over (order by r.RecipeName)
		from Staff s
		join Recipe r
		on r.StaffId = s.StaffId
		where s.StaffId = @StaffId
	)
	insert CookbookRecipe(RecipeId,CookbookId,SequenceVal)
	select r.RecipeId, c.CookbookId, x.SequenceVal
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName
	join Cookbook c
	on c.CookbookName = x.CookbookName


	return @return
end
go