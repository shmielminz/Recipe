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
            this.FormClosing += FrmCookbook_FormClosing;
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
            SetButtonsEnabledBasedOnNewRecord();
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

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDescription();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
            var res = MessageBox.Show($"Are you sure you want to delete this {GetCookbookDescription()} with all it's related records?", Application.ProductName, MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookChildTables.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipes(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "CookbookRecipeId");
            if (id != 0)
            {
                try
                {
                    CookbookChildTables.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipes.Rows.Count)
            {
                gRecipes.Rows.RemoveAt(rowindex);
            }
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

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gRecipes.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteCookbookRecipes(e.RowIndex);
            }
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (!b)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
