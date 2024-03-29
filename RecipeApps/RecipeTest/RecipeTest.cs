namespace RecipeTest
{
    public class Tests
    {
        //string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DbManager.SetConnectionString(testconnstring, true);
        }

        [Test]
        [TestCase("New recipe", 100, "2022-12-31")]
        [TestCase("Another recipe", 200, "2023-01-01")]
        [TestCase("Third recipe", 100, "2022-01-01")]
        public void InsertNewRecipe(string recipename, int calories, DateTime datedrafted)
        {
            int cuisineid = GetExistingCuisineId();
            int staffid = GetExistingStaffId();
            Assume.That(cuisineid > 0, "No cuisine in DB, can't run test");
            Assume.That(staffid > 0, "No staff in DB, can't run test");

            TestContext.WriteLine("Insert new recipe");
            bizRecipe recipe = new();

            recipe.StaffId = staffid;
            recipe.CuisineId = cuisineid;
            recipe.RecipeName = recipename;
            recipe.Calories = calories;
            recipe.DateDrafted = datedrafted;

            recipe.Save();

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe where recipename = '" + recipename + "'");
            Assert.IsTrue(newid > 0, "Recipe with recipename (" + recipename + ") is not in DB");
            TestContext.WriteLine("Recipe with recipename (" + recipename + ") is found in DB");
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            DataTable dtrecipename = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            string recipename = dtrecipename.Rows[0]["recipename"].ToString();
            TestContext.WriteLine("Recipe name for recipeid (" + recipeid + ") = " + recipename);
            recipename += " - clone";
            TestContext.WriteLine("Changed recipe name to " + recipename);
            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = recipename;
            recipe.Save(dt);

            dtrecipename = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            string newrecipename = dtrecipename.Rows[0]["recipename"].ToString();
            Assert.IsTrue(newrecipename == recipename, "Recipe name for recipe (" + recipeid + ") <> " + newrecipename);
            TestContext.WriteLine("Recipe name for recipe (" + recipeid + ") = " + newrecipename);
        }

        [Test]
        public void ChangeExistingRecipeNameToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            DataTable dtrecipename = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            DataTable dtexistingrecipename = SQLUtility.GetDataTable("select top 1 recipename from recipe where recipeid <> " + recipeid);
            string recipename = dtrecipename.Rows[0]["recipename"].ToString();
            string existingrecipename = dtexistingrecipename.Rows[0]["recipename"].ToString();
            TestContext.WriteLine("Changed recipe name " + recipename + " to other existing recipe name " + existingrecipename);
            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = existingrecipename;
            Exception ex = Assert.Throws<Exception>(()=> recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Recipe calories for recipeid (" + recipeid + ") = " + calories);
            calories += 100;
            TestContext.WriteLine("Changed calories to " + calories);
            bizRecipe recipe = new();
            recipe.Load(recipeid);

            recipe.Calories = calories;
            recipe.Save();

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "Calories for recipe (" + recipeid + ") <> " + calories);
            TestContext.WriteLine("Calories for recipe (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void ChangeExistingRecipeCaloriesToInvalidRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Recipe calories for recipeid (" + recipeid + ") = " + calories);
            calories = 0;
            TestContext.WriteLine("Changed calories to " + calories);
            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipe without meal and cookbook or no archived recipes for more than 30 days in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe " + recipedesc + "with id (" + recipeid + ") Exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeById()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipe without meal and cookbook or no archived recipes for more than 30 days in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);
            bizRecipe recipe = new();
            recipe.Delete(recipeid);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe " + recipedesc + "with id (" + recipeid + ") Exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeByDataTable()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipe without meal and cookbook or no archived recipes for more than 30 days in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);
            bizRecipe recipe = new();
            recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe " + recipedesc + "with id (" + recipeid + ") Exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeletePublishedRecipe()
        {
            string sql = @"select top 1 r.recipeid, r.recipename, r.recipestatus 
                        from recipe r
                        left join mealcourserecipe mcr
                        on mcr.recipeid = r.recipeid
                        left join cookbookrecipe cr
                        on cr.recipeid = r.recipeid
                        where mcr.mealcourserecipeid is null
                        and cr.cookbookrecipeid is null
                        and r.RecipeStatus = 'Published'
                        order by r.recipeid";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No Published or non relational recipe in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeThatsArchivedLessThan30Days()
        {
            string sql = @"select top 1 r.recipeid, r.recipename, r.recipestatus 
                        from recipe r
                        left join mealcourserecipe mcr
                        on mcr.recipeid = r.recipeid
                        left join cookbookrecipe cr
                        on cr.recipeid = r.recipeid
                        where mcr.mealcourserecipeid is null
                        and cr.cookbookrecipeid is null
                        and datediff(day,r.DateArchived,getdate()) <= 30
                        and r.RecipeStatus = 'Archived'
                        order by r.recipeid";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No non relational recipe in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid + " that has been archived for less than 30 days.");
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeWithMealCourseRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, recipestatus from recipe r join mealcourserecipe mcr on mcr.recipeid = r.recipeid where r.RecipeStatus <> 'published'");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No mealcourse with recipe in DB, can't run test");
            TestContext.WriteLine("Existing meal course recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);
            Exception ex = Assert.Throws<Exception>(()=> Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeWithCookbookRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, recipestatus from recipe r join cookbookrecipe cr on r.recipeid = cr.recipeid");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No cookbook with recipe in DB, can't run test");
            TestContext.WriteLine("Existing cookbook recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            Assert.IsTrue(loadedid == recipeid, "Id returned by app (" + loadedid + ") <> " + recipeid);
            TestContext.WriteLine("Loaded recipe with id = " + loadedid);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "a";
            int num = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from recipe where recipename like '%{criteria}%'");
            Assume.That(num > 0, "No recipes that match the search for " + criteria);
            TestContext.WriteLine(num + " recipes that match '" + criteria + "' criteria");
            TestContext.WriteLine("Ensure that recipes search returns " + num + " rows");

            bizRecipe recipe = new();
            List<bizRecipe> lst = recipe.Search(criteria);
            int results = lst.Count;

            Assert.IsTrue(results == num, "Results of recipes search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipes search (" + results + ") = " + num);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank)
            {
                recipecount++;
            }
            Assume.That(recipecount > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + recipecount);
            bizRecipe recipe = new();
            var lst = recipe.GetList(includeblank);
            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of rows in recipes returned by app = " + lst.Count);
        }

        [Test]
        public void SearchIngredient()
        {
            string criteria = "apple";
            int num = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from Ingredient where Ingredient like '%{criteria}%'");
            Assume.That(num > 0, "No ingredients that match the search for " + criteria);
            TestContext.WriteLine(num + " ingredients that match '" + criteria + "' criteria");
            TestContext.WriteLine("Ensure that ingredients search returns " + num + " rows");

            bizIngredient ingredient = new();
            List<bizIngredient> lst = ingredient.Search(criteria);
            int results = lst.Count;

            Assert.IsTrue(results == num, "Results of ingredients search does not match number of ingredients, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by ingredient search (" + results + ") = " + num);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank)
            {
                ingredientcount++;
            }
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't test");
            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + ingredientcount);
            bizIngredient ingredient = new();
            var lst = ingredient.GetList(includeblank);
            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of rows in ingredients returned by app = " + lst.Count);
        }

        [Test]
        public void GetListOfStaff()
        {
            int staffcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from staff");
            Assume.That(staffcount > 0, "No staff members in DB, can't test");
            TestContext.WriteLine("Num of staff members in DB = " + staffcount);
            TestContext.WriteLine("Ensure that num of staff members returned by app are " + staffcount);
            DataTable dt = Recipe.GetStaffList();
            Assert.IsTrue(dt.Rows.Count == staffcount, "Num of staff members returned by app (" + dt.Rows.Count + ") <> " + staffcount);
            TestContext.WriteLine("Num of rows returned by app = " + staffcount);
        }

        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisine members in DB, can't test");
            TestContext.WriteLine("Num of cuisine members in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of cuisine members returned by app are " + cuisinecount);
            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinecount, "Num of cuisine members returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Num of rows returned by app = " + cuisinecount);
        }

        private DataTable GetRecipeForDelete()
        {
            string sql = @"select top 1 r.recipeid, r.recipename, r.recipestatus 
                        from recipe r
                        left join mealcourserecipe mcr
                        on mcr.recipeid = r.recipeid
                        left join cookbookrecipe cr
                        on cr.recipeid = r.recipeid
                        where mcr.mealcourserecipeid is null
                        and cr.cookbookrecipeid is null
                        and ((r.DateArchived is not null
                        and datediff(day,r.DateArchived,getdate()) >= 30)
                        or r.Recipestatus = 'Drafted')
                        order by r.recipeid";
            return SQLUtility.GetDataTable(sql);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

        private int GetExistingCuisineId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
        }

        private int GetExistingStaffId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 staffid from staff");
        }
    }
}