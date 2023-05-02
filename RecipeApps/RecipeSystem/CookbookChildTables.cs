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
    }
}
