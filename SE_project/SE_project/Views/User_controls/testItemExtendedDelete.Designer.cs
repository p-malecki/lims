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
            units = new Label();
            label1 = new Label();
            maxVal = new Label();
            minVal = new Label();
            testType = new Label();
            testName = new Label();
            testID = new Label();
            btnTestDelete = new Button();
            label3 = new Label();
            price = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // units
            // 
            units.AutoSize = true;
            units.Location = new Point(390, 49);
            units.Name = "units";
            units.Size = new Size(58, 30);
            units.TabIndex = 12;
            units.Text = "units";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 19);
            label1.Name = "label1";
            label1.Size = new Size(261, 30);
            label1.TabIndex = 11;
            label1.Text = "wart. min | max | jednostka";
            // 
            // maxVal
            // 
            maxVal.AutoSize = true;
            maxVal.Location = new Point(305, 49);
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(79, 30);
            maxVal.TabIndex = 10;
            maxVal.Text = "maxVal";
            // 
            // minVal
            // 
            minVal.AutoSize = true;
            minVal.Location = new Point(224, 49);
            minVal.Name = "minVal";
            minVal.Size = new Size(75, 30);
            minVal.TabIndex = 9;
            minVal.Text = "minVal";
            // 
            // testType
            // 
            testType.AutoSize = true;
            testType.Location = new Point(508, 19);
            testType.Name = "testType";
            testType.Size = new Size(140, 30);
            testType.TabIndex = 8;
            testType.Text = "testType 0000";
            testType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            testName.Location = new Point(18, 19);
            testName.Name = "testName";
            testName.Size = new Size(197, 30);
            testName.TabIndex = 7;
            testName.Text = "testName 0000000";
            // 
            // testID
            // 
            testID.AutoSize = true;
            testID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            testID.Location = new Point(58, 49);
            testID.Name = "testID";
            testID.Size = new Size(95, 30);
            testID.TabIndex = 13;
            testID.Text = "ID 00001";
            // 
            // btnTestDelete
            // 
            btnTestDelete.Location = new Point(693, 32);
            btnTestDelete.Name = "btnTestDelete";
            btnTestDelete.Size = new Size(131, 40);
            btnTestDelete.TabIndex = 14;
            btnTestDelete.Text = "Usuń";
            btnTestDelete.UseVisualStyleBackColor = true;
            btnTestDelete.Click += btnTestDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 49);
            label3.Name = "label3";
            label3.Size = new Size(29, 30);
            label3.TabIndex = 16;
            label3.Text = "zł";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(545, 49);
            price.Name = "price";
            price.Size = new Size(68, 30);
            price.TabIndex = 15;
            price.Text = "label2";
            price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(34, 30);
            label2.TabIndex = 17;
            label2.Text = "ID";
            // 
            // testItemExtendedDelete
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(btnTestDelete);
            Controls.Add(testID);
            Controls.Add(units);
            Controls.Add(label1);
            Controls.Add(maxVal);
            Controls.Add(minVal);
            Controls.Add(testType);
            Controls.Add(testName);
            Name = "testItemExtendedDelete";
            Size = new Size(854, 98);
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
        private Label price;
        private Label label2;
    }
}
