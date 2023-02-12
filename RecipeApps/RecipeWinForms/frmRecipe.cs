using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;
using CPUWindowsFormFramework;

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
            string sql = "select r.*, c.CuisineType, s.Username from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Staff s on s.StaffId = r.StaffId where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if(recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtstaff = SQLUtility.GetDataTable("select StaffId, Username from Staff");
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
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
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql;
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                        "set dateformat dmy;",
                        $"update Recipe set",
                        $"StaffId = {r["StaffId"]},",
                        $"CuisineId = {r["CuisineId"]},",
                        $"RecipeName = '{r["RecipeName"]}',",
                        $"Calories = {r["Calories"]},",
                        $"DateDrafted = '{r["DateDrafted"]}'",
                        $"where RecipeId = {r["RecipeId"]}"
                    );
            }
            else
            {
                sql = "insert Recipe(StaffId,CuisineId,RecipeName,Calories,DateDrafted)";
                sql += $"select {r["StaffId"]},{r["CuisineId"]},'{r["RecipeName"]}',{r["Calories"]},'{r["DateDrafted"]}'";
            }
            Debug.Print(sql);
            SQLUtility.ExecuteSql(sql);
            this.Close();
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = $"delete recipeingredient where recipeid = {id}; delete mealcourserecipe where recipeid = {id}; delete cookbookrecipe where recipeid = {id}; delete recipestep where recipeid = {id}; delete Recipe where RecipeId = {id}";
            SQLUtility.ExecuteSql(sql);
            this.Close();
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
