set nocount on
declare @RecipeId int

select top 1 @RecipeId = r.RecipeId
from Recipe r
/*left*/ join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
--where mcr.MealCourseRecipeId is null
order by r.RecipeId

select @RecipeId

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'Meal',mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId

begin try
	begin tran
	--delete MealCourseRecipe where RecipeId = @RecipeId
	delete RecipeStep where RecipeId = @RecipeId
	delete RecipeIngredient where RecipeId = @RecipeId
	delete Recipe where RecipeId = @RecipeId
	commit
end try
begin catch
	rollback;

	select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
	union select 'Meal',mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId
	;
	throw
end catch
--select @@TRANCOUNT

select 'Recipe', r.RecipeId, r.RecipeName from Recipe r where r.RecipeId = @RecipeId
union select 'Meal',mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mc.MealCourseId = mcr.MealCourseId join Meal m on m.MealId = mc.MealId where mcr.RecipeId = @RecipeId
