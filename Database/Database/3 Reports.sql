--AS Amazinng job!! 100%
use RecipeDB
go
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.

Home Page
    One resultset with number of recipes, meals, and cookbooks
*/
select NumOfRecipes = count(distinct r.RecipeId), NumOfMeals = count(distinct m.MealId), NumOfCookbooks = count(distinct c.CookbookId)
from Recipe r
cross join Meal m
cross join Cookbook c
/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
*/
select 
    RecipeName = case r.RecipeStatus when 'Archived' then concat('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, 
    r.RecipeStatus, 
    DatePublished = isnull(convert(varchar(10),r.DatePublished,23),''),
    DateArchived = isnull(convert(varchar(10),r.DateArchived,23),''),
    s.Username,
    r.Calories, 
    NumOfIngredients = count(*)
from Staff s
join Recipe r
on s.StaffId = r.StaffId
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
where r.RecipeStatus in('Published','Archived')
group by r.RecipeStatus, r.RecipeName, r.DatePublished, r.DateArchived, r.Calories, s.Username
order by r.RecipeStatus desc, r.RecipeName
/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
-- SM left image name as it's for specific recipe
--AS Yes but that is not one of the columns specified. Same below
select r.RecipeName, r.Calories, NumOfIngredients = count(distinct ri.RecipeIngredientId), NumOfSteps = count(distinct rs.RecipeStepId), r.ImageName
from Recipe r
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
join RecipeStep rs
on r.RecipeId = rs.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
group by r.RecipeName, r.Calories, r.ImageName

select Ingredient = concat(ri.MeasurementQty,' ',m.MeasurementType,' ', i.Ingredient), i.ImageName
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on i.IngredientId = ri.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by ri.SequenceVal

select rs.SequenceVal, rs.Instruction
from Recipe r
join RecipeStep rs
on r.RecipeId = rs.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by rs.SequenceVal

/*
Meal list page:
    All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, s.Username, TotalCalories = sum(r.Calories), NumOfCourses = count(distinct mc.CourseId), NumOfRecipes = count(distinct mcr.RecipeId)
from Staff s
join Meal m
on m.StaffId = s.StaffId
join MealCourse mc
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
where m.Active = 1
group by m.MealName, s.Username
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
*/
-- SM left image name as it's for specific meal
select m.MealName, s.Username, m.DateCreated, m.ImageName
from Staff s
join Meal m
on m.StaffId = s.StaffId
where m.MealName = 'Super Supper'
/*
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select MealRecipe = concat(
    case when c.CourseName = 'Main' and mcr.MainDish = 1 then '<b>' end,
    c.CourseName,
    ': ',
    case c.CourseName when 'Main' then case mcr.MainDish when 1 then 'Main' else 'Side' end + ' dish - ' end,
    r.RecipeName,
    case when c.CourseName = 'Main' and mcr.MainDish = 1 then '</b>' end)
from Meal m
join MealCourse mc
on m.MealId = mc.MealId
join Course c
on c.CourseId = mc.CourseId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join Recipe r
on r.RecipeId = mcr.RecipeId
where m.MealName = 'Super Supper'
/*

Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, s.Username, NumOfRecipes = count(*)
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
join CookbookRecipe cr
on cr.CookbookId = c.CookbookId
where c.Active = 1
group by c.CookbookName, s.Username
order by c.CookbookName
/*

Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
*/
-- SM left image name as it's for specific cookbook
select c.CookbookName, s.Username, c.DateCreated, c.Price, NumOfRecipes = count(*), c.ImageName
from Staff s
join Cookbook c
on c.StaffId = s.StaffId
join CookbookRecipe cr
on cr.CookbookId = c.CookbookId
where c.CookbookName = 'Eat to Live'
group by c.CookbookName, s.Username, c.DateCreated, c.Price, c.ImageName
/*
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
select 
    r.RecipeName, 
    c.CuisineType, 
    NumOfIngredients = count(distinct ri.RecipeIngredientId), 
    NumOfSteps = count(distinct rs.RecipeStepId), 
    b.ImageName
from Cookbook b
join CookbookRecipe cr
on cr.CookbookId = b.CookbookId
join Recipe r
on r.RecipeId = cr.RecipeId
join Cuisine c
on c.CuisineId = r.CuisineId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join RecipeStep rs
on rs.RecipeId = r.RecipeId
where b.CookbookName = 'Eat to Live'
group by r.RecipeName, c.CuisineType, b.ImageName, cr.SequenceVal
order by cr.SequenceVal
go
/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. 
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
*/
--AS Wow nice for using functions!!
create or alter function dbo.ProperCase(@Value varchar(100))
returns varchar(100)
as
begin
    declare @Reset bit,
        @ReturnValue varchar(100),
        @Counter int,
        @Char char(1)

    if @Value is null
    return null

    select @Reset = 1, @Counter = 1, @ReturnValue = ''

    while (@Counter < len(@Value) + 1)
    begin
        select @Char = substring(@Value, @Counter, 1),
        @ReturnValue += case when @Reset = 1 then upper(@Char) else lower(@Char) end,
        @Reset = case when @Char like '[a-z]' then 0 else 1 end,
        @Counter += 1
    end
    return @ReturnValue
end
go
select RecipeName = dbo.ProperCase(reverse(r.RecipeName)), ImageName = dbo.ProperCase(reverse(replace(r.RecipeName,' ','-'))) + '.jpg'
from Cookbook c
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
join Recipe r
on r.RecipeId = cr.RecipeId
/*
    b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, 
        and a list of the last step in each recipe in the system
*/
;with x as(
    select r.RecipeName, Step = max(rs.SequenceVal), Ingredient = min(ri.SequenceVal)
    from Recipe r
    join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    join Measurement m
    on m.MeasurementId = ri.MeasurementId
    join Ingredient i
    on i.IngredientId = ri.IngredientId
    join RecipeStep rs
    on rs.RecipeId = r.RecipeId
    where r.RecipeName = 'Chocolate Chip Cookies'
    group by r.RecipeName
)
select RecipeName = dbo.ProperCase(reverse(r.RecipeName)), ri.MeasurementQty, m.MeasurementType, i.Ingredient, rs.Instruction, ImageName = dbo.ProperCase(reverse(replace(r.RecipeName,' ','-'))) + '.jpg'
from x
join Recipe r
on r.RecipeName = x.RecipeName
join RecipeIngredient ri
on ri.SequenceVal = x.Ingredient
and r.RecipeId = ri.RecipeId
join RecipeStep rs
on rs.SequenceVal = x.Step
and r.RecipeId = rs.RecipeId
join Ingredient i
on i.IngredientId = ri.IngredientId
join Measurement m
on m.MeasurementId = ri.MeasurementId
/*
For site administration page:
--5 seperate reports
*/

-- a) List of how many recipes each user created per status. Show 0 if none
select s.Username, RecipeStatus = isnull(r.RecipeStatus,''), NumOfRecipes = count(r.RecipeId)
from Staff s
left join Recipe r
on r.StaffId = s.StaffId
group by s.Username, r.RecipeStatus

