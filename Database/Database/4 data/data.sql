--AS Great data!! 100%
use RecipeDB
go

delete RecipeStep
delete RecipeIngredient
delete Ingredient
delete Measurement
delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete Course
delete Recipe
delete Cuisine
delete Staff
go

;with x as(
   select FirstName = 'John',LastName = 'Smith', Username = 'johnsmith@heartyhearth.com'
   union select 'Mike','Jones','mike@heartyhearth.com'
   union select 'Robert','Roberts','robert@heartyhearth.com'
   union select 'Robert', 'Smith', 'admin@heartyhearth.com'
   union select 'John', 'Roberts', 'johnroberts@heartyhearth.com'
)
insert Staff(FirstName,LastName,Username)
select x.FirstName, x.LastName, x.Username
from x
go

;with x as(
   select RecipeName = 'Chocolate Chip Cookies', Cuisine = 'American'
   union select 'Apple Yogurt Smoothie', 'French'
   union select 'Cheese Bread', 'English'
   union select 'Butter Muffins', 'American'
   union select '360_Minute Steak', 'American'
   union select 'Roasted Vegetable Yapchik', 'English'
   union select 'Yemenite Chicken Soup', 'Middle East'
   union select 'Eggplant Casserole Dip', 'French'
)
insert Cuisine(CuisineType)
select distinct x.Cuisine
from x
go

;with x as(
   select Username = 'johnsmith@heartyhearth.com', RecipeName = 'Chocolate Chip Cookies', Cuisine = 'American', Calories = 148, Drafted = dateadd(month,-3,getdate()), Published = dateadd(month,-2,getdate()), Archived = null
   union select 'mike@heartyhearth.com', 'Apple Yogurt Smoothie', 'French', 60, dateadd(day,-45,getdate()), null, dateadd(day,-45,getdate())
   union select 'mike@heartyhearth.com', 'Cheese Bread', 'English', 71, dateadd(month,-2,getdate()), getdate(), null
   union select 'robert@heartyhearth.com', 'Butter Muffins', 'American', 170, dateadd(day,-50,getdate()), dateadd(day,-45,getdate()), getdate()
   union select 'johnroberts@heartyhearth.com', '360_Minute Steak', 'American', 210, dateadd(day,-50,getdate()), null, dateadd(day,-45,getdate())
   union select 'mike@heartyhearth.com', 'Roasted Vegetable Yapchik', 'English', 60, dateadd(day,-50,getdate()), null, null
   union select 'johnroberts@heartyhearth.com', 'Yemenite Chicken Soup', 'Middle East', 150, dateadd(day,-25,getdate()), getdate(), null
   union select 'johnsmith@heartyhearth.com', 'Eggplant Casserole Dip', 'French', 75, dateadd(month,-2,getdate()), dateadd(day,-35,getdate()), null
)
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select s.StaffId, c.CuisineId, x.RecipeName, x.Calories, x.Drafted, x.Published, x.Archived
from x
join Staff s
on s.Username = x.Username
join Cuisine c
on c.CuisineType = x.Cuisine
go

