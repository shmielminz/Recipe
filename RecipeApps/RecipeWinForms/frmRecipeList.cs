namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            this.Activated += FrmRecipeList_Activated;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "Recipe");
        }

        private void SearchForRecipe(string recipe)
        {
            DataTable dt = Recipe.SearchRecipe(recipe);
            gRecipes.DataSource = dt;
            gRecipes.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            SearchForRecipe("");
        }
    }
}
