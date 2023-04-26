namespace RecipeSystem
{
    public class Recipe
    {
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
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaffList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
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