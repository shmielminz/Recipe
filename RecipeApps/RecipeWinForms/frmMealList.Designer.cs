namespace RecipeWinForms
{
    partial class frmMealList
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
            this.gMeal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // gMeal
            // 
            this.gMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMeal.Location = new System.Drawing.Point(0, 0);
            this.gMeal.Name = "gMeal";
            this.gMeal.RowHeadersWidth = 62;
            this.gMeal.RowTemplate.Height = 33;
            this.gMeal.Size = new System.Drawing.Size(1040, 576);
            this.gMeal.TabIndex = 0;
            // 
            // frmMealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 576);
            this.Controls.Add(this.gMeal);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMealList";
            this.Text = "Meal List";
            ((System.ComponentModel.ISupportInitialize)(this.gMeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gMeal;
    }
}