;with x as(
   select Amount = 1, MeasurementType = 'cup', Ingredient = 'sugar'
   union select 0.5, 'cup', 'oil' 
   union select 3, null, 'eggs'
   union select 2, 'cup', 'Flour'
   union select 1, 'tsp', 'vanilla sugar'
   union select 2, 'tsp','baking powder'
   union select 0.5, 'tsp', 'baking soda'
   union select 1, 'cup', 'chocolate chips'
   union select 3, null, 'granny smith apples'
   union select 2, 'cup', 'vanilla yogurt'
   union select 2, 'tsp', 'sugar'
   union select 0.5, 'cup', 'orange juice'
   union select 2, 'tbsp','honey'
   union select 6, null,'ice cubes'
   union select 1, null,'club bread'
   union select 4, 'oz', 'butter'
   union select 8, 'oz', 'shredded cheese'
   union select 2, 'cloves', 'garlic (crushed)'
   union select 0.25, 'tsp', 'black pepper'
   union select 1, 'pinch', 'salt'
   union select 1, 'stick', 'butter'
   union select 3, 'cup', 'sugar'
   union select 2, 'tbsp', 'vanilla pudding'
   union select 4, null, 'eggs'
   union select 8, 'oz','whipped cream cheese'
   union select 8, 'oz','sour cream cheese'
   union select 1, 'cup', 'flour'
   union select 2, 'tsp', 'baking powder'
   union select 3, 'pounds', 'minute steak'
   union select 2.5, 'pounds', 'Yukon gold potatoes'
   union select 2, null, 'onions'
   union select 14, 'cloves', 'garlic'
   union select 3, 'tbsp', 'oil' 
   union select 1.5, 'tsp', 'salt' 
   union select 2, 'tsp','Garlic Powder'
   union select 2, 'tsp', 'Paprika'
   union select 0.75, 'tsp','pepper'
   union select 6, 'large', 'potatoes' 
   union select 1, null, 'carrot' 
   union select 1, null, 'sweet potato'
   union select 1,null,'onion'
   union select 2,null, 'celery stalks' 
   union select 1, 'tsp', 'salt' 
   union select 1, 'tsp', 'garlic powder'
   union select 1, 'tsp', 'onion powder' 
   union select 0.25, 'tsp', 'black pepper'
   union select 0.5, 'cup', 'oil' 
   union select 1, 'tbsp', 'oil' 
   union select 4, null, 'eggs'
   union select 1,'pound', 'boneless flanken'
   union select 1, 'tsp', 'salt'
   union select 4, null, 'chicken breasts'
   union select 2, 'tbsp', 'olive oil'
   union select 3, null, 'yellow onions'
   union select 4, null, 'potatoes'
   union select 0.25, 'cup', 'hawaij'
   union select 2, 'tbsp', 'salt'
   union select 3, 'tbsp', 'chicken soup powder'
   union select 2, 'tbsp', 'oil'
   union select 1, null, 'eggplant'
   union select 1, null, 'onion'
   union select 0.5, 'tsp', 'salt'
   union select 0.12, 'tsp', 'pepper'
   union select 3, null, 'eggs'
)
insert Measurement(MeasurementType)
select distinct x.MeasurementType
from x
where x.MeasurementType is not null
go

;with x as(
   select Amount = 1, MeasurementType = 'cup', Ingredient = 'sugar'
   union select 0.5, 'cup', 'oil' 
   union select 3, null, 'eggs'
   union select 2, 'cup', 'Flour'
   union select 1, 'tsp', 'vanilla sugar'
   union select 2, 'tsp', 'baking powder'
   union select 0.5, 'tsp', 'baking soda'
   union select 1, 'cup', 'chocolate chips'
   union select 3, null, 'granny smith apples'
   union select 2, 'cup', 'vanilla yogurt'
   union select 2, 'tsp', 'sugar'
   union select 0.5, 'cup', 'orange juice'
   union select 2, 'tbsp', 'honey'
   union select 6, null, 'ice cubes'
   union select 1, null,'club bread'
   union select 4, 'oz', 'butter'
   union select 8, 'oz', 'shredded cheese'
   union select 2, 'clove', 'garlic'
   union select 0.25, 'tsp', 'black pepper'
   union select 1, 'pinch', 'salt'
   union select 1, 'stick', 'butter'
   union select 3, 'cup', 'sugar'
   union select 2, 'tbsp', 'vanilla pudding'
   union select 4, null, 'eggs'
   union select 8, 'oz', 'whipped cream cheese'
   union select 8, 'oz', 'sour cream cheese'
   union select 1, 'cup', 'flour'
   union select 2, 'tsp', 'baking powder'
   union select 3, 'pounds', 'minute steak'
   union select 2.5, 'pounds', 'Yukon gold potatoes'
   union select 2, null, 'onions'
   union select 14, 'cloves', 'garlic'
   union select 3, 'tbsp', 'oil' 
   union select 1.5, 'tsp', 'salt' 
   union select 2, 'tsp','Garlic Powder'
   union select 2, 'tsp', 'Paprika'
   union select 0.75, 'tsp','pepper'
   union select 6, 'large', 'potatoes' 
   union select 1, null, 'carrot' 
   union select 1, null, 'sweet potato'
   union select 1,null,'onion'
   union select 2,null, 'celery stalks' 
   union select 1, 'tsp', 'salt' 
   union select 1, 'tsp', 'garlic powder'
   union select 1, 'tsp', 'onion powder' 
   union select 0.25, 'tsp', 'black pepper'
   union select 0.5, 'cup', 'oil' 
   union select 1, 'tbsp', 'oil' 
   union select 4, null, 'eggs'
   union select 1,'pound', 'boneless flanken'
   union select 1, 'tsp', 'salt'
   union select 4, null, 'chicken breasts'
   union select 2, 'tbsp', 'olive oil'
   union select 3, null, 'yellow onions'
   union select 4, null, 'potatoes'
   union select 0.25, 'cup', 'hawaij'
   union select 2, 'tbsp', 'salt'
   union select 3, 'tbsp', 'chicken soup powder'
   union select 2, 'tbsp', 'oil'
   union select 1, null, 'eggplant'
   union select 1, null, 'onion'
   union select 0.5, 'tsp', 'salt'
   union select 0.12, 'tsp', 'pepper'
   union select 3, null, 'eggs'
)
insert Ingredient(Ingredient)
select distinct x.Ingredient
from x
go

