--AS Wow amazing job!! 100%
use RecipeDB
go
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause 
-- 	using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. 
-- 		Write the SQL to delete a specific user and all the user's related records.
delete rs
-- select *
from Staff s
join Recipe r
on s.StaffId = r.StaffId
join RecipeStep rs
on rs.RecipeId = r.RecipeId
where s.Username = 'mike@heartyhearth.com'

delete ri
-- select *
from Staff s
join Recipe r
on s.StaffId = r.StaffId
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where s.Username = 'mike@heartyhearth.com'

delete mcr
-- select *
from Staff s
join Recipe r
on s.StaffId = r.StaffId
join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
where s.Username = 'mike@heartyhearth.com'

delete cr
-- select *
from Staff s
join Recipe r
on s.StaffId = r.StaffId
join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where s.Username = 'mike@heartyhearth.com'

delete r
-- select *
from Staff s
join Recipe r
on s.StaffId = r.StaffId
where s.Username = 'mike@heartyhearth.com'

delete mcr
-- select *
from Staff s
join Meal m
on m.StaffId = s.StaffId
join MealCourse mc
on mc.MealId = m.MealId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
where s.Username = 'mike@heartyhearth.com'

delete mc
-- select *
from Staff s
join Meal m
on m.StaffId = s.StaffId
join MealCourse mc
on mc.MealId = m.MealId
where s.Username = 'mike@heartyhearth.com'

delete m
-- select *
from Staff s
join Meal m
on m.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'

delete cr
-- select *
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
join CookbookRecipe cr
on cr.CookbookId = c.CookbookId
where s.Username = 'mike@heartyhearth.com'

delete c
-- select *
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'

delete s
-- select *
from Staff s
where s.Username = 'mike@heartyhearth.com'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. 
-- 		For example we have a complex recipe (steps and ingredients) and want to make a modified version. 
-- 		Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(StaffId,CuisineId,RecipeName,Calories)
select r.StaffId, r.CuisineId, RecipeName = concat(r.RecipeName,' - clone'), r.Calories
from Recipe r
where r.RecipeName = 'Chocolate chip cookies'

;with x as(
	select RecipeName = concat(r.RecipeName,' - clone'), ri.MeasurementQty, ri.IngredientId, ri.MeasurementId, ri.SequenceVal
	from Recipe r
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where r.RecipeName = 'Chocolate chip cookies'
)
insert RecipeIngredient(RecipeId,MeasurementQty,IngredientId,MeasurementId,SequenceVal)
select r.RecipeId, x.MeasurementQty, x.IngredientId, x.MeasurementId, x.SequenceVal
from x
join Recipe r
on r.RecipeName = x.RecipeName

;with x as(
	select RecipeName = concat(r.RecipeName,' - clone'), rs.SequenceVal, rs.Instruction
	from Recipe r
	join RecipeStep rs
	on rs.RecipeId = r.RecipeId
	where r.RecipeName = 'Chocolate chip cookies'
)
insert RecipeStep(RecipeId,SequenceVal,Instruction)
select r.RecipeId,x.SequenceVal, x.Instruction
from x
join Recipe r
on r.RecipeName = x.RecipeName
/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The prices should be the number of recipes times $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , 
	 replace column name with the name of the column that the row number should be sorted
*/
;with x as(
	select s.Username, CookbookName = concat('Recipes by ',s.FirstName,' ',s.LastName), Price = count(*) * 1.33, Active = 1
	from Staff s
	join Recipe r
	on r.StaffId = s.StaffId
	where s.Username = 'johnsmith@heartyhearth.com'
	group by s.LastName, s.FirstName, s.Username
)
insert Cookbook(StaffId,CookbookName,Price,Active)
select s.StaffId, x.CookbookName, x.Price, x.Active
from x
join Staff s
on s.Username = x.Username

;with x as(
	select CookbookName = concat('Recipes by ',s.FirstName,' ',s.LastName), r.RecipeName, SequenceVal = row_number() over (order by r.RecipeName)
	from Staff s
	join Recipe r
	on r.StaffId = s.StaffId
	where s.Username = 'johnsmith@heartyhearth.com'
)
insert CookbookRecipe(RecipeId,CookbookId,SequenceVal)
select r.RecipeId, c.CookbookId, x.SequenceVal
from x
join Recipe r
on r.RecipeName = x.RecipeName
join Cookbook c
on c.CookbookName = x.CookbookName
/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calories for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count of butter went down by 2 per ounce, and 10 for a stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r
set r.Calories = r.Calories + (case m.MeasurementType when 'cup' then 5 when 'tbsp' then 1 end * ri.MeasurementQty)
-- select UpdatedCalories = r.Calories + (case m.MeasurementType when 'cup' then 5 when 'tbsp' then 1 end * ri.Amount), r.Calories, ri.Amount, m.MeasurementType
from Recipe r
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
join Measurement m
on m.MeasurementId = ri.MeasurementId
join Ingredient i
on i.IngredientId = ri.IngredientId
where i.Ingredient = 'oil'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time all recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with x as(
	select AvgHoursDrafted = avg(datediff(hour,r.DateDrafted,r.DatePublished))
	from Recipe r
)
select 
	s.FirstName, 
	s.LastName, 
	Email = lower(concat(substring(s.FirstName,1,1),s.LastName,'@heartyhearth.com')), 
	Alert = 
		concat('Your recipe ',
			r.RecipeName,
			' is sitting in draft for ',
			datediff(hour,r.DateDrafted,r.DatePublished),
			' hours. That is ',
			datediff(hour,r.DateDrafted,r.DatePublished) - x.AvgHoursDrafted,
			' hours more than the average ',
			x.AvgHoursDrafted,
			' hours all other recipes took to be published.')
from x
join Recipe r
on datediff(hour,r.DateDrafted,r.DatePublished) > x.AvgHoursDrafted
join Staff s
on s.StaffId = r.StaffId
/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average prices is [Y]. You can order all for 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ',count(*),' books for sale, average prices is ', convert(decimal(5,2),avg(c.Price)),'. You can order all for 25% discount, for a total of ', convert(decimal(5,2),sum(c.Price - c.Price * 0.25)), '. Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from Cookbook c