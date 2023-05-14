namespace RecipeSystem
{
    public class Recipe
    {
        /*AF I don't see any search functionality in your application.  If that is the case, I would remove the paramater to pass in recipename,
         as you are never actually passing in a recipe name.  Then you can take out the 'else' statement.  And it would be good to rename the procedure
        to what it's doing - it's just getting a list of all recipes, not searching */
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            if (recipename == "")
            {
                SQLUtility.SetParamValue(cmd, "@All", 1);
            }
            else
            {
                SQLUtility.SetParamValue(cmd, "@RecipeName", recipename);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDetailsGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaffList(bool includeblank = false)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank) {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeDesc()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDetailsGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void CloneRecipe(DataRow row)
        {
            SQLUtility.SaveDataRow(row, "CloneRecipe");
        }

        public static void Save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method, there were no recipes returned from database.");
            }
            
            DataRow r = dtrecipe.Rows[0];

            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}