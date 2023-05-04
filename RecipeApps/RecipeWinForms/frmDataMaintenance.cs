namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Staff, Cuisine, Ingredient, Measurement, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Staff;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            SetupRadioButtons();
            BindData(currenttabletype);
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            string msg = "";
            if (id != 0)
            {
                if (currenttabletype == TableTypeEnum.Staff)
                {
                    msg = $"Are you sure you want to delete this user '{dtlist.Rows[rowindex]["Username"]}' with all related Recipes, Meals, and Cookbooks? This cannot be reversed!";
                }
                else
                {
                    msg = $"Are you sure you want to delete this {currenttabletype} with all related records? This cannot be reversed!";
                }
                var res = MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    return;
                }
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.RemoveAt(rowindex);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optStaff.Tag = TableTypeEnum.Staff;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.Measurement;
            optCourse.Tag = TableTypeEnum.Course;
        }

        private bool CloseWithoutSavingChanges(string changedvalue)
        {
            bool close = true;
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {changedvalue} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (!b)
                        {
                            close = false;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        close = false;
                        this.Activate();
                        break;
                    default:
                        break;
                }
            }
            return close;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            RadioButton opt = new();
            string currenttable = currenttabletype.ToString();
            if (sender is RadioButton)
            {
                opt = (RadioButton)sender;
            }
            if (opt.Tag is TableTypeEnum @enum)
            {
                bool close = CloseWithoutSavingChanges(currenttabletype.ToString());
                if (close)
                {
                    BindData(@enum);
                }
                else
                {
                    opt.Checked = false;
                    foreach (Control c in pnlOptionButtons.Controls)
                    {
                        if (c is RadioButton radio)
                        {
                            if (radio.Tag != null)
                            {
                                if (radio.Tag.ToString() == currenttable)
                                {
                                    radio.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bool close = CloseWithoutSavingChanges(this.Text);
            if (!close)
            {
                e.Cancel = true;
            }
        }
    }
}