;with x as(
   select RecipeName = 'Chocolate Chip Cookies', Cuisine = 'American', Amount = 1, MeasurementType = 'cup', Ingredient = 'sugar', SequenceVal = 1, SpecialInstruction = ''
   union select 'Chocolate Chip Cookies', 'American', 0.5, 'cup', 'oil', 2, ''
   union select 'Chocolate Chip Cookies', 'American', 3, null, 'eggs', 3, 'Separated'
   union select 'Chocolate Chip Cookies', 'American', 2, 'cup', 'Flour', 4, ''
   union select 'Chocolate Chip Cookies', 'American', 1, 'tsp', 'vanilla sugar', 5, ''
   union select 'Chocolate Chip Cookies', 'American', 2, 'tsp', 'baking powder', 6, ''
   union select 'Chocolate Chip Cookies', 'American', 0.5, 'tsp', 'baking soda',7, ''
   union select 'Chocolate Chip Cookies', 'American', 1, 'cup', 'chocolate chips',8, ''
   union select 'Apple Yogurt Smoothie', 'French',3, null, 'granny smith apples',1, ''
   union select 'Apple Yogurt Smoothie', 'French',2, 'cup', 'vanilla yogurt',2, ''
   union select 'Apple Yogurt Smoothie', 'French', 2, 'tsp', 'sugar',3, ''
   union select 'Apple Yogurt Smoothie', 'French', 0.5, 'cup', 'orange juice',4, ''
   union select 'Apple Yogurt Smoothie', 'French', 2, 'tbsp', 'honey',5, ''
   union select 'Apple Yogurt Smoothie', 'French', 6, null, 'ice cubes',6, ''
   union select 'Cheese Bread', 'English', 1, null,'club bread',1, ''
   union select 'Cheese Bread', 'English', 4, 'oz', 'butter',2, ''
   union select 'Cheese Bread', 'English', 8, 'oz', 'shredded cheese',3, ''
   union select 'Cheese Bread', 'English', 2, 'clove', 'garlic',4, 'crushed'
   union select 'Cheese Bread', 'English', 0.25, 'tsp', 'black pepper',5, ''
   union select 'Cheese Bread', 'English', 1, 'pinch', 'salt',6, ''
   union select 'Butter Muffins', 'American', 1, 'stick', 'butter',1, ''
   union select 'Butter Muffins', 'American', 3, 'cup', 'sugar',2, ''
   union select 'Butter Muffins', 'American', 2, 'tbsp', 'vanilla pudding',3, ''
   union select 'Butter Muffins', 'American', 4, null, 'eggs',4, ''
   union select 'Butter Muffins', 'American', 8, 'oz', 'whipped cream cheese',5, ''
   union select 'Butter Muffins', 'American', 8, 'oz', 'sour cream cheese',6, ''
   union select 'Butter Muffins', 'American', 1, 'cup', 'flour',7, ''
   union select 'Butter Muffins', 'American', 2, 'tsp', 'baking powder',8, ''
   union select '360_Minute Steak', 'American', 3, 'pound', 'minute steak',1, ''
   union select '360_Minute Steak', 'American', 2.5, 'pound', 'Yukon gold potatoes',2, ''
   union select '360_Minute Steak', 'American', 2, null,'onions',3, 'Diced'
   union select '360_Minute Steak', 'American', 14, 'clove', 'garlic',4, ''
   union select '360_Minute Steak', 'American', 3, 'tbsp', 'oil',5, ''
   union select '360_Minute Steak', 'American', 1.5, 'tsp', 'salt',6 , ''
   union select '360_Minute Steak', 'American', 2, 'tsp','Garlic Powder',7, ''
   union select '360_Minute Steak', 'American', 2, 'tsp', 'Paprika',8, ''
   union select '360_Minute Steak', 'American', 0.75, 'tsp','pepper',9, ''
   union select 'Roasted Vegetable Yapchik', 'English', 6, 'large', 'potatoes',1, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1, null, 'carrot',2, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1, null, 'sweet potato',3, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1,null,'onion',4, ''
   union select 'Roasted Vegetable Yapchik', 'English', 2,null, 'celery stalks',5, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1, 'tsp', 'salt',6, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1, 'tsp', 'garlic powder',7, ''
   union select 'Roasted Vegetable Yapchik', 'English', 1, 'tsp', 'onion powder',8, ''
   union select 'Roasted Vegetable Yapchik', 'English', 0.25, 'tsp', 'black pepper',9, ''
   union select 'Roasted Vegetable Yapchik', 'English', 0.5, 'cup', 'oil',10, ''
   union select 'Roasted Vegetable Yapchik', 'English', 4, null, 'eggs',11, 'Separated'
   union select 'Roasted Vegetable Yapchik', 'English', 1,'pound', 'boneless flanken',12, 'Striped'
   union select 'Yemenite Chicken Soup', 'Middle East', 4, null, 'chicken breasts',1, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 2, 'tbsp', 'olive oil',2, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 3, null, 'yellow onions',3, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 4, null, 'potatoes',4, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 0.25, 'cup', 'hawaij',5, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 2, 'tbsp', 'salt',6, ''
   union select 'Yemenite Chicken Soup', 'Middle East', 3, 'tbsp', 'chicken soup powder',7, ''
   union select 'Eggplant Casserole Dip', 'French', 2, 'tbsp', 'oil',1, ''
   union select 'Eggplant Casserole Dip', 'French', 1, null, 'eggplant',2, ''
   union select 'Eggplant Casserole Dip', 'French', 1, null, 'onion',3, ''
   union select 'Eggplant Casserole Dip', 'French', 0.5, 'tsp', 'salt',4, ''
   union select 'Eggplant Casserole Dip', 'French', 0.12, 'tsp', 'pepper',5, ''
   union select 'Eggplant Casserole Dip', 'French', 3, null, 'eggs',6, ''
)
insert RecipeIngredient(RecipeId,MeasurementId,IngredientId,MeasurementQty,SequenceVal,SpecialInstruction)
select r.RecipeId,m.MeasurementId,i.IngredientId,x.Amount,x.SequenceVal,x.SpecialInstruction
from x
join Ingredient i
on i.Ingredient = x.Ingredient
join Recipe r
on r.RecipeName = x.RecipeName
left join Measurement m
on m.MeasurementType = x.MeasurementType
go

