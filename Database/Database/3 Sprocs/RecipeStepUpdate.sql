create or alter proc dbo.RecipeStepUpdate(
	@RecipeStepId int = 0 output,
	@Instruction varchar(200) = '',
	@RecipeId int = 0,
	@SequenceVal int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeStepId = ISNULL(@RecipeStepId,0), @Instruction = isnull(@Instruction,''), @RecipeId = isnull(@RecipeId,0), @SequenceVal = isnull(@SequenceVal,0)

	if @RecipeStepId = 0
	begin
		insert RecipeStep(RecipeId, SequenceVal, Instruction)
		values(@RecipeId, @SequenceVal, @Instruction)

		select @RecipeStepId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeStep
		set
			RecipeId = @RecipeId, 
			SequenceVal = @SequenceVal, 
			Instruction = @Instruction
		where RecipeStepId = @RecipeStepId
	end

	return @return
end
go