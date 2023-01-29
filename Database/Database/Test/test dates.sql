use RecipeDB
go
-- Test dates
-- Recipe, Meal, Cookbook

insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, dateadd(day,1,getdate()), getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100,  getdate(),dateadd(day,1,getdate()),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, getdate(),getdate(), dateadd(day,1,getdate())
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, '2021-12-30', getdate(),getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, '2021-12-31', '2021-12-30',getdate()
go
insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'),(select c.CuisineId from Cuisine c where c.CuisineType = 'American'),'A lovely recipe', 100, '2021-12-31', null,'2021-12-30'
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A new meal', 1,'2021-12-30'
go
insert Meal(StaffId,MealName,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A new meal', 1,dateadd(day,1,getdate())
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', 10, 1, '2021-12-30'
go
insert Cookbook(StaffId,CookbookName,Price,Active,DateCreated)
select (select s.StaffId from Staff s where s.Username = 'johnsmith@heartyhearth.com'), 'A fun cookbook', 10, 1, dateadd(day,1,getdate())
go