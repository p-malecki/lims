namespace SE_project
{
    partial class TechnicianView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianView));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            listbxToAcceptOrders = new ListBox();
            label42 = new Label();
            groupBox4 = new GroupBox();
            label16 = new Label();
            lbToAcceptOrderID = new Label();
            label17 = new Label();
            lbToAcceptDate = new Label();
            listbxToAcceptTests = new ListBox();
            btnLogout1 = new Button();
            btnDeny = new Button();
            btnAccept = new Button();
            groupBox3 = new GroupBox();
            lbToAcceptTestType = new Label();
            lbToAcceptTestName = new Label();
            lbToAcceptTestID = new Label();
            label14 = new Label();
            label13 = new Label();
            label15 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            splitContainer2 = new SplitContainer();
            listbxToFillOrders = new ListBox();
            groupBox6 = new GroupBox();
            lbToFillUnits = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            btnConfirmResult = new Button();
            groupBox5 = new GroupBox();
            label46 = new Label();
            label32 = new Label();
            lbToFillClientID = new Label();
            lbToFillOrderID = new Label();
            label43 = new Label();
            btnLogout2 = new Button();
            listbxToFillTests = new ListBox();
            groupBox2 = new GroupBox();
            lbToFillTestMax = new Label();
            lbToFillTestMin = new Label();
            lbToFillTestType = new Label();
            lbToFillTestName = new Label();
            lbToFillTestID = new Label();
            label25 = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            listbxCompletedOrders = new ListBox();
            label2 = new Label();
            groupBox8 = new GroupBox();
            lbCompletedUnits = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            btnConfirmResultEdit = new Button();
            groupBox7 = new GroupBox();
            label47 = new Label();
            lbCompletedClientID = new Label();
            label34 = new Label();
            lbCompletedOrderID = new Label();
            label44 = new Label();
            btnLogout3 = new Button();
            listbxCompletedTests = new ListBox();
            groupBox1 = new GroupBox();
            lbCompletedResult = new Label();
            lbCompletedTestType = new Label();
            lbCompletedTestName = new Label();
            lbCompletedClientTestID = new Label();
            label35 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1094, 878);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1086, 840);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "badania do akceptacji";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 50);
            label1.TabIndex = 0;
            label1.Text = "zamówienia\r\ndo akceptacji";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label1);
            splitContainer3.Panel1.Controls.Add(listbxToAcceptOrders);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(label42);
            splitContainer3.Panel2.Controls.Add(groupBox4);
            splitContainer3.Panel2.Controls.Add(listbxToAcceptTests);
            splitContainer3.Panel2.Controls.Add(btnLogout1);
            splitContainer3.Panel2.Controls.Add(btnDeny);
            splitContainer3.Panel2.Controls.Add(btnAccept);
            splitContainer3.Panel2.Controls.Add(groupBox3);
            splitContainer3.Size = new Size(1080, 834);
            splitContainer3.SplitterDistance = 273;
            splitContainer3.SplitterWidth = 6;
            splitContainer3.TabIndex = 0;
            // 
            // listbxToAcceptOrders
            // 
            listbxToAcceptOrders.FormattingEnabled = true;
            listbxToAcceptOrders.ItemHeight = 25;
            listbxToAcceptOrders.Location = new Point(0, 82);
            listbxToAcceptOrders.Name = "listbxToAcceptOrders";
            listbxToAcceptOrders.Size = new Size(264, 754);
            listbxToAcceptOrders.TabIndex = 0;
            listbxToAcceptOrders.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(104, 32);
            label42.Name = "label42";
            label42.Size = new Size(75, 25);
            label42.TabIndex = 0;
            label42.Text = "badania";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(lbToAcceptOrderID);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(lbToAcceptDate);
            groupBox4.Location = new Point(343, 165);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(429, 208);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "szczegóły zamówienia";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 45);
            label16.Name = "label16";
            label16.Size = new Size(128, 25);
            label16.TabIndex = 6;
            label16.Text = "ID zamówienia";
            // 
            // lbToAcceptOrderID
            // 
            lbToAcceptOrderID.AutoSize = true;
            lbToAcceptOrderID.Location = new Point(203, 45);
            lbToAcceptOrderID.Name = "lbToAcceptOrderID";
            lbToAcceptOrderID.Size = new Size(69, 25);
            lbToAcceptOrderID.TabIndex = 12;
            lbToAcceptOrderID.Text = "label19";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 93);
            label17.Name = "label17";
            label17.Size = new Size(145, 25);
            label17.TabIndex = 10;
            label17.Text = "data zamówienia";
            // 
            // lbToAcceptDate
            // 
            lbToAcceptDate.AutoSize = true;
            lbToAcceptDate.Location = new Point(203, 93);
            lbToAcceptDate.Name = "lbToAcceptDate";
            lbToAcceptDate.Size = new Size(69, 25);
            lbToAcceptDate.TabIndex = 13;
            lbToAcceptDate.Text = "label20";
            // 
            // listbxToAcceptTests
            // 
            listbxToAcceptTests.FormattingEnabled = true;
            listbxToAcceptTests.ItemHeight = 25;
            listbxToAcceptTests.Location = new Point(7, 82);
            listbxToAcceptTests.Name = "listbxToAcceptTests";
            listbxToAcceptTests.Size = new Size(295, 754);
            listbxToAcceptTests.TabIndex = 13;
            listbxToAcceptTests.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnLogout1
            // 
            btnLogout1.Location = new Point(663, 25);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(109, 43);
            btnLogout1.TabIndex = 12;
            btnLogout1.Text = "Wyloguj";
            btnLogout1.UseVisualStyleBackColor = true;
            btnLogout1.Click += btnTechnicianLogOut_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(590, 642);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(164, 43);
            btnDeny.TabIndex = 4;
            btnDeny.Text = "odrzuć";
            btnDeny.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(366, 642);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(151, 43);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "akceptuj";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbToAcceptTestType);
            groupBox3.Controls.Add(lbToAcceptTestName);
            groupBox3.Controls.Add(lbToAcceptTestID);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(343, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(429, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "szczegóły badania";
            // 
            // lbToAcceptTestType
            // 
            lbToAcceptTestType.AutoSize = true;
            lbToAcceptTestType.Location = new Point(203, 163);
            lbToAcceptTestType.Name = "lbToAcceptTestType";
            lbToAcceptTestType.Size = new Size(69, 25);
            lbToAcceptTestType.TabIndex = 17;
            lbToAcceptTestType.Text = "label24";
            // 
            // lbToAcceptTestName
            // 
            lbToAcceptTestName.AutoSize = true;
            lbToAcceptTestName.Location = new Point(203, 113);
            lbToAcceptTestName.Name = "lbToAcceptTestName";
            lbToAcceptTestName.Size = new Size(69, 25);
            lbToAcceptTestName.TabIndex = 16;
            lbToAcceptTestName.Text = "label23";
            // 
            // lbToAcceptTestID
            // 
            lbToAcceptTestID.AutoSize = true;
            lbToAcceptTestID.Location = new Point(203, 67);
            lbToAcceptTestID.Name = "lbToAcceptTestID";
            lbToAcceptTestID.Size = new Size(69, 25);
            lbToAcceptTestID.TabIndex = 15;
            lbToAcceptTestID.Text = "label22";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(41, 163);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 9;
            label14.Text = "typ testu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 67);
            label13.Name = "label13";
            label13.Size = new Size(74, 25);
            label13.TabIndex = 8;
            label13.Text = "ID testu";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(41, 113);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 7;
            label15.Text = "nazwa testu";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1086, 840);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "badania zaakceptowane";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 17);
            label7.Name = "label7";
            label7.Size = new Size(133, 50);
            label7.TabIndex = 0;
            label7.Text = "zamówienia\r\nzaakceptowane";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(listbxToFillOrders);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label43);
            splitContainer2.Panel2.Controls.Add(groupBox6);
            splitContainer2.Panel2.Controls.Add(groupBox5);
            splitContainer2.Panel2.Controls.Add(btnLogout2);
            splitContainer2.Panel2.Controls.Add(listbxToFillTests);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(1080, 834);
            splitContainer2.SplitterDistance = 273;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // listbxToFillOrders
            // 
            listbxToFillOrders.FormattingEnabled = true;
            listbxToFillOrders.ItemHeight = 25;
            listbxToFillOrders.Location = new Point(3, 82);
            listbxToFillOrders.Name = "listbxToFillOrders";
            listbxToFillOrders.Size = new Size(267, 754);
            listbxToFillOrders.TabIndex = 3;
            listbxToFillOrders.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbToFillUnits);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(btnConfirmResult);
            groupBox6.Location = new Point(320, 627);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(463, 177);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "wprowadzanie wartosci badania";
            // 
            // lbToFillUnits
            // 
            lbToFillUnits.AutoSize = true;
            lbToFillUnits.Location = new Point(293, 50);
            lbToFillUnits.Name = "lbToFillUnits";
            lbToFillUnits.Size = new Size(69, 25);
            lbToFillUnits.TabIndex = 24;
            lbToFillUnits.Text = "label33";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 47);
            label8.Name = "label8";
            label8.Size = new Size(73, 25);
            label8.TabIndex = 8;
            label8.Text = "wartość";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 31);
            textBox5.TabIndex = 23;
            // 
            // btnConfirmResult
            // 
            btnConfirmResult.Location = new Point(107, 108);
            btnConfirmResult.Name = "btnConfirmResult";
            btnConfirmResult.Size = new Size(179, 48);
            btnConfirmResult.TabIndex = 2;
            btnConfirmResult.Text = "zatwierdz";
            btnConfirmResult.UseVisualStyleBackColor = true;
            btnConfirmResult.Click += btnConfirmResult_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label46);
            groupBox5.Controls.Add(label32);
            groupBox5.Controls.Add(lbToFillClientID);
            groupBox5.Controls.Add(lbToFillOrderID);
            groupBox5.Location = new Point(320, 97);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(463, 123);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "szczegóły zamówienia";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(14, 78);
            label46.Name = "label46";
            label46.Size = new Size(86, 25);
            label46.TabIndex = 22;
            label46.Text = "ID klienta";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(14, 43);
            label32.Name = "label32";
            label32.Size = new Size(128, 25);
            label32.TabIndex = 22;
            label32.Text = "ID zamówienia";
            // 
            // lbToFillClientID
            // 
            lbToFillClientID.AutoSize = true;
            lbToFillClientID.Location = new Point(187, 78);
            lbToFillClientID.Name = "lbToFillClientID";
            lbToFillClientID.Size = new Size(69, 25);
            lbToFillClientID.TabIndex = 16;
            lbToFillClientID.Text = "label45";
            // 
            // lbToFillOrderID
            // 
            lbToFillOrderID.AutoSize = true;
            lbToFillOrderID.Location = new Point(187, 43);
            lbToFillOrderID.Name = "lbToFillOrderID";
            lbToFillOrderID.Size = new Size(69, 25);
            lbToFillOrderID.TabIndex = 16;
            lbToFillOrderID.Text = "label26";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(121, 34);
            label43.Name = "label43";
            label43.Size = new Size(75, 25);
            label43.TabIndex = 0;
            label43.Text = "badania";
            // 
            // btnLogout2
            // 
            btnLogout2.Location = new Point(669, 25);
            btnLogout2.Name = "btnLogout2";
            btnLogout2.Size = new Size(109, 42);
            btnLogout2.TabIndex = 15;
            btnLogout2.Text = "Wyloguj";
            btnLogout2.UseVisualStyleBackColor = true;
            btnLogout2.Click += btnTechnicianLogOut_Click;
            // 
            // listbxToFillTests
            // 
            listbxToFillTests.FormattingEnabled = true;
            listbxToFillTests.ItemHeight = 25;
            listbxToFillTests.Location = new Point(3, 82);
            listbxToFillTests.Name = "listbxToFillTests";
            listbxToFillTests.Size = new Size(304, 754);
            listbxToFillTests.TabIndex = 14;
            listbxToFillTests.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbToFillTestMax);
            groupBox2.Controls.Add(lbToFillTestMin);
            groupBox2.Controls.Add(lbToFillTestType);
            groupBox2.Controls.Add(lbToFillTestName);
            groupBox2.Controls.Add(lbToFillTestID);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(320, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 337);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "szczegóły badania";
            // 
            // lbToFillTestMax
            // 
            lbToFillTestMax.AutoSize = true;
            lbToFillTestMax.Location = new Point(220, 278);
            lbToFillTestMax.Name = "lbToFillTestMax";
            lbToFillTestMax.Size = new Size(69, 25);
            lbToFillTestMax.TabIndex = 21;
            lbToFillTestMax.Text = "label31";
            // 
            // lbToFillTestMin
            // 
            lbToFillTestMin.AutoSize = true;
            lbToFillTestMin.Location = new Point(220, 225);
            lbToFillTestMin.Name = "lbToFillTestMin";
            lbToFillTestMin.Size = new Size(69, 25);
            lbToFillTestMin.TabIndex = 20;
            lbToFillTestMin.Text = "label30";
            // 
            // lbToFillTestType
            // 
            lbToFillTestType.AutoSize = true;
            lbToFillTestType.Location = new Point(220, 173);
            lbToFillTestType.Name = "lbToFillTestType";
            lbToFillTestType.Size = new Size(69, 25);
            lbToFillTestType.TabIndex = 19;
            lbToFillTestType.Text = "label29";
            // 
            // lbToFillTestName
            // 
            lbToFillTestName.AutoSize = true;
            lbToFillTestName.Location = new Point(220, 117);
            lbToFillTestName.Name = "lbToFillTestName";
            lbToFillTestName.Size = new Size(69, 25);
            lbToFillTestName.TabIndex = 18;
            lbToFillTestName.Text = "label28";
            // 
            // lbToFillTestID
            // 
            lbToFillTestID.AutoSize = true;
            lbToFillTestID.Location = new Point(220, 67);
            lbToFillTestID.Name = "lbToFillTestID";
            lbToFillTestID.Size = new Size(69, 25);
            lbToFillTestID.TabIndex = 17;
            lbToFillTestID.Text = "label27";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(17, 173);
            label25.Name = "label25";
            label25.Size = new Size(38, 25);
            label25.TabIndex = 15;
            label25.Text = "typ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 278);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 13;
            label12.Text = "górna granica ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 117);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 7;
            label9.Text = "nazwa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 67);
            label10.Name = "label10";
            label10.Size = new Size(98, 25);
            label10.TabIndex = 6;
            label10.Text = "ID badania";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 225);
            label11.Name = "label11";
            label11.Size = new Size(119, 25);
            label11.TabIndex = 5;
            label11.Text = "dolna granica";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1086, 840);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "historia badań";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(listbxCompletedOrders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label44);
            splitContainer1.Panel2.Controls.Add(groupBox8);
            splitContainer1.Panel2.Controls.Add(groupBox7);
            splitContainer1.Panel2.Controls.Add(btnLogout3);
            splitContainer1.Panel2.Controls.Add(listbxCompletedTests);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1080, 834);
            splitContainer1.SplitterDistance = 253;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // listbxCompletedOrders
            // 
            listbxCompletedOrders.FormattingEnabled = true;
            listbxCompletedOrders.ItemHeight = 25;
            listbxCompletedOrders.Location = new Point(0, 62);
            listbxCompletedOrders.Name = "listbxCompletedOrders";
            listbxCompletedOrders.Size = new Size(250, 779);
            listbxCompletedOrders.TabIndex = 3;
            listbxCompletedOrders.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 22);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 0;
            label2.Text = "zamówienia";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lbCompletedUnits);
            groupBox8.Controls.Add(textBox1);
            groupBox8.Controls.Add(label6);
            groupBox8.Controls.Add(btnConfirmResultEdit);
            groupBox8.Location = new Point(317, 618);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(482, 178);
            groupBox8.TabIndex = 15;
            groupBox8.TabStop = false;
            groupBox8.Text = "edycja badania";
            // 
            // lbCompletedUnits
            // 
            lbCompletedUnits.AutoSize = true;
            lbCompletedUnits.Location = new Point(373, 57);
            lbCompletedUnits.Name = "lbCompletedUnits";
            lbCompletedUnits.Size = new Size(69, 25);
            lbCompletedUnits.TabIndex = 31;
            lbCompletedUnits.Text = "label41";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 31);
            textBox1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 56);
            label6.Name = "label6";
            label6.Size = new Size(206, 25);
            label6.TabIndex = 8;
            label6.Text = "zaaktualizowana wartość";
            // 
            // btnConfirmResultEdit
            // 
            btnConfirmResultEdit.Location = new Point(163, 108);
            btnConfirmResultEdit.Name = "btnConfirmResultEdit";
            btnConfirmResultEdit.Size = new Size(137, 45);
            btnConfirmResultEdit.TabIndex = 1;
            btnConfirmResultEdit.Text = "zatwierdz";
            btnConfirmResultEdit.UseVisualStyleBackColor = true;
            btnConfirmResultEdit.Click += btnConfirmResultEdit_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label47);
            groupBox7.Controls.Add(lbCompletedClientID);
            groupBox7.Controls.Add(label34);
            groupBox7.Controls.Add(lbCompletedOrderID);
            groupBox7.Location = new Point(317, 125);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(482, 118);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "zamówienie";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(33, 72);
            label47.Name = "label47";
            label47.Size = new Size(86, 25);
            label47.TabIndex = 28;
            label47.Text = "ID klienta";
            // 
            // lbCompletedClientID
            // 
            lbCompletedClientID.AutoSize = true;
            lbCompletedClientID.Location = new Point(237, 72);
            lbCompletedClientID.Name = "lbCompletedClientID";
            lbCompletedClientID.Size = new Size(69, 25);
            lbCompletedClientID.TabIndex = 27;
            lbCompletedClientID.Text = "label48";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(33, 38);
            label34.Name = "label34";
            label34.Size = new Size(128, 25);
            label34.TabIndex = 23;
            label34.Text = "ID zamówienia";
            // 
            // lbCompletedOrderID
            // 
            lbCompletedOrderID.AutoSize = true;
            lbCompletedOrderID.Location = new Point(237, 38);
            lbCompletedOrderID.Name = "lbCompletedOrderID";
            lbCompletedOrderID.Size = new Size(69, 25);
            lbCompletedOrderID.TabIndex = 26;
            lbCompletedOrderID.Text = "label36";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(100, 25);
            label44.Name = "label44";
            label44.Size = new Size(75, 25);
            label44.TabIndex = 0;
            label44.Text = "badania";
            // 
            // btnLogout3
            // 
            btnLogout3.Location = new Point(690, 25);
            btnLogout3.Name = "btnLogout3";
            btnLogout3.Size = new Size(109, 40);
            btnLogout3.TabIndex = 13;
            btnLogout3.Text = "Wyloguj";
            btnLogout3.UseVisualStyleBackColor = true;
            btnLogout3.Click += btnTechnicianLogOut_Click;
            // 
            // listbxCompletedTests
            // 
            listbxCompletedTests.FormattingEnabled = true;
            listbxCompletedTests.ItemHeight = 25;
            listbxCompletedTests.Location = new Point(3, 62);
            listbxCompletedTests.Name = "listbxCompletedTests";
            listbxCompletedTests.Size = new Size(278, 779);
            listbxCompletedTests.TabIndex = 4;
            listbxCompletedTests.SelectedIndexChanged += listBox6_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbCompletedResult);
            groupBox1.Controls.Add(lbCompletedTestType);
            groupBox1.Controls.Add(lbCompletedTestName);
            groupBox1.Controls.Add(lbCompletedClientTestID);
            groupBox1.Controls.Add(label35);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(317, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "badanie";
            // 
            // lbCompletedResult
            // 
            lbCompletedResult.AutoSize = true;
            lbCompletedResult.Location = new Point(237, 233);
            lbCompletedResult.Name = "lbCompletedResult";
            lbCompletedResult.Size = new Size(69, 25);
            lbCompletedResult.TabIndex = 30;
            lbCompletedResult.Text = "label40";
            // 
            // lbCompletedTestType
            // 
            lbCompletedTestType.AutoSize = true;
            lbCompletedTestType.Location = new Point(237, 173);
            lbCompletedTestType.Name = "lbCompletedTestType";
            lbCompletedTestType.Size = new Size(69, 25);
            lbCompletedTestType.TabIndex = 29;
            lbCompletedTestType.Text = "label39";
            // 
            // lbCompletedTestName
            // 
            lbCompletedTestName.AutoSize = true;
            lbCompletedTestName.Location = new Point(237, 118);
            lbCompletedTestName.Name = "lbCompletedTestName";
            lbCompletedTestName.Size = new Size(69, 25);
            lbCompletedTestName.TabIndex = 28;
            lbCompletedTestName.Text = "label38";
            // 
            // lbCompletedClientTestID
            // 
            lbCompletedClientTestID.AutoSize = true;
            lbCompletedClientTestID.Location = new Point(237, 63);
            lbCompletedClientTestID.Name = "lbCompletedClientTestID";
            lbCompletedClientTestID.Size = new Size(69, 25);
            lbCompletedClientTestID.TabIndex = 27;
            lbCompletedClientTestID.Text = "label37";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(33, 173);
            label35.Name = "label35";
            label35.Size = new Size(38, 25);
            label35.TabIndex = 25;
            label35.Text = "typ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 63);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 24;
            label3.Text = "ID badania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 7;
            label4.Text = "nazwa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 233);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 5;
            label5.Text = "obecna wartość";
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 878);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TechnicianView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LIS Technik";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnConfirmResultEdit;
        private SplitContainer splitContainer2;
        private Label label7;
        private GroupBox groupBox2;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label1;
        private SplitContainer splitContainer3;
        private Button btnConfirmResult;
        private GroupBox groupBox3;
        private Label label15;
        private Label label16;
        private Button btnDeny;
        private Button btnAccept;
        private Button btnLogout1;
        private ListBox listbxToAcceptOrders;
        private ListBox listbxToAcceptTests;
        private Label label13;
        private Label label14;
        private Label label17;
        private Label lbToAcceptTestType;
        private Label lbToAcceptTestName;
        private Label lbToAcceptTestID;
        private Label lbToAcceptDate;
        private Label lbToAcceptOrderID;
        private ListBox listbxToFillOrders;
        private ListBox listbxToFillTests;
        private Button btnLogout2;
        private Label label25;
        private Label lbToFillOrderID;
        private Label lbToFillTestMax;
        private Label lbToFillTestMin;
        private Label lbToFillTestType;
        private Label lbToFillTestName;
        private Label lbToFillTestID;
        private Label label32;
        private TextBox textBox5;
        private Label lbToFillUnits;
        private ListBox listbxCompletedOrders;
        private ListBox listbxCompletedTests;
        private Label label34;
        private Label label3;
        private Label label35;
        private TextBox textBox1;
        private Label lbCompletedUnits;
        private Label lbCompletedResult;
        private Label lbCompletedTestType;
        private Label lbCompletedTestName;
        private Label lbCompletedClientTestID;
        private Label lbCompletedOrderID;
        private Button btnLogout3;
        private GroupBox groupBox4;
        private Label label42;
        private Label label43;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label label44;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private Label label46;
        private Label lbToFillClientID;
        private Label label47;
        private Label lbCompletedClientID;
    }
}