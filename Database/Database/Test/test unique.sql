use RecipeDB
go
-- Test unique
-- Staff, Cuisine, Measurement, Ingredient, Recipe, Course, Meal, Cookbook, CookbookRecipe, MealCourse, MealCourseRecipe, RecipeIngredient, RecipeStep

insert Staff(FirstName,LastName,Username)
select top 1 'Name', 'Name', s.Username
from Staff s
go
insert Cuisine(CuisineType)
select top 1 c.CuisineType
from Cuisine c
go
insert Measurement(MeasurementType)
select top 1 m.MeasurementType
from Measurement m
go
insert Ingredient(Ingredient)
select top 1 i.Ingredient
from Ingredient i
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted)
select top 1 r.StaffId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted
from Recipe r
go
insert Course(SequenceVal,CourseName)
select top 1 1, c.CourseName
from Course c
go
insert Meal(StaffId,MealName,Active)
select top 1 m.StaffId, m.MealName, 1
from Meal m
go
insert Cookbook(StaffId,CookbookName,Price,Active)
select top 1 c.StaffId, c.CookbookName, 10, 1
from Cookbook c
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select (select c.CookbookId from Cookbook c where c.CookbookName = 'Eat To Live'), (select r.RecipeId from Recipe r where r.RecipeName = 'Eggplant Casserole Dip'), 1
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select top 1 cr.CookbookId, cr.RecipeId, 100
from CookbookRecipe cr
go
insert MealCourse(CourseId,MealId)
select top 1 mc.CourseId, mc.MealId
from MealCourse mc
go
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select top 1 mcr.MealCourseId, mcr.RecipeId, 1
from MealCourseRecipe mcr
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Cheese Bread'), (select i.IngredientId from Ingredient i where i.Ingredient = 'shredded cheese'), 1, 100
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Cheese Bread'), (select i.IngredientId from Ingredient i where i.Ingredient = 'vanilla yogurt'), 1, 1
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Cheese Bread'), 'Do what you want', 1
go