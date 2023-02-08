using CPUFramework;
using System.Data;
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
            string sql = "select r.RecipeId, r.RecipeName, r.Calories, r.RecipeStatus from Recipe r where r.RecipeName like '%" + recipename + "%'";
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, c.CuisineType, s.Username from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Staff s on s.StaffId = r.StaffId where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetStaffList()
        {
            return SQLUtility.GetDataTable("select StaffId, Username from Staff");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
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
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
        }
    }
}