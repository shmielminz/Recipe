use RecipeDB
go
-- Test nulls
-- Staff, Cuisine, Measurement, Ingredient, Recipe, Course, Meal, Cookbook, CookbookRecipe, MealCourse, MealCourseRecipe, RecipeIngredient, RecipeStep

insert Staff(FirstName,LastName,Username)
select null, 'Smith', 'johnsmith'
go
insert Staff(FirstName,LastName,Username)
select 'John', null, 'johnsmith'
go
insert Staff(FirstName,LastName,Username)
select 'John', 'Smith', null
go
insert Cuisine(CuisineType)
select null
go
insert Measurement(MeasurementType)
select null
go
insert Ingredient(Ingredient)
select null
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select null,(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, getdate(), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),null,'A lovely recipe', 100, getdate(), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),null, 100, getdate(), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', null, getdate(), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, null, getdate(),getdate()
go
insert Course(SequenceVal,CourseName)
select null, 'A new course'
go
insert Course(SequenceVal,CourseName)
select 1, null
go
insert Meal(StaffId,MealName,Active,DateCreated)
select null, 'A new meal', 1, getdate()
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), null, 1, getdate()
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A new meal', null, getdate()
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A new meal', 1, null
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select null, 'A fun cookbook', 10, 1, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), null, 10, 1, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', null, 1, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', 10, null, getdate()
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', 10, 1, null
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select null, (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 1
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select (select c.CookbookId from cookbook c where c.CookbookName = 'Treats for two'), null, 1
go
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select (select c.CookbookId from cookbook c where c.CookbookName = 'Treats for two'), (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), null
go
insert MealCourse(CourseId,MealId)
select null, (select m.MealId from Meal m where m.MealName = 'Breakfast bash')
go
insert MealCourse(CourseId,MealId)
select (select c.CourseId from Course c where c.CourseName = 'Appetizer'), null
go
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select null, (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 1
go
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select (select top 1 mc.MealCourseId from MealCourse mc join Meal m on m.MealId = mc.MealId where m.MealName = 'Breakfast bash'), null, 1
go
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select (select top 1 mc.MealCourseId from MealCourse mc join Meal m on m.MealId = mc.MealId where m.MealName = 'Breakfast bash'), (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), null
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select null, (select i.IngredientId from Ingredient i where i.Ingredient = 'sugar'), 1, 1
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), null, 1, 1
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), (select i.IngredientId from Ingredient i where i.Ingredient = 'sugar'), null, 1
go
insert RecipeIngredient(RecipeId,IngredientId,MeasurementQty,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), (select i.IngredientId from Ingredient i where i.Ingredient = 'sugar'), 1, null
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select null, 'Do this', 1
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), null, 1
go
insert RecipeStep(RecipeId,Instruction,SequenceVal)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Chocolate Chip Cookies'), 'Do this', null
go