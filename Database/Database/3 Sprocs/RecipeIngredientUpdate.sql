create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0 output,
	@IngredientId int = 0,
	@MeasurementId int = 0,
	@MeasurementQty decimal(4,2) = 0,
	@RecipeId int = 0,
	@SequenceVal int = 0,
	@SpecialInstruction varchar(50) = '',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select 
		@RecipeIngredientId = ISNULL(@RecipeIngredientId,0), 
		@IngredientId = isnull(@IngredientId,0), 
		@MeasurementId = nullif(@MeasurementId,0), 
		@MeasurementQty = isnull(@MeasurementQty,0),
		@RecipeId = isnull(@RecipeId,0),
		@SequenceVal = isnull(@SequenceVal,0),
		@SpecialInstruction = isnull(@SpecialInstruction,'')

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