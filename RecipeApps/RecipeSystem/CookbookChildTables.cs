namespace RecipeSystem
{
    public class CookbookChildTables
    {
        public static DataTable LoadByCookbookId(int cookbookid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookRecipeId", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
