using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
            string sql;
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            var datedrafted = ((DateTime)r["DateDrafted"]).ToString("yyyy-MM-dd h:mm");
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                        $"update Recipe set",
                        $"StaffId = {r["StaffId"]},",
                        $"CuisineId = {r["CuisineId"]},",
                        $"RecipeName = '{r["RecipeName"]}',",
                        $"Calories = {r["Calories"]},",
                        $"DateDrafted = '{datedrafted}'",
                        $"where RecipeId = {r["RecipeId"]}"
                    );
            }
            else
            {
                sql = "insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted)";
                sql += $"select {r["StaffId"]},{r["CuisineId"]},'{r["RecipeName"]}',{r["Calories"]},'{datedrafted}'";
            }
            Debug.Print(sql);
            SQLUtility.ExecuteSql(sql);
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