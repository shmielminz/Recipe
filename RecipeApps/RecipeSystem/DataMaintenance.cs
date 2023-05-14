namespace RecipeSystem
{
    public class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSql(cmd);
        }

        public static DataTable GetDashboard()
        {
            return SQLUtility.GetDataTable(SQLUtility.GetSqlCommand("DashboardGet"));
        }

        public static void UpdateRecipeStatus(DataTable dt, string updatedate)
        {
            try
            {
                if (updatedate == "DateDrafted")
                {
                    //Doing -10 milliseconds because looks like the SQLServer getdate() might be off with a millisecond or two, so it throws error.
                    dt.Rows[0]["DateDrafted"] = DateTime.Now.AddMilliseconds(-10);
                    dt.Rows[0]["DatePublished"] = DBNull.Value;
                    dt.Rows[0]["DateArchived"] = DBNull.Value;
                }
                else if (updatedate == "DatePublished")
                {
                    dt.Rows[0]["DatePublished"] = DateTime.Now.AddMilliseconds(-10);
                }
                else if (updatedate == "DateArchived")
                {
                    dt.Rows[0]["DateArchived"] = DateTime.Now.AddMilliseconds(-10);
                }
            }
            catch
            {
                //AF What does this error mean and when can this happen?
                throw new Exception("Cannot update date fields, wrong table was sent to system.");
            }
            Recipe.Save(dt);
        }
    }
}