;with x as(
   select RecipeName = 'Chocolate Chip Cookies', SequenceVal = 1, Instructions = 'First combine sugar, oil and eggs in a bowl'
   union select 'Chocolate Chip Cookies', 2, 'mix well'
   union select 'Chocolate Chip Cookies',3, 'add flour, vanilla sugar, baking powder and baking soda'
   union select 'Chocolate Chip Cookies',4, 'beat for 5 minutes'
   union select 'Chocolate Chip Cookies',5, 'add chocolate chips'
   union select 'Chocolate Chip Cookies',6,'freeze for 1-2 hours'
   union select 'Chocolate Chip Cookies',7,'roll into balls and place spread out on a cookie sheet'
   union select 'Chocolate Chip Cookies',8,'bake on 350 for 10 min.'
   union select 'Apple Yogurt Smoothie', 1,'Peel the apples and dice'
   union select 'Apple Yogurt Smoothie',2,'Combine all ingredients in bowl except for apples and ice cubes'
   union select 'Apple Yogurt Smoothie',3,'mix until smooth'
   union select 'Apple Yogurt Smoothie',4, 'add apples and ice cubes'
   union select 'Apple Yogurt Smoothie', 5,'pour into glasses.'
   union select 'Cheese Bread',1,'Slit bread every 3/4 inch'
   union select 'Cheese Bread',2,'Combine all ingredients in bowl'
   union select 'Cheese Bread', 3,'fill slits with cheese mixture'
   union select 'Cheese Bread', 4,'wrap bread into a foil and bake for 30 minutes.'
   union select 'Butter Muffins',1,'Cream butter with sugars'
   union select 'Butter Muffins',2,'Add eggs and mix well'
   union select 'Butter Muffins',3,'Slowly add rest of ingredients and mix well'
   union select 'Butter Muffins',4,'fill muffin pans 3/4 full and bake for 30 minutes.'
   union select '360_Minute Steak', 1, 'Preheat your oven to 275 degrees Fahrenheit'
   union select '360_Minute Steak', 2, 'combine the potatoes, diced onion, sliced garlic, two tablespoons oil, one teaspoon salt, one and a half teaspoons garlic powder, one and a half teaspoons paprika, and half a teaspoon of pepper.'
   union select '360_Minute Steak', 3, 'Pour into a large baking pan. Top the potato layer with the minute steaks.'
   union select '360_Minute Steak', 4, 'Combine the remaining ingredients in the same bowl and then pour over the top of the minute steaks.'
   union select '360_Minute Steak', 5, 'Cover tightly and bake for six hours.'
   union select 'Roasted Vegetable Yapchik', 1, 'Preheat oven to 400 degrees Fahrenheit.'
   union select 'Roasted Vegetable Yapchik',2, 'Peel and dice the carrot, sweet potato, onion, and celery.'
   union select 'Roasted Vegetable Yapchik',3, 'Grate the potatoes using the shredding blade in the food processor. Add the eggs, oil, and spices straight into the potatoes and mix.'
   union select 'Roasted Vegetable Yapchik',4, 'Pour half the batter into a greased pan. Layer on the vegetables and meat, and drizzle with the extra tablespoon oil and teaspoon salt. Cover with the rest of the kugel batter.'
   union select 'Roasted Vegetable Yapchik',5,'Bake uncovered on 400 degrees Fahrenheit for an hour and a half, then cover and lower to 300 for another hour and a half.'
   union select 'Yemenite Chicken Soup', 1, 'Place chicken in a pot and cover with water. Bring to a boil and cook for 30 minutes.'
   union select 'Yemenite Chicken Soup', 2, 'Remove chicken and discard water.'
   union select 'Yemenite Chicken Soup', 3, 'Dice cooked chicken and set aside'
   union select 'Yemenite Chicken Soup', 4, 'Place large pot over medium high heat.'
   union select 'Yemenite Chicken Soup', 5, 'Add oil and onions and cook for about seven to eight minutes, stirring often'
   union select 'Yemenite Chicken Soup', 6, 'Add all the remaining ingredients, besides water and the reserved chicken'
   union select 'Yemenite Chicken Soup', 7, 'Cook for three to four minutes until very fragrant.'
   union select 'Yemenite Chicken Soup', 8, 'Fill pot with water to cover everything by about three-fourths of an inch'
   union select 'Yemenite Chicken Soup', 9, 'Bring to a boil, then reduce heat to low and cover the pot.'
   union select 'Yemenite Chicken Soup', 10, 'Allow soup to simmer, covered, for at least two hours'
   union select 'Yemenite Chicken Soup', 11, 'Serve hot with lachuch or kubane and a heaping scoop of hilbe!'
   union select 'Eggplant Casserole Dip', 1, 'Hard boil the eggs'
   union select 'Eggplant Casserole Dip',2,'Place oil, eggplant, onion and spices in heavy pot. Cover'
   union select 'Eggplant Casserole Dip',3, 'Simmer for 45 minutes'
   union select 'Eggplant Casserole Dip', 4, 'Mash with fork. Add chopped eggs.'
   union select 'Eggplant Casserole Dip', 5, 'Serve warm or chilled.'
)
insert RecipeStep(RecipeId,SequenceVal,Instruction)
select r.RecipeId,x.SequenceVal,x.Instructions
from x
join Recipe r
on r.RecipeName = x.RecipeName
go

