create or alter proc dbo.CloneRecipe(
	@RecipeId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0, @NewId int = 0
	
	select @RecipeId = isnull(@RecipeId,0)


	insert Recipe(StaffId,CuisineId,RecipeName,Calories)
	select r.StaffId, r.CuisineId, RecipeName = concat(r.RecipeName,' - clone'), r.Calories
	from Recipe r
	where r.RecipeId = @RecipeId

	select @NewId = SCOPE_IDENTITY()

	;with x as(
		select RecipeName = concat(r.RecipeName,' - clone'), ri.MeasurementQty, ri.IngredientId, ri.MeasurementId, ri.SequenceVal
		from Recipe r
		join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		where r.RecipeId = @RecipeId
	)
	insert RecipeIngredient(RecipeId,MeasurementQty,IngredientId,MeasurementId,SequenceVal)
	select r.RecipeId, x.MeasurementQty, x.IngredientId, x.MeasurementId, x.SequenceVal
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName

	;with x as(
		select RecipeName = concat(r.RecipeName,' - clone'), rs.SequenceVal, rs.Instruction
		from Recipe r
		join RecipeStep rs
		on rs.RecipeId = r.RecipeId
		where r.RecipeId = @RecipeId
	)
	insert RecipeStep(RecipeId,SequenceVal,Instruction)
	select r.RecipeId,x.SequenceVal, x.Instruction
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName

	select @RecipeId = @NewId

	return @return
end
go