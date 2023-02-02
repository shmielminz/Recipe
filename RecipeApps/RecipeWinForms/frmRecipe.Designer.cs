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
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionStaffName = new System.Windows.Forms.Label();
            this.lblCaptionCuisine = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lblCaptionRecipeStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstUsername = new System.Windows.Forms.ComboBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.txtDateArchived, 1, 6);
            this.tblMain.Controls.Add(this.txtDatePublished, 1, 5);
            this.tblMain.Controls.Add(this.txtDateDrafted, 1, 4);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionStaffName, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionCuisine, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionDateDrafted, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionDatePublished, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 6);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 7);
            this.tblMain.Controls.Add(this.lblCaptionRecipeStatus, 0, 7);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 0, 8);
            this.tblMain.Controls.Add(this.lstUsername, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(662, 435);
            this.tblMain.TabIndex = 0;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Location = new System.Drawing.Point(186, 283);
            this.txtDateArchived.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(476, 39);
            this.txtDateArchived.TabIndex = 14;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatePublished.Location = new System.Drawing.Point(186, 239);
            this.txtDatePublished.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(476, 39);
            this.txtDatePublished.TabIndex = 13;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDrafted.Location = new System.Drawing.Point(186, 195);
            this.txtDateDrafted.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(476, 39);
            this.txtDateDrafted.TabIndex = 12;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(186, 151);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(476, 39);
            this.txtCalories.TabIndex = 11;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(4, 6);
            this.lblCaptionRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(155, 32);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionStaffName
            // 
            this.lblCaptionStaffName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionStaffName.AutoSize = true;
            this.lblCaptionStaffName.Location = new System.Drawing.Point(4, 51);
            this.lblCaptionStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionStaffName.Name = "lblCaptionStaffName";
            this.lblCaptionStaffName.Size = new System.Drawing.Size(133, 32);
            this.lblCaptionStaffName.TabIndex = 1;
            this.lblCaptionStaffName.Text = "Staff Name";
            // 
            // lblCaptionCuisine
            // 
            this.lblCaptionCuisine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisine.AutoSize = true;
            this.lblCaptionCuisine.Location = new System.Drawing.Point(4, 102);
            this.lblCaptionCuisine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionCuisine.Name = "lblCaptionCuisine";
            this.lblCaptionCuisine.Size = new System.Drawing.Size(92, 32);
            this.lblCaptionCuisine.TabIndex = 2;
            this.lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Location = new System.Drawing.Point(4, 152);
            this.lblCaptionCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(98, 32);
            this.lblCaptionCalories.TabIndex = 3;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionDateDrafted
            // 
            this.lblCaptionDateDrafted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDrafted.AutoSize = true;
            this.lblCaptionDateDrafted.Location = new System.Drawing.Point(4, 196);
            this.lblCaptionDateDrafted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            this.lblCaptionDateDrafted.Size = new System.Drawing.Size(151, 32);
            this.lblCaptionDateDrafted.TabIndex = 4;
            this.lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            this.lblCaptionDatePublished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDatePublished.AutoSize = true;
            this.lblCaptionDatePublished.Location = new System.Drawing.Point(4, 240);
            this.lblCaptionDatePublished.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            this.lblCaptionDatePublished.Size = new System.Drawing.Size(175, 32);
            this.lblCaptionDatePublished.TabIndex = 5;
            this.lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            this.lblCaptionDateArchived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateArchived.AutoSize = true;
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(4, 284);
            this.lblCaptionDateArchived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            this.lblCaptionDateArchived.Size = new System.Drawing.Size(164, 32);
            this.lblCaptionDateArchived.TabIndex = 6;
            this.lblCaptionDateArchived.Text = "Date Archived";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(186, 5);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(476, 39);
            this.txtRecipeName.TabIndex = 8;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Location = new System.Drawing.Point(186, 327);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(476, 34);
            this.lblRecipeStatus.TabIndex = 15;
            // 
            // lblCaptionRecipeStatus
            // 
            this.lblCaptionRecipeStatus.AutoSize = true;
            this.lblCaptionRecipeStatus.Location = new System.Drawing.Point(4, 329);
            this.lblCaptionRecipeStatus.Margin = new System.Windows.Forms.Padding(4, 7, 4, 0);
            this.lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            this.lblCaptionRecipeStatus.Size = new System.Drawing.Size(78, 32);
            this.lblCaptionRecipeStatus.TabIndex = 7;
            this.lblCaptionRecipeStatus.Text = "Status";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 364);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 76);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(332, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(324, 79);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(323, 79);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lstUsername
            // 
            this.lstUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstUsername.FormattingEnabled = true;
            this.lstUsername.Location = new System.Drawing.Point(186, 47);
            this.lstUsername.Name = "lstUsername";
            this.lstUsername.Size = new System.Drawing.Size(425, 40);
            this.lstUsername.TabIndex = 19;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(186, 93);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(239, 40);
            this.lstCuisineType.TabIndex = 20;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 435);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionStaffName;
        private Label lblCaptionCuisine;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtRecipeName;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private TextBox txtCalories;
        private Label lblRecipeStatus;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDelete;
        private Button btnSave;
        private ComboBox lstUsername;
        private ComboBox lstCuisineType;
    }
}