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
            this.Activated += FrmChangeRecipeStatus_Activated;
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
                foreach (Form f in Application.OpenForms)
                {
                    if (f is frmRecipe)
                    {
                        ((frmRecipe)f).bindsource.DataSource = Recipe.Load(recipeid);
                    }
                }
            }
            this.Close();
        }

        private void UpdateRecipeStatus(string updatedate)
        {
            var res = MessageBox.Show($"Are you sure you want to chnge status of {lblRecipeName.Text} to {updatedate.Substring(4)}?", Application.ProductName, MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    DataMaintenance.UpdateRecipeStatus(dtrecipe, updatedate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                LoadRecipeForm();
            }
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            if (txtDateArchived.Text == "" && txtDateDrafted.Text != "")
            {
                UpdateRecipeStatus("DateArchived");
            }
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            if (txtDateArchived.Text == "" && txtDatePublished.Text == "" && txtDateDrafted.Text != "")
            {
                UpdateRecipeStatus("DatePublished");
            }
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            if (txtDatePublished.Text != "" || txtDateArchived.Text != "")
            {
                UpdateRecipeStatus("DateDrafted");
            }
        }

        private void FrmChangeRecipeStatus_Activated(object? sender, EventArgs e)
        {
            switch (lblRecipeStatus.Text)
            {
                case "Drafted":
                    btnDraft.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    btnPublish.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
