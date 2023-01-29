use RecipeDB
go
-- Test blanks and 0
-- Staff, Cuisine, Measurement, Ingredient, Recipe, Course, Meal, Cookbook, CookbookRecipe, RecipeIngredient, RecipeStep

insert Staff(FirstName,LastName,Username)
select '', 'Smith', 'johnsmith'
go
insert Staff(FirstName,LastName,Username)
select 'John', '', 'johnsmith'
go
insert Staff(FirstName,LastName,Username)
select 'John', 'Smith', ''
go
insert Cuisine(CuisineType)
select ''
go
insert Measurement(MeasurementType)
select ''
go
insert Ingredient(Ingredient)
select ''
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'', 100, getdate(), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 0, getdate(), getdate(),getdate()
go
insert Course(SequenceVal,CourseName)
select 0, 'A new course'
go
insert Course(SequenceVal,CourseName)
select 1, ''
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), '', 1, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), '', 10, 1, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', 0, 1, getdate()
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select (select c.CookbookId from cookbook c where c.CookbookName = 'When Vegetable Meet'), (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 0
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), (select i.IngredientId from Ingredient i where i.Ingredient = 'vanilla yogurt'), 0, 100
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), (select i.IngredientId from Ingredient i where i.Ingredient = 'vanilla yogurt'), 1, 0
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), '', 100
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 'Do this', 0
go