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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtbAddID = new TextBox();
            tabPage2 = new TabPage();
            testListPanel = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numAddMax = new NumericUpDown();
            numAddMin = new NumericUpDown();
            txtbAddName = new TextBox();
            cbAddCategory = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbAddUnits = new ComboBox();
            btnAddTest = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddMin).BeginInit();
            SuspendLayout();
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
            tabControl1.TabIndex = 0;
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
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1590, 1070);
            splitContainer1.SplitterDistance = 776;
            splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 175);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 895);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 175);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddTest);
            groupBox1.Controls.Add(cbAddUnits);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbAddCategory);
            groupBox1.Controls.Add(txtbAddName);
            groupBox1.Controls.Add(numAddMin);
            groupBox1.Controls.Add(numAddMax);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtbAddID);
            groupBox1.Location = new Point(94, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 477);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "nowe badanie";
            // 
            // txtbAddID
            // 
            txtbAddID.Location = new Point(200, 66);
            txtbAddID.Name = "txtbAddID";
            txtbAddID.Size = new Size(283, 35);
            txtbAddID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(testListPanel);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1596, 1076);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "usuwanie badań";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // testListPanel
            // 
            testListPanel.Location = new Point(34, 61);
            testListPanel.Name = "testListPanel";
            testListPanel.Size = new Size(757, 926);
            testListPanel.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 2;
            label3.Text = "nazwa";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 231);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 4;
            label5.Text = "wartość minimalna";
            // 
            // numAddMax
            // 
            numAddMax.DecimalPlaces = 3;
            numAddMax.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numAddMax.Location = new Point(388, 278);
            numAddMax.Name = "numAddMax";
            numAddMax.Size = new Size(95, 35);
            numAddMax.TabIndex = 5;
            // 
            // numAddMin
            // 
            numAddMin.DecimalPlaces = 3;
            numAddMin.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numAddMin.Location = new Point(388, 226);
            numAddMin.Name = "numAddMin";
            numAddMin.Size = new Size(95, 35);
            numAddMin.TabIndex = 6;
            // 
            // txtbAddName
            // 
            txtbAddName.Location = new Point(200, 122);
            txtbAddName.Name = "txtbAddName";
            txtbAddName.Size = new Size(283, 35);
            txtbAddName.TabIndex = 9;
            // 
            // cbAddCategory
            // 
            cbAddCategory.FormattingEnabled = true;
            cbAddCategory.Location = new Point(200, 173);
            cbAddCategory.Name = "cbAddCategory";
            cbAddCategory.Size = new Size(283, 38);
            cbAddCategory.TabIndex = 10;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 335);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 12;
            label7.Text = "jednostki";
            // 
            // cbAddUnits
            // 
            cbAddUnits.FormattingEnabled = true;
            cbAddUnits.Location = new Point(314, 332);
            cbAddUnits.Name = "cbAddUnits";
            cbAddUnits.Size = new Size(169, 38);
            cbAddUnits.TabIndex = 13;
            // 
            // btnAddTest
            // 
            btnAddTest.Location = new Point(200, 405);
            btnAddTest.Name = "btnAddTest";
            btnAddTest.Size = new Size(174, 40);
            btnAddTest.TabIndex = 14;
            btnAddTest.Text = "dodaj";
            btnAddTest.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 1117);
            Controls.Add(tabControl1);
            Name = "AdminView";
            Text = "AdminView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAddMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddMin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel testListPanel;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtbAddID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddTest;
        private ComboBox cbAddUnits;
        private Label label7;
        private Label label6;
        private ComboBox cbAddCategory;
        private TextBox txtbAddName;
        private NumericUpDown numAddMin;
        private NumericUpDown numAddMax;
    }
}