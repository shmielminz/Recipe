using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.CuisineType, s.Username from Recipe r join Cuisine c on c.CuisineId = r.CuisineId join Staff s on s.StaffId = r.StaffId where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtStaffName.DataBindings.Add("Text", dt, "Username");
            lblCuisine.DataBindings.Add("Text", dt, "CuisineType");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            this.Show();
        }
    }
}
