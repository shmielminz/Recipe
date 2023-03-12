exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = null

exec CuisineGet @CuisineType = ''

exec CuisineGet @CuisineType = 'a'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId