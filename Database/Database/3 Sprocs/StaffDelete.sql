create or alter proc dbo.StaffDelete(
	@StaffId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)

	begin try
		begin tran
		;with x as(
			select s.StaffId
			from Staff s
			where s.StaffId = @StaffId
		)
		delete cr
		from Recipe r 
		join CookBookRecipe cr 
		on r.RecipeId = cr.RecipeId
		join CookBook c 
		on cr.CookBookId = c.CookBookId
		join x 
		on r.StaffId = @StaffId
		or c.StaffId = @StaffId

		delete CookBook where StaffId = @StaffId

		;with x as(
			select s.StaffId
			from Staff s
			where s.StaffId = @StaffId
		)
		delete mcr
		from Recipe r 
		join MealCourseRecipe mcr
		on r.RecipeId = mcr.RecipeId
		join mealcourse mc   
		on mcr.MealCourseId = mc.MealCourseId
		join meal m 
		on mc.MealId = m.MealId
		join x 
		on r.StaffId = @StaffId
		or m.StaffId = @StaffId


		delete mc 
		from Meal m 
		join MealCourse mc 
		on m.MealId = mc.MealId
		where m.StaffId = @StaffId

		delete Meal where StaffId = @StaffId

		delete rs 
		from Recipe r 
		join RecipeStep rs 
		on r.RecipeId = rs.RecipeId
		where r.StaffId = @StaffId

		delete ri 
		from Recipe r 
		join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		where r.StaffId = @StaffId

		delete Recipe where StaffId = @StaffId

		delete Staff where StaffId = @StaffId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go