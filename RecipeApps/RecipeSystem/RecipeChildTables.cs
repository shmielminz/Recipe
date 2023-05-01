namespace RecipeSystem
{
    public class RecipeChildTables
    {
        public static DataTable LoadByRecipeId(string tablename, int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, string tablename, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void Delete(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand($"{tablename}Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
