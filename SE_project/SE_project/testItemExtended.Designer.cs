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
            minVal = new Label();
            maxVal = new Label();
            label1 = new Label();
            units = new Label();
            SuspendLayout();
            // 
            // testID
            // 
            testID.AutoSize = true;
            testID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            testID.Location = new Point(14, 16);
            testID.Name = "testID";
            testID.Size = new Size(101, 30);
            testID.TabIndex = 0;
            testID.Text = "ID 00001";
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            testName.Location = new Point(14, 46);
            testName.Name = "testName";
            testName.Size = new Size(186, 30);
            testName.TabIndex = 1;
            testName.Text = "testName 0000000";
            // 
            // testType
            // 
            testType.AutoSize = true;
            testType.Location = new Point(504, 34);
            testType.Name = "testType";
            testType.Size = new Size(140, 30);
            testType.TabIndex = 2;
            testType.Text = "testType 0000";
            testType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minVal
            // 
            minVal.AutoSize = true;
            minVal.Location = new Point(220, 46);
            minVal.Name = "minVal";
            minVal.Size = new Size(75, 30);
            minVal.TabIndex = 3;
            minVal.Text = "minVal";
            // 
            // maxVal
            // 
            maxVal.AutoSize = true;
            maxVal.Location = new Point(301, 46);
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(79, 30);
            maxVal.TabIndex = 4;
            maxVal.Text = "maxVal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 16);
            label1.Name = "label1";
            label1.Size = new Size(261, 30);
            label1.TabIndex = 5;
            label1.Text = "wart. min | max | jednostka";
            // 
            // units
            // 
            units.AutoSize = true;
            units.Location = new Point(386, 46);
            units.Name = "units";
            units.Size = new Size(58, 30);
            units.TabIndex = 6;
            units.Text = "units";
            // 
            // testItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(units);
            Controls.Add(label1);
            Controls.Add(maxVal);
            Controls.Add(minVal);
            Controls.Add(testType);
            Controls.Add(testName);
            Controls.Add(testID);
            Name = "testItem";
            Size = new Size(666, 98);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testID;
        private Label testName;
        private Label testType;
        private Label minVal;
        private Label maxVal;
        private Label label1;
        private Label units;
    }
}
