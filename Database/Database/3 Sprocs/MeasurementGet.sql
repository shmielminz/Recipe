create or alter proc dbo.MeasurementGet(
	@MeasurementId int,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0), @All = ISNULL(@All,0), @IncludeBlank = ISNULL(@IncludeBlank,0)

	select m.MeasurementId, m.MeasurementType
	from Measurement m
	where m.MeasurementId = @MeasurementId
	or @All = 1
	union select 0,''
	where @IncludeBlank = 1
	order by m.MeasurementId

	return @return
end
go