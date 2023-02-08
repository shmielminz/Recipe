using CPUFramework;
using System.Data;

namespace RecipeSystem
{
    public class DbManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.ConnectionString = connectionstring;
        }
    }
}
