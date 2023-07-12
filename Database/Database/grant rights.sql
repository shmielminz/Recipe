--select distinct concat('grant execute on ',r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r
--join INFORMATION_SCHEMA.TABLES t
--on r.ROUTINE_NAME like '%' + t.TABLE_NAME + '%'
--or r.ROUTINE_NAME in('MealCalories','RecipeDesc','ProperCase')

grant execute on CloneRecipe to approle
grant execute on CookbookAutoCreate to approle
grant execute on CookbookDelete to approle
grant execute on CookbookGet to approle
grant execute on CookbookRecipeDelete to approle
grant execute on CookbookRecipeGet to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on CookbookUpdate to approle
grant execute on CourseDelete to approle
grant execute on CourseGet to approle
grant execute on CourseUpdate to approle
grant execute on CuisineDelete to approle
grant execute on CuisineGet to approle
grant execute on CuisineUpdate to approle
grant execute on IngredientDelete to approle
grant execute on IngredientGet to approle
grant execute on IngredientUpdate to approle
grant execute on MealCalories to approle
grant execute on MealCourseDelete to approle
grant execute on MealCourseGet to approle
grant execute on MealCourseRecipeDelete to approle
grant execute on MealCourseRecipeGet to approle
grant execute on MealCourseRecipeUpdate to approle
grant execute on MealCourseUpdate to approle
grant execute on MealDelete to approle
grant execute on MealGet to approle
grant execute on MealUpdate to approle
grant execute on MeasurementDelete to approle
grant execute on MeasurementGet to approle
grant execute on MeasurementUpdate to approle
grant execute on ProperCase to approle
grant execute on RecipeDelete to approle
grant execute on RecipeDesc to approle
grant execute on RecipeDetailsGet to approle
grant execute on RecipeGet to approle
grant execute on RecipeIngredientDelete to approle
grant execute on RecipeIngredientGet to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on RecipeStepDelete to approle
grant execute on RecipeStepGet to approle
grant execute on RecipeStepUpdate to approle
grant execute on RecipeUpdate to approle
grant execute on StaffDelete to approle
grant execute on StaffGet to approle
grant execute on StaffUpdate to approle