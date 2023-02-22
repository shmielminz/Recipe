using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DbManager.SetConnectionString("Server=.\\MSSQLSERVER01;Database=RecipeDB;Trusted_Connection=True;");
        }

        [Test]
        [TestCase("New recipe", 100, "2022-12-31")]
        [TestCase("Another recipe", 200, "2023-01-01")]
        [TestCase("Third recipe", 100, "2022-01-01")]
        public void InsertNewRecipe(string recipename, int calories, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = GetExistingCuisineId();
            int staffid = GetExistingStaffId();
            Assume.That(cuisineid > 0, "No cuisine in DB, can't run test");
            Assume.That(staffid > 0, "No staff in DB, can't run test");

            TestContext.WriteLine("Insert new recipe");

            r["staffid"] = staffid;
            r["cuisineid"] = cuisineid;
            r["recipename"] = recipename;
            r["calories"] = calories;
            r["datedrafted"] = datedrafted;

            Recipe.Save(dt);

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
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = recipename;
            Recipe.Save(dt);

            dtrecipename = SQLUtility.GetDataTable("select recipename from recipe where recipeid = " + recipeid);
            string newrecipename = dtrecipename.Rows[0]["recipename"].ToString();
            Assert.IsTrue(newrecipename == recipename, "Recipe name for recipe (" + recipeid + ") <> " + newrecipename);
            TestContext.WriteLine("Recipe name for recipe (" + recipeid + ") = " + newrecipename);
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
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "Calories for recipe (" + recipeid + ") <> " + calories);
            TestContext.WriteLine("Calories for recipe (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 recipeid, recipename, recipestatus from recipe");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipestatus"] + " recipe " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("Existing recipe " + recipedesc + " with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe " + recipedesc + "with id (" + recipeid + ") Exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
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

            DataTable dt = Recipe.SearchRecipe(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of recipes search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipes search (" + results + ") = " + num);
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