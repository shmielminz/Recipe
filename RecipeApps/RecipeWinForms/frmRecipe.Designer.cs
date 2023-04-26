namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.tbChildRecords = new System.Windows.Forms.TabControl();
            this.tbIngredients = new System.Windows.Forms.TabPage();
            this.tblIngredients = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveIngredients = new System.Windows.Forms.Button();
            this.gIngredients = new System.Windows.Forms.DataGridView();
            this.tbSteps = new System.Windows.Forms.TabPage();
            this.tblSteps = new System.Windows.Forms.TableLayoutPanel();
            this.gSteps = new System.Windows.Forms.DataGridView();
            this.btnSaveSteps = new System.Windows.Forms.Button();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblCuisineType = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.tblStatusDates = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.tbChildRecords.SuspendLayout();
            this.tbIngredients.SuspendLayout();
            this.tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredients)).BeginInit();
            this.tbSteps.SuspendLayout();
            this.tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).BeginInit();
            this.tblStatusDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.tblButtons, 0, 0);
            this.tblMain.Controls.Add(this.tbChildRecords, 0, 6);
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 1);
            this.tblMain.Controls.Add(this.lblCuisineType, 0, 2);
            this.tblMain.Controls.Add(this.lblCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 0, 4);
            this.tblMain.Controls.Add(this.lblStatusDates, 0, 5);
            this.tblMain.Controls.Add(this.tblStatusDates, 1, 5);
            this.tblMain.Controls.Add(this.txtRecipeStatus, 1, 4);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(772, 699);
            this.tblMain.TabIndex = 0;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.AutoSize = true;
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblButtons.Controls.Add(this.btnChangeStatus, 2, 0);
            this.tblButtons.Location = new System.Drawing.Point(3, 3);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(783, 48);
            this.tblButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(20, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Location = new System.Drawing.Point(137, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChangeStatus.AutoSize = true;
            this.btnChangeStatus.BackColor = System.Drawing.Color.LightGray;
            this.btnChangeStatus.Location = new System.Drawing.Point(586, 3);
            this.btnChangeStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(177, 42);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "&Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // tbChildRecords
            // 
            this.tbChildRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.SetColumnSpan(this.tbChildRecords, 2);
            this.tbChildRecords.Controls.Add(this.tbIngredients);
            this.tbChildRecords.Controls.Add(this.tbSteps);
            this.tbChildRecords.Location = new System.Drawing.Point(3, 350);
            this.tbChildRecords.Name = "tbChildRecords";
            this.tbChildRecords.SelectedIndex = 0;
            this.tbChildRecords.Size = new System.Drawing.Size(783, 346);
            this.tbChildRecords.TabIndex = 1;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Controls.Add(this.tblIngredients);
            this.tbIngredients.Location = new System.Drawing.Point(4, 41);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngredients.Size = new System.Drawing.Size(775, 301);
            this.tbIngredients.TabIndex = 0;
            this.tbIngredients.Text = "Ingredients";
            this.tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            this.tblIngredients.ColumnCount = 1;
            this.tblIngredients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIngredients.Controls.Add(this.btnSaveIngredients, 0, 0);
            this.tblIngredients.Controls.Add(this.gIngredients, 0, 1);
            this.tblIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIngredients.Location = new System.Drawing.Point(3, 3);
            this.tblIngredients.Name = "tblIngredients";
            this.tblIngredients.RowCount = 2;
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIngredients.Size = new System.Drawing.Size(769, 295);
            this.tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            this.btnSaveIngredients.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveIngredients.AutoSize = true;
            this.btnSaveIngredients.Location = new System.Drawing.Point(3, 3);
            this.btnSaveIngredients.Name = "btnSaveIngredients";
            this.btnSaveIngredients.Size = new System.Drawing.Size(112, 42);
            this.btnSaveIngredients.TabIndex = 0;
            this.btnSaveIngredients.Text = "Save";
            this.btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            this.gIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIngredients.Location = new System.Drawing.Point(3, 51);
            this.gIngredients.Name = "gIngredients";
            this.gIngredients.RowHeadersWidth = 62;
            this.gIngredients.RowTemplate.Height = 33;
            this.gIngredients.Size = new System.Drawing.Size(763, 241);
            this.gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            this.tbSteps.Controls.Add(this.tblSteps);
            this.tbSteps.Location = new System.Drawing.Point(4, 34);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tbSteps.Size = new System.Drawing.Size(775, 339);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "Steps";
            this.tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            this.tblSteps.ColumnCount = 1;
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSteps.Controls.Add(this.gSteps, 0, 1);
            this.tblSteps.Controls.Add(this.btnSaveSteps, 0, 0);
            this.tblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSteps.Location = new System.Drawing.Point(3, 3);
            this.tblSteps.Name = "tblSteps";
            this.tblSteps.RowCount = 2;
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSteps.Size = new System.Drawing.Size(769, 333);
            this.tblSteps.TabIndex = 0;
            // 
            // gSteps
            // 
            this.gSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSteps.Location = new System.Drawing.Point(3, 51);
            this.gSteps.Name = "gSteps";
            this.gSteps.RowHeadersWidth = 62;
            this.gSteps.RowTemplate.Height = 33;
            this.gSteps.Size = new System.Drawing.Size(763, 279);
            this.gSteps.TabIndex = 2;
            // 
            // btnSaveSteps
            // 
            this.btnSaveSteps.AutoSize = true;
            this.btnSaveSteps.Location = new System.Drawing.Point(3, 3);
            this.btnSaveSteps.Name = "btnSaveSteps";
            this.btnSaveSteps.Size = new System.Drawing.Size(112, 42);
            this.btnSaveSteps.TabIndex = 0;
            this.btnSaveSteps.Text = "Save";
            this.btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(20, 60);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(155, 32);
            this.lblRecipeName.TabIndex = 2;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuisineType
            // 
            this.lblCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuisineType.AutoSize = true;
            this.lblCuisineType.Location = new System.Drawing.Point(20, 106);
            this.lblCuisineType.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblCuisineType.Name = "lblCuisineType";
            this.lblCuisineType.Size = new System.Drawing.Size(92, 32);
            this.lblCuisineType.TabIndex = 3;
            this.lblCuisineType.Text = "Cuisine";
            this.lblCuisineType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalories
            // 
            this.lblCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(20, 151);
            this.lblCalories.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(158, 32);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "Num Calories";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Location = new System.Drawing.Point(20, 196);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(165, 32);
            this.lblRecipeStatus.TabIndex = 5;
            this.lblRecipeStatus.Text = "Current Status";
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Location = new System.Drawing.Point(20, 275);
            this.lblStatusDates.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(145, 32);
            this.lblStatusDates.TabIndex = 6;
            this.lblStatusDates.Text = "Status Dates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblStatusDates
            // 
            this.tblStatusDates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblStatusDates.ColumnCount = 3;
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusDates.Controls.Add(this.txtDateArchived, 2, 1);
            this.tblStatusDates.Controls.Add(this.txtDatePublished, 1, 1);
            this.tblStatusDates.Controls.Add(this.lblDateArchived, 2, 0);
            this.tblStatusDates.Controls.Add(this.lblDatePublished, 1, 0);
            this.tblStatusDates.Controls.Add(this.lblDateDrafted, 0, 0);
            this.tblStatusDates.Controls.Add(this.txtDateDrafted, 0, 1);
            this.tblStatusDates.Location = new System.Drawing.Point(191, 238);
            this.tblStatusDates.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.tblStatusDates.Name = "tblStatusDates";
            this.tblStatusDates.RowCount = 2;
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.Size = new System.Drawing.Size(578, 106);
            this.tblStatusDates.TabIndex = 7;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateArchived.BackColor = System.Drawing.Color.Silver;
            this.txtDateArchived.Enabled = false;
            this.txtDateArchived.ForeColor = System.Drawing.Color.Black;
            this.txtDateArchived.Location = new System.Drawing.Point(387, 60);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(188, 39);
            this.txtDateArchived.TabIndex = 5;
            this.txtDateArchived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatePublished.BackColor = System.Drawing.Color.Silver;
            this.txtDatePublished.Enabled = false;
            this.txtDatePublished.ForeColor = System.Drawing.Color.Black;
            this.txtDatePublished.Location = new System.Drawing.Point(195, 60);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(186, 39);
            this.txtDatePublished.TabIndex = 4;
            this.txtDatePublished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Location = new System.Drawing.Point(387, 10);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(188, 32);
            this.lblDateArchived.TabIndex = 2;
            this.lblDateArchived.Text = "Archived";
            this.lblDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(195, 10);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(186, 32);
            this.lblDatePublished.TabIndex = 1;
            this.lblDatePublished.Text = "Published";
            this.lblDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDrafted.AutoSize = true;
            this.lblDateDrafted.Location = new System.Drawing.Point(3, 10);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(186, 32);
            this.lblDateDrafted.TabIndex = 0;
            this.lblDateDrafted.Text = "Drafted";
            this.lblDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateDrafted.BackColor = System.Drawing.Color.Silver;
            this.txtDateDrafted.Enabled = false;
            this.txtDateDrafted.ForeColor = System.Drawing.Color.Black;
            this.txtDateDrafted.Location = new System.Drawing.Point(3, 60);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(186, 39);
            this.txtDateDrafted.TabIndex = 3;
            this.txtDateDrafted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.BackColor = System.Drawing.Color.Silver;
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Enabled = false;
            this.txtRecipeStatus.ForeColor = System.Drawing.Color.Black;
            this.txtRecipeStatus.Location = new System.Drawing.Point(191, 193);
            this.txtRecipeStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(578, 39);
            this.txtRecipeStatus.TabIndex = 8;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(191, 148);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(578, 39);
            this.txtCalories.TabIndex = 9;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(191, 57);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(578, 39);
            this.txtRecipeName.TabIndex = 10;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(191, 102);
            this.lstCuisineType.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(578, 40);
            this.lstCuisineType.TabIndex = 11;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 699);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.tbChildRecords.ResumeLayout(false);
            this.tbIngredients.ResumeLayout(false);
            this.tblIngredients.ResumeLayout(false);
            this.tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredients)).EndInit();
            this.tbSteps.ResumeLayout(false);
            this.tblSteps.ResumeLayout(false);
            this.tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).EndInit();
            this.tblStatusDates.ResumeLayout(false);
            this.tblStatusDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private Label lblRecipeName;
        private Label lblCuisineType;
        private Label lblCalories;
        private Label lblRecipeStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TextBox txtDatePublished;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblDateDrafted;
        private TextBox txtDateDrafted;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private TextBox txtRecipeStatus;
        private TextBox txtCalories;
        private TextBox txtRecipeName;
        private ComboBox lstCuisineType;
        private DataGridView gIngredients;
        private DataGridView gSteps;
    }
}