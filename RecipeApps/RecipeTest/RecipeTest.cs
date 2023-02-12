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
    }
}