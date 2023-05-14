namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetAllCookbooks()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void AutoCreate(DataRow row)
        {
            SQLUtility.SaveDataRow(row, "CookbookAutoCreate");
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                //SM this should never fail, but if was called without any rows, it shouldnt crash. As was done in video.
                throw new Exception("Cannot call Cookbook Save method, there were no cookbooks returned from database.");
            }

            DataRow r = dtcookbook.Rows[0];

            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
