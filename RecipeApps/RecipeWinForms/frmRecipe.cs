namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if(recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtstaff = Recipe.GetStaffList();
            DataTable dtcuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, dtrecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
