namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNew.Click += BtnNew_Click;
            gCookbooks.CellDoubleClick += GCookbooks_CellDoubleClick;
            this.Activated += FrmCookbookList_Activated;
            WindowsFormsUtility.FormatGridForSearchResults(gCookbooks, "Cookbook");
        }

        private void LoadData()
        {
            DataTable dt = Cookbook.SearchCookbook();
            gCookbooks.DataSource = dt;
            gCookbooks.Columns["CookbookId"].Visible = false;
            gCookbooks.Columns["StaffId"].Visible = false;
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbooks, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void GCookbooks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
    }
}
