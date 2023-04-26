namespace RecipeWinForms
{
    partial class frmRecipeList
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
            this.btnNew = new System.Windows.Forms.Button();
            this.gRecipes = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.btnNew, 0, 0);
            this.tblMain.Controls.Add(this.gRecipes, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(675, 578);
            this.tblMain.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNew.AutoSize = true;
            this.btnNew.Location = new System.Drawing.Point(20, 10);
            this.btnNew.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New Recipe";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            this.gRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipes.Location = new System.Drawing.Point(3, 58);
            this.gRecipes.Name = "gRecipes";
            this.gRecipes.RowHeadersWidth = 62;
            this.gRecipes.RowTemplate.Height = 33;
            this.gRecipes.Size = new System.Drawing.Size(669, 517);
            this.gRecipes.TabIndex = 1;
            // 
            // frmRecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 578);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipeList";
            this.Text = "Recipe List";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNew;
        private DataGridView gRecipes;
    }
}