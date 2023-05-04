namespace RecipeWinForms
{
    public partial class frmCookbookAutoCreate : Form
    {
        DataTable dtstaff = new();
        public frmCookbookAutoCreate()
        {
            InitializeComponent();
            btnCreate.Click += BtnCreate_Click;
            BindForm();
        }

        private void BindForm()
        {
            dtstaff = Recipe.GetStaffList(true);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, null, "Staff");
        }

        private void CreateCookbook()
        {
            DataTable dt = Cookbook.Load(0);
            dt.Rows.Add();
            DataRow row = dt.Rows[0];
            int staffid = WindowsFormsUtility.GetIdFromComboBox(lstUsername);
            row["StaffId"] = staffid;
            Cookbook.AutoCreate(row);
            int cookbookid = (int)row["CookbookId"];
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), cookbookid);
            }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
            this.Close();
        }
    }
}
