create or alter procedure dbo.CuisineGet(
	@All bit = 0, 
	@CuisineId int = 0, 
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by c.CuisineId

	return @return
end
go
/*
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = null

exec CuisineGet @CuisineType = ''

exec CuisineGet @CuisineType = 'a'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId
*/