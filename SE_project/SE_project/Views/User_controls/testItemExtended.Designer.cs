namespace SE_project
{
    partial class testItemExtended
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
            testID = new Label();
            testName = new Label();
            testType = new Label();
            price = new Label();
            units = new Label();
            maxVal = new Label();
            minVal = new Label();
            SuspendLayout();
            // 
            // testID
            // 
            testID.AutoSize = true;
            testID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            testID.Location = new Point(740, 16);
            testID.Name = "testID";
            testID.Size = new Size(95, 30);
            testID.TabIndex = 0;
            testID.Text = "ID 00001";
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            testName.Location = new Point(17, 16);
            testName.Name = "testName";
            testName.Size = new Size(197, 30);
            testName.TabIndex = 1;
            testName.Text = "testName 0000000";
            // 
            // testType
            // 
            testType.AutoSize = true;
            testType.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            testType.Location = new Point(17, 46);
            testType.Name = "testType";
            testType.Size = new Size(140, 30);
            testType.TabIndex = 2;
            testType.Text = "testType 0000";
            testType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(740, 46);
            price.Name = "price";
            price.Size = new Size(61, 30);
            price.TabIndex = 7;
            price.Text = "price";
            price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // units
            // 
            units.AutoSize = true;
            units.Location = new Point(567, 46);
            units.Name = "units";
            units.Size = new Size(58, 30);
            units.TabIndex = 22;
            units.Text = "units";
            // 
            // maxVal
            // 
            maxVal.AutoSize = true;
            maxVal.Location = new Point(413, 46);
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(79, 30);
            maxVal.TabIndex = 21;
            maxVal.Text = "maxVal";
            // 
            // minVal
            // 
            minVal.AutoSize = true;
            minVal.Location = new Point(293, 46);
            minVal.Name = "minVal";
            minVal.Size = new Size(75, 30);
            minVal.TabIndex = 20;
            minVal.Text = "minVal";
            // 
            // testItemExtended
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(units);
            Controls.Add(maxVal);
            Controls.Add(minVal);
            Controls.Add(price);
            Controls.Add(testType);
            Controls.Add(testName);
            Controls.Add(testID);
            Name = "testItemExtended";
            Size = new Size(847, 98);
            Load += testItemExtended_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testID;
        private Label testName;
        private Label testType;
        private Label maxVal;
        private Label units;
        private Label price;
        private Label minVal;
    }
}
