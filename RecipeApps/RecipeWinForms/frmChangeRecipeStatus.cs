namespace RecipeWinForms
{
    public partial class frmChangeRecipeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        int recipeid = 0;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                this.Close();
            }
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
        }

        private void LoadRecipeForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
            }
            this.Close();
        }

        private void UpdateRecipeStatus(string updatedate)
        {
            try
            {
                DataMaintenance.UpdateRecipeStatus(dtrecipe, updatedate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            if (txtDateArchived.Text == "" && txtDateDrafted.Text != "")
            {
                UpdateRecipeStatus("DateArchived");
            }
            LoadRecipeForm();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            if (txtDateArchived.Text == "" && txtDatePublished.Text == "" && txtDateDrafted.Text != "")
            {
                UpdateRecipeStatus("DatePublished");
            }
            LoadRecipeForm();
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            if (txtDatePublished.Text != "" || txtDateArchived.Text != "")
            {
                UpdateRecipeStatus("DateDrafted");
            }
            LoadRecipeForm();
        }
    }
}