;with x as(
   select SequenceVal = 1, Course = 'Appetizer'
   union select 2, 'Fish'
   union select 3, 'Soup'
   union select 4, 'Salad'
   union select 5, 'Main'
   union select 6, 'Dessert'
   union select 7, 'Coffee'
)
insert Course(SequenceVal,CourseName)
select x.SequenceVal, x.Course
from x
go

;with x as(
   select Username = 'johnsmith@heartyhearth.com', MealName = 'Breakfast bash', Active = 1
   union select 'mike@heartyhearth.com', 'Super Supper', 1
   union select 'johnroberts@heartyhearth.com', 'Bruncheese', 0
   union select 'johnroberts@heartyhearth.com', 'Tohameya', 1
)
insert Meal(StaffId,MealName,Active)
select s.StaffId, x.MealName, x.Active
from x
join Staff s
on s.Username = x.Username
go

;with x as(
   select MealName = 'Breakfast bash', Course = 'Main'
   union select 'Breakfast bash', 'Appetizer'
   union select 'Super Supper', 'Soup'
   union select 'Super Supper', 'Main'
   union select 'Super Supper', 'Dessert'
   union select 'Bruncheese', 'Main'
   union select 'Tohameya', 'Main'
   union select 'Tohameya', 'Soup'
)
insert MealCourse(CourseId,MealId)
select c.CourseId, m.MealId
from x
join Course c
on c.CourseName = x.Course
join Meal m
on m.MealName = x.MealName
go

