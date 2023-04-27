create or alter proc dbo.MeasurementUpdate(
	@MeasurementId int output,
	@MeasurementType varchar(10),
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MeasurementId = ISNULL(@MeasurementId,0)

	if @MeasurementId = 0
	begin
		insert Measurement(MeasurementType)
		values(@MeasurementType)

		select @MeasurementId = SCOPE_IDENTITY()
	end
	else
	begin
		update Measurement
		set
			MeasurementType = @MeasurementType
		where MeasurementId = @MeasurementId
	end

	return @return
end
go