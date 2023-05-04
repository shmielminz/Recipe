using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindForm();
        }

        private void BindForm()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            DataTable dtmeal = SQLUtility.GetDataTable(cmd);
            gMeal.DataSource = dtmeal;
            WindowsFormsUtility.FormatGridForSearchResults(gMeal, "Meal");
        }
    }
}
