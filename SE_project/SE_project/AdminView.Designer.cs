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
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAddCategory = new Button();
            txtbAddCategoryName = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnAddTest = new Button();
            cbAddTestUnits = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            cbAddTestCategory = new ComboBox();
            txtbAddTestName = new TextBox();
            numAddTestMin = new NumericUpDown();
            numAddTestMax = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtbAddTestID = new TextBox();
            splitContainer2 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            label9 = new Label();
            groupBox3 = new GroupBox();
            btnDelCategory = new Button();
            cbDelSelectCategory = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddTestMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddTestMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1590, 1070);
            splitContainer1.SplitterDistance = 900;
            splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 175);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(900, 895);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 175);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 70);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 0;
            label1.Text = "Lista badań";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddCategory);
            groupBox2.Controls.Add(txtbAddCategoryName);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(65, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 223);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "nowa kategoria";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(200, 147);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(174, 40);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "dodaj";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtbAddCategoryName
            // 
            txtbAddCategoryName.Location = new Point(200, 67);
            txtbAddCategoryName.Name = "txtbAddCategoryName";
            txtbAddCategoryName.Size = new Size(283, 35);
            txtbAddCategoryName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 70);
            label8.Name = "label8";
            label8.Size = new Size(72, 30);
            label8.TabIndex = 0;
            label8.Text = "nazwa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddTest);
            groupBox1.Controls.Add(cbAddTestUnits);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbAddTestCategory);
            groupBox1.Controls.Add(txtbAddTestName);
            groupBox1.Controls.Add(numAddTestMin);
            groupBox1.Controls.Add(numAddTestMax);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtbAddTestID);
            groupBox1.Location = new Point(65, 490);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 477);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "nowe badanie";
            // 
            // btnAddTest
            // 
            btnAddTest.Location = new Point(200, 405);
            btnAddTest.Name = "btnAddTest";
            btnAddTest.Size = new Size(174, 40);
            btnAddTest.TabIndex = 9;
            btnAddTest.Text = "dodaj";
            btnAddTest.UseVisualStyleBackColor = true;
            // 
            // cbAddTestUnits
            // 
            cbAddTestUnits.FormattingEnabled = true;
            cbAddTestUnits.Location = new Point(314, 332);
            cbAddTestUnits.Name = "cbAddTestUnits";
            cbAddTestUnits.Size = new Size(169, 38);
            cbAddTestUnits.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 335);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 12;
            label7.Text = "jednostki";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 283);
            label6.Name = "label6";
            label6.Size = new Size(205, 30);
            label6.TabIndex = 11;
            label6.Text = "wartość maksymalna";
            // 
            // cbAddTestCategory
            // 
            cbAddTestCategory.FormattingEnabled = true;
            cbAddTestCategory.Location = new Point(200, 173);
            cbAddTestCategory.Name = "cbAddTestCategory";
            cbAddTestCategory.Size = new Size(283, 38);
            cbAddTestCategory.TabIndex = 5;
            // 
            // txtbAddTestName
            // 
            txtbAddTestName.Location = new Point(200, 122);
            txtbAddTestName.Name = "txtbAddTestName";
            txtbAddTestName.Size = new Size(283, 35);
            txtbAddTestName.TabIndex = 4;
            // 
            // numAddTestMin
            // 
            numAddTestMin.DecimalPlaces = 3;
            numAddTestMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numAddTestMin.Location = new Point(388, 226);
            numAddTestMin.Name = "numAddTestMin";
            numAddTestMin.Size = new Size(95, 35);
            numAddTestMin.TabIndex = 6;
            // 
            // numAddTestMax
            // 
            numAddTestMax.DecimalPlaces = 3;
            numAddTestMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numAddTestMax.Location = new Point(388, 278);
            numAddTestMax.Name = "numAddTestMax";
            numAddTestMax.Size = new Size(95, 35);
            numAddTestMax.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 231);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 4;
            label5.Text = "wartość minimalna";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 178);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 3;
            label4.Text = "kategoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 2;
            label3.Text = "nazwa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 71);
            label2.Name = "label2";
            label2.Size = new Size(34, 30);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // txtbAddTestID
            // 
            txtbAddTestID.Location = new Point(200, 66);
            txtbAddTestID.Name = "txtbAddTestID";
            txtbAddTestID.Size = new Size(283, 35);
            txtbAddTestID.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel2);
            splitContainer2.Panel1.Controls.Add(panel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox3);
            splitContainer2.Size = new Size(1590, 1070);
            splitContainer2.SplitterDistance = 900;
            splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 175);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(900, 895);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 175);
            panel2.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(306, 70);
            label9.Name = "label9";
            label9.Size = new Size(125, 30);
            label9.TabIndex = 0;
            label9.Text = "Lista badań";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDelCategory);
            groupBox3.Controls.Add(cbDelSelectCategory);
            groupBox3.Location = new Point(72, 345);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 222);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "usuwanie kategorii";
            // 
            // btnDelCategory
            // 
            btnDelCategory.Location = new Point(207, 133);
            btnDelCategory.Name = "btnDelCategory";
            btnDelCategory.Size = new Size(131, 40);
            btnDelCategory.TabIndex = 1;
            btnDelCategory.Text = "usuń";
            btnDelCategory.UseVisualStyleBackColor = true;
            // 
            // cbDelSelectCategory
            // 
            cbDelSelectCategory.FormattingEnabled = true;
            cbDelSelectCategory.Location = new Point(41, 62);
            cbDelSelectCategory.Name = "cbDelSelectCategory";
            cbDelSelectCategory.Size = new Size(483, 38);
            cbDelSelectCategory.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1604, 1119);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1596, 1076);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "dodawanie badań";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1596, 1076);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "usuwanie badań";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 1117);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminView";
            Text = "LIS Admin";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddTestMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddTestMax).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
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
        private testItemExtendedDelete testItem3;
    }
}