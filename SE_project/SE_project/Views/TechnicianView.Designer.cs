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
            panel1 = new Panel();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            listbxToAcceptOrders = new ListBox();
            panel4 = new Panel();
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
            panel3 = new Panel();
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
            panel5 = new Panel();
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
            panel2 = new Panel();
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
            panel6 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            panel6.SuspendLayout();
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
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(766, 527);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(splitContainer3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(758, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "badania do akceptacji";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 4);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 46);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "lista zamówień do akceptacji";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(2, 2);
            splitContainer3.Margin = new Padding(2);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(listbxToAcceptOrders);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(panel4);
            splitContainer3.Panel2.Controls.Add(groupBox4);
            splitContainer3.Panel2.Controls.Add(listbxToAcceptTests);
            splitContainer3.Panel2.Controls.Add(btnLogout1);
            splitContainer3.Panel2.Controls.Add(btnDeny);
            splitContainer3.Panel2.Controls.Add(btnAccept);
            splitContainer3.Panel2.Controls.Add(groupBox3);
            splitContainer3.Size = new Size(754, 495);
            splitContainer3.SplitterDistance = 191;
            splitContainer3.TabIndex = 0;
            // 
            // listbxToAcceptOrders
            // 
            listbxToAcceptOrders.FormattingEnabled = true;
            listbxToAcceptOrders.ItemHeight = 15;
            listbxToAcceptOrders.Location = new Point(0, 49);
            listbxToAcceptOrders.Margin = new Padding(2);
            listbxToAcceptOrders.Name = "listbxToAcceptOrders";
            listbxToAcceptOrders.Size = new Size(186, 454);
            listbxToAcceptOrders.TabIndex = 0;
            listbxToAcceptOrders.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(label42);
            panel4.Location = new Point(2, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 46);
            panel4.TabIndex = 3;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(14, 13);
            label42.Margin = new Padding(2, 0, 2, 0);
            label42.Name = "label42";
            label42.Size = new Size(173, 15);
            label42.TabIndex = 0;
            label42.Text = "lista badań danego zamówienia";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(lbToAcceptOrderID);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(lbToAcceptDate);
            groupBox4.Location = new Point(240, 99);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(300, 125);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "szczegóły zamówienia";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 27);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 6;
            label16.Text = "ID zamówienia";
            // 
            // lbToAcceptOrderID
            // 
            lbToAcceptOrderID.AutoSize = true;
            lbToAcceptOrderID.Location = new Point(142, 27);
            lbToAcceptOrderID.Margin = new Padding(2, 0, 2, 0);
            lbToAcceptOrderID.Name = "lbToAcceptOrderID";
            lbToAcceptOrderID.Size = new Size(44, 15);
            lbToAcceptOrderID.TabIndex = 12;
            lbToAcceptOrderID.Text = "label19";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 56);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(96, 15);
            label17.TabIndex = 10;
            label17.Text = "data zamówienia";
            // 
            // lbToAcceptDate
            // 
            lbToAcceptDate.AutoSize = true;
            lbToAcceptDate.Location = new Point(142, 56);
            lbToAcceptDate.Margin = new Padding(2, 0, 2, 0);
            lbToAcceptDate.Name = "lbToAcceptDate";
            lbToAcceptDate.Size = new Size(44, 15);
            lbToAcceptDate.TabIndex = 13;
            lbToAcceptDate.Text = "label20";
            // 
            // listbxToAcceptTests
            // 
            listbxToAcceptTests.FormattingEnabled = true;
            listbxToAcceptTests.ItemHeight = 15;
            listbxToAcceptTests.Location = new Point(5, 49);
            listbxToAcceptTests.Margin = new Padding(2);
            listbxToAcceptTests.Name = "listbxToAcceptTests";
            listbxToAcceptTests.Size = new Size(208, 454);
            listbxToAcceptTests.TabIndex = 13;
            listbxToAcceptTests.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnLogout1
            // 
            btnLogout1.Location = new Point(464, 15);
            btnLogout1.Margin = new Padding(2);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(76, 26);
            btnLogout1.TabIndex = 12;
            btnLogout1.Text = "Wyloguj";
            btnLogout1.UseVisualStyleBackColor = true;
            btnLogout1.Click += btnTechnicianLogOut_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(413, 385);
            btnDeny.Margin = new Padding(2);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(115, 26);
            btnDeny.TabIndex = 4;
            btnDeny.Text = "odrzuć";
            btnDeny.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(256, 385);
            btnAccept.Margin = new Padding(2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(106, 26);
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
            groupBox3.Location = new Point(240, 243);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(300, 132);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "szczegóły badania";
            // 
            // lbToAcceptTestType
            // 
            lbToAcceptTestType.AutoSize = true;
            lbToAcceptTestType.Location = new Point(142, 98);
            lbToAcceptTestType.Margin = new Padding(2, 0, 2, 0);
            lbToAcceptTestType.Name = "lbToAcceptTestType";
            lbToAcceptTestType.Size = new Size(44, 15);
            lbToAcceptTestType.TabIndex = 17;
            lbToAcceptTestType.Text = "label24";
            // 
            // lbToAcceptTestName
            // 
            lbToAcceptTestName.AutoSize = true;
            lbToAcceptTestName.Location = new Point(142, 68);
            lbToAcceptTestName.Margin = new Padding(2, 0, 2, 0);
            lbToAcceptTestName.Name = "lbToAcceptTestName";
            lbToAcceptTestName.Size = new Size(44, 15);
            lbToAcceptTestName.TabIndex = 16;
            lbToAcceptTestName.Text = "label23";
            // 
            // lbToAcceptTestID
            // 
            lbToAcceptTestID.AutoSize = true;
            lbToAcceptTestID.Location = new Point(142, 40);
            lbToAcceptTestID.Margin = new Padding(2, 0, 2, 0);
            lbToAcceptTestID.Name = "lbToAcceptTestID";
            lbToAcceptTestID.Size = new Size(44, 15);
            lbToAcceptTestID.TabIndex = 15;
            lbToAcceptTestID.Text = "label22";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 98);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(53, 15);
            label14.TabIndex = 9;
            label14.Text = "typ testu";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 40);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 8;
            label13.Text = "ID testu";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 68);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 7;
            label15.Text = "nazwa testu";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(758, 499);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "badania zaakceptowane";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 4);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 43);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 15);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 15);
            label7.TabIndex = 0;
            label7.Text = "lista zamówień zaakceptowanych";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(2, 2);
            splitContainer2.Margin = new Padding(2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listbxToFillOrders);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox6);
            splitContainer2.Panel2.Controls.Add(groupBox5);
            splitContainer2.Panel2.Controls.Add(panel5);
            splitContainer2.Panel2.Controls.Add(btnLogout2);
            splitContainer2.Panel2.Controls.Add(listbxToFillTests);
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(754, 495);
            splitContainer2.SplitterDistance = 191;
            splitContainer2.TabIndex = 0;
            // 
            // listbxToFillOrders
            // 
            listbxToFillOrders.FormattingEnabled = true;
            listbxToFillOrders.ItemHeight = 15;
            listbxToFillOrders.Location = new Point(2, 49);
            listbxToFillOrders.Margin = new Padding(2);
            listbxToFillOrders.Name = "listbxToFillOrders";
            listbxToFillOrders.Size = new Size(188, 454);
            listbxToFillOrders.TabIndex = 3;
            listbxToFillOrders.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbToFillUnits);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(btnConfirmResult);
            groupBox6.Location = new Point(224, 376);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(324, 106);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "wprowadzanie wartosci badania";
            // 
            // lbToFillUnits
            // 
            lbToFillUnits.AutoSize = true;
            lbToFillUnits.Location = new Point(205, 30);
            lbToFillUnits.Margin = new Padding(2, 0, 2, 0);
            lbToFillUnits.Name = "lbToFillUnits";
            lbToFillUnits.Size = new Size(44, 15);
            lbToFillUnits.TabIndex = 24;
            lbToFillUnits.Text = "label33";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 28);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 8;
            label8.Text = "wartość";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(93, 28);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(96, 23);
            textBox5.TabIndex = 23;
            // 
            // btnConfirmResult
            // 
            btnConfirmResult.Location = new Point(75, 65);
            btnConfirmResult.Margin = new Padding(2);
            btnConfirmResult.Name = "btnConfirmResult";
            btnConfirmResult.Size = new Size(125, 29);
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
            groupBox5.Location = new Point(224, 58);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(324, 74);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "szczegóły zamówienia";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(10, 47);
            label46.Margin = new Padding(2, 0, 2, 0);
            label46.Name = "label46";
            label46.Size = new Size(56, 15);
            label46.TabIndex = 22;
            label46.Text = "ID klienta";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(10, 26);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(84, 15);
            label32.TabIndex = 22;
            label32.Text = "ID zamówienia";
            // 
            // lbToFillClientID
            // 
            lbToFillClientID.AutoSize = true;
            lbToFillClientID.Location = new Point(131, 47);
            lbToFillClientID.Margin = new Padding(2, 0, 2, 0);
            lbToFillClientID.Name = "lbToFillClientID";
            lbToFillClientID.Size = new Size(44, 15);
            lbToFillClientID.TabIndex = 16;
            lbToFillClientID.Text = "label45";
            // 
            // lbToFillOrderID
            // 
            lbToFillOrderID.AutoSize = true;
            lbToFillOrderID.Location = new Point(131, 26);
            lbToFillOrderID.Margin = new Padding(2, 0, 2, 0);
            lbToFillOrderID.Name = "lbToFillOrderID";
            lbToFillOrderID.Size = new Size(44, 15);
            lbToFillOrderID.TabIndex = 16;
            lbToFillOrderID.Text = "label26";
            // 
            // panel5
            // 
            panel5.Controls.Add(label43);
            panel5.Location = new Point(2, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 45);
            panel5.TabIndex = 4;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(18, 17);
            label43.Margin = new Padding(2, 0, 2, 0);
            label43.Name = "label43";
            label43.Size = new Size(173, 15);
            label43.TabIndex = 0;
            label43.Text = "lista badań danego zamówienia";
            // 
            // btnLogout2
            // 
            btnLogout2.Location = new Point(468, 15);
            btnLogout2.Margin = new Padding(2);
            btnLogout2.Name = "btnLogout2";
            btnLogout2.Size = new Size(76, 25);
            btnLogout2.TabIndex = 15;
            btnLogout2.Text = "Wyloguj";
            btnLogout2.UseVisualStyleBackColor = true;
            btnLogout2.Click += btnTechnicianLogOut_Click;
            // 
            // listbxToFillTests
            // 
            listbxToFillTests.FormattingEnabled = true;
            listbxToFillTests.ItemHeight = 15;
            listbxToFillTests.Location = new Point(2, 49);
            listbxToFillTests.Margin = new Padding(2);
            listbxToFillTests.Name = "listbxToFillTests";
            listbxToFillTests.Size = new Size(214, 454);
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
            groupBox2.Location = new Point(224, 143);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(320, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "szczegóły badania";
            // 
            // lbToFillTestMax
            // 
            lbToFillTestMax.AutoSize = true;
            lbToFillTestMax.Location = new Point(154, 167);
            lbToFillTestMax.Margin = new Padding(2, 0, 2, 0);
            lbToFillTestMax.Name = "lbToFillTestMax";
            lbToFillTestMax.Size = new Size(44, 15);
            lbToFillTestMax.TabIndex = 21;
            lbToFillTestMax.Text = "label31";
            // 
            // lbToFillTestMin
            // 
            lbToFillTestMin.AutoSize = true;
            lbToFillTestMin.Location = new Point(154, 135);
            lbToFillTestMin.Margin = new Padding(2, 0, 2, 0);
            lbToFillTestMin.Name = "lbToFillTestMin";
            lbToFillTestMin.Size = new Size(44, 15);
            lbToFillTestMin.TabIndex = 20;
            lbToFillTestMin.Text = "label30";
            // 
            // lbToFillTestType
            // 
            lbToFillTestType.AutoSize = true;
            lbToFillTestType.Location = new Point(154, 104);
            lbToFillTestType.Margin = new Padding(2, 0, 2, 0);
            lbToFillTestType.Name = "lbToFillTestType";
            lbToFillTestType.Size = new Size(44, 15);
            lbToFillTestType.TabIndex = 19;
            lbToFillTestType.Text = "label29";
            // 
            // lbToFillTestName
            // 
            lbToFillTestName.AutoSize = true;
            lbToFillTestName.Location = new Point(154, 70);
            lbToFillTestName.Margin = new Padding(2, 0, 2, 0);
            lbToFillTestName.Name = "lbToFillTestName";
            lbToFillTestName.Size = new Size(44, 15);
            lbToFillTestName.TabIndex = 18;
            lbToFillTestName.Text = "label28";
            // 
            // lbToFillTestID
            // 
            lbToFillTestID.AutoSize = true;
            lbToFillTestID.Location = new Point(154, 40);
            lbToFillTestID.Margin = new Padding(2, 0, 2, 0);
            lbToFillTestID.Name = "lbToFillTestID";
            lbToFillTestID.Size = new Size(44, 15);
            lbToFillTestID.TabIndex = 17;
            lbToFillTestID.Text = "label27";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(10, 104);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(24, 15);
            label25.TabIndex = 15;
            label25.Text = "typ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 167);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 13;
            label12.Text = "górna granica ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 70);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 7;
            label9.Text = "nazwa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 40);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 6;
            label10.Text = "ID badania";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 135);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 5;
            label11.Text = "dolna granica";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(758, 499);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "historia badań";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(2, 2);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listbxCompletedOrders);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox8);
            splitContainer1.Panel2.Controls.Add(groupBox7);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(btnLogout3);
            splitContainer1.Panel2.Controls.Add(listbxCompletedTests);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(754, 495);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 0;
            // 
            // listbxCompletedOrders
            // 
            listbxCompletedOrders.FormattingEnabled = true;
            listbxCompletedOrders.ItemHeight = 15;
            listbxCompletedOrders.Location = new Point(0, 37);
            listbxCompletedOrders.Margin = new Padding(2);
            listbxCompletedOrders.Name = "listbxCompletedOrders";
            listbxCompletedOrders.Size = new Size(181, 469);
            listbxCompletedOrders.TabIndex = 3;
            listbxCompletedOrders.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-6, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 39);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 0;
            label2.Text = "lista historii zamówień";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lbCompletedUnits);
            groupBox8.Controls.Add(textBox1);
            groupBox8.Controls.Add(label6);
            groupBox8.Controls.Add(btnConfirmResultEdit);
            groupBox8.Location = new Point(222, 371);
            groupBox8.Margin = new Padding(2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(2);
            groupBox8.Size = new Size(320, 107);
            groupBox8.TabIndex = 15;
            groupBox8.TabStop = false;
            groupBox8.Text = "edycja badania";
            // 
            // lbCompletedUnits
            // 
            lbCompletedUnits.AutoSize = true;
            lbCompletedUnits.Location = new Point(261, 34);
            lbCompletedUnits.Margin = new Padding(2, 0, 2, 0);
            lbCompletedUnits.Name = "lbCompletedUnits";
            lbCompletedUnits.Size = new Size(44, 15);
            lbCompletedUnits.TabIndex = 31;
            lbCompletedUnits.Text = "label41";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 32);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 32);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 8;
            label6.Text = "zaaktualizowana wartość";
            // 
            // btnConfirmResultEdit
            // 
            btnConfirmResultEdit.Location = new Point(114, 65);
            btnConfirmResultEdit.Margin = new Padding(2);
            btnConfirmResultEdit.Name = "btnConfirmResultEdit";
            btnConfirmResultEdit.Size = new Size(96, 27);
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
            groupBox7.Location = new Point(222, 75);
            groupBox7.Margin = new Padding(2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(2);
            groupBox7.Size = new Size(320, 71);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "zamówienie";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(23, 43);
            label47.Margin = new Padding(2, 0, 2, 0);
            label47.Name = "label47";
            label47.Size = new Size(56, 15);
            label47.TabIndex = 28;
            label47.Text = "ID klienta";
            // 
            // lbCompletedClientID
            // 
            lbCompletedClientID.AutoSize = true;
            lbCompletedClientID.Location = new Point(166, 43);
            lbCompletedClientID.Margin = new Padding(2, 0, 2, 0);
            lbCompletedClientID.Name = "lbCompletedClientID";
            lbCompletedClientID.Size = new Size(44, 15);
            lbCompletedClientID.TabIndex = 27;
            lbCompletedClientID.Text = "label48";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(23, 23);
            label34.Margin = new Padding(2, 0, 2, 0);
            label34.Name = "label34";
            label34.Size = new Size(84, 15);
            label34.TabIndex = 23;
            label34.Text = "ID zamówienia";
            // 
            // lbCompletedOrderID
            // 
            lbCompletedOrderID.AutoSize = true;
            lbCompletedOrderID.Location = new Point(166, 23);
            lbCompletedOrderID.Margin = new Padding(2, 0, 2, 0);
            lbCompletedOrderID.Name = "lbCompletedOrderID";
            lbCompletedOrderID.Size = new Size(44, 15);
            lbCompletedOrderID.TabIndex = 26;
            lbCompletedOrderID.Text = "label36";
            // 
            // panel6
            // 
            panel6.Controls.Add(label44);
            panel6.Location = new Point(2, 2);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(196, 37);
            panel6.TabIndex = 3;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(12, 9);
            label44.Margin = new Padding(2, 0, 2, 0);
            label44.Name = "label44";
            label44.Size = new Size(173, 15);
            label44.TabIndex = 0;
            label44.Text = "lista badań danego zamówienia";
            // 
            // btnLogout3
            // 
            btnLogout3.Location = new Point(483, 15);
            btnLogout3.Margin = new Padding(2);
            btnLogout3.Name = "btnLogout3";
            btnLogout3.Size = new Size(76, 24);
            btnLogout3.TabIndex = 13;
            btnLogout3.Text = "Wyloguj";
            btnLogout3.UseVisualStyleBackColor = true;
            btnLogout3.Click += btnTechnicianLogOut_Click;
            // 
            // listbxCompletedTests
            // 
            listbxCompletedTests.FormattingEnabled = true;
            listbxCompletedTests.ItemHeight = 15;
            listbxCompletedTests.Location = new Point(2, 37);
            listbxCompletedTests.Margin = new Padding(2);
            listbxCompletedTests.Name = "listbxCompletedTests";
            listbxCompletedTests.Size = new Size(196, 469);
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
            groupBox1.Location = new Point(222, 163);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(320, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "badanie";
            // 
            // lbCompletedResult
            // 
            lbCompletedResult.AutoSize = true;
            lbCompletedResult.Location = new Point(166, 140);
            lbCompletedResult.Margin = new Padding(2, 0, 2, 0);
            lbCompletedResult.Name = "lbCompletedResult";
            lbCompletedResult.Size = new Size(44, 15);
            lbCompletedResult.TabIndex = 30;
            lbCompletedResult.Text = "label40";
            // 
            // lbCompletedTestType
            // 
            lbCompletedTestType.AutoSize = true;
            lbCompletedTestType.Location = new Point(166, 104);
            lbCompletedTestType.Margin = new Padding(2, 0, 2, 0);
            lbCompletedTestType.Name = "lbCompletedTestType";
            lbCompletedTestType.Size = new Size(44, 15);
            lbCompletedTestType.TabIndex = 29;
            lbCompletedTestType.Text = "label39";
            // 
            // lbCompletedTestName
            // 
            lbCompletedTestName.AutoSize = true;
            lbCompletedTestName.Location = new Point(166, 71);
            lbCompletedTestName.Margin = new Padding(2, 0, 2, 0);
            lbCompletedTestName.Name = "lbCompletedTestName";
            lbCompletedTestName.Size = new Size(44, 15);
            lbCompletedTestName.TabIndex = 28;
            lbCompletedTestName.Text = "label38";
            // 
            // lbCompletedClientTestID
            // 
            lbCompletedClientTestID.AutoSize = true;
            lbCompletedClientTestID.Location = new Point(166, 38);
            lbCompletedClientTestID.Margin = new Padding(2, 0, 2, 0);
            lbCompletedClientTestID.Name = "lbCompletedClientTestID";
            lbCompletedClientTestID.Size = new Size(44, 15);
            lbCompletedClientTestID.TabIndex = 27;
            lbCompletedClientTestID.Text = "label37";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(23, 104);
            label35.Margin = new Padding(2, 0, 2, 0);
            label35.Name = "label35";
            label35.Size = new Size(24, 15);
            label35.TabIndex = 25;
            label35.Text = "typ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "ID badania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "nazwa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 140);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 5;
            label5.Text = "obecna wartość";
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 527);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "TechnicianView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LIS Technik";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnConfirmResultEdit;
        private SplitContainer splitContainer2;
        private Panel panel3;
        private Label label7;
        private GroupBox groupBox2;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
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
        private Panel panel4;
        private Label label42;
        private Panel panel5;
        private Label label43;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Panel panel6;
        private Label label44;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private Label label46;
        private Label lbToFillClientID;
        private Label label47;
        private Label lbCompletedClientID;
    }
}