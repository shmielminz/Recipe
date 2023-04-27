create or alter proc dbo.CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select c.CookbookId, s.StaffId, s.Username, c.CookbookName, c.DateCreated, c.Price, c.Active
	from Cookbook c
	join Staff s
	on s.StaffId = c.StaffId
	where c.CookbookId = @CookbookId
	or @All = 1
	union select 0,0,'','',null,0,null
	where @IncludeBlank = 1
	order by c.CookbookId

	return @return
end
go