;with x as(
   select MealName = 'Breakfast bash', Course = 'Main', RecipeName = 'Cheese Bread', Main = 1
   --union select 'Breakfast bash', 'Main', 'Butter Muffins', 0
   union select 'Breakfast bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
   --union select 'Super Supper', 'Soup', 'Yemenite Chicken Soup', 1
   --union select 'Super Supper', 'Main', '360_Minute Steak', 1
   --union select 'Super Supper', 'Main', 'Roasted Vegetable Yapchik', 0
   union select 'Super Supper', 'Main', 'Eggplant Casserole Dip', 0
   union select 'Super Supper', 'Dessert', 'Chocolate Chip Cookies', 1
   union select 'Bruncheese', 'Main', 'Cheese Bread', 1
   union select 'Bruncheese', 'Main', 'Eggplant Casserole Dip', 0
   --union select 'Tohameya', 'Soup', 'Yemenite Chicken Soup', 1
   --union select 'Tohameya', 'Main', 'Roasted Vegetable Yapchik', 1
)
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select mc.MealCourseId, r.RecipeId, x.Main
from x
join Recipe r
on r.RecipeName = x.RecipeName
join Course c
on c.CourseName = x.Course
join Meal m
on m.MealName = x.MealName
join MealCourse mc
on mc.MealId = m.MealId
and mc.CourseId = c.CourseId
go

;with x as(
   select Username = 'johnsmith@heartyhearth.com', CookbookName = 'Treats for two', Price = 30, Active = 1
   union select 'mike@heartyhearth.com', 'When Vegetable Meet', 39.99, 1
   union select 'johnroberts@heartyhearth.com', 'Homemade No Time', 25.50, 0
   union select 'johnroberts@heartyhearth.com', 'Eat To Live', 20, 1
)
insert Cookbook(StaffId, CookbookName, Price, Active)
select s.StaffId, x.CookbookName, x.Price, x.Active
from x
join Staff s
on s.Username = x.Username
go

