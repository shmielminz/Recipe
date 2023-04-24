namespace RecipeWinForms
{
    partial class frmDashboard
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberCookbooks = new System.Windows.Forms.Label();
            this.lblTypeCookbooks = new System.Windows.Forms.Label();
            this.lblNumberMeals = new System.Windows.Forms.Label();
            this.lblTypeMeals = new System.Windows.Forms.Label();
            this.lblNumberRecipes = new System.Windows.Forms.Label();
            this.lblTypeRecipes = new System.Windows.Forms.Label();
            this.lblNumberHeader = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTypeHeader = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCookbook = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblNumberCookbooks, 1, 5);
            this.tblMain.Controls.Add(this.lblTypeCookbooks, 0, 5);
            this.tblMain.Controls.Add(this.lblNumberMeals, 1, 4);
            this.tblMain.Controls.Add(this.lblTypeMeals, 0, 4);
            this.tblMain.Controls.Add(this.lblNumberRecipes, 1, 3);
            this.tblMain.Controls.Add(this.lblTypeRecipes, 0, 3);
            this.tblMain.Controls.Add(this.lblNumberHeader, 1, 2);
            this.tblMain.Controls.Add(this.lblWelcome, 0, 0);
            this.tblMain.Controls.Add(this.lblDescription, 0, 1);
            this.tblMain.Controls.Add(this.lblTypeHeader, 0, 2);
            this.tblMain.Controls.Add(this.tblButtons, 0, 6);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1058, 751);
            this.tblMain.TabIndex = 0;
            // 
            // lblNumberCookbooks
            // 
            this.lblNumberCookbooks.AutoSize = true;
            this.lblNumberCookbooks.BackColor = System.Drawing.Color.White;
            this.lblNumberCookbooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberCookbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberCookbooks.Location = new System.Drawing.Point(529, 578);
            this.lblNumberCookbooks.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblNumberCookbooks.Name = "lblNumberCookbooks";
            this.lblNumberCookbooks.Padding = new System.Windows.Forms.Padding(20);
            this.lblNumberCookbooks.Size = new System.Drawing.Size(479, 74);
            this.lblNumberCookbooks.TabIndex = 9;
            this.lblNumberCookbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeCookbooks
            // 
            this.lblTypeCookbooks.AutoSize = true;
            this.lblTypeCookbooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeCookbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeCookbooks.Location = new System.Drawing.Point(50, 578);
            this.lblTypeCookbooks.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTypeCookbooks.Name = "lblTypeCookbooks";
            this.lblTypeCookbooks.Padding = new System.Windows.Forms.Padding(20);
            this.lblTypeCookbooks.Size = new System.Drawing.Size(479, 74);
            this.lblTypeCookbooks.TabIndex = 8;
            this.lblTypeCookbooks.Text = "Cookbooks";
            this.lblTypeCookbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberMeals
            // 
            this.lblNumberMeals.AutoSize = true;
            this.lblNumberMeals.BackColor = System.Drawing.Color.White;
            this.lblNumberMeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberMeals.Location = new System.Drawing.Point(529, 504);
            this.lblNumberMeals.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblNumberMeals.Name = "lblNumberMeals";
            this.lblNumberMeals.Padding = new System.Windows.Forms.Padding(20);
            this.lblNumberMeals.Size = new System.Drawing.Size(479, 74);
            this.lblNumberMeals.TabIndex = 7;
            this.lblNumberMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeMeals
            // 
            this.lblTypeMeals.AutoSize = true;
            this.lblTypeMeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeMeals.Location = new System.Drawing.Point(50, 504);
            this.lblTypeMeals.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTypeMeals.Name = "lblTypeMeals";
            this.lblTypeMeals.Padding = new System.Windows.Forms.Padding(20);
            this.lblTypeMeals.Size = new System.Drawing.Size(479, 74);
            this.lblTypeMeals.TabIndex = 6;
            this.lblTypeMeals.Text = "Meals";
            this.lblTypeMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberRecipes
            // 
            this.lblNumberRecipes.AutoSize = true;
            this.lblNumberRecipes.BackColor = System.Drawing.Color.White;
            this.lblNumberRecipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberRecipes.Location = new System.Drawing.Point(529, 430);
            this.lblNumberRecipes.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblNumberRecipes.Name = "lblNumberRecipes";
            this.lblNumberRecipes.Padding = new System.Windows.Forms.Padding(20);
            this.lblNumberRecipes.Size = new System.Drawing.Size(479, 74);
            this.lblNumberRecipes.TabIndex = 5;
            this.lblNumberRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeRecipes
            // 
            this.lblTypeRecipes.AutoSize = true;
            this.lblTypeRecipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeRecipes.Location = new System.Drawing.Point(50, 430);
            this.lblTypeRecipes.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTypeRecipes.Name = "lblTypeRecipes";
            this.lblTypeRecipes.Padding = new System.Windows.Forms.Padding(20);
            this.lblTypeRecipes.Size = new System.Drawing.Size(479, 74);
            this.lblTypeRecipes.TabIndex = 4;
            this.lblTypeRecipes.Text = "Recipes";
            this.lblTypeRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberHeader
            // 
            this.lblNumberHeader.AutoSize = true;
            this.lblNumberHeader.BackColor = System.Drawing.Color.Silver;
            this.lblNumberHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberHeader.Location = new System.Drawing.Point(529, 350);
            this.lblNumberHeader.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lblNumberHeader.Name = "lblNumberHeader";
            this.lblNumberHeader.Padding = new System.Windows.Forms.Padding(20);
            this.lblNumberHeader.Size = new System.Drawing.Size(479, 80);
            this.lblNumberHeader.TabIndex = 3;
            this.lblNumberHeader.Text = "Number";
            this.lblNumberHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblWelcome, 2);
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(3, 10);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(3, 10, 3, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1052, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hearty Hearth Desktop App";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblDescription, 2);
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(50, 120);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(958, 180);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Welcome to the Hearty Hearth Desktop Application. In this app you can view our ra" +
    "nge of Recipes Meals and Cookbooks. You can also create new Recipes with just a " +
    "click of a button. Lets get it rolling.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeHeader
            // 
            this.lblTypeHeader.AutoSize = true;
            this.lblTypeHeader.BackColor = System.Drawing.Color.Silver;
            this.lblTypeHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTypeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeHeader.Location = new System.Drawing.Point(50, 350);
            this.lblTypeHeader.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTypeHeader.Name = "lblTypeHeader";
            this.lblTypeHeader.Padding = new System.Windows.Forms.Padding(20);
            this.lblTypeHeader.Size = new System.Drawing.Size(479, 80);
            this.lblTypeHeader.TabIndex = 2;
            this.lblTypeHeader.Text = "Type";
            this.lblTypeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.AutoSize = true;
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButtons.Controls.Add(this.btnCookbook, 2, 0);
            this.tblButtons.Controls.Add(this.btnRecipe, 0, 0);
            this.tblButtons.Controls.Add(this.btnMeal, 1, 0);
            this.tblButtons.Location = new System.Drawing.Point(50, 655);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(958, 93);
            this.tblButtons.TabIndex = 10;
            // 
            // btnCookbook
            // 
            this.btnCookbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCookbook.Location = new System.Drawing.Point(648, 10);
            this.btnCookbook.Margin = new System.Windows.Forms.Padding(10);
            this.btnCookbook.Name = "btnCookbook";
            this.btnCookbook.Size = new System.Drawing.Size(300, 73);
            this.btnCookbook.TabIndex = 2;
            this.btnCookbook.Text = "Cookbook List";
            this.btnCookbook.UseVisualStyleBackColor = true;
            // 
            // btnRecipe
            // 
            this.btnRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecipe.Location = new System.Drawing.Point(10, 10);
            this.btnRecipe.Margin = new System.Windows.Forms.Padding(10);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(299, 73);
            this.btnRecipe.TabIndex = 0;
            this.btnRecipe.Text = "Recipe List";
            this.btnRecipe.UseVisualStyleBackColor = true;
            // 
            // btnMeal
            // 
            this.btnMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeal.Location = new System.Drawing.Point(329, 10);
            this.btnMeal.Margin = new System.Windows.Forms.Padding(10);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(299, 73);
            this.btnMeal.TabIndex = 1;
            this.btnMeal.Text = "Meal List";
            this.btnMeal.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 751);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private Label lblTypeCookbooks;
        private Label lblNumberMeals;
        private Label lblTypeMeals;
        private Label lblNumberRecipes;
        private Label lblTypeRecipes;
        private Label lblNumberHeader;
        private Label lblTypeHeader;
        private Label lblNumberCookbooks;
        private TableLayoutPanel tblButtons;
        private Button btnCookbook;
        private Button btnMeal;
        private Button btnRecipe;
    }
}