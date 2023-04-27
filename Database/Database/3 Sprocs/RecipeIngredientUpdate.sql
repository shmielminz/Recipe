create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int output,
	@IngredientId int,
	@MeasurementId int,
	@MeasurementQty decimal(4,2),
	@RecipeId int,
	@SequenceVal int,
	@SpecialInstruction varchar(50),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = ISNULL(@RecipeIngredientId,0), @SpecialInstruction = isnull(@SpecialInstruction,'')

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(MeasurementId, IngredientId, RecipeId, SequenceVal, MeasurementQty, SpecialInstruction)
		values(@MeasurementId, @IngredientId, @RecipeId, @SequenceVal, @MeasurementQty, @SpecialInstruction)

		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set
			MeasurementId = @MeasurementId, 
			IngredientId = @IngredientId, 
			RecipeId = @RecipeId, 
			SequenceVal = @SequenceVal, 
			MeasurementQty = @MeasurementQty, 
			SpecialInstruction = @SpecialInstruction
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
go