using CPUFramework;
using System.Data;

namespace RecipeSystem
{
    public class DbManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen, string userid = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionstring, tryopen, userid, password);
        }
    }
}
