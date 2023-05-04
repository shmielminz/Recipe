--AS: Amazing job!! 100%
use RecipeDB
go

drop table if exists RecipeStep
drop table if exists RecipeIngredient
drop table if exists Ingredient
drop table if exists Measurement
drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course
drop table if exists Recipe
drop table if exists Cuisine
drop table if exists Staff
go


create table dbo.Staff(
    StaffId int not null identity primary key,
    FirstName varchar(25) not null constraint ck_Staff_first_name_cannot_be_blank check(FirstName > ''),
    LastName varchar(25) not null constraint ck_Staff_last_name_cannot_be_blank check(LastName > ''),
    Username varchar(50) not null
        constraint ck_Staff_username_cannot_be_blank check(Username > '')
        constraint u_Staff_username unique
)
go

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(25) not null
        constraint ck_Cuisine_type_cannot_be_blank check(CuisineType > '')
        constraint u_Cuisine_CuisineType unique
)
go

create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementType varchar(10) not null
        constraint ck_Measurement_type_cannot_be_blank check(MeasurementType > '')
        constraint u_Measurement_MeasurementType unique,
)
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    Ingredient varchar(25) not null
        constraint ck_Ingredient_ingredient_cannot_be_blank check(Ingredient > '')
        constraint u_Ingredient_Ingredient unique,
    ImageName as concat('Ingredient-', replace(Ingredient,' ','-'), '.jpg') persisted
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    StaffId int not null constraint f_Staff_Recipe foreign key references Staff(StaffId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(100) not null
        constraint ck_Recipe_recipe_name_cannot_be_blank check(RecipeName > '')
        constraint u_Recipe_RecipeName unique,
    Calories int not null constraint ck_Recipe_calories_must_be_greater_than_0 check(Calories > 0),
    DateDrafted datetime not null default getdate()
        constraint ck_Recipe_date_drafted_must_be_between_31_12_2021_and_today check(DateDrafted between '2021-12-31' and getdate()),
    DatePublished datetime,
    DateArchived datetime,
    ImageName as concat('Recipe-',replace(RecipeName,' ','-'),'.jpg') persisted,
    RecipeStatus as case when DateArchived is not null then 'Archived' else case when DatePublished is not null then 'Published' else 'Drafted' end end,
    constraint ck_DatePublished_must_be_between_DateDrafted_and_today check(DatePublished between DateDrafted and getdate()),
    constraint ck_DateArchived_must_be_between_DateDrafted_and_today_and_after_DatePublished 
        check(DateArchived between case when DatePublished is null then DateDrafted else DatePublished end and getdate())
)
go

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    MeasurementId int null constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    SequenceVal int not null constraint ck_RecipeIngredient_sequence_must_be_greater_than_0 check(SequenceVal > 0),
    MeasurementQty decimal(4,2) not null constraint ck_RecipeIngredient_qty_must_be_greater_than_0 check(MeasurementQty > 0),
    SpecialInstruction varchar(50) not null default '',
    constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId,IngredientId)
)
go


create table dbo.RecipeStep(
    RecipeStepId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeStep foreign key references Recipe(RecipeId),
    SequenceVal int not null constraint ck_RecipeStep_sequence_must_be_greater_than_0 check(SequenceVal > 0),
    Instruction varchar(200) not null constraint ck_RecipeStep_instruction_cannot_be_blank check(Instruction > ''),
    constraint u_RecipeStep_RecipeId_SequenceVal unique(RecipeId,SequenceVal)
)
go

create table dbo.Course(
    CourseId int not null identity primary key,
    SequenceVal int not null 
		constraint ck_Course_sequence_must_be_greater_than_0 check(SequenceVal > 0)
		constraint u_Course_SequenceVal unique,
    CourseName varchar(20) not null
        constraint ck_Course_name_cannot_be_blank check(CourseName > '')
        constraint u_Course_CourseName unique
)
go

create table dbo.Meal(
    MealId int not null identity primary key,
    StaffId int not null constraint f_Staff_Meal foreign key references Staff(StaffId),
    MealName varchar(100) not null
        constraint ck_Meal_name_cannot_be_blank check(MealName > '')
        constraint u_Meal_MealName unique,
    Active bit not null default 1,
    DateCreated date not null default getdate() constraint ck_Meal_DateCreated_must_be_between_31_12_2021_and_today check(DateCreated between '2021-12-31' and getdate()),
    ImageName as concat('Meal-',replace(MealName,' ','-'),'.jpg') persisted
)
go

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealCourse_MealId_CourseId unique(MealId,CourseId)
)
go

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null,
    constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId,RecipeId)
)
go

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    StaffId int not null constraint f_Staff_Cookbook foreign key references Staff(StaffId),
    CookbookName varchar(50) not null
        constraint ck_Cookbook_name_cannot_be_blank check(CookbookName > '')
        constraint u_Cookbook_CookbookName unique,
    Price decimal(5,2) not null constraint ck_Cookbook_price_must_be_greater_than_0 check(Price > 0),
    Active bit not null default 1,
    DateCreated date not null default getdate() constraint ck_Cookbook_DateCreated_must_be_between_31_12_2021_and_today check(DateCreated between '2021-12-31' and getdate()),
    ImageName as concat('Cookbook-',replace(CookbookName,' ','-'),'.jpg') persisted
)
go

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    SequenceVal int not null constraint ck_CookbookRecipe_sequence_must_be_greater_than_0 check(SequenceVal > 0),
    constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId,RecipeId),
    constraint u_CookbookRecipe_CookbookId_SequenceVal unique(CookbookId,SequenceVal)
)