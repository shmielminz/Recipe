namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipeList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloneRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookAutoCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecipes,
            this.mnuMeals,
            this.mnuCookbooks,
            this.mnuDataMaint,
            this.mnuWindow});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1040, 42);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(67, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(233, 40);
            this.mnuDashboard.Text = "&Dashboard";
            // 
            // mnuRecipes
            // 
            this.mnuRecipes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecipeList,
            this.mnuNewRecipe,
            this.mnuCloneRecipe});
            this.mnuRecipes.Name = "mnuRecipes";
            this.mnuRecipes.Size = new System.Drawing.Size(110, 36);
            this.mnuRecipes.Text = "&Recipes";
            // 
            // mnuRecipeList
            // 
            this.mnuRecipeList.Name = "mnuRecipeList";
            this.mnuRecipeList.Size = new System.Drawing.Size(276, 40);
            this.mnuRecipeList.Text = "&List";
            // 
            // mnuNewRecipe
            // 
            this.mnuNewRecipe.Name = "mnuNewRecipe";
            this.mnuNewRecipe.Size = new System.Drawing.Size(276, 40);
            this.mnuNewRecipe.Text = "&New Recipe";
            // 
            // mnuCloneRecipe
            // 
            this.mnuCloneRecipe.Name = "mnuCloneRecipe";
            this.mnuCloneRecipe.Size = new System.Drawing.Size(276, 40);
            this.mnuCloneRecipe.Text = "&Clone a Recipe";
            // 
            // mnuMeals
            // 
            this.mnuMeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealList});
            this.mnuMeals.Name = "mnuMeals";
            this.mnuMeals.Size = new System.Drawing.Size(93, 36);
            this.mnuMeals.Text = "&Meals";
            // 
            // mnuMealList
            // 
            this.mnuMealList.Name = "mnuMealList";
            this.mnuMealList.Size = new System.Drawing.Size(153, 40);
            this.mnuMealList.Text = "&List";
            // 
            // mnuCookbooks
            // 
            this.mnuCookbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCookbookList,
            this.mnuNewCookbook,
            this.mnuCookbookAutoCreate});
            this.mnuCookbooks.Name = "mnuCookbooks";
            this.mnuCookbooks.Size = new System.Drawing.Size(149, 36);
            this.mnuCookbooks.Text = "&Cookbooks";
            // 
            // mnuCookbookList
            // 
            this.mnuCookbookList.Name = "mnuCookbookList";
            this.mnuCookbookList.Size = new System.Drawing.Size(361, 40);
            this.mnuCookbookList.Text = "&List";
            // 
            // mnuNewCookbook
            // 
            this.mnuNewCookbook.Name = "mnuNewCookbook";
            this.mnuNewCookbook.Size = new System.Drawing.Size(361, 40);
            this.mnuNewCookbook.Text = "&New Cookbook";
            // 
            // mnuCookbookAutoCreate
            // 
            this.mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            this.mnuCookbookAutoCreate.Size = new System.Drawing.Size(361, 40);
            this.mnuCookbookAutoCreate.Text = "&Auto Create Cookbook";
            // 
            // mnuDataMaint
            // 
            this.mnuDataMaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataMaintEdit});
            this.mnuDataMaint.Name = "mnuDataMaint";
            this.mnuDataMaint.Size = new System.Drawing.Size(225, 36);
            this.mnuDataMaint.Text = "&Data Maintenance";
            // 
            // mnuDataMaintEdit
            // 
            this.mnuDataMaintEdit.Name = "mnuDataMaintEdit";
            this.mnuDataMaintEdit.Size = new System.Drawing.Size(214, 40);
            this.mnuDataMaintEdit.Text = "&Edit Data";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(117, 36);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(205, 40);
            this.mnuWindowTile.Text = "&Tile";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(205, 40);
            this.mnuWindowCascade.Text = "&Cascade";
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMain.Location = new System.Drawing.Point(0, 42);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsMain.Size = new System.Drawing.Size(1040, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 965);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Hearty Hearth";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuDataMaintEdit;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
    }
}