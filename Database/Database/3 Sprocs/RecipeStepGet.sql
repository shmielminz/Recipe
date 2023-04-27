create or alter proc dbo.RecipeStepGet(
	@RecipeStepId int,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeStepId = isnull(@RecipeStepId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select r.RecipeStepId,r.RecipeId,r.SequenceVal,r.Instruction
	from RecipeStep r
	where r.RecipeStepId = @RecipeStepId
	or @All = 1
	union select 0,0,0,''
	where @IncludeBlank = 1
	order by r.RecipeStepId

	return @return
end
go