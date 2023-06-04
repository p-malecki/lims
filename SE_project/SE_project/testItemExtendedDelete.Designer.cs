namespace SE_project
{
    partial class testItemExtendedDelete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.units = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxVal = new System.Windows.Forms.Label();
            this.minVal = new System.Windows.Forms.Label();
            this.testType = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.Label();
            this.testID = new System.Windows.Forms.Label();
            this.btnTestDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(390, 49);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(58, 30);
            this.units.TabIndex = 12;
            this.units.Text = "units";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "wart. min | max | jednostka";
            // 
            // maxVal
            // 
            this.maxVal.AutoSize = true;
            this.maxVal.Location = new System.Drawing.Point(305, 49);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(79, 30);
            this.maxVal.TabIndex = 10;
            this.maxVal.Text = "maxVal";
            // 
            // minVal
            // 
            this.minVal.AutoSize = true;
            this.minVal.Location = new System.Drawing.Point(224, 49);
            this.minVal.Name = "minVal";
            this.minVal.Size = new System.Drawing.Size(75, 30);
            this.minVal.TabIndex = 9;
            this.minVal.Text = "minVal";
            // 
            // testType
            // 
            this.testType.AutoSize = true;
            this.testType.Location = new System.Drawing.Point(508, 37);
            this.testType.Name = "testType";
            this.testType.Size = new System.Drawing.Size(140, 30);
            this.testType.TabIndex = 8;
            this.testType.Text = "testType 0000";
            this.testType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testName.Location = new System.Drawing.Point(18, 49);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(186, 30);
            this.testName.TabIndex = 7;
            this.testName.Text = "testName 0000000";
            // 
            // testID
            // 
            this.testID.AutoSize = true;
            this.testID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testID.Location = new System.Drawing.Point(18, 19);
            this.testID.Name = "testID";
            this.testID.Size = new System.Drawing.Size(101, 30);
            this.testID.TabIndex = 13;
            this.testID.Text = "ID 00001";
            // 
            // btnTestDelete
            // 
            this.btnTestDelete.Location = new System.Drawing.Point(693, 32);
            this.btnTestDelete.Name = "btnTestDelete";
            this.btnTestDelete.Size = new System.Drawing.Size(131, 40);
            this.btnTestDelete.TabIndex = 14;
            this.btnTestDelete.Text = "Usuń";
            this.btnTestDelete.UseVisualStyleBackColor = true;
            // 
            // testItemExtendedDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTestDelete);
            this.Controls.Add(this.testID);
            this.Controls.Add(this.units);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxVal);
            this.Controls.Add(this.minVal);
            this.Controls.Add(this.testType);
            this.Controls.Add(this.testName);
            this.Name = "testItemExtendedDelete";
            this.Size = new System.Drawing.Size(854, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label units;
        private Label label1;
        private Label maxVal;
        private Label minVal;
        private Label testType;
        private Label testName;
        private Label testID;
        private Button btnTestDelete;
    }
}
