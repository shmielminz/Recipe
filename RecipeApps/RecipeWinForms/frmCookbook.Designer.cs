namespace RecipeWinForms
{
    partial class frmCookbook
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCookbookName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtCookbookName = new System.Windows.Forms.TextBox();
            this.lstUsername = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.tbChildRecords = new System.Windows.Forms.TabControl();
            this.tbRecipes = new System.Windows.Forms.TabPage();
            this.tblChildRecords = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.gRecipes = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tbChildRecords.SuspendLayout();
            this.tbRecipes.SuspendLayout();
            this.tblChildRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Controls.Add(this.btnDelete, 1, 0);
            this.tblMain.Controls.Add(this.lblCookbookName, 0, 1);
            this.tblMain.Controls.Add(this.lblUser, 0, 2);
            this.tblMain.Controls.Add(this.lblPrice, 0, 3);
            this.tblMain.Controls.Add(this.lblActive, 0, 4);
            this.tblMain.Controls.Add(this.txtCookbookName, 1, 1);
            this.tblMain.Controls.Add(this.lstUsername, 1, 2);
            this.tblMain.Controls.Add(this.txtPrice, 1, 3);
            this.tblMain.Controls.Add(this.chkActive, 1, 4);
            this.tblMain.Controls.Add(this.lblDateCreated, 2, 3);
            this.tblMain.Controls.Add(this.txtDateCreated, 2, 4);
            this.tblMain.Controls.Add(this.tbChildRecords, 0, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(858, 873);
            this.tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(52, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10);
            this.btnSave.Size = new System.Drawing.Size(112, 62);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(244, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10);
            this.btnDelete.Size = new System.Drawing.Size(114, 62);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            this.lblCookbookName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCookbookName.AutoSize = true;
            this.lblCookbookName.Location = new System.Drawing.Point(20, 88);
            this.lblCookbookName.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.lblCookbookName.Name = "lblCookbookName";
            this.lblCookbookName.Size = new System.Drawing.Size(194, 32);
            this.lblCookbookName.TabIndex = 0;
            this.lblCookbookName.Text = "Cookbook Name";
            this.lblCookbookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 160);
            this.lblUser.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 32);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 232);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 32);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActive
            // 
            this.lblActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(20, 304);
            this.lblActive.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(79, 32);
            this.lblActive.TabIndex = 6;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCookbookName
            // 
            this.txtCookbookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.SetColumnSpan(this.txtCookbookName, 2);
            this.txtCookbookName.Location = new System.Drawing.Point(227, 84);
            this.txtCookbookName.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.txtCookbookName.Name = "txtCookbookName";
            this.txtCookbookName.Size = new System.Drawing.Size(611, 39);
            this.txtCookbookName.TabIndex = 1;
            // 
            // lstUsername
            // 
            this.lstUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.SetColumnSpan(this.lstUsername, 2);
            this.lstUsername.FormattingEnabled = true;
            this.lstUsername.Location = new System.Drawing.Point(227, 159);
            this.lstUsername.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.lstUsername.Name = "lstUsername";
            this.lstUsername.Size = new System.Drawing.Size(611, 40);
            this.lstUsername.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrice.Location = new System.Drawing.Point(220, 228);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 39);
            this.txtPrice.TabIndex = 5;
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(220, 309);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(22, 21);
            this.chkActive.TabIndex = 7;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(545, 242);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(154, 32);
            this.lblDateCreated.TabIndex = 8;
            this.lblDateCreated.Text = "Date Created";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateCreated.Enabled = false;
            this.txtDateCreated.Location = new System.Drawing.Point(518, 294);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(207, 39);
            this.txtDateCreated.TabIndex = 9;
            this.txtDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbChildRecords
            // 
            this.tblMain.SetColumnSpan(this.tbChildRecords, 3);
            this.tbChildRecords.Controls.Add(this.tbRecipes);
            this.tbChildRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChildRecords.Location = new System.Drawing.Point(3, 359);
            this.tbChildRecords.Name = "tbChildRecords";
            this.tbChildRecords.SelectedIndex = 0;
            this.tbChildRecords.Size = new System.Drawing.Size(852, 539);
            this.tbChildRecords.TabIndex = 12;
            // 
            // tbRecipes
            // 
            this.tbRecipes.Controls.Add(this.tblChildRecords);
            this.tbRecipes.Location = new System.Drawing.Point(4, 41);
            this.tbRecipes.Name = "tbRecipes";
            this.tbRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecipes.Size = new System.Drawing.Size(844, 494);
            this.tbRecipes.TabIndex = 1;
            this.tbRecipes.Text = "Recipes";
            this.tbRecipes.UseVisualStyleBackColor = true;
            // 
            // tblChildRecords
            // 
            this.tblChildRecords.ColumnCount = 1;
            this.tblChildRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChildRecords.Controls.Add(this.btnSaveRecipe, 0, 0);
            this.tblChildRecords.Controls.Add(this.gRecipes, 0, 1);
            this.tblChildRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChildRecords.Location = new System.Drawing.Point(3, 3);
            this.tblChildRecords.Name = "tblChildRecords";
            this.tblChildRecords.RowCount = 2;
            this.tblChildRecords.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChildRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChildRecords.Size = new System.Drawing.Size(838, 488);
            this.tblChildRecords.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveRecipe.AutoSize = true;
            this.btnSaveRecipe.Location = new System.Drawing.Point(20, 3);
            this.btnSaveRecipe.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(112, 42);
            this.btnSaveRecipe.TabIndex = 0;
            this.btnSaveRecipe.Text = "Save";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            this.gRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipes.Location = new System.Drawing.Point(3, 51);
            this.gRecipes.Name = "gRecipes";
            this.gRecipes.RowHeadersWidth = 62;
            this.gRecipes.RowTemplate.Height = 33;
            this.gRecipes.Size = new System.Drawing.Size(832, 434);
            this.gRecipes.TabIndex = 1;
            // 
            // frmCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 873);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCookbook";
            this.Text = "Cookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tbChildRecords.ResumeLayout(false);
            this.tbRecipes.ResumeLayout(false);
            this.tblChildRecords.ResumeLayout(false);
            this.tblChildRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox lstUsername;
        private TextBox txtPrice;
        private CheckBox chkActive;
        private Label lblDateCreated;
        private TextBox txtDateCreated;
        private TabControl tbChildRecords;
        private TabPage tbRecipes;
        private TableLayoutPanel tblChildRecords;
        private Button btnSaveRecipe;
        private DataGridView gRecipes;
    }
}