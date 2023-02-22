using CPUFramework;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            if (recipename == "")
            {
                cmd.Parameters["@All"].Value = 1;
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaffList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("StaffGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "set dateformat dmy;";
            if (id > 0)
            {
                sql += string.Join(Environment.NewLine,
                        "set dateformat dmy;",
                        $"update Recipe set",
                        $"StaffId = {r["StaffId"]},",
                        $"CuisineId = {r["CuisineId"]},",
                        $"RecipeName = '{r["RecipeName"]}',",
                        $"Calories = {r["Calories"]},",
                        $"DateDrafted = '{r["DateDrafted"]}'",
                        $"where RecipeId = {r["RecipeId"]}"
                    );
            }
            else
            {
                sql += "insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted)";
                sql += $"select {r["StaffId"]},{r["CuisineId"]},'{r["RecipeName"]}',{r["Calories"]},'{r["DateDrafted"]}'";
            }
            Debug.Print(sql);
            SQLUtility.ExecuteSql(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = $"delete recipeingredient where recipeid = {id}; delete mealcourserecipe where recipeid = {id}; delete cookbookrecipe where recipeid = {id}; delete recipestep where recipeid = {id}; delete Recipe where RecipeId = {id}";
            SQLUtility.ExecuteSql(sql);
        }
    }
}