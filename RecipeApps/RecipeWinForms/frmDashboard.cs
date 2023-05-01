namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipe.Click += BtnRecipe_Click;
            btnMeal.Click += BtnMeal_Click;
            btnCookbook.Click += BtnCookbook_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            SetLabelText(dt, "Recipes", lblNumberRecipes);
            SetLabelText(dt, "Meals", lblNumberMeals);
            SetLabelText(dt, "Cookbooks", lblNumberCookbooks);
        }

        private void SetLabelText(DataTable dt, string recordtype, Label lbl)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");
            if (rows.Length > 0)
            {
                lbl.Text = rows[0]["DashboardText"].ToString();
            }
        }

        private void BtnCookbook_Click(object? sender, EventArgs e)
        {

        }

        private void BtnMeal_Click(object? sender, EventArgs e)
        {

        }

        private void BtnRecipe_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }
    }
}
