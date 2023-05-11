namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipestep = new();
        public BindingSource bindsource = new();
        int recipeid = 0;
        string deletecolname = "deletecol";
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmRecipe_FormClosing;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if(recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtstaff = Recipe.GetStaffList();
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUsername, dtstaff, dtrecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            this.Text = GetRecipeDescription();
            LoadRecipeIngredients();
            LoadRecipeSteps();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeChildTables.LoadByRecipeId("RecipeIngredient", recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "Ingredient");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Measurement", true), "Measurement", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            
        }

        private void LoadRecipeSteps()
        {
            dtrecipestep = RecipeChildTables.LoadByRecipeId("RecipeStep", recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipestep;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "RecipeStep");
        }

        private void LoadChildTable(DataTable dt)
        {
            if (dt == dtrecipeingredient)
            {
                LoadRecipeIngredients();
            }
            else if (dt == dtrecipestep)
            {
                LoadRecipeSteps();
            }
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDescription();
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
            var response = MessageBox.Show($"Are you sure you want to delete this '{this.Text}' with all related records?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
        }

        private string GetRecipeDescription()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void SaveRecipeChildTable(DataTable dt, string tablename, int id)
        {
            try
            {
                RecipeChildTables.SaveTable(dt, tablename, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeChildTable(DataGridView grid, int rowindex, DataTable dt, string tablename)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(grid, rowindex, $"{tablename}Id");
            if (id != 0)
            {
                try
                {
                    RecipeChildTables.Delete(tablename, id);
                    LoadChildTable(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < grid.Rows.Count)
            {
                grid.Rows.RemoveAt(rowindex);
            }
        }

        private void SaveRecipeIngredients()
        {
            SaveRecipeChildTable(dtrecipeingredient, "RecipeIngredient", recipeid);
        }

        private void SaveRecipeSteps()
        {
            SaveRecipeChildTable(dtrecipestep, "RecipeStep", recipeid);
        }

        private void DeleteRecipeIngredients(int rowindex)
        {
            DeleteRecipeChildTable(gIngredients, rowindex, dtrecipeingredient, "RecipeIngredient");
        }

        private void DeleteRecipeSteps(int rowindex)
        {
            DeleteRecipeChildTable(gSteps, rowindex, dtrecipestep, "RecipeStep");
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeSteps(e.RowIndex);
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeIngredients(e.RowIndex);
            }
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus),recipeid);
            }
            //bindsource.DataSource = Recipe.Load(recipeid);
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to '{this.Text}' before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
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
