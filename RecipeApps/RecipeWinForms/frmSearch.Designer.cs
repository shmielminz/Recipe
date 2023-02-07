namespace RecipeWinForms
{
    partial class frmSearch
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
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.gRecipes = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Controls.Add(this.gRecipes, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(675, 578);
            this.tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.AutoSize = true;
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearch.Controls.Add(this.txtRecipe, 1, 0);
            this.tblSearch.Controls.Add(this.lblRecipe, 0, 0);
            this.tblSearch.Controls.Add(this.btnNew, 3, 0);
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(447, 48);
            this.tblSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(249, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRecipe.Location = new System.Drawing.Point(93, 4);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(150, 39);
            this.txtRecipe.TabIndex = 0;
            // 
            // lblRecipe
            // 
            this.lblRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(3, 8);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(84, 32);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Recipe";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNew.AutoSize = true;
            this.btnNew.Location = new System.Drawing.Point(350, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 42);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            this.gRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipes.Location = new System.Drawing.Point(3, 57);
            this.gRecipes.Name = "gRecipes";
            this.gRecipes.RowHeadersWidth = 62;
            this.gRecipes.RowTemplate.Height = 33;
            this.gRecipes.Size = new System.Drawing.Size(669, 518);
            this.gRecipes.TabIndex = 1;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 578);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearch";
            this.Text = "Search for Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Button btnSearch;
        private TextBox txtRecipe;
        private Label lblRecipe;
        private DataGridView gRecipes;
        private Button btnNew;
    }
}