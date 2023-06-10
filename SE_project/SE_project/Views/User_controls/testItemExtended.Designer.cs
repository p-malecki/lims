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
            this.testID = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.Label();
            this.testType = new System.Windows.Forms.Label();
            this.minVal = new System.Windows.Forms.Label();
            this.maxVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testID
            // 
            this.testID.AutoSize = true;
            this.testID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testID.Location = new System.Drawing.Point(14, 16);
            this.testID.Name = "testID";
            this.testID.Size = new System.Drawing.Size(101, 30);
            this.testID.TabIndex = 0;
            this.testID.Text = "ID 00001";
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testName.Location = new System.Drawing.Point(14, 46);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(186, 30);
            this.testName.TabIndex = 1;
            this.testName.Text = "testName 0000000";
            // 
            // testType
            // 
            this.testType.AutoSize = true;
            this.testType.Location = new System.Drawing.Point(501, 16);
            this.testType.Name = "testType";
            this.testType.Size = new System.Drawing.Size(140, 30);
            this.testType.TabIndex = 2;
            this.testType.Text = "testType 0000";
            this.testType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minVal
            // 
            this.minVal.AutoSize = true;
            this.minVal.Location = new System.Drawing.Point(220, 46);
            this.minVal.Name = "minVal";
            this.minVal.Size = new System.Drawing.Size(75, 30);
            this.minVal.TabIndex = 3;
            this.minVal.Text = "minVal";
            // 
            // maxVal
            // 
            this.maxVal.AutoSize = true;
            this.maxVal.Location = new System.Drawing.Point(301, 46);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(79, 30);
            this.maxVal.TabIndex = 4;
            this.maxVal.Text = "maxVal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "wart. min | max | jednostka";
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(386, 46);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(58, 30);
            this.units.TabIndex = 6;
            this.units.Text = "units";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(538, 46);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(68, 30);
            this.price.TabIndex = 7;
            this.price.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "zł";
            // 
            // testItemExtended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.units);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxVal);
            this.Controls.Add(this.minVal);
            this.Controls.Add(this.testType);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.testID);
            this.Name = "testItemExtended";
            this.Size = new System.Drawing.Size(666, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
