namespace SE_project
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtbAddCategoryName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.cbAddTestUnits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAddTestCategory = new System.Windows.Forms.ComboBox();
            this.txtbAddTestName = new System.Windows.Forms.TextBox();
            this.numAddTestMin = new System.Windows.Forms.NumericUpDown();
            this.numAddTestMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbAddTestID = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.cbDelSelectCategory = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.testItem3 = new SE_project.testItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTestMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTestMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.testItem3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnAddCategory);
            this.groupBox2.Controls.Add(this.txtbAddCategoryName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnAddCategory
            // 
            resources.ApplyResources(this.btnAddCategory, "btnAddCategory");
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtbAddCategoryName
            // 
            resources.ApplyResources(this.txtbAddCategoryName, "txtbAddCategoryName");
            this.txtbAddCategoryName.Name = "txtbAddCategoryName";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnAddTest);
            this.groupBox1.Controls.Add(this.cbAddTestUnits);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbAddTestCategory);
            this.groupBox1.Controls.Add(this.txtbAddTestName);
            this.groupBox1.Controls.Add(this.numAddTestMin);
            this.groupBox1.Controls.Add(this.numAddTestMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbAddTestID);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnAddTest
            // 
            resources.ApplyResources(this.btnAddTest, "btnAddTest");
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.UseVisualStyleBackColor = true;
            // 
            // cbAddTestUnits
            // 
            resources.ApplyResources(this.cbAddTestUnits, "cbAddTestUnits");
            this.cbAddTestUnits.FormattingEnabled = true;
            this.cbAddTestUnits.Name = "cbAddTestUnits";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cbAddTestCategory
            // 
            resources.ApplyResources(this.cbAddTestCategory, "cbAddTestCategory");
            this.cbAddTestCategory.FormattingEnabled = true;
            this.cbAddTestCategory.Name = "cbAddTestCategory";
            // 
            // txtbAddTestName
            // 
            resources.ApplyResources(this.txtbAddTestName, "txtbAddTestName");
            this.txtbAddTestName.Name = "txtbAddTestName";
            // 
            // numAddTestMin
            // 
            resources.ApplyResources(this.numAddTestMin, "numAddTestMin");
            this.numAddTestMin.DecimalPlaces = 3;
            this.numAddTestMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAddTestMin.Name = "numAddTestMin";
            // 
            // numAddTestMax
            // 
            resources.ApplyResources(this.numAddTestMax, "numAddTestMax");
            this.numAddTestMax.DecimalPlaces = 3;
            this.numAddTestMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAddTestMax.Name = "numAddTestMax";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtbAddTestID
            // 
            resources.ApplyResources(this.txtbAddTestID, "txtbAddTestID");
            this.txtbAddTestID.Name = "txtbAddTestID";
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label9);
            this.panel2.Name = "panel2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnDelCategory);
            this.groupBox3.Controls.Add(this.cbDelSelectCategory);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnDelCategory
            // 
            resources.ApplyResources(this.btnDelCategory, "btnDelCategory");
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.UseVisualStyleBackColor = true;
            // 
            // cbDelSelectCategory
            // 
            resources.ApplyResources(this.cbDelSelectCategory, "cbDelSelectCategory");
            this.cbDelSelectCategory.FormattingEnabled = true;
            this.cbDelSelectCategory.Name = "cbDelSelectCategory";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // testItem3
            // 
            resources.ApplyResources(this.testItem3, "testItem3");
            this.testItem3.Name = "testItem3";
            // 
            // AdminView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTestMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddTestMax)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtbAddTestID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddTest;
        private ComboBox cbAddTestUnits;
        private Label label7;
        private Label label6;
        private ComboBox cbAddTestCategory;
        private TextBox txtbAddTestName;
        private NumericUpDown numAddTestMin;
        private NumericUpDown numAddTestMax;
        private GroupBox groupBox2;
        private Button btnAddCategory;
        private TextBox txtbAddCategoryName;
        private Label label8;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label9;
        private GroupBox groupBox3;
        private Button btnDelCategory;
        private ComboBox cbDelSelectCategory;
        private testItemExtended testItem1;
        private testItemExtended testItem2;
        private testItem testItem3;
    }
}