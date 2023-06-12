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
            price = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // testID
            // 
            testID.AutoSize = true;
            testID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            testID.Location = new Point(57, 46);
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
            testType.Location = new Point(501, 16);
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
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(538, 46);
            price.Name = "price";
            price.Size = new Size(68, 30);
            price.TabIndex = 7;
            price.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 46);
            label3.Name = "label3";
            label3.Size = new Size(29, 30);
            label3.TabIndex = 8;
            label3.Text = "zł";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 46);
            label4.Name = "label4";
            label4.Size = new Size(34, 30);
            label4.TabIndex = 19;
            label4.Text = "ID";
            // 
            // testItemExtended
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(units);
            Controls.Add(label1);
            Controls.Add(maxVal);
            Controls.Add(minVal);
            Controls.Add(testType);
            Controls.Add(testName);
            Controls.Add(testID);
            Name = "testItemExtended";
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
        private Label price;
        private Label label3;
        private Label label4;
    }
}
