create or alter procedure dbo.CuisineGet(
	@All bit = 0, 
	@CuisineId int = 0, 
	@CuisineType varchar(25) = ''
)
as
begin
	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or (@CuisineType <> '' and c.CuisineType like '%' + @CuisineType + '%')
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