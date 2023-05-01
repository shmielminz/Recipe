namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        public frmCloneRecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            this.Activated += FrmCloneRecipe_Activated;
        }

        private void FrmCloneRecipe_Activated(object? sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            dtrecipe = Recipe.GetRecipeDesc();
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetListBinding(lstRecipeDesc, dtrecipe, null, "Recipe");
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            DataRow row = dtrecipe.Rows[lstRecipeDesc.SelectedIndex];
            Recipe.CloneRecipe(row);
            int newid = (int)row["RecipeId"];
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newid);
            }
        }
    }
}
