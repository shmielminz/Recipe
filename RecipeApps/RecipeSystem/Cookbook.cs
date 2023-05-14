namespace RecipeSystem
{
    public class Cookbook
    {
        //AF I'd rename this - it seems to be getting all cookbooks, not searching
        public static DataTable SearchCookbook()
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
                //AF When would this error happen?
            {
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
