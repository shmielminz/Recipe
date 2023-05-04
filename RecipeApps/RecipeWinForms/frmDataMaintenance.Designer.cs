namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            this.pnlOptionButtons = new System.Windows.Forms.Panel();
            this.optCourse = new System.Windows.Forms.RadioButton();
            this.optMeasurement = new System.Windows.Forms.RadioButton();
            this.optIngredient = new System.Windows.Forms.RadioButton();
            this.optCuisine = new System.Windows.Forms.RadioButton();
            this.optStaff = new System.Windows.Forms.RadioButton();
            this.gData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pnlOptionButtons, 0, 1);
            this.tblMain.Controls.Add(this.gData, 1, 1);
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1040, 576);
            this.tblMain.TabIndex = 0;
            // 
            // pnlOptionButtons
            // 
            this.pnlOptionButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOptionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptionButtons.Controls.Add(this.optCourse);
            this.pnlOptionButtons.Controls.Add(this.optMeasurement);
            this.pnlOptionButtons.Controls.Add(this.optIngredient);
            this.pnlOptionButtons.Controls.Add(this.optCuisine);
            this.pnlOptionButtons.Controls.Add(this.optStaff);
            this.pnlOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionButtons.Location = new System.Drawing.Point(3, 51);
            this.pnlOptionButtons.Name = "pnlOptionButtons";
            this.pnlOptionButtons.Size = new System.Drawing.Size(300, 522);
            this.pnlOptionButtons.TabIndex = 0;
            // 
            // optCourse
            // 
            this.optCourse.AutoSize = true;
            this.optCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.optCourse.Location = new System.Drawing.Point(0, 234);
            this.optCourse.Name = "optCourse";
            this.optCourse.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.optCourse.Size = new System.Drawing.Size(298, 56);
            this.optCourse.TabIndex = 4;
            this.optCourse.TabStop = true;
            this.optCourse.Text = "Courses";
            this.optCourse.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            this.optMeasurement.AutoSize = true;
            this.optMeasurement.Dock = System.Windows.Forms.DockStyle.Top;
            this.optMeasurement.Location = new System.Drawing.Point(0, 178);
            this.optMeasurement.Name = "optMeasurement";
            this.optMeasurement.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.optMeasurement.Size = new System.Drawing.Size(298, 56);
            this.optMeasurement.TabIndex = 3;
            this.optMeasurement.TabStop = true;
            this.optMeasurement.Text = "Measurements";
            this.optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            this.optIngredient.AutoSize = true;
            this.optIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.optIngredient.Location = new System.Drawing.Point(0, 122);
            this.optIngredient.Name = "optIngredient";
            this.optIngredient.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.optIngredient.Size = new System.Drawing.Size(298, 56);
            this.optIngredient.TabIndex = 2;
            this.optIngredient.TabStop = true;
            this.optIngredient.Text = "Ingredients";
            this.optIngredient.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            this.optCuisine.AutoSize = true;
            this.optCuisine.Dock = System.Windows.Forms.DockStyle.Top;
            this.optCuisine.Location = new System.Drawing.Point(0, 66);
            this.optCuisine.Name = "optCuisine";
            this.optCuisine.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.optCuisine.Size = new System.Drawing.Size(298, 56);
            this.optCuisine.TabIndex = 1;
            this.optCuisine.TabStop = true;
            this.optCuisine.Text = "Cuisines";
            this.optCuisine.UseVisualStyleBackColor = true;
            // 
            // optStaff
            // 
            this.optStaff.AutoSize = true;
            this.optStaff.Checked = true;
            this.optStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.optStaff.Location = new System.Drawing.Point(0, 0);
            this.optStaff.Name = "optStaff";
            this.optStaff.Padding = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.optStaff.Size = new System.Drawing.Size(298, 66);
            this.optStaff.TabIndex = 0;
            this.optStaff.TabStop = true;
            this.optStaff.Text = "Staff";
            this.optStaff.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Location = new System.Drawing.Point(309, 51);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 62;
            this.gData.RowTemplate.Height = 33;
            this.gData.Size = new System.Drawing.Size(728, 522);
            this.gData.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(20, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 576);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.pnlOptionButtons.ResumeLayout(false);
            this.pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Panel pnlOptionButtons;
        private RadioButton optCourse;
        private RadioButton optMeasurement;
        private RadioButton optIngredient;
        private RadioButton optCuisine;
        private RadioButton optStaff;
        private DataGridView gData;
        private Button btnSave;
    }
}