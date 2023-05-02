namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.tblStatus = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblStatus.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblStatusCaption, 0, 1);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 1);
            this.tblMain.Controls.Add(this.tblStatus, 0, 2);
            this.tblMain.Controls.Add(this.tblButtons, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(873, 445);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.tblMain.SetColumnSpan(this.lblRecipeName, 2);
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 10);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 20);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblRecipeName.Size = new System.Drawing.Size(867, 94);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "label1";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Location = new System.Drawing.Point(178, 124);
            this.lblStatusCaption.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Padding = new System.Windows.Forms.Padding(10);
            this.lblStatusCaption.Size = new System.Drawing.Size(248, 65);
            this.lblStatusCaption.TabIndex = 1;
            this.lblStatusCaption.Text = "Current Status:";
            this.lblStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeStatus.Location = new System.Drawing.Point(446, 124);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Padding = new System.Windows.Forms.Padding(10);
            this.lblRecipeStatus.Size = new System.Drawing.Size(130, 65);
            this.lblRecipeStatus.TabIndex = 2;
            this.lblRecipeStatus.Text = "label1";
            this.lblRecipeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblStatus
            // 
            this.tblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblStatus.ColumnCount = 4;
            this.tblMain.SetColumnSpan(this.tblStatus, 2);
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.Controls.Add(this.txtDateArchived, 3, 1);
            this.tblStatus.Controls.Add(this.txtDatePublished, 2, 1);
            this.tblStatus.Controls.Add(this.txtDateDrafted, 1, 1);
            this.tblStatus.Controls.Add(this.lblDateArchived, 3, 0);
            this.tblStatus.Controls.Add(this.lblDatePublished, 2, 0);
            this.tblStatus.Controls.Add(this.lblDateDrafted, 1, 0);
            this.tblStatus.Controls.Add(this.lblStatus, 0, 0);
            this.tblStatus.Location = new System.Drawing.Point(3, 212);
            this.tblStatus.Name = "tblStatus";
            this.tblStatus.RowCount = 2;
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus.Size = new System.Drawing.Size(867, 130);
            this.tblStatus.TabIndex = 3;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Enabled = false;
            this.txtDateArchived.Location = new System.Drawing.Point(648, 68);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(216, 50);
            this.txtDateArchived.TabIndex = 6;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatePublished.Enabled = false;
            this.txtDatePublished.Location = new System.Drawing.Point(426, 68);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(216, 50);
            this.txtDatePublished.TabIndex = 4;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDrafted.Enabled = false;
            this.txtDateDrafted.Location = new System.Drawing.Point(204, 68);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(216, 50);
            this.txtDateDrafted.TabIndex = 2;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateArchived.Location = new System.Drawing.Point(648, 0);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(216, 65);
            this.lblDateArchived.TabIndex = 5;
            this.lblDateArchived.Text = "Date Archived";
            this.lblDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(426, 0);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(216, 65);
            this.lblDatePublished.TabIndex = 3;
            this.lblDatePublished.Text = "Date Published";
            this.lblDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.AutoSize = true;
            this.lblDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDrafted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDrafted.Location = new System.Drawing.Point(204, 0);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(216, 65);
            this.lblDateDrafted.TabIndex = 1;
            this.lblDateDrafted.Text = "Date Drafted";
            this.lblDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.tblStatus.SetRowSpan(this.lblStatus, 2);
            this.lblStatus.Size = new System.Drawing.Size(195, 130);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status Dates";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnArchive, 2, 0);
            this.tblButtons.Controls.Add(this.btnPublish, 1, 0);
            this.tblButtons.Controls.Add(this.btnDraft, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblButtons.Location = new System.Drawing.Point(3, 355);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(3, 10, 3, 20);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(867, 85);
            this.tblButtons.TabIndex = 4;
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArchive.AutoSize = true;
            this.btnArchive.Location = new System.Drawing.Point(651, 15);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(143, 55);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublish.AutoSize = true;
            this.btnPublish.Location = new System.Drawing.Point(362, 15);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(143, 55);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            this.btnDraft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDraft.AutoSize = true;
            this.btnDraft.Location = new System.Drawing.Point(73, 15);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(143, 55);
            this.btnDraft.TabIndex = 0;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 445);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChangeRecipeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblStatus.ResumeLayout(false);
            this.tblStatus.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblStatusCaption;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblStatus;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblDateDrafted;
        private Label lblStatus;
        private TableLayoutPanel tblButtons;
        private Button btnArchive;
        private Button btnPublish;
        private Button btnDraft;
    }
}