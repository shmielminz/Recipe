create or alter proc dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0)

	begin try
		begin tran
		delete RecipeIngredient where MeasurementId = @MeasurementId
		delete Measurement where MeasurementId = @MeasurementId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go