;with x as(
   select CookbookName = 'Treats for two', SequenceVal = 1, RecipeName = 'Chocolate Chip Cookies'
   --union select 'Treats for two', 2, 'Apple Yogurt Smoothie'
   union select 'Treats for two', 3, 'Cheese Bread'
   --union select 'Treats for two', 4, 'Butter Muffins'
   --union select 'When Vegetable Meet',1,'Roasted Vegetable Yapchik'
   --union select 'When Vegetable Meet',2,'Apple Yogurt Smoothie'
   union select 'When Vegetable Meet',3,'Eggplant Casserole Dip'
   --union select 'Homemade No Time',4, 'Roasted Vegetable Yapchik'
   union select 'Homemade No Time',2, 'Eggplant Casserole Dip'
   --union select 'Homemade No Time',3, 'Butter Muffins'
   union select 'Homemade No Time',1, 'Chocolate Chip Cookies'
   union select 'Eat To Live',1,'Cheese Bread'
   --union select 'Eat To Live',2,'Butter Muffins'
)
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select c.CookbookId, r.RecipeId, x.SequenceVal
from x
join Cookbook c
on c.CookbookName = x.CookbookName
join Recipe r
on r.RecipeName = x.RecipeName
go
;with x as(
   select MealName = 'Breakfast bash', Course = 'Main', RecipeName = 'Butter Muffins', Main = 0
   union select 'Super Supper', 'Soup', 'Yemenite Chicken Soup', 1
   union select 'Super Supper', 'Main', '360_Minute Steak', 1
   union select 'Super Supper', 'Main', 'Roasted Vegetable Yapchik', 0
   union select 'Tohameya', 'Soup', 'Yemenite Chicken Soup', 1
   union select 'Tohameya', 'Main', 'Roasted Vegetable Yapchik', 1
)
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select mc.MealCourseId, r.RecipeId, x.Main
from x
join Recipe r
on r.RecipeName = x.RecipeName
join Course c
on c.CourseName = x.Course
join Meal m
on m.MealName = x.MealName
join MealCourse mc
on mc.MealId = m.MealId
and mc.CourseId = c.CourseId
go

;with x as(
   select CookbookName = 'Treats for two', SequenceVal = 2, RecipeName = 'Apple Yogurt Smoothie'
   union select 'Treats for two', 4, 'Butter Muffins'
   union select 'When Vegetable Meet',1,'Roasted Vegetable Yapchik'
   union select 'When Vegetable Meet',2,'Apple Yogurt Smoothie'
   union select 'Homemade No Time',4, 'Roasted Vegetable Yapchik'
   union select 'Homemade No Time',3, 'Butter Muffins'
   union select 'Eat To Live',2,'Butter Muffins'
)
insert CookbookRecipe(CookbookId,RecipeId,SequenceVal)
select c.CookbookId, r.RecipeId, x.SequenceVal
from x
join Cookbook c
on c.CookbookName = x.CookbookName
join Recipe r
on r.RecipeName = x.RecipeName
go

;with x(CookbookName, Skill) as(
	select 'Eat To Live',2
	union select 'Homemade No Time',1
	union select 'Treats for two',3
	union select 'When Vegetable Meet',1
)
update c
set c.CookbookSkill = x.Skill
--select *
from Cookbook c
join x
on x.CookbookName = c.CookbookName

;with x(MealName,MealDesc) as(
	select 'Bruncheese', 'This meal is one of our staff favourite. We serve it as a brunch which is between breakfast and lunch'
	union select 'Tohameya', 'This meal is served on Friday afternoon only. In the winter we might have this available on Thursday evening also.'
	union select 'Breakfast bash', 'Breakfast bash is what you think it is. It''s a breakfast.'
	union select 'Super Supper', 'This is our basic supper which is available every afternoon from 4:00PM till late.'
)
update m
set m.MealDesc = x.MealDesc
--select *
from Meal m
join x
on x.MealName = m.MealName

;with x (RecipeName, IsVegan) as(
	select '360_Minute Steak',0
	union select 'Yemenite Chicken Soup',0
	union select 'Chocolate Chip Cookies',1
	union select 'Eggplant Casserole Dip',1
	union select 'Apple Yogurt Smoothie',0
	union select 'Cheese Bread',0
	union select 'Roasted Vegetable Yapchik',0
	union select 'Butter Muffins',0
)
update r
set r.IsVegan = x.IsVegan
--select *
from Recipe r
join x
on x.RecipeName = r.RecipeName