using CPUFramework;
using System.Data;
using System.Data.SqlTypes;
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
    }
}