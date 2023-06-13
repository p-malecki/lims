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
            btnTestDelete = new Button();
            testType = new Label();
            testName = new Label();
            price = new Label();
            testID = new Label();
            SuspendLayout();
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
            // testType
            // 
            testType.AutoSize = true;
            testType.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            testType.Location = new Point(22, 47);
            testType.Name = "testType";
            testType.Size = new Size(140, 30);
            testType.TabIndex = 16;
            testType.Text = "testType 0000";
            testType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // testName
            // 
            testName.AutoSize = true;
            testName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            testName.Location = new Point(22, 17);
            testName.Name = "testName";
            testName.Size = new Size(197, 30);
            testName.TabIndex = 15;
            testName.Text = "testName 0000000";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(596, 47);
            price.Name = "price";
            price.Size = new Size(61, 30);
            price.TabIndex = 21;
            price.Text = "price";
            price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // testID
            // 
            testID.AutoSize = true;
            testID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            testID.Location = new Point(562, 17);
            testID.Name = "testID";
            testID.Size = new Size(95, 30);
            testID.TabIndex = 20;
            testID.Text = "ID 00001";
            // 
            // testItemExtendedDelete
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(price);
            Controls.Add(testID);
            Controls.Add(testType);
            Controls.Add(testName);
            Controls.Add(btnTestDelete);
            Name = "testItemExtendedDelete";
            Size = new Size(854, 98);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTestDelete;
        private Label testType;
        private Label testName;
        private Label price;
        private Label testID;
    }
}