-- b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select s.Username, NumOfRecipes = count(*), AvgDaysToPublish = avg(datediff(day,r.DateDrafted,r.DatePublished))
from Staff s
join Recipe r
on s.StaffId = r.StaffId
group by s.Username

-- c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
select s.Username, NumOfMeals = count(m.MealId), Active = case when m.Active is not null then case m.Active when 1 then 'Active' else 'Inavtive' end else '' end
from Staff s
left join Meal m
on s.StaffId = m.StaffId
group by s.Username, m.Active

-- d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
select s.Username, NumOfCookbooks = count(c.CookbookId), Active = case when c.Active is not null then case c.Active when 1 then 'Active' else 'Inavtive' end else '' end
from Staff s
left join Cookbook c
on s.StaffId = c.StaffId
group by s.Username, c.Active

-- e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, NumOfDaysDrafted = datediff(day,r.DateDrafted,r.DateArchived)
from Recipe r
where r.DatePublished is null
and r.RecipeStatus = 'Archived'

/*
For user dashboard page:
*/
-- a) Show number of the user's recipes, meals and cookbooks. 
select s.Username, NumOfRecipes = count(distinct r.RecipeId), NumOfMeals = count(distinct m.MealId), NumOfCookbooks = count(distinct c.CookbookId)
from Staff s
left join Recipe r
on r.StaffId = s.StaffId
left join Meal m
on m.StaffId = s.StaffId
left join Cookbook c
on c.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'
group by s.Username
-- b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
select 
    s.Username, 
    r.RecipeName, 
    r.RecipeStatus, 
    HoursInCurrentStatus = 
        datediff(hour,
        case r.RecipeStatus when 'Published' then r.DateDrafted when 'Archived' then isnull(r.DatePublished,r.DateDrafted) end,
        case r.RecipeStatus when 'Published' then r.DatePublished when 'Archived' then r.DateArchived end)
from Staff s
join Recipe r
on r.StaffId = s.StaffId
where s.Username = 'mike@heartyhearth.com'

-- c) Count of their recipes per cuisine. Show 0 for none.
select s.Username, CuisineType = isnull(c.CuisineType,''), NumOfRecipes = count(r.RecipeId)
from Staff s
left join Recipe r
on s.StaffId = r.StaffId
left join Cuisine c
on r.CuisineId = c.CuisineId 
where s.Username = 'mike@heartyhearth.com'
group by s.Username, c.CuisineType