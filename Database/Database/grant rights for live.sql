--select distinct concat('grant execute on ',r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r
--join INFORMATION_SCHEMA.TABLES t
--on (r.ROUTINE_NAME like '%' + t.TABLE_NAME + '%' and r.ROUTINE_NAME like '%Get')
--or r.ROUTINE_NAME in('MealCalories','RecipeDesc','ProperCase','DashboardGet')


grant execute on CookbookGet to approle
grant execute on CookbookRecipeGet to approle
grant execute on CourseGet to approle
grant execute on CuisineGet to approle
grant execute on DashboardGet to approle
grant execute on IngredientGet to approle
grant execute on MealCalories to approle
grant execute on MealCourseGet to approle
grant execute on MealCourseRecipeGet to approle
grant execute on MealGet to approle
grant execute on MeasurementGet to approle
grant execute on RecipeDesc to approle
grant execute on RecipeDetailsGet to approle
grant execute on RecipeGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on RecipeStepGet to approle
grant execute on StaffGet to approle