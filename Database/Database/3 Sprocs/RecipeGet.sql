create or alter proc dbo.RecipeGet(
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@RecipeName varchar(50) = '',
	@CookbookName varchar(50) = '',
	@MealName varchar(50) = '',
	@CuisineType varchar(25) = '',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0), @RecipeName = isnull(@RecipeName,''), @CuisineType = isnull(@CuisineType,''), @CookbookName = isnull(@CookbookName,''), @MealName = isnull(@MealName,'')
	
	select r.RecipeId, r.CuisineId, r.StaffId, s.Username, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, RecipeDesc = dbo.RecipeDesc(r.RecipeId),r.IsVegan, NumIngredients = dbo.NumIngredients(r.RecipeId), r.ImageName
	from Recipe r
	join Staff s
	on s.StaffId = r.StaffId
	join Cuisine cu
	on cu.CuisineId = r.CuisineId
	left join CookbookRecipe cr
	on cr.RecipeId = r.RecipeId
	left join Cookbook c
	on c.CookbookId = cr.CookbookId
	left join MealCourseRecipe mcr
	on mcr.RecipeId = r.RecipeId
	left join MealCourse mc
	on mc.MealCourseId = mcr.MealCourseId
	left join Meal m
	on m.MealId = mc.MealId
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	or (@CookbookName <> '' and c.CookbookName = @CookbookName)
	or (@MealName <> '' and m.MealName = @MealName)
	or (@CuisineType <> '' and cu.CuisineType = @CuisineType)
	union select 0,0,0,' ',' ',0,null,null,null,' ', ' ',null,null,' '
	where @IncludeBlank = 1
	order by r.RecipeId

	return @return
end
go