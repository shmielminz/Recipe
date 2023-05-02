namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();
        int cookbookid = 0;
        string deletecolname = "deletecol";
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gRecipes.CellContentClick += GRecipes_CellContentClick;
            this.Activated += FrmCookbook_Activated;
        }

        private void FrmCookbook_Activated(object? sender, EventArgs e)
        {
            bindsource.DataSource = Cookbook.Load(cookbookid);
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtstaff = Recipe.GetStaffList();
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(chkActive, bindsource);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, dtcookbook, "Staff");
            this.Text = GetCookbookDescription();
            LoadCookbookRecipes();
        }

        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = CookbookChildTables.LoadByCookbookId(cookbookid);
            gRecipes.Columns.Clear();
            gRecipes.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "CookbookRecipe");
        }

        private string GetCookbookDescription()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {

        }

        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
